namespace FilterWeatherData
{
    partial class UserInterface
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
            this.ux_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ux_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ux_ListBox = new System.Windows.Forms.ListBox();
            this.ux_FilterOptions = new System.Windows.Forms.GroupBox();
            this.ux_DateHistory = new System.Windows.Forms.RadioButton();
            this.ux_AboveTemp = new System.Windows.Forms.RadioButton();
            this.ux_BelowTemp = new System.Windows.Forms.RadioButton();
            this.ux_SelectedRange = new System.Windows.Forms.RadioButton();
            this.ux_Calendar = new System.Windows.Forms.MonthCalendar();
            this.ux_FilterButton = new System.Windows.Forms.Button();
            this.ux_UndoButton = new System.Windows.Forms.Button();
            this.ux_UpDown = new System.Windows.Forms.NumericUpDown();
            this.ux_TempLabel = new System.Windows.Forms.Label();
            this.ux_MenuStrip.SuspendLayout();
            this.ux_FilterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_MenuStrip
            // 
            this.ux_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ux_File});
            this.ux_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ux_MenuStrip.Name = "ux_MenuStrip";
            this.ux_MenuStrip.Size = new System.Drawing.Size(881, 24);
            this.ux_MenuStrip.TabIndex = 0;
            this.ux_MenuStrip.Text = "menuStrip1";
            // 
            // ux_File
            // 
            this.ux_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ux_Open});
            this.ux_File.Name = "ux_File";
            this.ux_File.Size = new System.Drawing.Size(37, 20);
            this.ux_File.Text = "File";
            // 
            // ux_Open
            // 
            this.ux_Open.Name = "ux_Open";
            this.ux_Open.Size = new System.Drawing.Size(112, 22);
            this.ux_Open.Text = "Open...";
            // 
            // ux_OpenFileDialog
            // 
            this.ux_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ux_ListBox
            // 
            this.ux_ListBox.FormattingEnabled = true;
            this.ux_ListBox.Location = new System.Drawing.Point(13, 37);
            this.ux_ListBox.Name = "ux_ListBox";
            this.ux_ListBox.Size = new System.Drawing.Size(357, 290);
            this.ux_ListBox.TabIndex = 1;
            // 
            // ux_FilterOptions
            // 
            this.ux_FilterOptions.Controls.Add(this.ux_DateHistory);
            this.ux_FilterOptions.Controls.Add(this.ux_AboveTemp);
            this.ux_FilterOptions.Controls.Add(this.ux_BelowTemp);
            this.ux_FilterOptions.Controls.Add(this.ux_SelectedRange);
            this.ux_FilterOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_FilterOptions.Location = new System.Drawing.Point(390, 73);
            this.ux_FilterOptions.Name = "ux_FilterOptions";
            this.ux_FilterOptions.Size = new System.Drawing.Size(227, 146);
            this.ux_FilterOptions.TabIndex = 2;
            this.ux_FilterOptions.TabStop = false;
            this.ux_FilterOptions.Text = "Filter Options";
            // 
            // ux_DateHistory
            // 
            this.ux_DateHistory.AutoSize = true;
            this.ux_DateHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_DateHistory.Location = new System.Drawing.Point(6, 111);
            this.ux_DateHistory.Name = "ux_DateHistory";
            this.ux_DateHistory.Size = new System.Drawing.Size(110, 20);
            this.ux_DateHistory.TabIndex = 3;
            this.ux_DateHistory.TabStop = true;
            this.ux_DateHistory.Text = "Date in history";
            this.ux_DateHistory.UseVisualStyleBackColor = true;
            // 
            // ux_AboveTemp
            // 
            this.ux_AboveTemp.AutoSize = true;
            this.ux_AboveTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_AboveTemp.Location = new System.Drawing.Point(6, 81);
            this.ux_AboveTemp.Name = "ux_AboveTemp";
            this.ux_AboveTemp.Size = new System.Drawing.Size(215, 20);
            this.ux_AboveTemp.TabIndex = 2;
            this.ux_AboveTemp.TabStop = true;
            this.ux_AboveTemp.Text = "Dates above given temperature";
            this.ux_AboveTemp.UseVisualStyleBackColor = true;
            // 
            // ux_BelowTemp
            // 
            this.ux_BelowTemp.AutoSize = true;
            this.ux_BelowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_BelowTemp.Location = new System.Drawing.Point(6, 52);
            this.ux_BelowTemp.Name = "ux_BelowTemp";
            this.ux_BelowTemp.Size = new System.Drawing.Size(212, 20);
            this.ux_BelowTemp.TabIndex = 1;
            this.ux_BelowTemp.TabStop = true;
            this.ux_BelowTemp.Text = "Dates below given temperature";
            this.ux_BelowTemp.UseVisualStyleBackColor = true;
            // 
            // ux_SelectedRange
            // 
            this.ux_SelectedRange.AutoSize = true;
            this.ux_SelectedRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SelectedRange.Location = new System.Drawing.Point(6, 23);
            this.ux_SelectedRange.Name = "ux_SelectedRange";
            this.ux_SelectedRange.Size = new System.Drawing.Size(195, 20);
            this.ux_SelectedRange.TabIndex = 0;
            this.ux_SelectedRange.TabStop = true;
            this.ux_SelectedRange.Text = "Dates during selected range";
            this.ux_SelectedRange.UseVisualStyleBackColor = true;
            // 
            // ux_Calendar
            // 
            this.ux_Calendar.Location = new System.Drawing.Point(629, 73);
            this.ux_Calendar.MaxDate = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            this.ux_Calendar.MaxSelectionCount = 31;
            this.ux_Calendar.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.ux_Calendar.Name = "ux_Calendar";
            this.ux_Calendar.TabIndex = 3;
            // 
            // ux_FilterButton
            // 
            this.ux_FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_FilterButton.Location = new System.Drawing.Point(393, 266);
            this.ux_FilterButton.Name = "ux_FilterButton";
            this.ux_FilterButton.Size = new System.Drawing.Size(101, 33);
            this.ux_FilterButton.TabIndex = 4;
            this.ux_FilterButton.Text = "Filter";
            this.ux_FilterButton.UseVisualStyleBackColor = true;
            this.ux_FilterButton.Click += new System.EventHandler(this.ux_FilterButton_Click);
            // 
            // ux_UndoButton
            // 
            this.ux_UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_UndoButton.Location = new System.Drawing.Point(507, 266);
            this.ux_UndoButton.Name = "ux_UndoButton";
            this.ux_UndoButton.Size = new System.Drawing.Size(101, 33);
            this.ux_UndoButton.TabIndex = 5;
            this.ux_UndoButton.Text = "Undo";
            this.ux_UndoButton.UseVisualStyleBackColor = true;
            // 
            // ux_UpDown
            // 
            this.ux_UpDown.Location = new System.Drawing.Point(629, 278);
            this.ux_UpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ux_UpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.ux_UpDown.Name = "ux_UpDown";
            this.ux_UpDown.Size = new System.Drawing.Size(227, 20);
            this.ux_UpDown.TabIndex = 6;
            this.ux_UpDown.Tag = "";
            // 
            // ux_TempLabel
            // 
            this.ux_TempLabel.AutoSize = true;
            this.ux_TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_TempLabel.Location = new System.Drawing.Point(627, 259);
            this.ux_TempLabel.Name = "ux_TempLabel";
            this.ux_TempLabel.Size = new System.Drawing.Size(89, 16);
            this.ux_TempLabel.TabIndex = 7;
            this.ux_TempLabel.Text = "Temperature:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 346);
            this.Controls.Add(this.ux_TempLabel);
            this.Controls.Add(this.ux_UpDown);
            this.Controls.Add(this.ux_UndoButton);
            this.Controls.Add(this.ux_FilterButton);
            this.Controls.Add(this.ux_Calendar);
            this.Controls.Add(this.ux_FilterOptions);
            this.Controls.Add(this.ux_ListBox);
            this.Controls.Add(this.ux_MenuStrip);
            this.MainMenuStrip = this.ux_MenuStrip;
            this.Name = "UserInterface";
            this.Text = "Filter Weather Data";
            this.ux_MenuStrip.ResumeLayout(false);
            this.ux_MenuStrip.PerformLayout();
            this.ux_FilterOptions.ResumeLayout(false);
            this.ux_FilterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ux_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ux_File;
        private System.Windows.Forms.ToolStripMenuItem ux_Open;
        private System.Windows.Forms.OpenFileDialog ux_OpenFileDialog;
        private System.Windows.Forms.ListBox ux_ListBox;
        private System.Windows.Forms.GroupBox ux_FilterOptions;
        private System.Windows.Forms.RadioButton ux_DateHistory;
        private System.Windows.Forms.RadioButton ux_AboveTemp;
        private System.Windows.Forms.RadioButton ux_BelowTemp;
        private System.Windows.Forms.RadioButton ux_SelectedRange;
        private System.Windows.Forms.MonthCalendar ux_Calendar;
        private System.Windows.Forms.Button ux_FilterButton;
        private System.Windows.Forms.Button ux_UndoButton;
        private System.Windows.Forms.NumericUpDown ux_UpDown;
        private System.Windows.Forms.Label ux_TempLabel;
    }
}

