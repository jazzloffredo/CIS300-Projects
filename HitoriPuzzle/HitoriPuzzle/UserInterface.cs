using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Jazz Loffredo
/// CIS 300 Scholars
/// Project 2 - Hitori Puzzle
/// This project generates a hitori puzzle given a proper input file and is able to
/// check a given solution and display a solution for the user.
/// </summary>
namespace HitoriPuzzle
{
    public partial class UserInterface : Form
    {
        private PuzzleCell[,] _PuzzleGrid;

        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a text file with the contents of a hitori puzzle and generates the corresponding puzzle.
        /// If the file is not formatted correctly, a message box will display and the current puzzle
        /// will not be updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_OpenMenu_Click(object sender, EventArgs e)
        {
            try
            {
                ReadPuzzleFile();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect file format.");
            }


        }

        /// <summary>
        /// Method to be called upon clicking a label. If the label is white, sets background to black and forecolor to white.
        /// If the label is black, sets background to white and forecolor to black. Updates PuzzleCell properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_PuzzleCell_Click(object sender, EventArgs e)
        {
            PuzzleCell clicked = sender as PuzzleCell;
            if (clicked.BackColor == Color.White)
            {
                clicked.BackColor = Color.Black;
                clicked.ForeColor = Color.White;
                clicked.White = false;
            }
            else
            {
                clicked.BackColor = Color.White;
                clicked.ForeColor = Color.Black;
                clicked.White = true;
            }
        }

        /// <summary>
        /// Checks if the current solution is valid and generates a message box with an appropriate message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_CheckButton_Click(object sender, EventArgs e)
        {
            ResetVisited();

            if (_PuzzleGrid == null)
            {
                MessageBox.Show("Please load a puzzle first.");
            }
            else
            {
                if (CheckNums() || CheckBlackCells()) MessageBox.Show("Incorrect solution. Check the rules and try again!");

                else if (!Connected(FindWhiteCell())) MessageBox.Show("Incorrect solution. Check the rules and try again!");

                else MessageBox.Show("You solved it!");
            }
        }

        /// <summary>
        /// Recursively calls SolvePuzzle() to find a solution (if possible) and display it to the user.
        /// Handles case if user has not loaded a puzzle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_DisplayButton_Click(object sender, EventArgs e)
        {

            if (_PuzzleGrid == null)
            {
                MessageBox.Show("Please load a puzzle first.");
            }
            else
            {
                List<PuzzleCell> allMoves = FindDuplicates();
                ResetWhiteVal();
                if (SolvePuzzle(allMoves, 0) == true)
                {
                    for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
                    {
                        for (int c = 0; c < _PuzzleGrid.GetLength(1); c++)
                        {
                            if (_PuzzleGrid[r, c].White == false)
                            {
                                _PuzzleGrid[r, c].BackColor = Color.Black;
                                _PuzzleGrid[r, c].ForeColor = Color.White;
                            }
                            else
                            {
                                _PuzzleGrid[r, c].BackColor = Color.White;
                                _PuzzleGrid[r, c].ForeColor = Color.Black;
                            }
                        }
                    }
                }
                else MessageBox.Show("No solution found.");
            }
        }

        /// <summary>
        /// Uses recursion to 'color' each cell that is duplicated in a row/column and check each possible
        /// coloring until a solution is found. Returns true if solution is valid and false if it is not.
        /// </summary>
        /// <param name="allMoves"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        private bool SolvePuzzle(List<PuzzleCell> allMoves, int pos)
        {
            if (CheckSolution())
            {
                ResetVisited();
                if (Connected(FindWhiteCell())) return true;
            }
            else if (pos > allMoves.Count - 1) return false;
            else
            {
                allMoves[pos].White = false;
                bool val = SolvePuzzle(allMoves, pos + 1);
                if (val) return true;
                allMoves[pos].White = true;
                val = SolvePuzzle(allMoves, pos + 1);
                if (val) return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if there are not any repeated values in columns/rows and no adjacent black cells.
        /// Flase if solution is not valid.
        /// </summary>
        /// <returns></returns>
        private bool CheckSolution()
        {
            if (!CheckNums() && !CheckBlackCells()) return true;
            return false;
        }

        /// <summary>
        /// Finds duplicate cells in the same row/column and adds them to a list. List is then passed
        /// to the SolvePuzzle() method to iterate through.
        /// </summary>
        /// <returns></returns>
        private List<PuzzleCell> FindDuplicates()
        {
            List<PuzzleCell> allDupes = new List<PuzzleCell>();
            ResetVisited();
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    for (int search = c + 1; search < _PuzzleGrid.GetLength(1); search++)
                    {
                        if (_PuzzleGrid[r, c].Visited == false && _PuzzleGrid[r, c].Number == _PuzzleGrid[r, search].Number)
                        {
                            if (!allDupes.Contains(_PuzzleGrid[r, c]))
                                allDupes.Add(_PuzzleGrid[r, c]);
                            if (!allDupes.Contains(_PuzzleGrid[r, search]))
                                allDupes.Add(_PuzzleGrid[r, search]);
                        }
                    }

                }
            }

            for (int c = 0; c < _PuzzleGrid.GetLength(1); c++)
            {
                for (int r = 0; r < _PuzzleGrid.GetLength(0) - 1; r++)
                {
                    for (int search = r + 1; search < _PuzzleGrid.GetLength(0); search++)
                    {
                        if (_PuzzleGrid[r, c].Visited == false && _PuzzleGrid[r, c].Number == _PuzzleGrid[search, c].Number)
                        {
                            if (!allDupes.Contains(_PuzzleGrid[r, c]))
                                allDupes.Add(_PuzzleGrid[r, c]);
                            if (!allDupes.Contains(_PuzzleGrid[search, c]))
                                allDupes.Add(_PuzzleGrid[search, c]);
                        }
                    }

                }
            }
            return allDupes;
        }

        /// <summary>
        /// Resets all PuzzleCell values for _white to true.
        /// </summary>
        private void ResetWhiteVal()
        {
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    _PuzzleGrid[r, c].White = true;
                }
            }
        }

        /// <summary>
        /// Uses recursion to find a path from each white cell to another. If no path can be found, returns false.
        /// </summary>
        /// <param name="cur"></param>
        /// <returns>True if all white cells are connected vertically/horizontally and false otherwise.</returns>
        private bool Connected(PuzzleCell cur)
        {
            cur.Visited = true;
            if (_PuzzleGrid[cur.Row, cur.Column].Row != 0 && _PuzzleGrid[cur.Row - 1, cur.Column].White == true && _PuzzleGrid[cur.Row - 1, cur.Column].Visited == false)
            {
                Connected(_PuzzleGrid[cur.Row - 1, cur.Column]);
            }
            if (_PuzzleGrid[cur.Row, cur.Column].Column != _PuzzleGrid.GetLength(1) - 1 && _PuzzleGrid[cur.Row, cur.Column + 1].White == true && _PuzzleGrid[cur.Row, cur.Column + 1].Visited == false)
            {
                Connected(_PuzzleGrid[cur.Row, cur.Column + 1]);
            }
            if (_PuzzleGrid[cur.Row, cur.Column].Row != _PuzzleGrid.GetLength(0) - 1 && _PuzzleGrid[cur.Row + 1, cur.Column].White == true && _PuzzleGrid[cur.Row + 1, cur.Column].Visited == false)
            {
                Connected(_PuzzleGrid[cur.Row + 1, cur.Column]);
            }
            if (_PuzzleGrid[cur.Row, cur.Column].Column != 0 && _PuzzleGrid[cur.Row, cur.Column - 1].White == true && _PuzzleGrid[cur.Row, cur.Column - 1].Visited == false)
            {
                Connected(_PuzzleGrid[cur.Row, cur.Column - 1]);
            }
            if (CheckVisited()) return true;
            return false;
        }

        /// <summary>
        /// Calls CheckDuplicateRows() and CheckDuplicateCol() for checking any duplicate numbers of white cells only.
        /// </summary>
        /// <returns>Returns true if there is a duplicate number in either a column or row and false if there are no duplicates.</returns>
        private bool CheckNums()
        {
            if (CheckDuplicateCol() || CheckDuplicateRows()) return true;

            return false;
        }

        /// <summary>
        /// Checks for duplicate white numbered cells in ROWS only.
        /// </summary>
        /// <returns>Returns true if a duplicate white cell is found in any ROW. False otherwise.</returns>
        private bool CheckDuplicateRows()
        {
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    if (_PuzzleGrid[r, c].White == true)
                    {
                        for (int search = c + 1; search < _PuzzleGrid.GetLength(1); search++)
                        {
                            if (_PuzzleGrid[r, search].White == true && _PuzzleGrid[r, c].Number == _PuzzleGrid[r, search].Number) return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Checks for duplicate white numbered cells in COLUMNS only.
        /// </summary>
        /// <returns>Returns true if a duplicate white cell is found in any COLUMN. False otherwise.</returns>
        private bool CheckDuplicateCol()
        {
            for (int c = 0; c < _PuzzleGrid.GetLength(1); c++)
            {
                for (int r = 0; r < _PuzzleGrid.GetLength(0) - 1; r++)
                {
                    if (_PuzzleGrid[r, c].White == true)
                    {
                        for (int search = r + 1; search < _PuzzleGrid.GetLength(1); search++)
                        {
                            if (_PuzzleGrid[search, c].White == true && _PuzzleGrid[r, c].Number == _PuzzleGrid[search, c].Number) return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Checks for any two black cells that are adjacent. First runs through horizontally, then vertically.
        /// </summary>
        /// <returns>Returns true if any two black cells are adjacent. False otherwise.</returns>
        private bool CheckBlackCells()
        {
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    if (_PuzzleGrid[r, c].White == false && _PuzzleGrid[r, c + 1].White == false) return true;
                }
            }

            for (int c = 0; c < _PuzzleGrid.GetLength(1); c++)
            {
                for (int r = 0; r < _PuzzleGrid.GetLength(0) - 1; r++)
                {
                    if (_PuzzleGrid[r, c].White == false && _PuzzleGrid[r + 1, c].White == false) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Resets the _visited value to false for all PuzzleCells.
        /// </summary>
        private void ResetVisited()
        {
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    _PuzzleGrid[r, c].Visited = false;
                }
            }
        }

        /// <summary>
        /// Used in the Connected() method to determine if all white cells of a current puzzle have been visited
        /// signifying that there exists a path from each white cell to the next.
        /// </summary>
        /// <returns></returns>
        private bool CheckVisited()
        {
            bool allVisited = true;
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    if (_PuzzleGrid[r, c].White == true && _PuzzleGrid[r, c].Visited == false)
                    {
                        allVisited = false;
                    }
                }
            }
            return allVisited;
        }

        /// <summary>
        /// Finds the nearest white cell in the _PuzzleGrid array.
        /// </summary>
        /// <returns>First PuzzleCell that has value White = true</returns>
        private PuzzleCell FindWhiteCell()
        {
            for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
            {
                for (int c = 0; c < _PuzzleGrid.GetLength(1) - 1; c++)
                {
                    if (_PuzzleGrid[r, c].White == true) return _PuzzleGrid[r, c];
                }
            }

            return null;
        }

        /// <summary>
        /// Reads in a puzzle file and error checks for a valid input file.
        /// </summary>
        private void ReadPuzzleFile()
        {
            if (ux_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_PuzzleGrid == null)
                {
                    int[,] tempPuzzleGrid = new int[5, 5];
                    using (StreamReader inFile = new StreamReader(ux_OpenFileDialog.FileName))
                    {
                        int rowIndex = 0;
                        while (!inFile.EndOfStream)
                        {
                            string[] nums = inFile.ReadLine().Split(' ');

                            if (nums.Length != 5) throw new Exception();

                            for (int i = 0; i < nums.Length; i++)
                            {
                                if (Convert.ToInt32(nums[i]) < 1 || Convert.ToInt32(nums[i]) > 5) throw new Exception();
                            }

                            for (int i = 0; i < nums.Length; i++)
                            {
                                tempPuzzleGrid[rowIndex, i] = Convert.ToInt32(nums[i]);
                            }
                            rowIndex++;
                        }
                    }

                    int xLocation = 130;
                    int yLocation = 80;

                    _PuzzleGrid = new PuzzleCell[5, 5];

                    for (int r = 0; r < tempPuzzleGrid.GetLength(0); r++)
                    {
                        for (int c = 0; c < tempPuzzleGrid.GetLength(1); c++)
                        {
                            PuzzleCell tempPC = new PuzzleCell(tempPuzzleGrid[r, c], r, c);
                            _PuzzleGrid[r, c] = tempPC;
                            tempPC.Text = tempPC.Number.ToString();
                            tempPC.Location = new Point(xLocation, yLocation);
                            tempPC.Size = new Size(30, 30);
                            tempPC.BackColor = Color.White;
                            Controls.Add(tempPC);
                            tempPC.Click += new EventHandler(ux_PuzzleCell_Click);
                            xLocation += 35;
                        }
                        xLocation = 130;
                        yLocation += 35;
                    }
                }
                else
                {
                    for (int r = 0; r < _PuzzleGrid.GetLength(0); r++)
                    {
                        for (int c = 0; c < _PuzzleGrid.GetLength(1); c++)
                        {
                            Controls.Remove(_PuzzleGrid[r, c]);
                        }
                    }
                    int[,] tempPuzzleGrid = new int[5, 5];
                    using (StreamReader inFile = new StreamReader(ux_OpenFileDialog.FileName))
                    {
                        int rowIndex = 0;
                        while (!inFile.EndOfStream)
                        {
                            string[] nums = inFile.ReadLine().Split(' ');

                            if (nums.Length != 5) throw new Exception();

                            for (int i = 0; i < nums.Length; i++)
                            {
                                if (Convert.ToInt32(nums[i]) < 1 || Convert.ToInt32(nums[i]) > 5) throw new Exception();
                            }

                            for (int i = 0; i < nums.Length; i++)
                            {
                                tempPuzzleGrid[rowIndex, i] = Convert.ToInt32(nums[i]);
                            }
                            rowIndex++;
                        }
                    }

                    int xLocation = 130;
                    int yLocation = 80;

                    _PuzzleGrid = new PuzzleCell[5, 5];

                    for (int r = 0; r < tempPuzzleGrid.GetLength(0); r++)
                    {
                        for (int c = 0; c < tempPuzzleGrid.GetLength(1); c++)
                        {
                            PuzzleCell tempPC = new PuzzleCell(tempPuzzleGrid[r, c], r, c);
                            _PuzzleGrid[r, c] = tempPC;
                            tempPC.Text = tempPC.Number.ToString();
                            tempPC.Location = new Point(xLocation, yLocation);
                            tempPC.Size = new Size(30, 30);
                            tempPC.BackColor = Color.White;
                            Controls.Add(tempPC);
                            tempPC.Click += new EventHandler(ux_PuzzleCell_Click);
                            xLocation += 35;
                        }
                        xLocation = 130;
                        yLocation += 35;
                    }
                }
            }
        }

    }
}
