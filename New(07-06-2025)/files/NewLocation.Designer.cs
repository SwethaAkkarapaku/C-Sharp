namespace NewTravelEF
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
            groupBox1 = new GroupBox();
            AddLocationButton = new Button();
            textLocationDescription = new TextBox();
            textLocationName = new TextBox();
            LocationDescriptionLabel = new Label();
            LocationNameLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddLocationButton);
            groupBox1.Controls.Add(textLocationDescription);
            groupBox1.Controls.Add(textLocationName);
            groupBox1.Controls.Add(LocationDescriptionLabel);
            groupBox1.Controls.Add(LocationNameLabel);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(47, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "AddLocations";
            // 
            // AddLocationButton
            // 
            AddLocationButton.Location = new Point(287, 185);
            AddLocationButton.Name = "AddLocationButton";
            AddLocationButton.Size = new Size(141, 29);
            AddLocationButton.TabIndex = 4;
            AddLocationButton.Text = "AddLocation";
            AddLocationButton.UseVisualStyleBackColor = true;
            AddLocationButton.Click += AddLocationButton_Click;
            // 
            // textLocationDescription
            // 
            textLocationDescription.Location = new Point(286, 96);
            textLocationDescription.Multiline = true;
            textLocationDescription.Name = "textLocationDescription";
            textLocationDescription.Size = new Size(364, 65);
            textLocationDescription.TabIndex = 3;
            // 
            // textLocationName
            // 
            textLocationName.Location = new Point(286, 31);
            textLocationName.Name = "textLocationName";
            textLocationName.Size = new Size(364, 29);
            textLocationName.TabIndex = 2;
            // 
            // LocationDescriptionLabel
            // 
            LocationDescriptionLabel.AutoSize = true;
            LocationDescriptionLabel.Location = new Point(30, 93);
            LocationDescriptionLabel.Name = "LocationDescriptionLabel";
            LocationDescriptionLabel.Size = new Size(164, 21);
            LocationDescriptionLabel.TabIndex = 1;
            LocationDescriptionLabel.Text = "LocationDescription";
            // 
            // LocationNameLabel
            // 
            LocationNameLabel.AutoSize = true;
            LocationNameLabel.Location = new Point(29, 39);
            LocationNameLabel.Name = "LocationNameLabel";
            LocationNameLabel.Size = new Size(122, 21);
            LocationNameLabel.TabIndex = 0;
            LocationNameLabel.Text = "LocationName";
            // 
            // NewLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "NewLocation";
            Text = "NewLocation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textLocationName;
        private Label LocationDescriptionLabel;
        private Label LocationNameLabel;
        private Button AddLocationButton;
        private TextBox textLocationDescription;
    }
}