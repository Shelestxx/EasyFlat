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
            lblPublishDate.Location = new Point(205, 276);
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
            // ListingDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
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
    }
}