namespace UI_WinForms
{
    partial class FormAddEditRoom
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel(); // New panel to hold all input controls for centering
            this.numericUpDownNumberOfComputers = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfComputers = new System.Windows.Forms.Label();
            this.checkBoxHasSoundSystem = new System.Windows.Forms.CheckBox();
            this.checkBoxHasAirConditioning = new System.Windows.Forms.CheckBox();
            this.checkBoxHasTV = new System.Windows.Forms.CheckBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.checkBoxHasWhiteboard = new System.Windows.Forms.CheckBox();
            this.checkBoxHasProjector = new System.Windows.Forms.CheckBox();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // Red header
            this.panelHeader.Controls.Add(this.labelFormTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; // Dock to top
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 70); // Set a fixed height
            this.panelHeader.TabIndex = 0;
            //
            // labelFormTitle
            //
            this.labelFormTitle.Anchor = System.Windows.Forms.AnchorStyles.None; // Will be centered dynamically
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFormTitle.ForeColor = System.Drawing.Color.White;
            this.labelFormTitle.Location = new System.Drawing.Point(300, 20); // Initial position, will be adjusted in CS
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(189, 29);
            this.labelFormTitle.TabIndex = 0;
            this.labelFormTitle.Text = "Add/Edit Room"; // Default text, will be set in CS
            //
            // panelContent
            //
            this.panelContent.Anchor = System.Windows.Forms.AnchorStyles.None; // Will be centered dynamically
            this.panelContent.Controls.Add(this.numericUpDownNumberOfComputers);
            this.panelContent.Controls.Add(this.labelNumberOfComputers);
            this.panelContent.Controls.Add(this.checkBoxHasSoundSystem);
            this.panelContent.Controls.Add(this.checkBoxHasAirConditioning);
            this.panelContent.Controls.Add(this.checkBoxHasTV);
            this.panelContent.Controls.Add(this.textBoxFloor);
            this.panelContent.Controls.Add(this.labelFloor);
            this.panelContent.Controls.Add(this.checkBoxHasWhiteboard);
            this.panelContent.Controls.Add(this.checkBoxHasProjector);
            this.panelContent.Controls.Add(this.numericUpDownCapacity);
            this.panelContent.Controls.Add(this.labelCapacity);
            this.panelContent.Controls.Add(this.textBoxRoomName);
            this.panelContent.Controls.Add(this.labelRoomName);
            this.panelContent.Location = new System.Drawing.Point(200, 100); // Initial position, will be adjusted
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(400, 400); // Fixed size for content panel
            this.panelContent.TabIndex = 1;
            //
            // numericUpDownNumberOfComputers
            //
            this.numericUpDownNumberOfComputers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownNumberOfComputers.Location = new System.Drawing.Point(230, 317); // Relative to panelContent
            this.numericUpDownNumberOfComputers.Name = "numericUpDownNumberOfComputers";
            this.numericUpDownNumberOfComputers.Size = new System.Drawing.Size(80, 29);
            this.numericUpDownNumberOfComputers.TabIndex = 14;
            this.numericUpDownNumberOfComputers.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            //
            // labelNumberOfComputers
            //
            this.labelNumberOfComputers.AutoSize = true;
            this.labelNumberOfComputers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOfComputers.Location = new System.Drawing.Point(50, 320); // Relative to panelContent
            this.labelNumberOfComputers.Name = "labelNumberOfComputers";
            this.labelNumberOfComputers.Size = new System.Drawing.Size(167, 21);
            this.labelNumberOfComputers.TabIndex = 13;
            this.labelNumberOfComputers.Text = "Number of Computers:";
            //
            // checkBoxHasSoundSystem
            //
            this.checkBoxHasSoundSystem.AutoSize = true;
            this.checkBoxHasSoundSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasSoundSystem.Location = new System.Drawing.Point(50, 270); // Relative to panelContent
            this.checkBoxHasSoundSystem.Name = "checkBoxHasSoundSystem";
            this.checkBoxHasSoundSystem.Size = new System.Drawing.Size(157, 25);
            this.checkBoxHasSoundSystem.TabIndex = 12;
            this.checkBoxHasSoundSystem.Text = "Has Sound System";
            this.checkBoxHasSoundSystem.UseVisualStyleBackColor = true;
            //
            // checkBoxHasAirConditioning
            //
            this.checkBoxHasAirConditioning.AutoSize = true;
            this.checkBoxHasAirConditioning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasAirConditioning.Location = new System.Drawing.Point(50, 240); // Relative to panelContent
            this.checkBoxHasAirConditioning.Name = "checkBoxHasAirConditioning";
            this.checkBoxHasAirConditioning.Size = new System.Drawing.Size(170, 25);
            this.checkBoxHasAirConditioning.TabIndex = 11;
            this.checkBoxHasAirConditioning.Text = "Has Air Conditioning";
            this.checkBoxHasAirConditioning.UseVisualStyleBackColor = true;
            //
            // checkBoxHasTV
            //
            this.checkBoxHasTV.AutoSize = true;
            this.checkBoxHasTV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasTV.Location = new System.Drawing.Point(50, 210); // Relative to panelContent
            this.checkBoxHasTV.Name = "checkBoxHasTV";
            this.checkBoxHasTV.Size = new System.Drawing.Size(81, 25);
            this.checkBoxHasTV.TabIndex = 10;
            this.checkBoxHasTV.Text = "Has TV";
            this.checkBoxHasTV.UseVisualStyleBackColor = true;
            //
            // textBoxFloor
            //
            this.textBoxFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFloor.Location = new System.Drawing.Point(180, 117); // Relative to panelContent
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(200, 29);
            this.textBoxFloor.TabIndex = 9;
            //
            // labelFloor
            //
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFloor.Location = new System.Drawing.Point(50, 120); // Relative to panelContent
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(49, 21);
            this.labelFloor.TabIndex = 8;
            this.labelFloor.Text = "Floor:";
            //
            // checkBoxHasWhiteboard
            //
            this.checkBoxHasWhiteboard.AutoSize = true;
            this.checkBoxHasWhiteboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasWhiteboard.Location = new System.Drawing.Point(50, 180); // Relative to panelContent
            this.checkBoxHasWhiteboard.Name = "checkBoxHasWhiteboard";
            this.checkBoxHasWhiteboard.Size = new System.Drawing.Size(142, 25);
            this.checkBoxHasWhiteboard.TabIndex = 5;
            this.checkBoxHasWhiteboard.Text = "Has Whiteboard";
            this.checkBoxHasWhiteboard.UseVisualStyleBackColor = true;
            //
            // checkBoxHasProjector
            //
            this.checkBoxHasProjector.AutoSize = true;
            this.checkBoxHasProjector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasProjector.Location = new System.Drawing.Point(50, 150); // Relative to panelContent
            this.checkBoxHasProjector.Name = "checkBoxHasProjector";
            this.checkBoxHasProjector.Size = new System.Drawing.Size(126, 25);
            this.checkBoxHasProjector.TabIndex = 4;
            this.checkBoxHasProjector.Text = "Has Projector";
            this.checkBoxHasProjector.UseVisualStyleBackColor = true;
            //
            // numericUpDownCapacity
            //
            this.numericUpDownCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownCapacity.Location = new System.Drawing.Point(180, 67); // Relative to panelContent
            this.numericUpDownCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(80, 29);
            this.numericUpDownCapacity.TabIndex = 3;
            this.numericUpDownCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // labelCapacity
            //
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCapacity.Location = new System.Drawing.Point(50, 70); // Relative to panelContent
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(73, 21);
            this.labelCapacity.TabIndex = 2;
            this.labelCapacity.Text = "Capacity:";
            //
            // textBoxRoomName
            //
            this.textBoxRoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRoomName.Location = new System.Drawing.Point(180, 17); // Relative to panelContent
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(200, 29);
            this.textBoxRoomName.TabIndex = 1;
            //
            // labelRoomName
            //
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomName.Location = new System.Drawing.Point(50, 20); // Relative to panelContent
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(102, 21);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "Room Name:";
            //
            // buttonSave
            //
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None; // Will be centered dynamically
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(300, 520); // Initial position, will be adjusted
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 40); // Larger buttons
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None; // Will be centered dynamically
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(410, 520); // Initial position, will be adjusted
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 40); // Larger buttons
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            //
            // FormAddEditRoom
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600); // Larger default size for a full-screen appearance
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormAddEditRoom";
            this.Text = "Add/Edit Room";
            this.Load += new System.EventHandler(this.FormAddEditRoom_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.CheckBox checkBoxHasProjector;
        private System.Windows.Forms.CheckBox checkBoxHasWhiteboard;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.CheckBox checkBoxHasTV;
        private System.Windows.Forms.CheckBox checkBoxHasAirConditioning;
        private System.Windows.Forms.CheckBox checkBoxHasSoundSystem;
        private System.Windows.Forms.Label labelNumberOfComputers;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfComputers;
    }
}