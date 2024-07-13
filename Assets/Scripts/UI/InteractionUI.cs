using UnityEngine;
using UnityEngine.UI;

public class InteractionUI : MonoBehaviour
{
    [SerializeField] public Text interactionText;
    private CharacterFacade characterFacade;
    void Start()
    {
        interactionText.text = "";
        characterFacade = FindObjectOfType<CharacterFacade>();
    }

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(characterFacade.transform.position, 2f);
        bool canInteract = false;

        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("HealthPickup") || hitCollider.CompareTag("DamageObject"))
            {
                canInteract = true;
                break;
            }
        }

        if (canInteract) interactionText.text = "Нажмите E для взаимодействия";
        else interactionText.text = "";
    }
}
