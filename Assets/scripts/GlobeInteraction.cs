using UnityEngine;



//template(father script of all interactables, only handles code for desk tho)
public class Globeinteraction : Interactable
{
    public override void Interact() {

        FindFirstObjectByType<InteractionUIManager>().displayInt(
            "The globe spins slowly. Dust clings to every country.",
            "Why is the globe still spinning?",
            "Why is it important where he looked last?",
            () => Debug.Log("You chose: Spinning Mystery"),       // Option 1 logic
            () => Debug.Log("You chose: Last Location")       // Option 2 logic
        );

    }
}