using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DtmDatabase
{
    public partial class form_posts : Form
    {
        int currentTab = -1;
        public List<PostData> postData;
        public form_posts(List<PostData> postData)
        {
            InitializeComponent();
            this.postData = postData;
            radioButton_picture.Tag = Const.CONTAIN_IMAGES;
            radioButton_video.Tag = Const.CONTAIN_VIDEO;
            pictureBox_thumbnail.Hide();
            loadListBox();
        }

        private void loadListBox()
        {
            foreach (PostData post in postData)
            {
                listBox.Items.Add(post.Title);
            }
        }

        private void refresh()
        {
            PostData data = new PostData();
            if (listBox.SelectedIndex >= 0) data = postData[listBox.SelectedIndex];
            Title.Text = data.Title;
            Content.Text = data.Content;

            ImagePanel.Controls.Clear();
            Size pictureSize = new Size(100, 100);
            for (int i = 0; i < data.Images.Count; i++)
            {
                PictureBox picture = new PictureBox() { Size = pictureSize, Tag = new PictureInformation(data, i), ImageLocation = data.Images[i], SizeMode = PictureBoxSizeMode.Zoom };
                picture.Click += Picture_Click;
                ImagePanel.Controls.Add(picture);
            }
            Button buttonAddPicture = new Button() { Text = "Thêm ảnh mới", Size = pictureSize, Tag = data };
            buttonAddPicture.Click += ButtonAddPicture_Click;
            ImagePanel.Controls.Add(buttonAddPicture);

            button_thumbnail.Show();
            pictureBox_thumbnail.Hide();
            if (data.Thumbnail != "")
            {
                pictureBox_thumbnail.ImageLocation = data.Thumbnail;
                pictureBox_thumbnail.Tag = new PictureInformation(data, -1);
                button_thumbnail.Hide();
                pictureBox_thumbnail.Show();
            }

            if (data.type == Const.CONTAIN_IMAGES) radioButton_picture.Checked = true; else radioButton_video.Checked = true;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            form_pictureEdit pictureEditDialog = new form_pictureEdit() { Tag = (sender as PictureBox).Tag };
            pictureEditDialog.ShowDialog(this);
            if (pictureEditDialog.changed)
            {
                refresh();
                Data.saved = false;
            }
        }

        private void ButtonAddPicture_Click(object sender, EventArgs e)
        {
            PostData tab = (sender as Button).Tag as PostData;
            OpenFileDialog newPictureDialog = new OpenFileDialog();
            if (newPictureDialog.ShowDialog() == DialogResult.Cancel) return;
            File.Copy(newPictureDialog.FileName, Const.assetFolder + Data.pictureCount.ToString() + ".jpg");
            tab.Images.Add(Const.assetFolder + Data.pictureCount.ToString() + ".jpg");
            Data.updatePictureCount();
            refresh();
            Data.saved = false;
        }

        private void button_newPost_Click(object sender, EventArgs e)
        {
            postData.Add(new PostData("Title", "Content"));
            listBox.Items.Add("Title");
            listBox.SelectedIndex = listBox.Items.Count - 1;
            Data.saved = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_deletePost_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Xóa bài này?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            int index = listBox.SelectedIndex;
            if (index < 0) return;
            postData.RemoveAt(index);
            listBox.Items.RemoveAt(index);
            if (index == listBox.Items.Count) index--;
            listBox.SelectedIndex = index;
            refresh();
            Data.saved = false;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == currentTab) return;
            if (listBox.SelectedIndex < 0) return;
            currentTab = listBox.SelectedIndex;
            refresh();
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            postData[listBox.SelectedIndex].Content = (sender as TextBox).Text;
            Data.saved = false;
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            postData[listBox.SelectedIndex].Title = (sender as TextBox).Text;
            listBox.Items[listBox.SelectedIndex] = (sender as TextBox).Text;
            Data.saved = false;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (listBox.SelectedIndex < 0) return;
            postData[listBox.SelectedIndex].type = (int)rb.Tag;
            Data.saved = false;
        }

        private void button_thumbnail_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;
            OpenFileDialog newThumbnailDialog = new OpenFileDialog();
            if (newThumbnailDialog.ShowDialog() == DialogResult.Cancel) return;
            File.Copy(newThumbnailDialog.FileName, Const.assetFolder + Data.pictureCount.ToString() + ".jpg");
            postData[listBox.SelectedIndex].Thumbnail = Const.assetFolder + Data.pictureCount.ToString() + ".jpg";
            Data.updatePictureCount();
            refresh();
            Data.saved = false;
        }
    }
}
