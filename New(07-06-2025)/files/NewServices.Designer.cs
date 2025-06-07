namespace NewTravelEF
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
            groupBox1 = new GroupBox();
            AddServicesButton = new Button();
            DistanceNumericUpDown = new NumericUpDown();
            Distancelabel = new Label();
            DestLocIdBox = new ComboBox();
            SourceLocIdBox = new ComboBox();
            ServTypeIdBox = new ComboBox();
            DestLocIdlabel = new Label();
            SourceLocIdlabel = new Label();
            ServTypeIdlabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DistanceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddServicesButton);
            groupBox1.Controls.Add(DistanceNumericUpDown);
            groupBox1.Controls.Add(Distancelabel);
            groupBox1.Controls.Add(DestLocIdBox);
            groupBox1.Controls.Add(SourceLocIdBox);
            groupBox1.Controls.Add(ServTypeIdBox);
            groupBox1.Controls.Add(DestLocIdlabel);
            groupBox1.Controls.Add(SourceLocIdlabel);
            groupBox1.Controls.Add(ServTypeIdlabel);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(44, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "AddServices";
            // 
            // AddServicesButton
            // 
            AddServicesButton.Location = new Point(280, 250);
            AddServicesButton.Name = "AddServicesButton";
            AddServicesButton.Size = new Size(123, 31);
            AddServicesButton.TabIndex = 8;
            AddServicesButton.Text = "AddServices";
            AddServicesButton.UseVisualStyleBackColor = true;
            AddServicesButton.Click += AddServicesButton_Click;
            // 
            // DistanceNumericUpDown
            // 
            DistanceNumericUpDown.Location = new Point(282, 188);
            DistanceNumericUpDown.Name = "DistanceNumericUpDown";
            DistanceNumericUpDown.Size = new Size(201, 29);
            DistanceNumericUpDown.TabIndex = 7;
            // 
            // Distancelabel
            // 
            Distancelabel.AutoSize = true;
            Distancelabel.Location = new Point(31, 188);
            Distancelabel.Name = "Distancelabel";
            Distancelabel.Size = new Size(76, 21);
            Distancelabel.TabIndex = 6;
            Distancelabel.Text = "Distance";
            // 
            // DestLocIdBox
            // 
            DestLocIdBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DestLocIdBox.FormattingEnabled = true;
            DestLocIdBox.Location = new Point(281, 139);
            DestLocIdBox.Name = "DestLocIdBox";
            DestLocIdBox.Size = new Size(202, 29);
            DestLocIdBox.TabIndex = 5;
            // 
            // SourceLocIdBox
            // 
            SourceLocIdBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SourceLocIdBox.FormattingEnabled = true;
            SourceLocIdBox.Location = new Point(281, 95);
            SourceLocIdBox.Name = "SourceLocIdBox";
            SourceLocIdBox.Size = new Size(202, 29);
            SourceLocIdBox.TabIndex = 4;
            // 
            // ServTypeIdBox
            // 
            ServTypeIdBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ServTypeIdBox.FormattingEnabled = true;
            ServTypeIdBox.Location = new Point(281, 50);
            ServTypeIdBox.Name = "ServTypeIdBox";
            ServTypeIdBox.Size = new Size(202, 29);
            ServTypeIdBox.TabIndex = 3;
            // 
            // DestLocIdlabel
            // 
            DestLocIdlabel.AutoSize = true;
            DestLocIdlabel.Location = new Point(31, 139);
            DestLocIdlabel.Name = "DestLocIdlabel";
            DestLocIdlabel.Size = new Size(85, 21);
            DestLocIdlabel.TabIndex = 2;
            DestLocIdlabel.Text = "DestLocId";
            // 
            // SourceLocIdlabel
            // 
            SourceLocIdlabel.AutoSize = true;
            SourceLocIdlabel.Location = new Point(31, 95);
            SourceLocIdlabel.Name = "SourceLocIdlabel";
            SourceLocIdlabel.Size = new Size(103, 21);
            SourceLocIdlabel.TabIndex = 1;
            SourceLocIdlabel.Text = "SourceLocId";
            // 
            // ServTypeIdlabel
            // 
            ServTypeIdlabel.AutoSize = true;
            ServTypeIdlabel.Location = new Point(31, 50);
            ServTypeIdlabel.Name = "ServTypeIdlabel";
            ServTypeIdlabel.Size = new Size(95, 21);
            ServTypeIdlabel.TabIndex = 0;
            ServTypeIdlabel.Text = "ServTypeId";
            // 
            // NewServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "NewServices";
            Text = "NewServices";
            Load += NewServices_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DistanceNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label Distancelabel;
        private ComboBox DestLocIdBox;
        private ComboBox SourceLocIdBox;
        private ComboBox ServTypeIdBox;
        private Label DestLocIdlabel;
        private Label SourceLocIdlabel;
        private Label ServTypeIdlabel;
        private NumericUpDown DistanceNumericUpDown;
        private Button AddServicesButton;
    }
}