
//4. Створіть структуру Vector з властивостями double X і double Y, додайте метод для обчислення довжини вектора.
public struct Vector
{
    public string Name { get; set; } = "Vector";
    public double X { get; set; }
    public double Y { get; set; }
    public double Length { get; set; }
    public Vector(int x , int y) 
    {
        this.X = x;
        this.Y = y;
    }


    public double VectorLength()
    {
        double result = Math.Sqrt((X * X) + (Y * Y));
        Console.WriteLine($"Размер вектора = {result}");
        Length = result;
        return result;

    }
    public  void ShowInfo()
    {
        Console.WriteLine($"Вектор с координатами {X} и {Y}, и размером {Length}\n" +
                          $"______________________________________________________");
    }
}
