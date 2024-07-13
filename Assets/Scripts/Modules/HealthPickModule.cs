using UnityEngine;

public class HealthPickModule : MonoBehaviour, ICharacterModule
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
            if (_currentInteractiveObject is HealthObject)
            {
                _currentInteractiveObject.Interact(_character);
                _currentInteractiveObject = null;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HealthObject>() != null)
            _currentInteractiveObject = other.GetComponent<HealthObject>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<HealthObject>() != null && _currentInteractiveObject == other.GetComponent<HealthObject>())
            _currentInteractiveObject = null;
    }
}
