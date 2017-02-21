using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtmDatabase
{
    public class PostData
    {
        public string tableName;
        public string Title;
        public string Content;
        public List<string> Images = new List<string>();
        public long type;
        public string Thumbnail = "";

        public PostData(string title = "", string content = "", string imagesList = "", long type = Const.CONTAIN_IMAGES, string Thumbnail = "")
        {
            this.Title = title;
            this.Content = content;
            this.type = type;
            if (imagesList == "") return;
            this.Images = new List<string>(imagesList.Split(','));
            this.Thumbnail = Thumbnail;
        }

        public string getImageString()
        {
            if (Images.Count == 0) return "";
            string res = "";
            foreach (string s in Images)
            {
                res = res + s + ',';
            }
            res = res.Remove(res.Length - 1, 1);
            return res;
        }
    }
}
