/*
 * Backtracking | Set 3 (N Queen Problem)
 * The N Queen is the problem of placing N chess queens on an N×N chessboard so that no two queens attack each other. 
 * For example, following is a solution for 4 Queen problem.
 * following is the output matrix for above 4 queen solution
 *  { 0,  1,  0,  0}
 *  { 0,  0,  0,  1}
 *  { 1,  0,  0,  0}
 *  { 0,  0,  1,  0}
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueeenProblemBacktracking
{
    class NQueenSol
    {
        int N = 4;
        /*
         * utility function to print the solution
         */
        void printSolution(int[, ] board, int N)
        {
            Console.WriteLine("in printSolution");
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                    Console.Write("%d", board[i,j]);
                Console.Write('\n');
            }
        }

        bool isSafe(int[,] board, int N, int Row, int Col)
        {

            Console.WriteLine("in isSafe");
            Console.WriteLine("[{0}]", string.Join(", ", board));
            int i, j;
            
            /* Check row on the left side*/
            for(i = 0; i < Col; i++)
                if (board[Row, i] == 1)
                    return false;

            /* Check upper diagonal on the left */
            for (i = Row, j = Col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1)
                    return false;

            /* Check lower diagonal on the left */
            for(i = Row, j = Col; j >= 0 && i < N; i++, j--)
                if(board[i,j] == 1)
                    return false;
            return true;
        }

        /*
         * recursive utility function to solve N queen problem
         */

        bool solveNQueenUtil(int[,] board, int N, int Col)
        {
            Console.WriteLine("in solveNQueenUtil");
            /*
             * base case if N queen are placed then return true
             */
            if (Col > N)
                return true;

            /*
             * Consider Column and try placing queen in all rows one by one
             */
            for(int i = 0; i<N; i++)
            {
                if(isSafe(board, N, i, Col))
                {
                    //place queen in the ith row in the Col
                    board[i, Col] = 1;
                    //recur to place rest of the queen
                    if (solveNQueenUtil(board, N--, Col++))
                        return true;
                    //if placing queen in the board does not lead the solution then remove the queen from the board
                    board[i, Col] = 0;
                }
            }
            //if the queen can not e placed in this column the return false
            return false;
        }

        /*
         * This function solve the N Queen problem using Backtracking.
         * It mainly uses the solveNQueenUtil to solve the N queen problem
         * It returns false if the queen can not be placed else returns true with the solution printed
         * It prints one fisible solution
         */

        bool solveNQueen()
        {
            Console.WriteLine("in solveNQUeen");
            int[,] board = new int[,]{ {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0} };
            Console.WriteLine("[{0}]", string.Join(", ", board));
            if (solveNQueenUtil(board, 4, 0) == false)
            {
                Console.WriteLine("Solution does not exist.");
                return false;
            }

            printSolution(board, 4);
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("in Main");
            int[,] array = new int[,] { { 1, 2, 3 }, { 1, 2, 3 } };
            for(int i = 0; i <= array.GetLength(1); i++)
            {
                //Console.WriteLine("{0}", i);
                Console.WriteLine("[{0}]", string.Join(", ", array[i, array.GetLength(1)]));
            }
            Console.WriteLine(string.Join(",", array));
            var NQueenSol = new NQueenSol();
            NQueenSol.solveNQueen();
        }
    }
}
