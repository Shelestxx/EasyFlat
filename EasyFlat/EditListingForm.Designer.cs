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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.InactiveCaption;
            txtTitle.Location = new Point(238, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 91);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 8;
            label1.Text = "Назва оголошення";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 124);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 9;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 157);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 10;
            label3.Text = "Локація";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 190);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 11;
            label4.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 223);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 12;
            label5.Text = "Кількість кімнат";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 256);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 13;
            label6.Text = "Площа";
            // 
            // EditListingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}