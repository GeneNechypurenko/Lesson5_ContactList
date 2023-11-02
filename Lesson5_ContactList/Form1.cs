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
        public ContactListForm()
        {
            InitializeComponent();
        }

        private void addNewContactButton_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();

            editContactForm.ContactAdded += (s, contact) =>
            {
                Label nameLabel = new Label();
                Label emailLabel = new Label();
                Panel panel = new Panel();
                Button accessButton = new Button();

                nameLabel.AutoSize = true;
                nameLabel.Text = contact.Name;
                nameLabel.Location = new Point(91, 6);
                nameLabel.ForeColor = Color.Coral;
                panel.Controls.Add(nameLabel);

                emailLabel.AutoSize = true;
                emailLabel.ForeColor = Color.White;
                emailLabel.Text = contact.Email;
                emailLabel.Location = new Point(91, 30);
                panel.Controls.Add(emailLabel);

                accessButton.Height = 60;
                accessButton.Width = 60;
                accessButton.Text = "✒";
                accessButton.Font = new Font(accessButton.Font.FontFamily, 24);
                accessButton.BackColor = Color.FromArgb(64, 64, 64);
                accessButton.ForeColor = Color.Coral;
                accessButton.FlatStyle = FlatStyle.Popup;
                panel.Controls.Add(accessButton);
                accessButton.Dock = DockStyle.Left;
                accessButton.Click += AccessButton_Click;

                panel.Height = 60;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Dock = DockStyle.Top;

                this.Controls.Add(panel);
            };

            editContactForm.Show();
        }

        private void AccessButton_Click(object? sender, EventArgs e)
        {
            ViewContactForm viewContactForm = new ViewContactForm();

            viewContactForm.Show();
        }
    }
}