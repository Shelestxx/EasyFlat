namespace EasyFlat
{
    partial class EditListingForm
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
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveCaption;
            txtTitle.Location = new Point(238, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveCaption;
            txtDescription.Location = new Point(238, 117);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = SystemColors.InactiveCaption;
            txtLocation.Location = new Point(238, 150);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 2;
            // 
            // txtRentPrice
            // 
            txtRentPrice.BackColor = SystemColors.InactiveCaption;
            txtRentPrice.Location = new Point(238, 183);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(125, 27);
            txtRentPrice.TabIndex = 3;
            // 
            // txtRoomCount
            // 
            txtRoomCount.BackColor = SystemColors.InactiveCaption;
            txtRoomCount.Location = new Point(238, 216);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(125, 27);
            txtRoomCount.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.BackColor = SystemColors.InactiveCaption;
            txtArea.Location = new Point(238, 249);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(406, 98);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 65);
            btnSave.TabIndex = 6;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonFace;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(406, 183);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 65);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Повернутись назад";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditListingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtArea);
            Controls.Add(txtRoomCount);
            Controls.Add(txtRentPrice);
            Controls.Add(txtLocation);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "EditListingForm";
            Text = "EditListingForm";
            Load += EditListingForm_Load;
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
        private Button btnSave;
        private Button btnCancel;
    }
}