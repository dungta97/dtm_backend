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
    public partial class form_pictureEdit : Form
    {
        private PictureInformation pictureInfo;
        public bool changed = false;

        public form_pictureEdit()
        {
            InitializeComponent();
        }

        private void PictureEdit_Load(object sender, EventArgs e)
        {
            pictureInfo = this.Tag as PictureInformation;
            if (pictureInfo.i == -1) pictureBox.ImageLocation = pictureInfo.data.Thumbnail;
            else pictureBox.ImageLocation = pictureInfo.data.Images[pictureInfo.i];
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.Cancel) return;
            File.Copy(openFile.FileName, Const.assetFolder + Data.pictureCount.ToString() + ".jpg");
            pictureBox.ImageLocation = Const.assetFolder + Data.pictureCount.ToString() + ".jpg";
            Data.updatePictureCount();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (pictureInfo.i == -1) pictureInfo.data.Thumbnail = pictureBox.ImageLocation;
            else pictureInfo.data.Images[pictureInfo.i] = pictureBox.ImageLocation;
            changed = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Xóa ảnh này?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (pictureInfo.i == -1) pictureInfo.data.Thumbnail = "";
            else pictureInfo.data.Images.RemoveAt(pictureInfo.i);
            changed = true;
            this.Close();
        }
    }
}
