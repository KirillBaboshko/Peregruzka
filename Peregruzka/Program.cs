using System;
using static System.Console;

namespace Peregruzka
{
    abstract class Figure
    {
        public abstract void Draw();
    }
    abstract class Quadrangle : Figure { }
    class Rectangle : Quadrangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle
            {
                Width = s.Length * 2,
                Height = s.Length
            };
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; i++, WriteLine())
            {
                for (int j = 0; j < Width; j++)
                {
                    Write("*");
                }
            }
            WriteLine();
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width},Height = { Height}";
        }
    }
    class Square : Quadrangle
    {
        public int Length { get; set; }
        public static explicit operator
        Square(Rectangle rect)
        {
            return new Square { Length = rect.Height };
        }
        public static explicit operator int(Square s)
        {
            return s.Length;
        }
        public static implicit operator Square(int number)
        {
            return new Square { Length = number };
        }
        public override void Draw()
        {
            for (int i = 0; i < Length; i++, WriteLine())
            {
                for (int j = 0; j < Length; j++)
                {
                    Write("*");
                }
            }
            WriteLine();
        }
        public override string ToString()
        {
            return $"Square: Length = {Length}";
        }
    }

    class Point
    {

        public int X { get; set; }
        public int Y { get; set; }
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;
        }
        public static Point operator |(Point p1, Point p2)
        {
            if ((p1.X != 0 || p1.Y != 0) || (p2.X != 0 || p2.Y != 0))
            {
                return p2;
            }
            return new Point();
        }
        public static Point operator &(Point p1, Point p2)
        {
            if ((p1.X != 0 && p1.Y != 0) && (p2.X != 0 && p2.Y != 0))
            {
                return p2;
            }
            return new Point();
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}.";
        }
    }
    class Uravnenie
    {
        int A;
        int B;
        public void Parse(string s)
        {
            string AS = "";
            string BS = "";
            BS += s[2];
            AS += s[0];
            A = Convert.ToInt32(AS);
            B = Convert.ToInt32(BS);
            int x=1;
            int y = 4 - 2 * x;
            int sum = 2 * x - 4 * (4 - 2 * x);

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point { X = int.Parse(ReadLine()), Y = int.Parse(ReadLine()) };
            //Point p2 = new Point { X = int.Parse(ReadLine()), Y = int.Parse(ReadLine()) };
            //if (p1)
            //{
            //    WriteLine("true");
            //}
            //else
            //{
            //    WriteLine("false");
            //}
            //WriteLine(p1 | p2);
            //WriteLine(p1 & p2);

 //           Rectangle rectangle = new Rectangle
 //           {
 //               Width = 5,
 //               Height = 10
 //           };
 //           Square square = new Square { Length = 7 };
 //           Rectangle rectSquare = square;
 //           WriteLine($"Неявное преобразование квадрата({ square}) к прямоугольнику.\n{ rectSquare}\n");
 ////rectSquare.Draw();
 //Square squareRect = (Square)rectangle;
 //           WriteLine($"Явное преобразование прямоугольника({ rectangle}) к квадрату.\n{ squareRect}\n");
 ////squareRect.Draw();
 //WriteLine("Введите целое число.");
 //           int number = int.Parse(ReadLine());
 //           Square squareInt = number;
 //           WriteLine($"Неявное преобразование целого({ number}) к квадрату.\n{ squareInt}\n");
 ////squareInt.Draw();
 //number = (int)square;
 //           WriteLine($"Явное преобразование квадрата({ square}) к целому.\n{ number}");

               
       }


    }
}
