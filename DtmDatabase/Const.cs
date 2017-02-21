using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DtmDatabase
{
    static class Const
    {
        public static int CONTAIN_BUTTON = 0;
        public static int CONTAIN_POST1 = 1;
        public static int CONTAIN_POST2 = 2;

        public const int CONTAIN_IMAGES = 0;
        public const int CONTAIN_VIDEO = 1;

        public static string assetFolder;
        public static List<string> childrenAssetFolder;

        internal static void Load(string path)
        {
            assetFolder = path;
            int i = 0;
            while (true)
            {
                string dataFile = "\\\\May" + i.ToString() + "\\data.txt";
                if (!File.Exists(dataFile))
                {
                    MessageBox.Show("Load " + i.ToString() + " máy thành công");
                    break;
                }
                childrenAssetFolder.Add("\\\\May" + i.ToString() + "\\" + File.ReadAllText(dataFile));
                i++;
            }
        }

        internal static void Copy(string fileName)
        {
            foreach (string s in childrenAssetFolder)
            {
                File.Copy(fileName, s + Data.pictureCount.ToString() + ".jpg");
            }
        }
    }
}
