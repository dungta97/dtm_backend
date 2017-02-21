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
    public partial class form_addButton : Form
    {
        public int type = Const.CONTAIN_BUTTON;
        public string buttonName = "new button";
        public string buttonBackground = "";

        public form_addButton()
        {
            InitializeComponent();
            radioButton_containButton.Tag = Const.CONTAIN_BUTTON;
            radioButton_containPost1.Tag = Const.CONTAIN_POST1;
            radioButton_containPost2.Tag = Const.CONTAIN_POST2;
            radioButton_containButton.Checked = true;
            this.AcceptButton = buttonOK;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Debug.WriteLine(type);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked) type = (int)rb.Tag;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonName = textBox.Text;
        }

        private void button_chooseBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseBackground = new OpenFileDialog();
            if (chooseBackground.ShowDialog() == DialogResult.Cancel) return;
            File.Copy(chooseBackground.FileName, Const.assetFolder + Data.pictureCount.ToString() + ".jpg");
            pictureBox.ImageLocation = Const.assetFolder + Data.pictureCount.ToString() + ".jpg";
            buttonBackground = Const.assetFolder + Data.pictureCount.ToString() + ".jpg";
            Data.updatePictureCount();
        }
    }
}
