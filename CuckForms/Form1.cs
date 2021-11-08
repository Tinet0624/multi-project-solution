﻿using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuckForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComboBox().Wait();
        }

        private async Task LoadComboBox()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                cbCategories.Items.Add(cat);
            }
        }

        private void btnGenerateJoke_Click(object sender, EventArgs e)
        {
            // Get random joke
            // load joke into textbox to view
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
