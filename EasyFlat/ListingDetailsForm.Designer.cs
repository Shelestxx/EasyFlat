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
            txtTitle.Location = new Point(200, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(201, 122);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(202, 173);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 2;
            // 
            // txtRentPrice
            // 
            txtRentPrice.Location = new Point(203, 222);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(125, 27);
            txtRentPrice.TabIndex = 3;
            // 
            // txtRoomCount
            // 
            txtRoomCount.Location = new Point(204, 279);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(125, 27);
            txtRoomCount.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(205, 334);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 5;
            // 
            // lblPublishDate
            // 
            lblPublishDate.AutoSize = true;
            lblPublishDate.Location = new Point(200, 376);
            lblPublishDate.Name = "lblPublishDate";
            lblPublishDate.Size = new Size(50, 20);
            lblPublishDate.TabIndex = 6;
            lblPublishDate.Text = "label1";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(495, 123);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(499, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(497, 276);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ListingDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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