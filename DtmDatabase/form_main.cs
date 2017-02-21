using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace DtmDatabase
{
    public partial class form_main : Form
    {
        Board board;

        public form_main()
        {
            InitializeComponent();
            Data.init();
            board = new Board(MainBoard);
            Data.pictureCount = Int32.Parse(File.ReadAllText("pictureCount.txt"));
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog database = new OpenFileDialog();
            if (database.ShowDialog() == DialogResult.Cancel) return;
            Data.Load(database.FileName);
            board.refresh(Data.buttonRoot);
        }

        private void button_addButton_Click(object sender, EventArgs e)
        {
            form_addButton addButtonForm = new form_addButton();
            if (addButtonForm.ShowDialog(this) == DialogResult.Cancel) return;
            Data.AddButton(Board.currentButton, addButtonForm.type, addButtonForm.buttonName, addButtonForm.buttonBackground);
            board.refresh();
            Data.saved = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (Board.currentButton.parent != null) board.refresh(Board.currentButton.parent);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Data.Save();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (Data.saved) Application.Exit();
            form_exitConfirm exitConfirm = new form_exitConfirm();
            if (exitConfirm.ShowDialog() == DialogResult.Cancel) return;
            if (exitConfirm.DialogResult == DialogResult.Abort) Application.Exit();
            if (exitConfirm.DialogResult == DialogResult.OK)
                if (!Data.Save()) return;
            Application.Exit();
        }
    }
}
