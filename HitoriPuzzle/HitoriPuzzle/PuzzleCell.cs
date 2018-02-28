using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Jazz Loffredo
/// CIS 300 Scholars
/// Project 2 - Hitori Puzzle
/// This project generates a hitori puzzle given a proper input file and is able to
/// check a given solution and display a solution for the user.
/// </summary>
namespace HitoriPuzzle
{
    class PuzzleCell : Label
    {
        private int _number, _row, _col;
        private bool _white, _visited;
        
        /// <summary>
        /// Default constructor - does nothing.
        /// </summary>
        public PuzzleCell()
        {
            //default constructor
        }
        
        /// <summary>
        /// Constructor to create a single PuzzleCell.
        /// </summary>
        /// <param name="num">The num to be displayed on the label.</param>
        /// <param name="r">The row position of the cell.</param>
        /// <param name="c">The column position of the cell.</param>
        public PuzzleCell(int num, int r, int c)
        {
            _number = num;
            _row = r;
            _col = c;
            _white = true;
            _visited = false;
        }

        /// <summary>
        /// Get and set methods for int value _number
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        /// <summary>
        /// Get and set methods for int value _row
        /// </summary>
        public int Row
        {
            get
            {
                return _row;
            }
            set
            {
                _row = value;
            }
        }

        /// <summary>
        /// Get and set methods for int value _col
        /// </summary>
        public int Column
        {
            get
            {
                return _col;
            }
            set
            {
                _col = value;
            }
        }

        /// <summary>
        /// Get and set methods for bool value _white
        /// </summary>
        public bool White
        {
            get
            {
                return _white;
            }
            set
            {
                _white = value;
            }
        }

        /// <summary>
        /// Get and set methods for bool value _visited
        /// </summary>
        public bool Visited
        {
            get
            {
                return _visited;
            }
            set
            {
                _visited = value;
            }
        }
    }
}
