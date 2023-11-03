using System.Windows.Forms;

namespace Lesson5_ContactList
{
    public partial class ContactListForm : Form
    {
        Dictionary<Guid, Contact> contacts = new Dictionary<Guid, Contact>();
        public ContactListForm()
        {
            this.Left = 1524;
            this.Top = 0;
            InitializeComponent();
        }

        private void addNewContactButton_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.Owner = this;
            editContactForm.Location = new Point(this.Left, this.Top);

            editContactForm.ContactUpdated += AddContact;

            editContactForm.ShowDialog();
        }
        private void AddContact(object sender, Contact contact)
        {
            Panel panel = new Panel();
            Button accessButton = new Button();

            Guid key = Guid.NewGuid();
            contacts.Add(key, contact);

            AddLabels(panel, contact);
            AddAccessButton(panel, accessButton, key);

            AddPanel(this, panel);
        }

        private void AddPanel(ContactListForm contactListForm, Panel panel)
        {
            panel.Height = 60;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Dock = DockStyle.Top;

            this.Controls.Add(panel);
        }

        private void AddAccessButton(Panel panel, Button accessButton, Guid key)
        {
            accessButton.Height = 60;
            accessButton.Width = 60;

            accessButton.Text = "✒";
            accessButton.Font = new Font(accessButton.Font.FontFamily, 24);

            accessButton.BackColor = Color.FromArgb(64, 64, 64);
            accessButton.ForeColor = Color.Coral;

            accessButton.FlatStyle = FlatStyle.Popup;
            accessButton.Dock = DockStyle.Left;

            accessButton.Click += AccessButton_Click;

            accessButton.Tag = key;

            panel.Tag = accessButton.Tag;
            panel.Controls.Add(accessButton);
        }

        private void AddLabels(Panel panel, Contact contact)
        {
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Text = contact.Name;
            nameLabel.Location = new Point(91, 6);
            nameLabel.ForeColor = Color.Coral;

            panel.Controls.Add(nameLabel);

            Label emailLabel = new Label();
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.White;
            emailLabel.Text = contact.Email;
            emailLabel.Location = new Point(91, 30);

            panel.Controls.Add(emailLabel);
        }

        private void AccessButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button accessButton && accessButton.Tag is Guid key)
            {
                if (contacts.TryGetValue(key, out Contact contact))
                {
                    ViewContactForm viewContactForm = new ViewContactForm(contact, key);
                    viewContactForm.Owner = this;
                    viewContactForm.Location = new Point(this.Left, this.Top);
                    viewContactForm.ShowDialog();
                }
            }
        }
        public void DeleteContact(Guid key)
        {
            if (contacts.TryGetValue(key, out Contact contact))
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Panel panel &&
                        panel.Tag is Guid tagKey &&
                        tagKey == key)
                    {
                        foreach (Control panelControl in panel.Controls)
                        {
                            panel.Controls.Remove(panelControl);
                            panelControl.Dispose();
                        }

                        this.Controls.Remove(panel);
                        contacts.Remove(key);
                        break;
                    }
                }
            }
        }
        public void EditContact(Guid key)
        {
            if (contacts.TryGetValue(key, out Contact contact))
            {
                EditContactForm editContactForm = new EditContactForm();
                editContactForm.Owner = this;
                editContactForm.Location = new Point(this.Left, this.Top);

                DeleteContact(key);
                editContactForm.ContactUpdated += AddContact;

                editContactForm.ShowDialog();
            }
        }
    }
}