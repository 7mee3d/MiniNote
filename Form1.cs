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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void setFormFixedMoveAndSize ()
        {
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2; 
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1119, 765); 

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MakeNote MK = new MakeNote();
          
            MK.ShowDialog();


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            setFormFixedMoveAndSize();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            setFormFixedMoveAndSize();
        }

        private void pictureBox1_Exit(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
