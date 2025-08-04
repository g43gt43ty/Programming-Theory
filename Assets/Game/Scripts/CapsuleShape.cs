using UnityEngine;

public class CapsuleShape : Shape
{
    public override void DisplayText()
    {
        UImanager.Instance.ShowMessage("I am a Capsule!");
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
