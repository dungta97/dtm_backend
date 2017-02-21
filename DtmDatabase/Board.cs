using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DtmDatabase
{
    class Board
    {
        private Panel board;
        public static ButtonData currentButton;

        public Board(Panel board)
        {
            this.board = board;
            currentButton = Data.buttonRoot;
        }

        public void refresh(ButtonData centerData)
        {
            board.Controls.Clear();
            Point centerLocation = new Point(100, 100);
            Button centerButton = new Button() { Text = centerData.name, Location = centerLocation };
            board.Controls.Add(centerButton);

            for(int i = 0; i < centerData.children.Count; i++)
            {
                ButtonData childrenData = centerData.children[i];

                ContextMenuStrip button_rightClick = new ContextMenuStrip() { Tag = childrenData };
                button_rightClick.Items.Add("Rename");
                button_rightClick.Items[0].Click += rename_Click;
                button_rightClick.Items.Add("Delete");
                button_rightClick.Items[1].Click += delete_Click;
                button_rightClick.Items.Add("Change Background");
                button_rightClick.Items[2].Click += changeBackGround_Click;

                double distance = 100;
                double angle = 2 * Math.PI / centerData.children.Count * i;
                Point childrenLocation = new Point(- (int)(distance * Math.Cos(angle)) + centerLocation.X, - (int)(distance * Math.Sin(angle)) + centerLocation.Y);
                Button childrenButton = new Button() { Tag = childrenData, Text = childrenData.name, Location = childrenLocation, ContextMenuStrip = button_rightClick };
                childrenButton.Click += ChildrenButton_Click;

                board.Controls.Add(childrenButton);
            }

            currentButton = centerData;
        }

        private void changeBackGround_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose = new OpenFileDialog();
            if (choose.ShowDialog() == DialogResult.Cancel) return;
            File.Copy(choose.FileName, Const.assetFolder + Data.pictureCount.ToString() + ".jpg");
            ButtonData b = (sender as ToolStripMenuItem).GetCurrentParent().Tag as ButtonData;
            b.Background = Const.assetFolder + Data.pictureCount.ToString() + ".jpg";
            Data.updatePictureCount();
            Data.saved = false;
        }

        private void ChildrenButton_Click(object sender, EventArgs e)
        {
            ButtonData data = (sender as Button).Tag as ButtonData;
            if (data.type != Const.CONTAIN_BUTTON)
            {
                form_posts posts = new form_posts(data.posts);
                posts.ShowDialog();
                return;
            }
            refresh(data);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete button?") == DialogResult.Cancel) return;
            ButtonData b = (sender as ToolStripMenuItem).GetCurrentParent().Tag as ButtonData;
            b.RemoveYourself();
            refresh();
            Data.saved = false;
        }

        private void rename_Click(object sender, EventArgs e)
        {
            ButtonData b = (sender as ToolStripMenuItem).GetCurrentParent().Tag as ButtonData;
            form_renameButton renameButtonForm = new form_renameButton(b);
            if (renameButtonForm.ShowDialog() == DialogResult.Cancel) return;
            b.name = renameButtonForm.buttonName;
            b.type = renameButtonForm.type;
            refresh();
            Data.saved = false;
        }

        public void refresh()
        {
            refresh(currentButton);
        }
    }
}