using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtmDatabase
{
    public class ButtonData
    {
        public string name;
        public ButtonData parent;
        public List<ButtonData> children = new List<ButtonData>();
        public int type;
        public List<PostData> posts;
        public string Background = "";

        public ButtonData(string name, ButtonData parent, int type, List<PostData> posts, string background)
        {
            this.name = name;
            this.parent = parent;
            this.type = type;
            this.posts = posts;
            this.Background = background;

            if (parent != null) parent.children.Add(this);
        }
        public ButtonData(string name, long parent, long type, List<PostData> posts, string background)
        {
            this.name = name;
            this.type = (int)type;
            this.posts = posts;
            this.Background = background;

            if (parent != -1) this.parent = Data.menu[(int)parent];
            else this.parent = Data.buttonRoot;

            this.parent.children.Add(this);
        }

        internal void RemoveYourself()
        {
            Data.menu.Remove(this);
            this.parent.children.Remove(this);
            while (this.children.Count > 0)
            {
                this.children[0].RemoveYourself();
            }
        }
    }
}
