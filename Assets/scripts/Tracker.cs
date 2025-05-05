using UnityEngine;

public class Tracker : MonoBehaviour
{
    public int interactionCount = 0;
    public bool revealFlag = false;

    public void RegisterInteraction()
    {
        interactionCount++;
        Debug.Log("Interaction Count: " + interactionCount);

        if (interactionCount >= 4)
        {
            revealFlag = true;
            Debug.Log("Reveal Triggered");
        }
    }
}