namespace EasyFlat
{
    partial class ListingForm
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
            txtTitle = new TextBox();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtLocation = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtArea = new TextBox();
            label6 = new Label();
            btnAddListing = new Button();
            txtRentPrice = new TextBox();
            txtRoomCount = new TextBox();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveCaption;
            txtTitle.Cursor = Cursors.Hand;
            txtTitle.Location = new Point(177, 27);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(165, 27);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Назва оголошення";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveCaption;
            txtDescription.Cursor = Cursors.Hand;
            txtDescription.Location = new Point(177, 74);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 81);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Опис";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = SystemColors.InactiveCaption;
            txtLocation.Cursor = Cursors.Hand;
            txtLocation.Location = new Point(177, 120);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 127);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Локація";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 172);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 216);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 9;
            label5.Text = "Кількість кімнат";
            // 
            // txtArea
            // 
            txtArea.BackColor = SystemColors.InactiveCaption;
            txtArea.Cursor = Cursors.Hand;
            txtArea.Location = new Point(177, 256);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 263);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 11;
            label6.Text = "Площа";
            // 
            // btnAddListing
            // 
            btnAddListing.BackColor = SystemColors.ButtonFace;
            btnAddListing.Cursor = Cursors.Hand;
            btnAddListing.Location = new Point(437, 161);
            btnAddListing.Name = "btnAddListing";
            btnAddListing.Size = new Size(144, 59);
            btnAddListing.TabIndex = 12;
            btnAddListing.Text = "Створити оголошення";
            btnAddListing.UseVisualStyleBackColor = false;
            btnAddListing.Click += btnAddListing_Click;
            // 
            // txtRentPrice
            // 
            txtRentPrice.BackColor = SystemColors.InactiveCaption;
            txtRentPrice.Cursor = Cursors.Hand;
            txtRentPrice.Location = new Point(177, 165);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(125, 27);
            txtRentPrice.TabIndex = 13;
            // 
            // txtRoomCount
            // 
            txtRoomCount.BackColor = SystemColors.InactiveCaption;
            txtRoomCount.Cursor = Cursors.Hand;
            txtRoomCount.Location = new Point(177, 209);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(125, 27);
            txtRoomCount.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.InactiveCaption;
            txtPhoneNumber.Location = new Point(177, 299);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 306);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 17;
            label7.Text = "Номер телефону";
            // 
            // ListingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(704, 338);
            Controls.Add(label7);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtRoomCount);
            Controls.Add(txtRentPrice);
            Controls.Add(btnAddListing);
            Controls.Add(label6);
            Controls.Add(txtArea);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLocation);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListingForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtLocation;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtArea;
        private Label label6;
        private Button btnAddListing;
        private TextBox txtRentPrice;
        private TextBox txtRoomCount;
        private TextBox txtPhoneNumber;
        private Label label7;
    }
}