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
            numPriceFrom = new NumericUpDown();
            numPriceTo = new NumericUpDown();
            numRoomsFrom = new NumericUpDown();
            numRoomsTo = new NumericUpDown();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            columnHeader8 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)numPriceFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPriceTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoomsFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoomsTo).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
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
            Listingbtn.Location = new Point(523, 255);
            Listingbtn.Name = "Listingbtn";
            Listingbtn.Size = new Size(127, 70);
            Listingbtn.TabIndex = 1;
            Listingbtn.Text = "Створити оголошення";
            Listingbtn.UseVisualStyleBackColor = false;
            Listingbtn.Click += Listingbtn_Click;
            // 
            // numPriceFrom
            // 
            numPriceFrom.Location = new Point(12, 40);
            numPriceFrom.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPriceFrom.Name = "numPriceFrom";
            numPriceFrom.Size = new Size(150, 27);
            numPriceFrom.TabIndex = 2;
            // 
            // numPriceTo
            // 
            numPriceTo.Location = new Point(12, 96);
            numPriceTo.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPriceTo.Name = "numPriceTo";
            numPriceTo.Size = new Size(150, 27);
            numPriceTo.TabIndex = 3;
            // 
            // numRoomsFrom
            // 
            numRoomsFrom.Location = new Point(191, 40);
            numRoomsFrom.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRoomsFrom.Name = "numRoomsFrom";
            numRoomsFrom.Size = new Size(150, 27);
            numRoomsFrom.TabIndex = 4;
            // 
            // numRoomsTo
            // 
            numRoomsTo.Location = new Point(191, 96);
            numRoomsTo.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRoomsTo.Name = "numRoomsTo";
            numRoomsTo.Size = new Size(150, 27);
            numRoomsTo.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(113, 168);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 56);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Пошук за параметрами";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 7;
            label1.Text = "Ціна від:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 8;
            label2.Text = "Ціна до:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 17);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 9;
            label3.Text = "Кількість кімнат від:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 73);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 10;
            label4.Text = "Кількість кіімнат до:";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Тел. номер";
            columnHeader8.Width = 120;
            // 
            // AllListingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1500, 524);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(numRoomsTo);
            Controls.Add(numRoomsFrom);
            Controls.Add(numPriceTo);
            Controls.Add(numPriceFrom);
            Controls.Add(Listingbtn);
            Controls.Add(listView1);
            Name = "AllListingsForm";
            Text = "AllListingsForm";
            Load += AllListingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPriceFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPriceTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoomsFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoomsTo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private NumericUpDown numPriceFrom;
        private NumericUpDown numPriceTo;
        private NumericUpDown numRoomsFrom;
        private NumericUpDown numRoomsTo;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ColumnHeader columnHeader8;
    }
}