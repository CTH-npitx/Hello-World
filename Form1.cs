﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hello_World
{
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            //only closes whole thing if used on parent form
            Application.Exit();

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            var greeting = "Hello World!";
            txt_output.Text = greeting;

        }
    }
}
