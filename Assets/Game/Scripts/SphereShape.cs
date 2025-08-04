using UnityEngine;
// Inherits from Shape (OOP: Inheritance)
public class SphereShape : Shape
{
    public override void DisplayText()
    {
        UImanager.Instance.ShowMessage("I am a Sphere!");
    }
    public override void DisplayColor()
    {
        // Генерация случайного цвета
        Color = new Color(
            Random.value, 
            Random.value, 
            Random.value
        );
        
        ApplyColor(); // Применяем цвет через метод базового класса
    }
}
