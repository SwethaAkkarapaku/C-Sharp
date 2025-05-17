namespace TravelEzeeWinForms
{
    partial class NewServices
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
            this.ServiceNo = new System.Windows.Forms.Label();
            this.textServiceNo = new System.Windows.Forms.TextBox();
            this.Locationlabel = new System.Windows.Forms.Label();
            this.textFromLocation = new System.Windows.Forms.TextBox();
            this.ToLocationlabel = new System.Windows.Forms.Label();
            this.textToLocation = new System.Windows.Forms.TextBox();
            this.ServiceTypeIdlabel = new System.Windows.Forms.Label();
            this.textServiceTypeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServiceNo
            // 
            this.ServiceNo.AutoSize = true;
            this.ServiceNo.Location = new System.Drawing.Point(45, 26);
            this.ServiceNo.Name = "ServiceNo";
            this.ServiceNo.Size = new System.Drawing.Size(57, 13);
            this.ServiceNo.TabIndex = 0;
            this.ServiceNo.Text = "ServiceNo";
            // 
            // textServiceNo
            // 
            this.textServiceNo.Location = new System.Drawing.Point(194, 26);
            this.textServiceNo.Name = "textServiceNo";
            this.textServiceNo.Size = new System.Drawing.Size(100, 20);
            this.textServiceNo.TabIndex = 1;
            // 
            // Locationlabel
            // 
            this.Locationlabel.AutoSize = true;
            this.Locationlabel.Location = new System.Drawing.Point(45, 73);
            this.Locationlabel.Name = "Locationlabel";
            this.Locationlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Locationlabel.Size = new System.Drawing.Size(71, 13);
            this.Locationlabel.TabIndex = 2;
            this.Locationlabel.Text = "FromLocation";
            // 
            // textFromLocation
            // 
            this.textFromLocation.Enabled = false;
            this.textFromLocation.Location = new System.Drawing.Point(194, 73);
            this.textFromLocation.Name = "textFromLocation";
            this.textFromLocation.Size = new System.Drawing.Size(100, 20);
            this.textFromLocation.TabIndex = 3;
            // 
            // ToLocationlabel
            // 
            this.ToLocationlabel.AutoSize = true;
            this.ToLocationlabel.Location = new System.Drawing.Point(45, 118);
            this.ToLocationlabel.Name = "ToLocationlabel";
            this.ToLocationlabel.Size = new System.Drawing.Size(61, 13);
            this.ToLocationlabel.TabIndex = 4;
            this.ToLocationlabel.Text = "ToLocation";
            // 
            // textToLocation
            // 
            this.textToLocation.Location = new System.Drawing.Point(194, 118);
            this.textToLocation.Name = "textToLocation";
            this.textToLocation.Size = new System.Drawing.Size(100, 20);
            this.textToLocation.TabIndex = 5;
            // 
            // ServiceTypeIdlabel
            // 
            this.ServiceTypeIdlabel.AutoSize = true;
            this.ServiceTypeIdlabel.Location = new System.Drawing.Point(48, 164);
            this.ServiceTypeIdlabel.Name = "ServiceTypeIdlabel";
            this.ServiceTypeIdlabel.Size = new System.Drawing.Size(76, 13);
            this.ServiceTypeIdlabel.TabIndex = 6;
            this.ServiceTypeIdlabel.Text = "ServiceTypeId";
            // 
            // textServiceTypeId
            // 
            this.textServiceTypeId.Location = new System.Drawing.Point(194, 164);
            this.textServiceTypeId.Name = "textServiceTypeId";
            this.textServiceTypeId.Size = new System.Drawing.Size(100, 20);
            this.textServiceTypeId.TabIndex = 7;
            // 
            // NewServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textServiceTypeId);
            this.Controls.Add(this.ServiceTypeIdlabel);
            this.Controls.Add(this.textToLocation);
            this.Controls.Add(this.ToLocationlabel);
            this.Controls.Add(this.textFromLocation);
            this.Controls.Add(this.Locationlabel);
            this.Controls.Add(this.textServiceNo);
            this.Controls.Add(this.ServiceNo);
            this.Name = "NewServices";
            this.Text = "NewServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceNo;
        private System.Windows.Forms.TextBox textServiceNo;
        private System.Windows.Forms.Label Locationlabel;
        private System.Windows.Forms.TextBox textFromLocation;
        private System.Windows.Forms.Label ToLocationlabel;
        private System.Windows.Forms.TextBox textToLocation;
        private System.Windows.Forms.Label ServiceTypeIdlabel;
        private System.Windows.Forms.TextBox textServiceTypeId;
    }
}