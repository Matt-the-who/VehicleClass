namespace VehicleClass
{
    partial class frmVehicleClass
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lstListbox = new System.Windows.Forms.ListBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nudTimeUp = new System.Windows.Forms.NumericUpDown();
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.lblTimeBrake = new System.Windows.Forms.Label();
            this.nudTimeBrake = new System.Windows.Forms.NumericUpDown();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeBrake)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstListbox
            // 
            this.lstListbox.FormattingEnabled = true;
            this.lstListbox.Location = new System.Drawing.Point(12, 97);
            this.lstListbox.Name = "lstListbox";
            this.lstListbox.Size = new System.Drawing.Size(448, 108);
            this.lstListbox.TabIndex = 1;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(472, 24);
            this.mnuStrip.TabIndex = 2;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // nudTimeUp
            // 
            this.nudTimeUp.DecimalPlaces = 1;
            this.nudTimeUp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudTimeUp.Location = new System.Drawing.Point(165, 29);
            this.nudTimeUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeUp.Name = "nudTimeUp";
            this.nudTimeUp.Size = new System.Drawing.Size(103, 20);
            this.nudTimeUp.TabIndex = 3;
            this.nudTimeUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUp.Location = new System.Drawing.Point(5, 28);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.Size = new System.Drawing.Size(161, 20);
            this.lblTimeUp.TabIndex = 4;
            this.lblTimeUp.Text = "Time to speed up (s): ";
            // 
            // lblTimeBrake
            // 
            this.lblTimeBrake.AutoSize = true;
            this.lblTimeBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeBrake.Location = new System.Drawing.Point(31, 59);
            this.lblTimeBrake.Name = "lblTimeBrake";
            this.lblTimeBrake.Size = new System.Drawing.Size(131, 20);
            this.lblTimeBrake.TabIndex = 5;
            this.lblTimeBrake.Text = "Time to brake (s):";
            // 
            // nudTimeBrake
            // 
            this.nudTimeBrake.DecimalPlaces = 1;
            this.nudTimeBrake.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudTimeBrake.Location = new System.Drawing.Point(165, 58);
            this.nudTimeBrake.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeBrake.Name = "nudTimeBrake";
            this.nudTimeBrake.Size = new System.Drawing.Size(103, 20);
            this.nudTimeBrake.TabIndex = 6;
            this.nudTimeBrake.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmVehicleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.nudTimeBrake);
            this.Controls.Add(this.lblTimeBrake);
            this.Controls.Add(this.lblTimeUp);
            this.Controls.Add(this.nudTimeUp);
            this.Controls.Add(this.lstListbox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmVehicleClass";
            this.Text = "Vehicle Class";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeBrake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lstListbox;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.NumericUpDown nudTimeUp;
        private System.Windows.Forms.Label lblTimeUp;
        private System.Windows.Forms.Label lblTimeBrake;
        private System.Windows.Forms.NumericUpDown nudTimeBrake;
    }
}

