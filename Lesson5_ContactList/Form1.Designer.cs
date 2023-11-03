namespace Lesson5_ContactList
{
    partial class ContactListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addNewContactButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addNewContactButton
            // 
            addNewContactButton.AutoSize = true;
            addNewContactButton.BackColor = Color.Coral;
            addNewContactButton.Dock = DockStyle.Fill;
            addNewContactButton.FlatStyle = FlatStyle.Popup;
            addNewContactButton.ForeColor = Color.Black;
            addNewContactButton.Location = new Point(0, 0);
            addNewContactButton.Name = "addNewContactButton";
            addNewContactButton.Size = new Size(382, 30);
            addNewContactButton.TabIndex = 0;
            addNewContactButton.Text = "Create Contact";
            addNewContactButton.UseVisualStyleBackColor = false;
            addNewContactButton.Click += addNewContactButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(addNewContactButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1079);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 30);
            panel1.TabIndex = 1;
            // 
            // ContactListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(382, 1109);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ContactListForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Contact List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button addNewContactButton;
        private Panel panel1;
    }
}