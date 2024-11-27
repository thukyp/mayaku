using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace mayaku
{
    public partial class lobby : Form
    {




        public lobby()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lobbylogin org = new lobbylogin();
            org.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lobbylogin org = new lobbylogin();
            org.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            lobbylogin org = new lobbylogin();
            org.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            lobbylogin org = new lobbylogin();
            org.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
    }

