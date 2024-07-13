using UnityEngine;

public class MoveModule : MonoBehaviour, ICharacterModule
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    private Character _character;
    private float _speed = 8f;
    public void SetCharacter(Character character)
    {
        _character = character;
    }

    public void UpdateModule()
    {
        float moveHorizontal = Input.GetAxis(Horizontal);
        float moveVertical = Input.GetAxis(Vertical);

        Vector3 direction = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _character.Move(direction, _speed);
    }
}
