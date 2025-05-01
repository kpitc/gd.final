using UnityEngine;



//template(father script of all interactables, only handles code for desk tho)
public class GramInteraction : Interactable
{
    public override void Interact() {

        FindFirstObjectByType<InteractionUIManager>().displayInt(
            "The needle rests on the record's edge - motionless, yet ready.",
            "Why did he keep playing it?",
            "Why did he stop?",
            () => Debug.Log("You chose: Kept playing"),       // Option 1 logic
            () => Debug.Log("You chose: He stopped")       // Option 2 logic
        );

    }
}