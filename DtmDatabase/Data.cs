using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DtmDatabase
{
    class Data
    {
        public static ButtonData buttonRoot;
        public static List<ButtonData> menu;
        public static string path = "";
        public static bool saved = false;
        public static int pictureCount;

        public static void init()
        {
            buttonRoot = new ButtonData("home", null, Const.CONTAIN_BUTTON, null, "");
            menu = new List<ButtonData>();
        }

        public static void Load(string path)
        {
            Const.Load(path);
            saved = true;

            Data.path = path;
            SQLiteConnection conn = new SQLiteConnection("data source=" + path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);

            menu.Clear();

            cmd.CommandText = "SELECT * FROM Menu";
            SQLiteDataReader menuReader = cmd.ExecuteReader();
            while (menuReader.Read())
            {
                ButtonData data = new ButtonData((string)menuReader["Name"], (long)menuReader["Parent"], (long)menuReader["Type"], new List<PostData>(), (string)menuReader["Background"]);
                menu.Add(data);
                if (data.type == Const.CONTAIN_BUTTON) continue;
                SQLiteCommand cmd2 = new SQLiteCommand(conn);
                cmd2.CommandText = "SELECT * FROM " + menuReader["Table"];
                SQLiteDataReader postReader = cmd2.ExecuteReader();
                while (postReader.Read())
                {
                    data.posts.Add(new PostData((string)postReader["Tittle"], (string)postReader["Content"], (string)postReader["Media"], (long)postReader["Type"], (string)postReader["Thumbnail"]));
                }
                postReader.Close();
            }
            menuReader.Close();
            File.WriteAllText("lastDB.txt", path);
        }

        public static void AddButton(ButtonData parent, int type, string name, string background)
        {
            ButtonData newButton = new ButtonData(name, parent, type, new List<PostData>(), background);
            menu.Add(newButton);
        }

        internal static bool Save()
        {
            if (path == "")
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                if (saveDialog.ShowDialog() == DialogResult.Cancel) return false;
                path = saveDialog.FileName;
                if (File.Exists(path)) File.Delete(path);
            }

            SQLiteConnection conn = new SQLiteConnection("data source=" + path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS
                                 [Menu] (
                                 [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                 [Name] NVARCHAR(2048) NULL,
                                 [Parent] INTEGER,
                                 [Type] INTEGER,
                                 [Background] NVARCHAR(2048) NULL,
                                 [Table] NVARCHAR(2048) NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM Menu";
            cmd.ExecuteNonQuery();
            for (int i = 0; i < menu.Count; i++)
            {
                string tableName = "table" + i.ToString();
                ButtonData data = menu[i];
                cmd.CommandText = "INSERT INTO Menu('Id','Name','Parent','Type','Table','Background') values('" + i.ToString()
                                                                                          + "','" + data.name
                                                                                          + "','" + menu.IndexOf(data.parent).ToString()
                                                                                          + "','" + data.type.ToString()
                                                                                          + "','" + tableName
                                                                                          + "','" + data.Background
                                                                                          + "')";
                cmd.ExecuteNonQuery();
                if (data.type != Const.CONTAIN_BUTTON)
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS
                                 [" + tableName + "] (" + 
                                 "[PostId] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                                 "[Tittle] NVARCHAR(2048) NULL," +
                                 "[Content] NVARCHAR(2048) NULL," +
                                 "[Type] INTEGER," +
                                 "[Media] NVARCHAR(2048) NULL," +
                                 "[Thumbnail] NVARCHAR(2048) NULL)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM " + tableName;
                    cmd.ExecuteNonQuery();
                    for (int j = 0; j < data.posts.Count; j++)
                    {
                        PostData post = data.posts[j];
                        cmd.CommandText = "INSERT INTO " + tableName + "('PostId','Tittle','Content','Type','Media','Thumbnail') values('" + j.ToString()
                                                                                                                 + "','" + post.Title
                                                                                                                 + "','" + post.Content
                                                                                                                 + "','" + post.type.ToString()
                                                                                                                 + "','" + post.getImageString()
                                                                                                                 + "','" + post.Thumbnail
                                                                                                                 + "')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            saved = true;
            File.WriteAllText("lastDB.txt", path);
            return true;
        }

        internal static void updatePictureCount()
        {
            pictureCount++;
            File.WriteAllText("pictureCount.txt", pictureCount.ToString());
        }
    }
}
