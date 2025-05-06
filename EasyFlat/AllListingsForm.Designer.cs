namespace EasyFlat
{
    partial class AllListingsForm
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            Listingbtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(723, -1);
            listView1.Name = "listView1";
            listView1.Size = new Size(788, 533);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Назва";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Опис";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Місцезнаходження";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ціна";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Кімнат";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Площа";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Дата публікації";
            columnHeader7.Width = 120;
            // 
            // Listingbtn
            // 
            Listingbtn.BackColor = SystemColors.ButtonFace;
            Listingbtn.Cursor = Cursors.Hand;
            Listingbtn.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            Listingbtn.Location = new Point(273, 214);
            Listingbtn.Name = "Listingbtn";
            Listingbtn.Size = new Size(127, 70);
            Listingbtn.TabIndex = 1;
            Listingbtn.Text = "Створити оголошення";
            Listingbtn.UseVisualStyleBackColor = false;
            Listingbtn.Click += Listingbtn_Click;
            // 
            // AllListingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1500, 524);
            Controls.Add(Listingbtn);
            Controls.Add(listView1);
            Name = "AllListingsForm";
            Text = "AllListingsForm";
            Load += AllListingsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button Listingbtn;
    }
}