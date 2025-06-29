namespace UI_WinForms
{
    partial class FormManageRooms
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }




        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonAddRoom = new Button();
            buttonClose = new Button();
            dataGridViewRooms = new DataGridView();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkRed;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(buttonAddRoom);
            panelHeader.Controls.Add(buttonClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(30, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(191, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Manage Rooms";
            // 
            // buttonAddRoom
            // 
            buttonAddRoom.Anchor = AnchorStyles.Right;
            buttonAddRoom.BackColor = Color.White;
            buttonAddRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAddRoom.Location = new Point(794, 22);
            buttonAddRoom.Name = "buttonAddRoom";
            buttonAddRoom.Size = new Size(130, 35);
            buttonAddRoom.TabIndex = 1;
            buttonAddRoom.Text = "Add Room";
            buttonAddRoom.UseVisualStyleBackColor = true;
            buttonAddRoom.Click += buttonAddRoom_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.Goldenrod;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(938, 17);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(50, 40);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "×";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeight = 29;
            dataGridViewRooms.Dock = DockStyle.Fill;
            dataGridViewRooms.Location = new Point(0, 80);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 51;
            dataGridViewRooms.Size = new Size(1000, 620);
            dataGridViewRooms.TabIndex = 1;
            dataGridViewRooms.CellContentClick += dataGridViewRooms_CellContentClick;
            // 
            // FormManageRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(dataGridViewRooms);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManageRooms";
            Text = "FormManageRooms";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
        }



    }
}

