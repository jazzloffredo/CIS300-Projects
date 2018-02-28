namespace HeatTransfer
{
    partial class HeatTransfer
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
            this.ux_StartButton = new System.Windows.Forms.Button();
            this.ux_StopButton = new System.Windows.Forms.Button();
            this.ux_ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_StartButton
            // 
            this.ux_StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_StartButton.Location = new System.Drawing.Point(308, 354);
            this.ux_StartButton.Name = "ux_StartButton";
            this.ux_StartButton.Size = new System.Drawing.Size(100, 32);
            this.ux_StartButton.TabIndex = 0;
            this.ux_StartButton.Text = "Start";
            this.ux_StartButton.UseVisualStyleBackColor = true;
            this.ux_StartButton.Click += new System.EventHandler(this.ux_StartButton_Click);
            // 
            // ux_StopButton
            // 
            this.ux_StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_StopButton.Location = new System.Drawing.Point(424, 354);
            this.ux_StopButton.Name = "ux_StopButton";
            this.ux_StopButton.Size = new System.Drawing.Size(100, 32);
            this.ux_StopButton.TabIndex = 1;
            this.ux_StopButton.Text = "Stop";
            this.ux_StopButton.UseVisualStyleBackColor = true;
            this.ux_StopButton.Click += new System.EventHandler(this.ux_StopButton_Click);
            // 
            // ux_ResetButton
            // 
            this.ux_ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ResetButton.Location = new System.Drawing.Point(539, 354);
            this.ux_ResetButton.Name = "ux_ResetButton";
            this.ux_ResetButton.Size = new System.Drawing.Size(100, 32);
            this.ux_ResetButton.TabIndex = 2;
            this.ux_ResetButton.Text = "Reset";
            this.ux_ResetButton.UseVisualStyleBackColor = true;
            this.ux_ResetButton.Click += new System.EventHandler(this.ux_ResetButton_Click);
            // 
            // HeatTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 413);
            this.Controls.Add(this.ux_ResetButton);
            this.Controls.Add(this.ux_StopButton);
            this.Controls.Add(this.ux_StartButton);
            this.Name = "HeatTransfer";
            this.Text = "Heat Transfer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ux_StartButton;
        private System.Windows.Forms.Button ux_StopButton;
        private System.Windows.Forms.Button ux_ResetButton;
    }
}

