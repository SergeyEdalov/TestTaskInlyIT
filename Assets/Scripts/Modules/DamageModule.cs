using UnityEngine;

public class DamageModule : MonoBehaviour, ICharacterModule
{
    private Character _character;
    private InteractiveObject _currentInteractiveObject;

    public void SetCharacter(Character character)
    {
        _character = character;
    }

    public void UpdateModule()
    {
        if (Input.GetKeyDown(KeyCode.E) && _currentInteractiveObject != null)
        {
            if (_currentInteractiveObject is DamageObject)
            {
                _currentInteractiveObject.Interact(_character);
                _currentInteractiveObject = null;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DamageObject>() != null)
            _currentInteractiveObject = other.GetComponent<DamageObject>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<DamageObject>() != null && _currentInteractiveObject == other.GetComponent<DamageObject>())
            _currentInteractiveObject = null;
    }
}
