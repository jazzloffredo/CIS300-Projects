using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

/// <summary>
/// Jazz Loffredo
/// CIS 300 Scholars
/// Project #1 - Heat Transfer
/// This project seeks to simulate heat transfer through cellular automata represented as labels in a grid.
/// "Heat" cells are represented as red and will be recalculated as the average RGB value of their neighbors
/// every 300ms using a timer. The user can start, stop (pause), and reset the grid layout during simulations.
/// </summary>

namespace HeatTransfer
{
    public partial class HeatTransfer : Form
    {
        private Label[,] _VisibleLabelArray;
        private Label[,] _UpdateLabelArray;
        System.Timers.Timer _Timer;

        /// <summary>        
        /// Form constructor that calls the GenerateLabelArray() method to create a 20x65 array of labels
        /// with white background. Also generates start, stop, and reset buttons.
        /// </summary>
        public HeatTransfer()
        {
            InitializeComponent();
            GenerateLabelArray();
        }

        /// <summary>
        /// Method call for click event of "Start" button. If no timer exists, creates a new timer and adds an elapsed
        /// event handler (HeatUpdate() method) to occur every 300ms. The timer is then started. If a timer already exists,
        /// the .Start() method is called for the current timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_StartButton_Click(object sender, EventArgs e)
        {
            if(_Timer == null)
            {
                _Timer = new System.Timers.Timer(300);
                _Timer.Elapsed += new ElapsedEventHandler(HeatUpdate);
                _Timer.Enabled = true;
                _Timer.SynchronizingObject = this;
            }
            else
            {
                _Timer.Start();
            }

        }

        /// <summary>
        /// Method call for click event of "Stop" button. Attempts to call the .Stop() method - if no timer object exists,
        /// a null reference exception is thrown and alerts the user through a message box pop up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_StopButton_Click(object sender, EventArgs e)
        {
            try
            {
               _Timer.Stop();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Timer has not been started. Please press 'Start' to begin the simulation.");
            }
        }

        /// <summary>
        /// Method call for click event of "Reset" button. If a timer object exists, call the .Stop() method and set
        /// the current timer object to null. Proceeds to loop through both arrays and set them to their default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_ResetButton_Click(object sender, EventArgs e)
        {
            if(_Timer != null)
            {
                _Timer.Stop();
                _Timer = null;
            }
            for (int r = 0; r < _VisibleLabelArray.GetLength(0); r++)
            {
                for (int c = 0; c < _VisibleLabelArray.GetLength(1); c++)
                {
                    _VisibleLabelArray[r, c].BackColor = Color.White;
                    _UpdateLabelArray[r, c].BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Method call for click event of any label on the grid. Casts the sender as a label and checks the
        /// background color. If it is red, set it to white, otherwise set the background color to red. Proceeds
        /// to loop through the update array so that its contents match the visible array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (label.BackColor == Color.Red)
                label.BackColor = Color.White;
            else
                label.BackColor = Color.Red;

            for (int r = 1; r < _VisibleLabelArray.GetLength(0) - 1; r++)
            {
                for (int c = 1; c < _VisibleLabelArray.GetLength(1) - 1; c++)
                {
                    if(_VisibleLabelArray[r, c].BackColor == Color.Red)
                    {
                        _UpdateLabelArray[r, c].BackColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Loops through the visible array and calculates the average green and blue components of its neighbors (R will always be 255) then sets that
        /// value for the index of the update array. Following all the calculations, loops through the update array and changes the values to match
        /// the visible array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="el"></param>
        private void HeatUpdate(object sender, ElapsedEventArgs el)
        {
            for (int r = 1; r < _VisibleLabelArray.GetLength(0) - 1; r++)
            {
                for (int c = 1; c < _VisibleLabelArray.GetLength(1) - 1; c++)
                {
                    if(_VisibleLabelArray[r, c].BackColor != Color.Red)
                    {
                        int _greenValue = (_VisibleLabelArray[r - 1, c - 1].BackColor.G + _VisibleLabelArray[r - 1, c].BackColor.G + _VisibleLabelArray[r - 1, c + 1].BackColor.G +
                                           _VisibleLabelArray[r, c - 1].BackColor.G + _VisibleLabelArray[r, c + 1].BackColor.G +
                                           _VisibleLabelArray[r + 1, c - 1].BackColor.G + _VisibleLabelArray[r + 1, c].BackColor.G + _VisibleLabelArray[r + 1, c + 1].BackColor.G) / 8;
                        int _blueValue = (_VisibleLabelArray[r - 1, c - 1].BackColor.B + _VisibleLabelArray[r - 1, c].BackColor.B + _VisibleLabelArray[r - 1, c + 1].BackColor.B +
                                           _VisibleLabelArray[r, c - 1].BackColor.B + _VisibleLabelArray[r, c + 1].BackColor.B +
                                           _VisibleLabelArray[r + 1, c - 1].BackColor.B + _VisibleLabelArray[r + 1, c].BackColor.B + _VisibleLabelArray[r + 1, c + 1].BackColor.B) / 8;

                        _UpdateLabelArray[r, c].BackColor = Color.FromArgb(255, _greenValue, _blueValue);
                    }
                }
            }

            for (int r = 1; r < _UpdateLabelArray.GetLength(0) - 1; r++)
            {
                for (int c = 1; c < _UpdateLabelArray.GetLength(1) - 1; c++)
                {
                    _VisibleLabelArray[r, c].BackColor = _UpdateLabelArray[r, c].BackColor;
                }
            }
        }

        /// <summary>
        /// Initial method called in the constructor to generate a padded array of labels size 20x65. Also
        /// updates all label values to default state.
        /// </summary>
        private void GenerateLabelArray()
        {
            _VisibleLabelArray = new Label[22, 67];
            _UpdateLabelArray = new Label[22, 67];
            int xLocation = 10;
            int yLocation = 40;
            for (int r = 0; r < _VisibleLabelArray.GetLength(0); r++)
            {
                for (int c = 0; c < _VisibleLabelArray.GetLength(1); c++)
                {
                    if (r == 0 || c == 0 || r == _VisibleLabelArray.GetLength(0) - 1 || c == _VisibleLabelArray.GetLength(1) - 1)
                    {
                        Label ux_TempLabel = new Label();
                        Label ux_TempUpdLabel = new Label();
                        _VisibleLabelArray[r, c] = ux_TempLabel;
                        _UpdateLabelArray[r, c] = ux_TempUpdLabel;

                        ux_TempLabel.BackColor = Color.White;
                        ux_TempUpdLabel.BackColor = Color.White;
                        this.Controls.Add(ux_TempLabel);
                        this.Controls.Add(ux_TempUpdLabel);
                        ux_TempLabel.Visible = false;
                        ux_TempUpdLabel.Visible = false;
                        
                    }
                    else{
                        Label ux_TempLabel = new Label();
                        Label ux_TempUpdLabel = new Label();
                        _VisibleLabelArray[r, c] = ux_TempLabel;
                        _UpdateLabelArray[r, c] = ux_TempUpdLabel;

                        ux_TempLabel.Location = new Point(xLocation, yLocation);
                        ux_TempLabel.Size = new Size(12, 12);
                        ux_TempLabel.BackColor = Color.White;
                        ux_TempUpdLabel.BackColor = Color.White;
                        this.Controls.Add(ux_TempLabel);
                        this.Controls.Add(ux_TempUpdLabel);
                        ux_TempLabel.Click += new EventHandler(LabelClick);
                        ux_TempUpdLabel.Click += new EventHandler(LabelClick);
                        ux_TempUpdLabel.Visible = false;
                        xLocation += 14;
                    }
                }
                xLocation = 10;
                yLocation += 14;
            }
        }
    }
}
