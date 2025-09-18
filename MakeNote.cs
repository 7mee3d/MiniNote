using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project___Mini_Note
{
    public partial class MakeNote : Form
    {
        public MakeNote()
        {
            InitializeComponent();
        }

   
        private void setFormFixedMoveAndSize()
        {
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1119, 765);

        }
        private void ClickImageSave(object sender, EventArgs e)
        {

            System.IO.StreamWriter SW = new System.IO.StreamWriter("InfoMiniNote.txt");

            string oneNote = MiniNoteTextBox.Text;

            SW.WriteLine(oneNote + "\n\n");
            SW.Close();
            MessageBox.Show("Save This Note Sccussfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MiniNoteTextBox.Text = "";
            MiniNoteTextBox.Focus();

        }

        private void ClickImageReset(object sender, EventArgs e)
        {
            MiniNoteTextBox.Text = "";
            MessageBox.Show("Reset This Note Sccussfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MiniNoteTextBox.Focus();
        }

        private void ClickImageBack(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close(); 
            
        }

        private void MakeNote_Move(object sender, EventArgs e)
        {
            setFormFixedMoveAndSize();
        }

        private void MakeNote_Resize(object sender, EventArgs e)
        {
            setFormFixedMoveAndSize();

        }
    }
}
