using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Structs
{
    public readonly struct Vector2D(int x, int y)
    {
        public readonly int X = x;
        public readonly int Y = y;

        public string ToBoardString()
    {
            if (!IsValidBoardVector())
                return "";
            char column = (char)('A' + (X - 1));
            return $"{column}{Y}";
        }

        public static Vector2D ToBoardGrid(string s)
        {
            if (!IsValidVectorString(s))
                return new Vector2D(int.MinValue, int.MinValue);
            int boardX = s[0] - 64;
            int boardY = int.Parse(s[1].ToString());
            return new Vector2D(boardX, boardY);
        }

        public bool IsValidBoardVector()
        {
            if ((0 < X && X < 9) == false)
                throw new IndexOutOfRangeException("Value X must be between 1 and 8");
            if ((0 < Y && Y < 9) == false)
                throw new IndexOutOfRangeException("Value Y must be between 1 and 8");
            return true;
        }

        public static bool IsValidVectorString(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException("Cannot convert null or empty string to Vector2D", s);
            if (s.Length != 2)
                throw new ArgumentException("Must only have a char and int to parse", s);
            if (!char.IsLetter(s[0]))
                throw new ArgumentException("First character must be a letter (A - H)", s[0].ToString());
            if (!int.TryParse(s[1].ToString(), out int result) || (result < 1 || result > 8))
                throw new ArgumentException("Second character must be an integer (1 - 8)", s[1].ToString());

            char c = char.ToUpper(s[0]);
            int i = result;

            if (c < 'A' || c > 'H')
                throw new ArgumentException("First character is not A - H", c.ToString());

            return true;
        }
    }
}
