using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Structs
{
    public readonly struct Vector2D
    {
        public readonly int X;
        public readonly int Y;

        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string ToBoardString()
        {
            char column = (char)('A' + X);
            int row = 8 - Y;
            return $"{column}{row}";
        }

        // NOT USING??
        public static Vector2D ToVector(string s)
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

            return new Vector2D(0, 0);
        }
    }
}
