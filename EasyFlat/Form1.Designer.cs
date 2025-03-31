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
            btnRegistration = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(257, 221);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(201, 113);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Реєстрація";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(606, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 113);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Вхід";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistration);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistration;
        private Button btnLogin;
    }
}
