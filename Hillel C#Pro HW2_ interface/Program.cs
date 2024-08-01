//Створіть інтерфейс IMovable
interface IMovable
{
    // з методом void Move(int deltaX, int deltaY)
    void Move(int deltaX, int deltaY)
    {

    }
}

abstract class Shape : IMovable
{

}

//Реалізуйте метод Move в класах Circle і Rectangle.
class Circle : IMovable
{

}

class Rectangle
{

}

//Створіть структуру Vector з властивостями double X і double Y, додайте метод для обчислення довжини вектора.
struct Vector
{

}

public enum ProgramFunc
{
    ShowInfo = 1,


}

class Program
{
    static void Main(string[] args)
    {


    }
}