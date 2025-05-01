using UnityEngine;



//template(father script of all interactables, only handles code for desk tho)
public class Interactable : MonoBehaviour
{
    public virtual void Interact() {
        Debug.Log("reaching interact method with " + gameObject.name);

        FindFirstObjectByType<InteractionUIManager>().displayInt(
            "You feel something strange about this desk...",
            "Why is it important?",
            "Why was it left behind?",
            () => Debug.Log("You chose: Importance"),       // Option 1 logic
            () => Debug.Log("You chose: Left behind")       // Option 2 logic
        );


    }
}