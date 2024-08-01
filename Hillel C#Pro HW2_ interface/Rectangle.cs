
// 5.Додайте до класу Rectangle метод для зміни розмірів прямокутника, використовуючи вектор.
//3. Реалізуйте метод Move в класах Circle і Rectangle.
public class Rectangle : Shape 
{
    public string Name { get; set; } = "Прямоугольник";
    public double X { get; set;}
    public double  Y { get; set;}
    public double W { get; set; }
    public double H { get; set; }

    public Rectangle(int x ,int y , int w ,int h) 
    { 
        this.X = x; 
        this.Y = y;
        this.W = w;
        this.H = h;
    
    }


    public override void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
        Console.WriteLine($"[ТУТ У НАС КРАСИВЫ ПРЯМОУГОЛЬНИК] размером {H} на {W}см. По координатам x= {X}, y= {Y}.");
    }


    public void resize(Vector vector)
    {
        W += vector.X;
        H += vector.Y;
        Console.WriteLine($"Размер прямоугольника изменился {W} на {H}см.");
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"{Name} с координатами {X} и {Y}, Шириной - {W} и Высотой - {H}\n" +
                          $"________________________________________________________________");
    }
}
