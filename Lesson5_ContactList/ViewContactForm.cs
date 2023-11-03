﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5_ContactList
{
    public partial class ViewContactForm : Form
    {
        private Contact contact;
        public ViewContactForm(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            nameLabel.Text += contact.Name;
            emailLabel.Text += contact.Email;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
