﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormCommon : Form
    {
        public FormCommon()
        {
            InitializeComponent();
        }

        private void FormCommon_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}