using System;
using UnityEngine;

public class Character
{
    public event Action<Vector3> OnMove;
    public event Action<InteractiveObject> OnInteract;
    public event Action<InteractiveObject> OnInteractUI;  
    public Transform _transform { get; private set; }

    public Character(Transform transform)
    {
        _transform = transform;
    }

    public void Move(Vector3 direction) => OnMove?.Invoke(direction);

    public void Interact(InteractiveObject interactiveObject = null) => 
        OnInteract?.Invoke(interactiveObject);

    public void InteractUI(InteractiveObject interactiveObject) =>
        OnInteractUI?.Invoke(interactiveObject);
}
