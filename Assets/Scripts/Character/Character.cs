using UnityEngine;

public class Character
{
    public Transform _transform { get; private set; }

    public Character(Transform transform)
    {
        _transform = transform;
    }

    public void Move(Vector3 direction, float speed)
    {
        _transform.Translate(direction * speed * Time.deltaTime);
    }
}
