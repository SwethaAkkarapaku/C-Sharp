namespace NewTravelEF
{
    partial class SearchList
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
            components = new System.ComponentModel.Container();
            Sourcelabel = new Label();
            SearchBasedOnLocations = new GroupBox();
            DestinationBox = new ComboBox();
            SourceBox = new ComboBox();
            SearchButton = new Button();
            DestinationLabel = new Label();
            SearchGrid = new DataGridView();
            BookContextMenuStrip = new ContextMenuStrip(components);
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            SearchBasedOnLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchGrid).BeginInit();
            BookContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Sourcelabel
            // 
            Sourcelabel.AutoSize = true;
            Sourcelabel.Location = new Point(42, 37);
            Sourcelabel.Name = "Sourcelabel";
            Sourcelabel.Size = new Size(62, 21);
            Sourcelabel.TabIndex = 0;
            Sourcelabel.Text = "Source";
            // 
            // SearchBasedOnLocations
            // 
            SearchBasedOnLocations.Controls.Add(DestinationBox);
            SearchBasedOnLocations.Controls.Add(SourceBox);
            SearchBasedOnLocations.Controls.Add(SearchButton);
            SearchBasedOnLocations.Controls.Add(DestinationLabel);
            SearchBasedOnLocations.Controls.Add(Sourcelabel);
            SearchBasedOnLocations.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SearchBasedOnLocations.Location = new Point(45, 46);
            SearchBasedOnLocations.Name = "SearchBasedOnLocations";
            SearchBasedOnLocations.Size = new Size(665, 161);
            SearchBasedOnLocations.TabIndex = 1;
            SearchBasedOnLocations.TabStop = false;
            SearchBasedOnLocations.Text = "SearchBasedOnLocations";
            // 
            // DestinationBox
            // 
            DestinationBox.FormattingEnabled = true;
            DestinationBox.Location = new Point(462, 39);
            DestinationBox.Name = "DestinationBox";
            DestinationBox.Size = new Size(151, 29);
            DestinationBox.TabIndex = 4;
            // 
            // SourceBox
            // 
            SourceBox.FormattingEnabled = true;
            SourceBox.Location = new Point(157, 39);
            SourceBox.Name = "SourceBox";
            SourceBox.Size = new Size(148, 29);
            SourceBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(42, 94);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 32);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(350, 37);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(99, 21);
            DestinationLabel.TabIndex = 1;
            DestinationLabel.Text = "Destination";
            // 
            // SearchGrid
            // 
            SearchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchGrid.ContextMenuStrip = BookContextMenuStrip;
            SearchGrid.Location = new Point(45, 226);
            SearchGrid.Name = "SearchGrid";
            SearchGrid.Size = new Size(665, 136);
            SearchGrid.TabIndex = 2;
            // 
            // BookContextMenuStrip
            // 
            BookContextMenuStrip.Items.AddRange(new ToolStripItem[] { bookTicketToolStripMenuItem });
            BookContextMenuStrip.Name = "BookContextMenuStrip";
            BookContextMenuStrip.Size = new Size(181, 48);
            // 
            // bookTicketToolStripMenuItem
            // 
            bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            bookTicketToolStripMenuItem.Size = new Size(180, 22);
            bookTicketToolStripMenuItem.Text = "BookTicket";
            bookTicketToolStripMenuItem.Click += bookTicketToolStripMenuItem_Click;
            // 
            // SearchList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchGrid);
            Controls.Add(SearchBasedOnLocations);
            Name = "SearchList";
            Text = "SearchList";
            Load += SearchList_Load;
            SearchBasedOnLocations.ResumeLayout(false);
            SearchBasedOnLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchGrid).EndInit();
            BookContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Sourcelabel;
        private GroupBox SearchBasedOnLocations;
        private ComboBox DestinationBox;
        private ComboBox SourceBox;
        private Button SearchButton;
        private Label DestinationLabel;
        private DataGridView SearchGrid;
        private ContextMenuStrip BookContextMenuStrip;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
    }
}