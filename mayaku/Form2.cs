﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayaku
{
    public partial class lobbylogin : Form
    {
        public lobbylogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lobby org = new lobby();
            org.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            register org = new register();
            org.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lobby org = new lobby();
            org.Show();
        }
    }
}
