namespace Lesson5_ContactList
{
    partial class EditContactForm
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
            panel1 = new Panel();
            cancelButton = new Button();
            acceptButton = new Button();
            emailLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(acceptButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 30);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.Dock = DockStyle.Right;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(191, 0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(191, 30);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "✖";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.LimeGreen;
            acceptButton.Dock = DockStyle.Left;
            acceptButton.FlatStyle = FlatStyle.Popup;
            acceptButton.ForeColor = Color.White;
            acceptButton.Location = new Point(0, 0);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(191, 30);
            acceptButton.TabIndex = 0;
            acceptButton.Text = "✔";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.Coral;
            emailLabel.Location = new Point(91, 60);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(55, 20);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email: ";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.Coral;
            nameLabel.Location = new Point(91, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name: ";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(64, 64, 64);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.ForeColor = Color.Coral;
            nameTextBox.Location = new Point(150, 30);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(192, 27);
            nameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(64, 64, 64);
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.ForeColor = Color.Coral;
            emailTextBox.Location = new Point(150, 60);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(192, 27);
            emailTextBox.TabIndex = 6;
            // 
            // EditContactForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(382, 153);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "EditContactForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Edit Contact";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cancelButton;
        private Button acceptButton;
        private Label emailLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
    }
}