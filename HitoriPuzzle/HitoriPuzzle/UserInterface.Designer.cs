namespace HitoriPuzzle
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
            this.ux_FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_CheckButton = new System.Windows.Forms.Button();
            this.ux_DisplayButton = new System.Windows.Forms.Button();
            this.ux_Labels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ux_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ux_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_MenuStrip
            // 
            this.ux_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ux_FileMenu});
            this.ux_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ux_MenuStrip.Name = "ux_MenuStrip";
            this.ux_MenuStrip.Size = new System.Drawing.Size(442, 24);
            this.ux_MenuStrip.TabIndex = 0;
            this.ux_MenuStrip.Text = "menuStrip1";
            // 
            // ux_FileMenu
            // 
            this.ux_FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ux_OpenMenu});
            this.ux_FileMenu.Name = "ux_FileMenu";
            this.ux_FileMenu.Size = new System.Drawing.Size(37, 20);
            this.ux_FileMenu.Text = "File";
            // 
            // ux_OpenMenu
            // 
            this.ux_OpenMenu.Name = "ux_OpenMenu";
            this.ux_OpenMenu.Size = new System.Drawing.Size(112, 22);
            this.ux_OpenMenu.Text = "Open...";
            this.ux_OpenMenu.Click += new System.EventHandler(this.ux_OpenMenu_Click);
            // 
            // ux_CheckButton
            // 
            this.ux_CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_CheckButton.Location = new System.Drawing.Point(91, 366);
            this.ux_CheckButton.Name = "ux_CheckButton";
            this.ux_CheckButton.Size = new System.Drawing.Size(113, 38);
            this.ux_CheckButton.TabIndex = 1;
            this.ux_CheckButton.Text = "Check Solution";
            this.ux_CheckButton.UseVisualStyleBackColor = true;
            this.ux_CheckButton.Click += new System.EventHandler(this.ux_CheckButton_Click);
            // 
            // ux_DisplayButton
            // 
            this.ux_DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_DisplayButton.Location = new System.Drawing.Point(235, 366);
            this.ux_DisplayButton.Name = "ux_DisplayButton";
            this.ux_DisplayButton.Size = new System.Drawing.Size(133, 38);
            this.ux_DisplayButton.TabIndex = 2;
            this.ux_DisplayButton.Text = "Display Solution";
            this.ux_DisplayButton.UseVisualStyleBackColor = true;
            this.ux_DisplayButton.Click += new System.EventHandler(this.ux_DisplayButton_Click);
            // 
            // ux_Labels
            // 
            this.ux_Labels.AutoSize = true;
            this.ux_Labels.Location = new System.Drawing.Point(71, 287);
            this.ux_Labels.Name = "ux_Labels";
            this.ux_Labels.Size = new System.Drawing.Size(133, 13);
            this.ux_Labels.TabIndex = 3;
            this.ux_Labels.Text = "Black = not part of solution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "White = part of solution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Same digit can\'t appear more than once in a row or column.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "White cells must be connected.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Black cells can\'t touch vertically or horizontally.";
            // 
            // ux_OpenFileDialog
            // 
            this.ux_OpenFileDialog.FileName = "puzzle.txt";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_Labels);
            this.Controls.Add(this.ux_DisplayButton);
            this.Controls.Add(this.ux_CheckButton);
            this.Controls.Add(this.ux_MenuStrip);
            this.MainMenuStrip = this.ux_MenuStrip;
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.ux_MenuStrip.ResumeLayout(false);
            this.ux_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ux_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ux_FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ux_OpenMenu;
        private System.Windows.Forms.Button ux_CheckButton;
        private System.Windows.Forms.Button ux_DisplayButton;
        private System.Windows.Forms.Label ux_Labels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ux_OpenFileDialog;
    }
}

