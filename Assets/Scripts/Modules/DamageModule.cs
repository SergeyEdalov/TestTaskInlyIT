using UnityEngine;

public class DamageModule : MonoBehaviour, ICharacterModule
{
    private Character _character;
    private InteractiveObject _currentInteractiveObject;

    public void SetCharacter(Character character)
    {
        _character = character;
        _character.OnInteract += HandleInteract;
    }

    public void UpdateModule()
    {
        if (Input.GetKeyDown(KeyCode.E) && _currentInteractiveObject != null)
            _character.Interact();
    }

    private void OnTriggerEnter(Collider other)
    {
        InteractiveObject interactiveObject = other.GetComponent<InteractiveObject>();

        if (interactiveObject != null && interactiveObject is DamageObject)
        {
            _currentInteractiveObject = interactiveObject;
            _character.InteractUI(interactiveObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        InteractiveObject interactiveObject = other.GetComponent<InteractiveObject>();

        if (interactiveObject != null && interactiveObject == _currentInteractiveObject)
        {
            _currentInteractiveObject = null;
            _character.InteractUI(null);
        }
    }

    private void HandleInteract(InteractiveObject interactiveObject)
    {
        if (_currentInteractiveObject != null && _currentInteractiveObject is DamageObject)
            _currentInteractiveObject.Interact(_character);
    }
}
