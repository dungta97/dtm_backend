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
    public partial class form_exitConfirm : Form
    {
        public form_exitConfirm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
