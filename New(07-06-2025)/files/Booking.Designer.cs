namespace NewTravelEF
{
    partial class Booking
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
            ServiceIdlabel = new Label();
            TravelDatelabel = new Label();
            SeatCountlabel = new Label();
            BookBylabel = new Label();
            textServiceId = new TextBox();
            textSeatCount = new TextBox();
            textBookBy = new TextBox();
            AddBookingButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // ServiceIdlabel
            // 
            ServiceIdlabel.AutoSize = true;
            ServiceIdlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ServiceIdlabel.Location = new Point(55, 56);
            ServiceIdlabel.Name = "ServiceIdlabel";
            ServiceIdlabel.Size = new Size(81, 21);
            ServiceIdlabel.TabIndex = 0;
            ServiceIdlabel.Text = "ServiceId";
            // 
            // TravelDatelabel
            // 
            TravelDatelabel.AutoSize = true;
            TravelDatelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TravelDatelabel.Location = new Point(55, 106);
            TravelDatelabel.Name = "TravelDatelabel";
            TravelDatelabel.Size = new Size(92, 21);
            TravelDatelabel.TabIndex = 1;
            TravelDatelabel.Text = "TravelDate";
            // 
            // SeatCountlabel
            // 
            SeatCountlabel.AutoSize = true;
            SeatCountlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SeatCountlabel.Location = new Point(54, 152);
            SeatCountlabel.Name = "SeatCountlabel";
            SeatCountlabel.Size = new Size(89, 21);
            SeatCountlabel.TabIndex = 2;
            SeatCountlabel.Text = "SeatCount";
            // 
            // BookBylabel
            // 
            BookBylabel.AutoSize = true;
            BookBylabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BookBylabel.Location = new Point(55, 198);
            BookBylabel.Name = "BookBylabel";
            BookBylabel.Size = new Size(68, 21);
            BookBylabel.TabIndex = 3;
            BookBylabel.Text = "BookBy";
            // 
            // textServiceId
            // 
            textServiceId.Location = new Point(271, 59);
            textServiceId.Name = "textServiceId";
            textServiceId.Size = new Size(283, 23);
            textServiceId.TabIndex = 4;
            // 
            // textSeatCount
            // 
            textSeatCount.Location = new Point(271, 154);
            textSeatCount.Name = "textSeatCount";
            textSeatCount.Size = new Size(283, 23);
            textSeatCount.TabIndex = 6;
            // 
            // textBookBy
            // 
            textBookBy.Location = new Point(271, 200);
            textBookBy.Name = "textBookBy";
            textBookBy.Size = new Size(283, 23);
            textBookBy.TabIndex = 7;
            // 
            // AddBookingButton
            // 
            AddBookingButton.Location = new Point(271, 256);
            AddBookingButton.Name = "AddBookingButton";
            AddBookingButton.Size = new Size(100, 23);
            AddBookingButton.TabIndex = 8;
            AddBookingButton.Text = "AddBooking";
            AddBookingButton.UseVisualStyleBackColor = true;
            AddBookingButton.Click += AddBookingButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(AddBookingButton);
            Controls.Add(textBookBy);
            Controls.Add(textSeatCount);
            Controls.Add(textServiceId);
            Controls.Add(BookBylabel);
            Controls.Add(SeatCountlabel);
            Controls.Add(TravelDatelabel);
            Controls.Add(ServiceIdlabel);
            Name = "Booking";
            Text = "Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ServiceIdlabel;
        private Label TravelDatelabel;
        private Label SeatCountlabel;
        private Label BookBylabel;
        private TextBox textServiceId;
        private TextBox textSeatCount;
        private TextBox textBookBy;
        private Button AddBookingButton;
        private DateTimePicker dateTimePicker1;
    }
}