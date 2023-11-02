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
            editButton = new Button();
            panel1 = new Panel();
            delecteButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.Coral;
            nameLabel.Location = new Point(101, 39);
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
            emailLabel.Location = new Point(101, 72);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(55, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "email: ";
            // 
            // editButton
            // 
            editButton.BackColor = Color.LimeGreen;
            editButton.Dock = DockStyle.Left;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(0, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(191, 30);
            editButton.TabIndex = 0;
            editButton.Text = "Edit Contact";
            editButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(delecteButton);
            panel1.Controls.Add(editButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 30);
            panel1.TabIndex = 3;
            // 
            // delecteButton
            // 
            delecteButton.BackColor = Color.Red;
            delecteButton.Dock = DockStyle.Fill;
            delecteButton.FlatStyle = FlatStyle.Popup;
            delecteButton.ForeColor = Color.White;
            delecteButton.Location = new Point(191, 0);
            delecteButton.Name = "delecteButton";
            delecteButton.Size = new Size(191, 30);
            delecteButton.TabIndex = 1;
            delecteButton.Text = "Delete Contact";
            delecteButton.UseVisualStyleBackColor = false;
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
            Text = "View Contact";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private Label emailLabel;
        private Button editButton;
        private Panel panel1;
        private Button delecteButton;
    }
}