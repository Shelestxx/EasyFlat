namespace EasyFlat
{
    partial class ListingDetailsForm
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
            txtDescription = new TextBox();
            txtLocation = new TextBox();
            txtRentPrice = new TextBox();
            txtRoomCount = new TextBox();
            txtArea = new TextBox();
            lblPublishDate = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveCaption;
            txtTitle.Location = new Point(205, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveCaption;
            txtDescription.Location = new Point(205, 106);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = SystemColors.InactiveCaption;
            txtLocation.Location = new Point(205, 139);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 2;
            // 
            // txtRentPrice
            // 
            txtRentPrice.BackColor = SystemColors.InactiveCaption;
            txtRentPrice.Location = new Point(205, 172);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(125, 27);
            txtRentPrice.TabIndex = 3;
            // 
            // txtRoomCount
            // 
            txtRoomCount.BackColor = SystemColors.InactiveCaption;
            txtRoomCount.Location = new Point(205, 205);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(125, 27);
            txtRoomCount.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.BackColor = SystemColors.InactiveCaption;
            txtArea.Location = new Point(205, 238);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 5;
            // 
            // lblPublishDate
            // 
            lblPublishDate.AutoSize = true;
            lblPublishDate.Location = new Point(205, 303);
            lblPublishDate.Name = "lblPublishDate";
            lblPublishDate.Size = new Size(50, 20);
            lblPublishDate.TabIndex = 6;
            lblPublishDate.Text = "label1";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(499, 104);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Змінити";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(499, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonFace;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(499, 174);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 58);
            btnClose.TabIndex = 9;
            btnClose.Text = "повернутись назад";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 80);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 10;
            label1.Text = "Назва оголошення";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 113);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 11;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 146);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Локація";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 179);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 13;
            label4.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 212);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 14;
            label5.Text = "Кількість кімнат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 245);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 15;
            label6.Text = "Площа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 280);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 16;
            label7.Text = "Номер телефону";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.InactiveCaption;
            txtPhoneNumber.Location = new Point(205, 273);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 17;
            // 
            // ListingDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblPublishDate);
            Controls.Add(txtArea);
            Controls.Add(txtRoomCount);
            Controls.Add(txtRentPrice);
            Controls.Add(txtLocation);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "ListingDetailsForm";
            Text = "ListingDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtLocation;
        private TextBox txtRentPrice;
        private TextBox txtRoomCount;
        private TextBox txtArea;
        private Label lblPublishDate;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPhoneNumber;
    }
}