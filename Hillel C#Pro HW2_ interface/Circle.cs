
// 3. Реалізуйте метод Move в класах Circle і Rectangle.
public  class Circle : Shape
{
    public string Name { get; set; } = "Круг";
    public int X { get; set; }
    public int Y { get; set; }
    public int R { get; set; }

    public Circle(int X, int Y, int R) 
    { 
        this.X = X; 
        this.Y = Y;
        this.R = R;
    }



    public override void Move(int deltaX, int deltaY)
    {

        this.X += deltaX;
        this.Y += deltaY;
        Console.WriteLine($"(ТУТ У НАС КРАСИВЫ КРУГ) по координатам X = {X} и Y = {Y}");
    }
    public override void ShowInfo() 
    {
        Console.WriteLine($"{Name} с координатами {X} и {Y}, и радиусом {R}\n" +
                         $"_________________________________________________");
    }
}
