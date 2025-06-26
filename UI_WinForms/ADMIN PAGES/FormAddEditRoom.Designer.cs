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
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHasProjector = new System.Windows.Forms.CheckBox();
            this.checkBoxHasWhiteboard = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFloor = new System.Windows.Forms.Label(); // New Label for Floor
            this.textBoxFloor = new System.Windows.Forms.TextBox(); // New TextBox for Floor
            this.checkBoxHasTV = new System.Windows.Forms.CheckBox(); // New CheckBox for TV
            this.checkBoxHasAirConditioning = new System.Windows.Forms.CheckBox(); // New CheckBox for AC
            this.checkBoxHasSoundSystem = new System.Windows.Forms.CheckBox(); // New CheckBox for Sound System
            this.labelNumberOfComputers = new System.Windows.Forms.Label(); // New Label for Computers
            this.numericUpDownNumberOfComputers = new System.Windows.Forms.NumericUpDown(); // New NumericUpDown for Computers
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfComputers)).BeginInit(); // Initialize new NumericUpDown
            this.SuspendLayout();
            //
            // labelRoomName
            //
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomName.Location = new System.Drawing.Point(50, 50);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(102, 21);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "Room Name:";
            //
            // textBoxRoomName
            //
            this.textBoxRoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRoomName.Location = new System.Drawing.Point(180, 47);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(200, 29);
            this.textBoxRoomName.TabIndex = 1;
            //
            // labelCapacity
            //
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCapacity.Location = new System.Drawing.Point(50, 100);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(73, 21);
            this.labelCapacity.TabIndex = 2;
            this.labelCapacity.Text = "Capacity:";
            //
            // numericUpDownCapacity
            //
            this.numericUpDownCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownCapacity.Location = new System.Drawing.Point(180, 97);
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
            // labelFloor
            // // NEW LABEL FOR FLOOR
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFloor.Location = new System.Drawing.Point(50, 150); // Adjusted Y position
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(49, 21);
            this.labelFloor.TabIndex = 8; // Adjust TabIndex
            this.labelFloor.Text = "Floor:";
            //
            // textBoxFloor
            // // NEW TEXTBOX FOR FLOOR
            this.textBoxFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFloor.Location = new System.Drawing.Point(180, 147); // Adjusted Y position
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(200, 29);
            this.textBoxFloor.TabIndex = 9; // Adjust TabIndex
            //
            // checkBoxHasProjector
            //
            this.checkBoxHasProjector.AutoSize = true;
            this.checkBoxHasProjector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasProjector.Location = new System.Drawing.Point(50, 200); // Adjusted Y position
            this.checkBoxHasProjector.Name = "checkBoxHasProjector";
            this.checkBoxHasProjector.Size = new System.Drawing.Size(126, 25);
            this.checkBoxHasProjector.TabIndex = 4;
            this.checkBoxHasProjector.Text = "Has Projector";
            this.checkBoxHasProjector.UseVisualStyleBackColor = true;
            //
            // checkBoxHasWhiteboard
            //
            this.checkBoxHasWhiteboard.AutoSize = true;
            this.checkBoxHasWhiteboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasWhiteboard.Location = new System.Drawing.Point(50, 230); // Adjusted Y position
            this.checkBoxHasWhiteboard.Name = "checkBoxHasWhiteboard";
            this.checkBoxHasWhiteboard.Size = new System.Drawing.Size(142, 25);
            this.checkBoxHasWhiteboard.TabIndex = 5;
            this.checkBoxHasWhiteboard.Text = "Has Whiteboard";
            this.checkBoxHasWhiteboard.UseVisualStyleBackColor = true;
            //
            // checkBoxHasTV
            // // NEW CHECKBOX FOR TV
            this.checkBoxHasTV.AutoSize = true;
            this.checkBoxHasTV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasTV.Location = new System.Drawing.Point(50, 260); // Adjusted Y position
            this.checkBoxHasTV.Name = "checkBoxHasTV";
            this.checkBoxHasTV.Size = new System.Drawing.Size(81, 25);
            this.checkBoxHasTV.TabIndex = 10; // Adjust TabIndex
            this.checkBoxHasTV.Text = "Has TV";
            this.checkBoxHasTV.UseVisualStyleBackColor = true;
            //
            // checkBoxHasAirConditioning
            // // NEW CHECKBOX FOR AIR CONDITIONING
            this.checkBoxHasAirConditioning.AutoSize = true;
            this.checkBoxHasAirConditioning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasAirConditioning.Location = new System.Drawing.Point(50, 290); // Adjusted Y position
            this.checkBoxHasAirConditioning.Name = "checkBoxHasAirConditioning";
            this.checkBoxHasAirConditioning.Size = new System.Drawing.Size(170, 25);
            this.checkBoxHasAirConditioning.TabIndex = 11; // Adjust TabIndex
            this.checkBoxHasAirConditioning.Text = "Has Air Conditioning";
            this.checkBoxHasAirConditioning.UseVisualStyleBackColor = true;
            //
            // checkBoxHasSoundSystem
            // // NEW CHECKBOX FOR SOUND SYSTEM
            this.checkBoxHasSoundSystem.AutoSize = true;
            this.checkBoxHasSoundSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHasSoundSystem.Location = new System.Drawing.Point(50, 320); // Adjusted Y position
            this.checkBoxHasSoundSystem.Name = "checkBoxHasSoundSystem";
            this.checkBoxHasSoundSystem.Size = new System.Drawing.Size(157, 25);
            this.checkBoxHasSoundSystem.TabIndex = 12; // Adjust TabIndex
            this.checkBoxHasSoundSystem.Text = "Has Sound System";
            this.checkBoxHasSoundSystem.UseVisualStyleBackColor = true;
            //
            // labelNumberOfComputers
            // // NEW LABEL FOR NUMBER OF COMPUTERS
            this.labelNumberOfComputers.AutoSize = true;
            this.labelNumberOfComputers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOfComputers.Location = new System.Drawing.Point(50, 370); // Adjusted Y position
            this.labelNumberOfComputers.Name = "labelNumberOfComputers";
            this.labelNumberOfComputers.Size = new System.Drawing.Size(167, 21);
            this.labelNumberOfComputers.TabIndex = 13; // Adjust TabIndex
            this.labelNumberOfComputers.Text = "Number of Computers:";
            //
            // numericUpDownNumberOfComputers
            // // NEW NUMERICUPDOWN FOR NUMBER OF COMPUTERS
            this.numericUpDownNumberOfComputers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownNumberOfComputers.Location = new System.Drawing.Point(230, 367); // Adjusted Y position
            this.numericUpDownNumberOfComputers.Name = "numericUpDownNumberOfComputers";
            this.numericUpDownNumberOfComputers.Size = new System.Drawing.Size(80, 29);
            this.numericUpDownNumberOfComputers.TabIndex = 14; // Adjust TabIndex
            this.numericUpDownNumberOfComputers.Value = new decimal(new int[] {
            0,
            0,
            0,
            0}); // Default to 0
            //
            // buttonSave
            //
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(180, 420); // Adjusted Y position
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 35);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(290, 420); // Adjusted Y position
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            //
            // FormAddEditRoom
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500); // Increased form size to accommodate new controls
            this.Controls.Add(this.numericUpDownNumberOfComputers);
            this.Controls.Add(this.labelNumberOfComputers);
            this.Controls.Add(this.checkBoxHasSoundSystem);
            this.Controls.Add(this.checkBoxHasAirConditioning);
            this.Controls.Add(this.checkBoxHasTV);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxHasWhiteboard);
            this.Controls.Add(this.checkBoxHasProjector);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelRoomName);
            this.Name = "FormAddEditRoom";
            this.Text = "Add/Edit Room"; // This is the title displayed in the window bar
            this.Load += new System.EventHandler(this.FormAddEditRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfComputers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.CheckBox checkBoxHasProjector;
        private System.Windows.Forms.CheckBox checkBoxHasWhiteboard;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFloor; // New property
        private System.Windows.Forms.TextBox textBoxFloor; // New property
        private System.Windows.Forms.CheckBox checkBoxHasTV; // New property
        private System.Windows.Forms.CheckBox checkBoxHasAirConditioning; // New property
        private System.Windows.Forms.CheckBox checkBoxHasSoundSystem; // New property
        private System.Windows.Forms.Label labelNumberOfComputers; // New property
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfComputers; // New property
    }
}
