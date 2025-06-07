namespace NewTravelEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LocationGrid = new DataGridView();
            LocationContextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editLocationToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            ServiceTypeGrid = new DataGridView();
            ServiceTypeContextMenuStrip = new ContextMenuStrip(components);
            deleteServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addServicesToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            searchServicesToolStripMenuItem = new ToolStripMenuItem();
            ServicesGrid = new DataGridView();
            ServicesContextMenuStrip = new ContextMenuStrip(components);
            deleteServicesToolStripMenuItem = new ToolStripMenuItem();
            ServicesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LocationGrid).BeginInit();
            LocationContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).BeginInit();
            ServiceTypeContextMenuStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).BeginInit();
            ServicesContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // LocationGrid
            // 
            LocationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocationGrid.ContextMenuStrip = LocationContextMenuStrip;
            LocationGrid.Location = new Point(33, 81);
            LocationGrid.Name = "LocationGrid";
            LocationGrid.Size = new Size(316, 105);
            LocationGrid.TabIndex = 0;
            // 
            // LocationContextMenuStrip
            // 
            LocationContextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, editLocationToolStripMenuItem });
            LocationContextMenuStrip.Name = "LocationContextMenuStrip";
            LocationContextMenuStrip.Size = new Size(141, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(140, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editLocationToolStripMenuItem
            // 
            editLocationToolStripMenuItem.Name = "editLocationToolStripMenuItem";
            editLocationToolStripMenuItem.Size = new Size(140, 22);
            editLocationToolStripMenuItem.Text = "EditLocation";
            editLocationToolStripMenuItem.Click += editLocationToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 50);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 199);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "ServiceTypes";
            // 
            // ServiceTypeGrid
            // 
            ServiceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceTypeGrid.ContextMenuStrip = ServiceTypeContextMenuStrip;
            ServiceTypeGrid.Location = new Point(33, 226);
            ServiceTypeGrid.Name = "ServiceTypeGrid";
            ServiceTypeGrid.Size = new Size(316, 108);
            ServiceTypeGrid.TabIndex = 3;
            // 
            // ServiceTypeContextMenuStrip
            // 
            ServiceTypeContextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteServiceTypeToolStripMenuItem });
            ServiceTypeContextMenuStrip.Name = "contextMenuStrip1";
            ServiceTypeContextMenuStrip.Size = new Size(172, 26);
            // 
            // deleteServiceTypeToolStripMenuItem
            // 
            deleteServiceTypeToolStripMenuItem.Name = "deleteServiceTypeToolStripMenuItem";
            deleteServiceTypeToolStripMenuItem.Size = new Size(171, 22);
            deleteServiceTypeToolStripMenuItem.Text = "Delete ServiceType";
            deleteServiceTypeToolStripMenuItem.Click += deleteServiceTypeToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, userActionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationToolStripMenuItem, addServiceTypeToolStripMenuItem, addServicesToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(98, 20);
            adminToolStripMenuItem.Text = "Admin Actions";
            // 
            // addLocationToolStripMenuItem
            // 
            addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            addLocationToolStripMenuItem.Size = new Size(163, 22);
            addLocationToolStripMenuItem.Text = "Add Location";
            addLocationToolStripMenuItem.Click += addLocationToolStripMenuItem_Click;
            // 
            // addServiceTypeToolStripMenuItem
            // 
            addServiceTypeToolStripMenuItem.Name = "addServiceTypeToolStripMenuItem";
            addServiceTypeToolStripMenuItem.Size = new Size(163, 22);
            addServiceTypeToolStripMenuItem.Text = "Add Service Type";
            addServiceTypeToolStripMenuItem.Click += addServiceTypeToolStripMenuItem_Click;
            // 
            // addServicesToolStripMenuItem
            // 
            addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            addServicesToolStripMenuItem.Size = new Size(163, 22);
            addServicesToolStripMenuItem.Text = "Add Services";
            addServicesToolStripMenuItem.Click += addServicesToolStripMenuItem_Click;
            // 
            // userActionsToolStripMenuItem
            // 
            userActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookTicketToolStripMenuItem, searchServicesToolStripMenuItem });
            userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            userActionsToolStripMenuItem.Size = new Size(85, 20);
            userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // bookTicketToolStripMenuItem
            // 
            bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            bookTicketToolStripMenuItem.Size = new Size(180, 22);
            bookTicketToolStripMenuItem.Text = "Book Ticket";
            // 
            // searchServicesToolStripMenuItem
            // 
            searchServicesToolStripMenuItem.Name = "searchServicesToolStripMenuItem";
            searchServicesToolStripMenuItem.Size = new Size(180, 22);
            searchServicesToolStripMenuItem.Text = "Search Services";
            searchServicesToolStripMenuItem.Click += searchServicesToolStripMenuItem_Click;
            // 
            // ServicesGrid
            // 
            ServicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServicesGrid.ContextMenuStrip = ServicesContextMenuStrip;
            ServicesGrid.Location = new Point(426, 81);
            ServicesGrid.Name = "ServicesGrid";
            ServicesGrid.Size = new Size(324, 104);
            ServicesGrid.TabIndex = 5;
            // 
            // ServicesContextMenuStrip
            // 
            ServicesContextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteServicesToolStripMenuItem });
            ServicesContextMenuStrip.Name = "ServicesContextMenuStrip";
            ServicesContextMenuStrip.Size = new Size(153, 26);
            // 
            // deleteServicesToolStripMenuItem
            // 
            deleteServicesToolStripMenuItem.Name = "deleteServicesToolStripMenuItem";
            deleteServicesToolStripMenuItem.Size = new Size(152, 22);
            deleteServicesToolStripMenuItem.Text = "Delete Services";
            deleteServicesToolStripMenuItem.Click += deleteServicesToolStripMenuItem_Click;
            // 
            // ServicesLabel
            // 
            ServicesLabel.AutoSize = true;
            ServicesLabel.Location = new Point(426, 50);
            ServicesLabel.Name = "ServicesLabel";
            ServicesLabel.Size = new Size(49, 15);
            ServicesLabel.TabIndex = 6;
            ServicesLabel.Text = "Services";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ServicesLabel);
            Controls.Add(ServicesGrid);
            Controls.Add(ServiceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LocationGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LocationGrid).EndInit();
            LocationContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).EndInit();
            ServiceTypeContextMenuStrip.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).EndInit();
            ServicesContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LocationGrid;
        private Label label1;
        private Label label2;
        private DataGridView ServiceTypeGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private DataGridView ServicesGrid;
        private Label ServicesLabel;
        private ToolStripMenuItem addServicesToolStripMenuItem;
        private ContextMenuStrip LocationContextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip ServiceTypeContextMenuStrip;
        private ToolStripMenuItem deleteServiceTypeToolStripMenuItem;
        private ContextMenuStrip ServicesContextMenuStrip;
        private ToolStripMenuItem deleteServicesToolStripMenuItem;
        private ToolStripMenuItem searchServicesToolStripMenuItem;
        private ToolStripMenuItem editLocationToolStripMenuItem;
    }
}
