namespace EasyFlat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRegistration = new Button();
            btnLogin = new Button();
            btnManageUsers = new Button();
            SuspendLayout();
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = SystemColors.ButtonHighlight;
            btnRegistration.Cursor = Cursors.Hand;
            btnRegistration.FlatAppearance.BorderColor = Color.Fuchsia;
            btnRegistration.FlatAppearance.BorderSize = 10;
            btnRegistration.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            btnRegistration.ForeColor = Color.Black;
            btnRegistration.Image = (Image)resources.GetObject("btnRegistration.Image");
            btnRegistration.Location = new Point(145, 186);
            btnRegistration.Margin = new Padding(2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(161, 90);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Реєстрація";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(422, 186);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 90);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Вхід";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(578, 99);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(94, 29);
            btnManageUsers.TabIndex = 2;
            btnManageUsers.Text = "button1";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 440);
            Controls.Add(btnManageUsers);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistration);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistration;
        private Button btnLogin;
        private Button btnManageUsers;
    }
}
