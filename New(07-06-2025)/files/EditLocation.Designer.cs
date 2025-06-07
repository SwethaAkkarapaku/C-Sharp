namespace NewTravelEF
{
    partial class EditLocation
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
            EditLocationBox = new GroupBox();
            LocationEditbutton = new Button();
            LocationNamelabel = new Label();
            textLocationName = new TextBox();
            EditLocationBox.SuspendLayout();
            SuspendLayout();
            // 
            // EditLocationBox
            // 
            EditLocationBox.Controls.Add(textLocationName);
            EditLocationBox.Controls.Add(LocationEditbutton);
            EditLocationBox.Controls.Add(LocationNamelabel);
            EditLocationBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EditLocationBox.Location = new Point(171, 65);
            EditLocationBox.Name = "EditLocationBox";
            EditLocationBox.Size = new Size(444, 175);
            EditLocationBox.TabIndex = 0;
            EditLocationBox.TabStop = false;
            EditLocationBox.Text = "EditLocation";
            // 
            // LocationEditbutton
            // 
            LocationEditbutton.Location = new Point(155, 106);
            LocationEditbutton.Name = "LocationEditbutton";
            LocationEditbutton.Size = new Size(115, 31);
            LocationEditbutton.TabIndex = 4;
            LocationEditbutton.Text = "LocationEdit";
            LocationEditbutton.UseVisualStyleBackColor = true;
            LocationEditbutton.Click += LocationEditbutton_Click;
            // 
            // LocationNamelabel
            // 
            LocationNamelabel.AutoSize = true;
            LocationNamelabel.Location = new Point(41, 44);
            LocationNamelabel.Name = "LocationNamelabel";
            LocationNamelabel.Size = new Size(122, 21);
            LocationNamelabel.TabIndex = 0;
            LocationNamelabel.Text = "LocationName";
            // 
            // textLocationName
            // 
            textLocationName.Location = new Point(207, 51);
            textLocationName.Name = "textLocationName";
            textLocationName.Size = new Size(166, 29);
            textLocationName.TabIndex = 5;
            // 
            // EditLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditLocationBox);
            Name = "EditLocation";
            Text = "EditLocation";
            EditLocationBox.ResumeLayout(false);
            EditLocationBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EditLocationBox;
        private Label LocationNamelabel;
        private Button LocationEditbutton;
        private TextBox textLocationName;
    }
}