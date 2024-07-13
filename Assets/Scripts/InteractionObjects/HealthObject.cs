using UnityEngine;

public class HealthObject : InteractiveObject
{
    public override void Interact(Character character)
    {
        Debug.Log("Поднята аптечка");
        Destroy(gameObject);
    }
}
