using System.Windows.Forms;

namespace Lesson5_ContactList
{

    //    Создайте Windows Forms приложение для ведения списка контактов,
    //    где каждый контакт будет представлен в виде панели с использованием
    //    TableLayoutPanel.Это приложение позволит пользователям добавлять,
    //    редактировать и удалять контакты, а также отображать информацию о контактах.

    //    Реализовать пункты:
    //      1) Реализуйте функциональность для редактирования и добавления контактов.
    //    При выборе контакта на панели, пользователь сможет редактировать его информацию
    //    и сохранить изменения.
    //      2) Добавьте кнопку "Удалить", чтобы пользователь мог удалять контакты из списка.
    //      3) Используйте TableLayoutPanel для отображения информации о каждом контакте.Каждая
    //    панель будет содержать информацию об одном контакте, и они будут располагаться в виде сетки.
    //      4) Используйте Panel, для отображения формы редактирования и добавления контакта.

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
            editContactForm.Location = new Point(this.Left, this.Top);

            editContactForm.ContactAdded += (s, contact) =>
            {

                Panel panel = new Panel();
                Button accessButton = new Button();

                Guid key = Guid.NewGuid();
                contacts.Add(key, contact);

                AddLabels(panel, contact);
                AddAccessButton(panel, accessButton, key);

                AddPanel(this, panel);
            };

            editContactForm.ShowDialog();
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
                    ViewContactForm viewContactForm = new ViewContactForm(contact);
                    viewContactForm.Location = new Point(this.Left, this.Top);
                    viewContactForm.ShowDialog();
                }
            }
        }
    }
}