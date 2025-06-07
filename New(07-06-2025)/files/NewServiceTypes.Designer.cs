namespace NewTravelEF
{
    partial class NewServiceTypes
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
            groupBox1 = new GroupBox();
            ServiceTypeNameLabel = new Label();
            PricePerKmLabel = new Label();
            textServiceTypeName = new TextBox();
            textPricePerKm = new TextBox();
            AddServiceTypeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddServiceTypeButton);
            groupBox1.Controls.Add(textPricePerKm);
            groupBox1.Controls.Add(textServiceTypeName);
            groupBox1.Controls.Add(PricePerKmLabel);
            groupBox1.Controls.Add(ServiceTypeNameLabel);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(39, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "AddServiceType";
            // 
            // ServiceTypeNameLabel
            // 
            ServiceTypeNameLabel.AutoSize = true;
            ServiceTypeNameLabel.Location = new Point(28, 35);
            ServiceTypeNameLabel.Name = "ServiceTypeNameLabel";
            ServiceTypeNameLabel.Size = new Size(148, 21);
            ServiceTypeNameLabel.TabIndex = 0;
            ServiceTypeNameLabel.Text = "ServiceTypeName";
            // 
            // PricePerKmLabel
            // 
            PricePerKmLabel.AutoSize = true;
            PricePerKmLabel.Location = new Point(28, 81);
            PricePerKmLabel.Name = "PricePerKmLabel";
            PricePerKmLabel.Size = new Size(98, 21);
            PricePerKmLabel.TabIndex = 1;
            PricePerKmLabel.Text = "PricePerKm";
            // 
            // textServiceTypeName
            // 
            textServiceTypeName.Location = new Point(266, 35);
            textServiceTypeName.Name = "textServiceTypeName";
            textServiceTypeName.Size = new Size(353, 29);
            textServiceTypeName.TabIndex = 2;
            // 
            // textPricePerKm
            // 
            textPricePerKm.Location = new Point(266, 81);
            textPricePerKm.Name = "textPricePerKm";
            textPricePerKm.Size = new Size(353, 29);
            textPricePerKm.TabIndex = 3;
            // 
            // AddServiceTypeButton
            // 
            AddServiceTypeButton.Location = new Point(267, 130);
            AddServiceTypeButton.Name = "AddServiceTypeButton";
            AddServiceTypeButton.Size = new Size(156, 32);
            AddServiceTypeButton.TabIndex = 4;
            AddServiceTypeButton.Text = "AddServiceType";
            AddServiceTypeButton.UseVisualStyleBackColor = true;
            AddServiceTypeButton.Click += AddServiceTypeButton_Click;
            // 
            // NewServiceTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "NewServiceTypes";
            Text = "NewServiceTypes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label PricePerKmLabel;
        private Label ServiceTypeNameLabel;
        private Button AddServiceTypeButton;
        private TextBox textPricePerKm;
        private TextBox textServiceTypeName;
    }
}