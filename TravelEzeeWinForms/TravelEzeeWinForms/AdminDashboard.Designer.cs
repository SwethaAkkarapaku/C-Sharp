namespace TravelEzeeWinForms
{
    partial class AdminDashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddLocation = new System.Windows.Forms.Button();
            this.gridLocations = new System.Windows.Forms.DataGridView();
            this.Services = new System.Windows.Forms.GroupBox();
            this.BtnAddServices = new System.Windows.Forms.Button();
            this.gridServices = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocations)).BeginInit();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddLocation);
            this.groupBox1.Controls.Add(this.gridLocations);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // BtnAddLocation
            // 
            this.BtnAddLocation.Location = new System.Drawing.Point(456, 71);
            this.BtnAddLocation.Name = "BtnAddLocation";
            this.BtnAddLocation.Size = new System.Drawing.Size(133, 23);
            this.BtnAddLocation.TabIndex = 1;
            this.BtnAddLocation.Text = "BtnAddLocation";
            this.BtnAddLocation.UseVisualStyleBackColor = true;
            this.BtnAddLocation.Click += new System.EventHandler(this.BtnAddLocation_Click);
            // 
            // gridLocations
            // 
            this.gridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocations.Location = new System.Drawing.Point(16, 19);
            this.gridLocations.Name = "gridLocations";
            this.gridLocations.Size = new System.Drawing.Size(422, 75);
            this.gridLocations.TabIndex = 0;
            // 
            // Services
            // 
            this.Services.Controls.Add(this.BtnAddServices);
            this.Services.Controls.Add(this.gridServices);
            this.Services.Location = new System.Drawing.Point(12, 157);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(765, 122);
            this.Services.TabIndex = 1;
            this.Services.TabStop = false;
            this.Services.Text = "Services";
            // 
            // BtnAddServices
            // 
            this.BtnAddServices.Location = new System.Drawing.Point(456, 82);
            this.BtnAddServices.Name = "BtnAddServices";
            this.BtnAddServices.Size = new System.Drawing.Size(133, 23);
            this.BtnAddServices.TabIndex = 1;
            this.BtnAddServices.Text = "BtnAddServices";
            this.BtnAddServices.UseVisualStyleBackColor = true;
            this.BtnAddServices.Click += new System.EventHandler(this.BtnAddServices_Click);
            // 
            // gridServices
            // 
            this.gridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServices.Location = new System.Drawing.Point(16, 19);
            this.gridServices.Name = "gridServices";
            this.gridServices.Size = new System.Drawing.Size(422, 87);
            this.gridServices.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocations)).EndInit();
            this.Services.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridLocations;
        private System.Windows.Forms.Button BtnAddLocation;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.Button BtnAddServices;
        private System.Windows.Forms.DataGridView gridServices;
    }
}