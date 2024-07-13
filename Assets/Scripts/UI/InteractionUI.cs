using UnityEngine;
using UnityEngine.UI;

public class InteractionUI : MonoBehaviour
{
    [SerializeField] public Text _interactionText;
    private CharacterFacade _characterFacade;
    private bool _canInteract = false;
    void Start()
    {
        _interactionText.text = "";
        _characterFacade = FindObjectOfType<CharacterFacade>();
        _characterFacade._character.OnInteractUI += HandleInteractUI;
    }

    private void HandleInteractUI(InteractiveObject interactiveObject)
    {
        if (interactiveObject is not null)
            _interactionText.text = "Нажмите E для взаимодействия";
        else _interactionText.text = "";
    }
}
