using Mini_Project___Mini_Note.Properties;
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

            System.IO.StreamWriter SW = new System.IO.StreamWriter("InfoMiniNote.txt" , true );

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

        private void ClickpictureBoxChangeFont(object sender, EventArgs e)
        {

            FD.ShowEffects = true;
            FD.ShowColor = true;
            FD.ShowApply = true;

            Color c = MiniNoteTextBox.ForeColor;
            Font f = MiniNoteTextBox.Font;

            DialogResult DR  = FD.ShowDialog() ; 

            if(DR == DialogResult.OK)
            {
                MiniNoteTextBox.Font = FD.Font;
                MiniNoteTextBox.ForeColor = FD.Color;

            }
            else
            {

                MiniNoteTextBox.Font = f ;
                MiniNoteTextBox.ForeColor = c;
            }
        }

        private void FD_Apply(object sender, EventArgs e)
        {
            MiniNoteTextBox.Font = FD.Font;
            MiniNoteTextBox.ForeColor = FD.Color;
        }

        private void LoadTextFileToLoadTextBox_Click(object sender, EventArgs e)
        {
            OFD.Title = "Select the File Text";
            OFD.Filter = "TXT File|*.txt";
           

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string fillNameFile = OFD.FileName; 

                if (System.IO.File.Exists(fillNameFile))
                {
                    MiniNoteTextBox.Text = System.IO.File.ReadAllText(fillNameFile);

                }
                else
                {
                    MessageBox.Show("Not Found ");
                }
            }
           
        }
    }
}
