using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_restaurant
{
    public partial class akun : Form
    {
        public akun()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Warning!!!", "Yakin Ingin Keluar Halaman Login ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form1 ui1 = new Form1();
                ui1.Show();
                this.Close();
            }
            else
            {
                //Do something
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form1 ui1 = new Form1();
                ui1.Show();
                this.Close();
            }
            else
            {
                //Do something
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu f1 = new menu();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesan f2 = new pesan();
            f2.Show();
            this.Hide();
        }
    }
}
