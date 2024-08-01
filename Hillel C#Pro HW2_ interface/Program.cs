using System;
using System.Drawing;

public enum ProgramFunc
{
    Move = 1,
    GetSizeVector = 2,
    ResizeObjects = 3,
    


}

class Program
{
    static void Main(string[] args)
    {
        int X = 0, Y = 0 , R =0;
        int x = 0 , y = 0, w = 0 , h = 0;

        Circle circle = new Circle( X, Y, R);
        Rectangle rectangle = new Rectangle(x, y, w, h);
        Vector vector = new Vector(0 ,0);
        Console.WriteLine($"Создаем три  объекта {vector.Name}, {circle.Name} и {rectangle.Name}");
        while (true) {
            vector.ShowInfo();
            circle.ShowInfo();
            rectangle.ShowInfo();

            Console.WriteLine("1:Передвинуть объект ->\n" +
                "2:Задать координаты вектора и вычислить размер\n" +
                "3.Изменить размер объекта");
            Console.Write("Поле ввода:"); 
            var ProgramFuncQ = (ProgramFunc)Convert.ToInt32(Console.ReadLine());

            switch (ProgramFuncQ) 
            { 
             case ProgramFunc.Move:
                    Console.Clear();
                    Console.WriteLine($"Какой объект хотите переместить ? ({circle.Name}) - 1  ({rectangle.Name}) - 2 ");
                    Console.Write("Поле ввода:"); int q = Convert.ToInt32( Console.ReadLine());
                    if (q == 1)
                    {
                        Console.Write($"Переносим {circle.Name}\nКоордината Х:");
                        X = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Координата Y");
                        Y = Convert.ToInt32(Console.ReadLine());
                        circle.Move(X, Y);
                    }

                    else
                    {
                        Console.Write($"Переносим {rectangle.Name}\nКоордината Х:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Координата Y:");
                        y = Convert.ToInt32(Console.ReadLine());
                        rectangle.Move(x, y);
                    }

                    break;
             case ProgramFunc.GetSizeVector:
                    Console.Clear();
                    Console.Write ("введите значение по оси Х: ");
                    vector.X = Convert.ToInt32(Console.ReadLine());
                    Console.Write("введите значение по оси Y: ");
                    vector.Y = Convert.ToInt32(Console.ReadLine());
                    vector.VectorLength();
             break;
             case ProgramFunc.ResizeObjects:
                    Console.Clear();
                    Console.WriteLine($"Какой объект хотите ресайзнуть ? ({circle.Name}) - 1  ({rectangle.Name}) - 2 ");
                    Console.Write("Поле ввода:");  q = Convert.ToInt32(Console.ReadLine());
                    if (q == 1)
                    {
                        Console.Write($"Введите новый Радиус {circle.Name}а:");
                        R = Convert.ToInt32(Console.ReadLine());
                        circle.R = R;
                    }

                    else
                    {
                        Console.Write($"Введите размер {rectangle.Name}а\nШирина W:");
                        w = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Координата Y");
                        h = Convert.ToInt32(Console.ReadLine());
                        rectangle.W = w;
                        rectangle.H = h;
                    }

                    break;



            }


        }
    }
}