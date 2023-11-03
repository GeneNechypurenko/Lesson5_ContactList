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
    public partial class EditContactForm : Form
    {
        public delegate void ContactAddedEventHandler(object sender, Contact contact);
        public event ContactAddedEventHandler ContactAdded;

        public EditContactForm()
        {
            InitializeComponent();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            if (nameTextBox.Text != string.Empty && emailTextBox.Text != string.Empty)
            {
                contact.Name = nameTextBox.Text;
                contact.Email = emailTextBox.Text;

                ContactAdded?.Invoke(this, contact);

                this.Close();
            }
            else
            {
                MessageBox.Show("You must complete information about your contact", "An Error Occured...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
