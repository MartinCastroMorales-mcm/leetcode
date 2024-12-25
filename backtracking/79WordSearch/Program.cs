namespace _79WordSearch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        bool result = false;

        public bool Exist(char[][] board, string word)
        {
            bool[][] boolBoard = new bool[ board.Length, board.Length];
            for(int i = 0; i < board.Length; i++) {
                for(int j = 0; j < board.Length; j++) {
                    boolBoard[i][j] = false;
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    backtracking(board, word, i, j, num_characteres, boolBoard);
                }
            }
            return this.result;
        }

        public void backtracking(char[][] board, string word, int x, int y, int num_characteres, bool[][] boolBoard)
        {
            if(!boolBoard[x][y]) {
                return;
            }
            if (board[x][y] != word[num_characteres])
            {
                return;
            }
            if (word.Length - 1 == num_characteres)
            {
                this.result = true;
                return;
            }

            backtracking(board, word, x + 1, y, num_characteres + 1);
            if(this.result) {
                return true;
            }
            backtracking(board, word, x - 1, y, num_characteres + 1);
            if(this.result) {
                return true;
            }
            backtracking(board, word, x, y + 1, num_characteres + 1);
            if(this.result) {
                return true;
            }
            backtracking(board, word, x, y - 1, num_characteres + 1);
        }

        public bool Search(char[][] board, int x, int y, char c)
        {
            if (x < 0)
            {
                return false;
            }
            if (x >= board.Length)
            {
                return false;
            }
            if (y < 0)
            {
                return false;
            }
            if (y >= board.Length)
            {
                return false;
            }
            if (board[x][y] == c)
            {
                return true;
            }
            return false;
        }
    }
}
