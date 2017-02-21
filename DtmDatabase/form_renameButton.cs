using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DtmDatabase
{
    public partial class form_renameButton : Form
    {
        public string buttonName;
        public int type;
        public form_renameButton(ButtonData buttonData)
        {
            InitializeComponent();
            this.buttonName = buttonData.name;
            this.type = buttonData.type;

            radioButton_containButton.Tag = Const.CONTAIN_BUTTON;
            radioButton_post1.Tag = Const.CONTAIN_POST1;
            radioButton_post2.Tag = Const.CONTAIN_POST2;

            if (type == Const.CONTAIN_BUTTON) radioButton_containButton.Checked = true;
            else if (type == Const.CONTAIN_POST1) radioButton_post1.Checked = true;
            else radioButton_post2.Checked = true;

            this.AcceptButton = buttonOK;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonName = textBox.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked) this.type = (int)rb.Tag;
            Data.saved = false;
        }
    }
}
