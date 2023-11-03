namespace Lesson5_ContactList
{
    partial class ViewContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            emailLabel = new Label();
            deleteButton = new Button();
            panel1 = new Panel();
            backButton = new Button();
            editButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.Coral;
            nameLabel.Location = new Point(91, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "name: ";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.Coral;
            emailLabel.Location = new Point(91, 60);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(55, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "email: ";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Dock = DockStyle.Right;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(221, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(161, 30);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Delete Contact";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(deleteButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 30);
            panel1.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.BackColor = Color.DodgerBlue;
            backButton.Dock = DockStyle.Left;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 30);
            backButton.TabIndex = 4;
            backButton.Text = "🡄";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LimeGreen;
            editButton.Dock = DockStyle.Right;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(60, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(161, 30);
            editButton.TabIndex = 1;
            editButton.Text = "Edit Contact";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // ViewContactForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(382, 153);
            Controls.Add(panel1);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ViewContactForm";
            StartPosition = FormStartPosition.Manual;
            Text = "View Contact";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private Label emailLabel;
        private Button deleteButton;
        private Panel panel1;
        private Button editButton;
        private Button backButton;
    }
}