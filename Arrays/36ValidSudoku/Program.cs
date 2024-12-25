using System.Collections.Generic;

namespace _36ValidSudoku;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        sol.IsValidSudoku(
            [
                ["5", "3", ".", ".", "7", ".", ".", ".", "."],
                ["6", ".", ".", "1", "9", "5", ".", ".", "."],
                [".", "9", "8", ".", ".", ".", ".", "6", "."],
                ["8", ".", ".", ".", "6", ".", ".", ".", "3"],
                ["4", ".", ".", "8", ".", "3", ".", ".", "1"],
                ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
                [".", "6", ".", ".", ".", ".", "2", "8", "."],
                [".", ".", ".", "4", "1", "9", ".", ".", "5"],
                [".", ".", ".", ".", "8", ".", ".", "7", "9"]
            ]
        );
    }

    public class Solution
    {
        public bool IsValidSudoku(string[][] board)
        {
            List<Dictionary<char, int>> filas = new();
            List<Dictionary<char, int>> columnas = new();
            List<List<Dictionary<char, int>>> cuadrantes = new();

            for (int i = 0; i < 3; i++)
            {
                List<Dictionary<char, int>> filaCuadrantes = new();
                for (int j = 0; j < 3; j++)
                {
                    Dictionary<char, int> cuadrante = new();
                    filaCuadrantes.Add(cuadrante);
                }
                cuadrantes.Add(filaCuadrantes);
            }
            for (int i = 0; i < board.Length; i++)
            {
                Dictionary<char, int> columna;

                //Console.WriteLine("crear columan: " + i);
                columna = new Dictionary<char, int>();
                columnas.Add(columna);
            }
            char c;
            for (int i = 0; i < board.Length; i++)
            {
                Dictionary<char, int> fila = new();
                //Console.WriteLine("new Line;");
                for (int j = 0; j < board.Length; j++)
                {
                    c = board[i][j][0];

                    while (c == '.')
                    {
                        //Console.WriteLine("vacio: " + c);
                        j++;
                        if (j >= board.Length)
                        {
                            break;
                        }
                        c = board[i][j][0];
                    }
                    if (c == '.')
                    {
                        break;
                    }

                    //Console.WriteLine("c: " + c);

                    //Revisar filas
                    if (!fila.TryAdd(c, 1))
                    {
                        Console.WriteLine("test1");
                        return false;
                    }
                    //crear mapas de columnas
                    Dictionary<char, int> columna;
                    //Console.WriteLine("j: " + j + "count" + columnas.Count);
                    columna = columnas[j];
                    if (!columna.TryAdd(c, 1))
                    {
                        Console.WriteLine("test2");
                        return false;
                    }
                    //cuadrante
                    int colCua = j / 3;
                    int filCua = i / 3;
                    //Console.WriteLine("i: " + i + " j:" + j + "colCua: " + colCua + " filCua");
                    if (!cuadrantes[filCua][colCua].TryAdd(c, 1))
                    {
                        Console.WriteLine("test3");
                        return false;
                    }
                }
                filas.Add(fila);
            }

            return true;
        }
    }
}
/*
public class Solution
    {
        List<Dictionary<char, int>> lineas = new();
        List<Dictionary<char, int>> columnas = new();
        List<Dictionary<char, int>> cuadrantes = new();

        public bool IsValidSudoku(char[][] board)
        {
            int cuadrante = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    Dictionary<char, int> col;
                    //check column
                    if (columnas[j] == null)
                    {
                       col = new();
                    }
                    else
                    {
                        col = columnas[j];
                    }
                    if (!col.TryAdd(board[i][j], out 1))
                    {
                        col[board[i][j]] = col[board[i][j]]++;
                    }
                    columnas[j] = col;

                    //check file
                    if (lineas[i] == null)
                    {
                        Dictionary<char, int> lin = new();
                    }
                    else
                    {
                        Dictionary<char, int> lin = lineas[i];
                    }
                    if (!lin.TryAdd(board[i][j], out 1))
                    {
                        lin[board[i][j]] = lin[board[i][j]]++;
                    }
                    lineas[i] = lin;
                    //check block
                    int cuadranteEnI = (i / 3) + 1;
                    int cuadranteEnJ = (j / 3) + 1;
                    cuadrante = cuadranteEnI + cuadranteEnJ* 3;

                    if (cuadrantes[cuadrante] == null)
                    {
                        Dictionary<char, int> cua = new();
                    }
                    else
                    {
                        Dictionary<char, int> cua = cuadrantes[cuadrante];
                    }
                    if (!cua.TryAdd(board[i][j], out 1))
                    {
                        cua[board[i][j]] = cua[board[i][j]]++;
                    }
                    cuadrantes[cuadrante] = cua;

                }
            }

            int value = -1;
            for(int i = 0; i < 9; i) {
                for(int j = 1; j <= 9; j++) {
                    if(lineas[i].TryGetValue(j, out value)) {
                        if(value > 1) {
                            return false;
                        }
                    }
                    if(columnas[i].TryGetValue(j, out value)) {
                        if(value > 1) {
                            return false;
                        }
                    }
                    if(cuadrante[i].TryGetValue(j, out value)) {
                        return false;
                    }
                }
            }
            return true;
        }
    }

*/
