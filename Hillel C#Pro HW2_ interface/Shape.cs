
//  2. Додайте цей інтерфейс до абстрактного класу Shape.
public abstract class Shape : IMovable
{
    public abstract void Move(int deltaX, int deltaY);
    public abstract void ShowInfo();
}
