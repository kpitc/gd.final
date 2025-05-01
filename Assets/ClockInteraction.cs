using UnityEngine;



//template(father script of all interactables, only handles code for desk tho)
public class ClockInteraction : Interactable
{
    public override void Interact() {

        FindFirstObjectByType<InteractionUIManager>().displayInt(
            "The hands of the clock seem to be stuck in a loop - never moving past midnight.",
            "Why won't time move on?",
            "Why does it always return to midnight?",
            () => Debug.Log("You chose: frozen time"),       // Option 1 logic
            () => Debug.Log("You chose: back to midnight")       // Option 2 logic
        );

    }
}