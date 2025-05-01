using UnityEngine;

public class Tracker : MonoBehaviour
{
    public int interactionCount = 0;
    public bool revealFlag = false;

    public void RegisterInteraction()
    {
        interactionCount++;
        if (interactionCount >= 5)
        {
            revealFlag = true;
            Debug.Log("Reveal Triggered");
        }
    }
}