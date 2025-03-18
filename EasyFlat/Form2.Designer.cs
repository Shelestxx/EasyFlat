namespace EasyFlat
{
    partial class Form2
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
            add = new Button();
            listBoxApartments = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(586, 161);
            add.Name = "add";
            add.Size = new Size(112, 34);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // listBoxApartments
            // 
            listBoxApartments.FormattingEnabled = true;
            listBoxApartments.ItemHeight = 25;
            listBoxApartments.Location = new Point(58, 64);
            listBoxApartments.Name = "listBoxApartments";
            listBoxApartments.Size = new Size(267, 279);
            listBoxApartments.TabIndex = 1;
            listBoxApartments.SelectedIndexChanged += listBoxApartments_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(586, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(btnDelete);
            Controls.Add(listBoxApartments);
            Controls.Add(add);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button add;
        private ListBox listBoxApartments;
        private Button btnDelete;
    }
}