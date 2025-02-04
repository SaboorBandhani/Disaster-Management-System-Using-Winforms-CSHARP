using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisasterManagementSystem
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._1701519491358; // Replace 'image' with the actual name of the resource.
            this.BackgroundImageLayout = ImageLayout.Tile; // 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
