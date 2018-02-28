/**
 * This project recreates a 1-15 shuffle game using C# GUI. The program checks for a valid move,
 * uses a timer to keep track of time, and allows the user to reshuffle. The program also
 * keeps track of the number of moves made by the user. 
 *
 * Author: Jazz Loffredo
 * Version: Project 10
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShuffleGame
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;
        private Stopwatch stopWatch;
        private int moves = 0;

        public Form1()
        {
            InitializeComponent();
            
            //Create 4x4 array of button objects
            buttons = new Button[4, 4];
            
            //Initialize each button to an array row and column
            buttons[0, 0] = button1;
            buttons[0, 1] = button2;
            buttons[0, 2] = button3;
            buttons[0, 3] = button4;
            buttons[1, 0] = button5;
            buttons[1, 1] = button6;
            buttons[1, 2] = button7;
            buttons[1, 3] = button8;
            buttons[2, 0] = button9;
            buttons[2, 1] = button10;
            buttons[2, 2] = button11;
            buttons[2, 3] = button12;
            buttons[3, 0] = button13;
            buttons[3, 1] = button14;
            buttons[3, 2] = button15;
            buttons[3, 3] = button16;

            //Add Shift() method event handler to each button
            for (int r = 0; r < buttons.GetLength(0); r++)
            {
                for (int c = 0; c < buttons.GetLength(1); c++)
                {
                    buttons[r, c].Click += new EventHandler(Shift);
                }
            }
            //Initially display shuffled buttons
            Shuffle(buttons);
            //Add option to manually shuffle buttons using event handler
            shuffle_button.Click += new EventHandler(Shuffle);
            //Add option to set board to one-move win
            winning_button.Click += new EventHandler(SetWinningFormation);
        }

        /**
        * This method is called whenever a button is pressed. It checks the location of the blank
        * space and shifts the buttons accordingly.
        *
        * object sender The first parameter is a sender object that is used to define the button being pressed.
        * EventArgs e The second parameter is an event argument that is used to determine the type of event (Click).
        * object sender
        * EventArgs e
        * The method does not have a return value.
        */
        private void Shift(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            int[] blank_button = new int[2];
            int[] clicked_button = new int[2];

            //Find row and column of both blank button and clicked button. Store in array with [0] = row and [1] = column
            for (int r = 0; r < buttons.GetLength(0); r++)
            {
                for (int c = 0; c < buttons.GetLength(1); c++)
                {
                    if (buttons[r, c].Text.Equals(b.Text))
                    {
                        clicked_button[0] = r;
                        clicked_button[1] = c;
                    }
                    else if(buttons[r, c].Text.Equals("16"))
                    {
                        blank_button[0] = r;
                        blank_button[1] = c;
                    }
                }
            }

            //Check if rows are equal
            if (blank_button[0] == clicked_button[0])
            {
                do
                {
                    if(blank_button[1] < clicked_button[1])
                    {
                        string temp = buttons[blank_button[0], blank_button[1] + 1].Text;
                        buttons[blank_button[0], blank_button[1] + 1].Text = "16";
                        buttons[blank_button[0], blank_button[1] + 1].Visible = false;
                        buttons[blank_button[0], blank_button[1]].Text = temp;
                        buttons[blank_button[0], blank_button[1]].Visible = true;
                        blank_button[1] = blank_button[1] + 1;
                        moves++;
                        moves_label.Text = "Moves: " + moves.ToString();
                    }
                    else
                    {
                        string temp = buttons[blank_button[0], blank_button[1] - 1].Text;
                        buttons[blank_button[0], blank_button[1] - 1].Text = "16";
                        buttons[blank_button[0], blank_button[1] - 1].Visible = false;
                        buttons[blank_button[0], blank_button[1]].Text = temp;
                        buttons[blank_button[0], blank_button[1]].Visible = true;
                        blank_button[1] = blank_button[1] - 1;
                        moves++;
                        moves_label.Text = "Moves: " + moves.ToString();
                    }
                } while (!buttons[clicked_button[0], clicked_button[1]].Text.Equals("16"));

                CheckForWinner();
            }
            
            //Check if columns are equal
            else if (blank_button[1] == clicked_button[1])
            {
                do
                {
                    if (blank_button[0] < clicked_button[0])
                    {
                        string temp = buttons[blank_button[0] + 1, blank_button[1]].Text;
                        buttons[blank_button[0] + 1, blank_button[1]].Text = "16";
                        buttons[blank_button[0] + 1, blank_button[1]].Visible = false;
                        buttons[blank_button[0], blank_button[1]].Text = temp;
                        buttons[blank_button[0], blank_button[1]].Visible = true;
                        blank_button[0] = blank_button[0] + 1;
                        moves++;
                        moves_label.Text = "Moves: " + moves.ToString();
                    }
                    else
                    {
                        string temp = buttons[blank_button[0] - 1, blank_button[1]].Text;
                        buttons[blank_button[0] - 1, blank_button[1]].Text = "16";
                        buttons[blank_button[0] - 1, blank_button[1]].Visible = false;
                        buttons[blank_button[0], blank_button[1]].Text = temp;
                        buttons[blank_button[0], blank_button[1]].Visible = true;
                        blank_button[0] = blank_button[0] - 1;
                        moves++;
                        moves_label.Text = "Moves: " + moves.ToString();
                    }
                } while (!buttons[clicked_button[0], clicked_button[1]].Text.Equals("16"));
            }
            
            else;
                //Do nothing if neither rows or columns match
        }

        /**
        * This method is called at the end of every shift method to determine if the
        * buttons are in the correct order and position.
        *
        * The method does not have a return value.
        */
        private void CheckForWinner()
        {
            int index = 1;
            bool winner = true;
            for (int r = 0; r < buttons.GetLength(0); r++)
            {
                for (int c = 0; c < buttons.GetLength(1); c++)
                {
                    if(!buttons[r, c].Text.Equals(index.ToString()))
                        winner = false;
                    index++;
                }
            }

            //If every box is in the correct position, display "You Win!" and disable all buttons.
            if (winner)
            {
                for (int r = 0; r < buttons.GetLength(0); r++)
                {
                    for (int c = 0; c < buttons.GetLength(1); c++)
                    {
                        buttons[r, c].Enabled = false;
                        winning_label.Visible = true;
                        stopWatch.Stop();
                    }
                }
            }

        }

        /**
        * This method is applied to the "shuffle_button" and calls the Shuffle() method which randomly
        * places the button on the board.
        *
        * object sender The first parameter is a sender object that is used to define the button being pressed.
        * EventArgs e The second parameter is an event argument that is used to determine the type of event (Click).
        * object sender
        * EventArgs e
        * The method does not have a return value.
        */
        private void Shuffle(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Shuffle(buttons);
            moves = 0;
            moves_label.Text = "Moves: " + moves.ToString();
        }

        /**
        * This method randomly places the button on the board in no specific order.
        *
        * Button[,] buttons The first parameter is a 2D array of Button objects used to initialize text.
        * Button[,] buttons
        * The method does not have a return value.
        */
        private void Shuffle(Button[,] buttons)
        {
            //Creating a timer that will count elapsed time
            stopWatch = new Stopwatch();
            stopWatch.Start();

            winning_label.Visible = false;

            Random rand = new Random();
            HashSet<int> used_values = new HashSet<int>();
            int index = 0;

            while (used_values.Count < 16)
            {
                used_values.Add(rand.Next(16) + 1);
            }


            for (int r = 0; r < buttons.GetLength(0); r++)
            {
                for (int c = 0; c < buttons.GetLength(1); c++, index++)
                {
                    if (used_values.ElementAt(index) == 16)
                    {
                        buttons[r, c].Text = used_values.ElementAt(index).ToString();
                        buttons[r, c].Visible = false;
                        buttons[r, c].Enabled = true;

                    }
                    else
                    {
                        buttons[r, c].Text = used_values.ElementAt(index).ToString();
                        buttons[r, c].Visible = true;
                        buttons[r, c].Enabled = true;
                    }
                }
            }
        }

        /**
        * This method is purely for testing purposes and is applied to the "winning_button." The method rearranges
        * the board so that the user only has to make one click to win. The timer is stopped and all buttons
        * are disabled. "You win!" is displayed.
        *
        * object sender The first parameter is a sender object that is used to define the button being pressed.
        * EventArgs e The second parameter is an event argument that is used to determine the type of event (Click).
        * object sender
        * EventArgs e
        * The method does not have a return value.
        */
        private void SetWinningFormation(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            int index = 1;
            for (int r = 0; r < buttons.GetLength(0); r++)
            {
                for (int c = 0; c < buttons.GetLength(1); c++)
                {
                    buttons[r, c].Text = index.ToString();
                    buttons[r, c].Visible = true;
                    index++;
                }
            }

            buttons[3, 2].Text = "16";
            buttons[3, 2].Visible = false;
            buttons[3, 3].Text = "15";


        }

        /**
        * This method is used to change the text on the "timer_label" after every second.
        *
        * object sender The first parameter is a sender object that is used to define the button being pressed.
        * EventArgs e The second parameter is an event argument that is used to determine the type of event (Click).
        * object sender
        * EventArgs e
        * The method does not have a return value.
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed_time.Text = "Time: " +
                stopWatch.Elapsed.Hours.ToString("00") + ":" +
                stopWatch.Elapsed.Minutes.ToString("00") + ":" +
                stopWatch.Elapsed.Seconds.ToString("00");
        }
    }
}
