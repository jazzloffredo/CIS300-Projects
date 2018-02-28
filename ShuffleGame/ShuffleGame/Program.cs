/**
 * This project recreates a 1-15 shuffle game using C# GUI. The program checks for a valid move,
 * uses a timer to keep track of time, and allows the user to reshuffle. The program also
 * keeps track of the number of moves made by the user. 
 *
 * Author: Jazz Loffredo
 * Version: Project 10
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShuffleGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
