using System;
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
        private Guid key;
        private Contact contact;
        public ViewContactForm(Contact contact, Guid key)
        {
            InitializeComponent();
            this.contact = contact;
            this.key = key;

            nameLabel.Text += contact.Name;
            emailLabel.Text += contact.Email;
        }

        private void backButton_Click(object sender, EventArgs e) => this.Close();

        private void editButton_Click(object sender, EventArgs e)
        {
            if (Owner is ContactListForm contactListForm)
            {
                contactListForm.EditContact(key);
                this.Close();
            }

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Owner is ContactListForm contactListForm)
            {
                DialogResult dialogResult = MessageBox.Show

                      ("Are you sure you want to\nremove this contact?",
                      "Remove Contact",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK)
                {
                    contactListForm.DeleteContact(key);
                    this.Close();
                }
            }
        }
    }
}
