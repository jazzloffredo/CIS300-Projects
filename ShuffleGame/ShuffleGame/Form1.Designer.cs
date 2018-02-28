/**
 * This project recreates a 1-15 shuffle game using C# GUI. The program checks for a valid move,
 * uses a timer to keep track of time, and allows the user to reshuffle. The program also
 * keeps track of the number of moves made by the user. 
 *
 * Author: Jazz Loffredo
 * Version: Project 10
 */


namespace ShuffleGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.elapsed_time = new System.Windows.Forms.Label();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.moves_label = new System.Windows.Forms.Label();
            this.winning_label = new System.Windows.Forms.Label();
            this.winning_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(91, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(170, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(249, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 69);
            this.button4.TabIndex = 3;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 69);
            this.button5.TabIndex = 4;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(91, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 69);
            this.button6.TabIndex = 5;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(170, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 69);
            this.button7.TabIndex = 6;
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(249, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 69);
            this.button8.TabIndex = 7;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(12, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 69);
            this.button9.TabIndex = 8;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(91, 164);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 69);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(170, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 69);
            this.button11.TabIndex = 10;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(249, 164);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 69);
            this.button12.TabIndex = 11;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(12, 241);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 69);
            this.button13.TabIndex = 12;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(91, 241);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 69);
            this.button14.TabIndex = 13;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(170, 241);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 69);
            this.button15.TabIndex = 14;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(249, 241);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 69);
            this.button16.TabIndex = 15;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // elapsed_time
            // 
            this.elapsed_time.AutoSize = true;
            this.elapsed_time.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsed_time.Location = new System.Drawing.Point(7, 356);
            this.elapsed_time.Name = "elapsed_time";
            this.elapsed_time.Size = new System.Drawing.Size(153, 30);
            this.elapsed_time.TabIndex = 16;
            this.elapsed_time.Text = "Time: 00:00:00";
            // 
            // shuffle_button
            // 
            this.shuffle_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffle_button.Location = new System.Drawing.Point(225, 323);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.Size = new System.Drawing.Size(97, 53);
            this.shuffle_button.TabIndex = 17;
            this.shuffle_button.Text = "SHUFFLE";
            this.shuffle_button.UseVisualStyleBackColor = true;
            // 
            // moves_label
            // 
            this.moves_label.AutoSize = true;
            this.moves_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moves_label.Location = new System.Drawing.Point(7, 326);
            this.moves_label.Name = "moves_label";
            this.moves_label.Size = new System.Drawing.Size(99, 30);
            this.moves_label.TabIndex = 18;
            this.moves_label.Text = "Moves: 0";
            // 
            // winning_label
            // 
            this.winning_label.AutoSize = true;
            this.winning_label.BackColor = System.Drawing.SystemColors.Control;
            this.winning_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winning_label.Location = new System.Drawing.Point(122, 146);
            this.winning_label.Name = "winning_label";
            this.winning_label.Size = new System.Drawing.Size(93, 30);
            this.winning_label.TabIndex = 19;
            this.winning_label.Text = "You win!";
            this.winning_label.Visible = false;
            // 
            // winning_button
            // 
            this.winning_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winning_button.Location = new System.Drawing.Point(225, 381);
            this.winning_button.Name = "winning_button";
            this.winning_button.Size = new System.Drawing.Size(98, 34);
            this.winning_button.TabIndex = 20;
            this.winning_button.Text = "Test Winner";
            this.winning_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 427);
            this.Controls.Add(this.winning_button);
            this.Controls.Add(this.winning_label);
            this.Controls.Add(this.moves_label);
            this.Controls.Add(this.shuffle_button);
            this.Controls.Add(this.elapsed_time);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label elapsed_time;
        private System.Windows.Forms.Button shuffle_button;
        private System.Windows.Forms.Label moves_label;
        private System.Windows.Forms.Label winning_label;
        private System.Windows.Forms.Button winning_button;
    }
}

