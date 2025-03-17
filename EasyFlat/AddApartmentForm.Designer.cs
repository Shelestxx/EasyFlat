namespace EasyFlat
{
    partial class AddApartmentForm
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
            btnOK = new Button();
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
            txtTitle.Location = new Point(155, 40);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(155, 114);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(155, 197);
            txtLocation.Margin = new Padding(2);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(150, 31);
            txtLocation.TabIndex = 2;
            // 
            // txtRentPrice
            // 
            txtRentPrice.Location = new Point(155, 269);
            txtRentPrice.Margin = new Padding(2);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(150, 31);
            txtRentPrice.TabIndex = 3;
            // 
            // txtRoomCount
            // 
            txtRoomCount.Location = new Point(155, 336);
            txtRoomCount.Margin = new Padding(2);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(150, 31);
            txtRoomCount.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(155, 406);
            txtArea.Margin = new Padding(2);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(150, 31);
            txtArea.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(497, 241);
            btnOK.Margin = new Padding(2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(231, 34);
            btnOK.TabIndex = 7;
            btnOK.Text = "Створити оголошення";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 43);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 8;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 117);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 9;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 200);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 10;
            label3.Text = "Адреса";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 275);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 11;
            label4.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 342);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 12;
            label5.Text = "Кількість кімнат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 409);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 13;
            label6.Text = "Площа";
            // 
            // AddApartmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(txtArea);
            Controls.Add(txtRoomCount);
            Controls.Add(txtRentPrice);
            Controls.Add(txtLocation);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Margin = new Padding(2);
            Name = "AddApartmentForm";
            Text = "AddApartmentForm";
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
        private Button btnOK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}