namespace TravelEzeeWinForms
{
    partial class NewLocation
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
            this.LocationNumber = new System.Windows.Forms.Label();
            this.textLocNo = new System.Windows.Forms.TextBox();
            this.LocationName = new System.Windows.Forms.Label();
            this.textLocName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationNumber
            // 
            this.LocationNumber.AutoSize = true;
            this.LocationNumber.Location = new System.Drawing.Point(28, 29);
            this.LocationNumber.Name = "LocationNumber";
            this.LocationNumber.Size = new System.Drawing.Size(88, 13);
            this.LocationNumber.TabIndex = 0;
            this.LocationNumber.Text = "Location Number";
            // 
            // textLocNo
            // 
            this.textLocNo.Location = new System.Drawing.Point(148, 29);
            this.textLocNo.Name = "textLocNo";
            this.textLocNo.Size = new System.Drawing.Size(244, 20);
            this.textLocNo.TabIndex = 1;
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Location = new System.Drawing.Point(28, 72);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(79, 13);
            this.LocationName.TabIndex = 2;
            this.LocationName.Text = "Location Name";
            // 
            // textLocName
            // 
            this.textLocName.Location = new System.Drawing.Point(148, 72);
            this.textLocName.Name = "textLocName";
            this.textLocName.Size = new System.Drawing.Size(244, 20);
            this.textLocName.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(31, 130);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(203, 129);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textLocName);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.textLocNo);
            this.Controls.Add(this.LocationNumber);
            this.Name = "NewLocation";
            this.Text = "NewLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationNumber;
        private System.Windows.Forms.TextBox textLocNo;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.TextBox textLocName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}