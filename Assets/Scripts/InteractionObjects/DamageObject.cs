using UnityEngine;

public class DamageObject : InteractiveObject
{
    public override void Interact(Character character)
    {
        Debug.Log("Получен урон");
    }
}