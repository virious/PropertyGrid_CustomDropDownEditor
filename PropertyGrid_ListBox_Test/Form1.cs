﻿using System;
using System.Windows.Forms;

namespace PropertyGrid_ListBox_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = new TestCase();
        }
    }
}
