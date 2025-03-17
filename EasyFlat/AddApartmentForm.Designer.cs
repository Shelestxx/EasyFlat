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
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(114, 32);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(121, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(114, 91);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(114, 155);
            txtLocation.Margin = new Padding(2);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(121, 27);
            txtLocation.TabIndex = 2;
            // 
            // txtRentPrice
            // 
            txtRentPrice.Location = new Point(114, 213);
            txtRentPrice.Margin = new Padding(2);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(121, 27);
            txtRentPrice.TabIndex = 3;
            // 
            // txtRoomCount
            // 
            txtRoomCount.Location = new Point(114, 269);
            txtRoomCount.Margin = new Padding(2);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(121, 27);
            txtRoomCount.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(114, 325);
            txtArea.Margin = new Padding(2);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(121, 27);
            txtArea.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(426, 195);
            btnOK.Margin = new Padding(2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 27);
            btnOK.TabIndex = 7;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // AddApartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 458);
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
    }
}