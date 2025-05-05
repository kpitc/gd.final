using UnityEngine;
using UnityEngine.SceneManagement;

public class RecorderInteraction : Interactable
{
    protected override string initDialogue() =>
        "A portable tape recorder lies on the floor. Scuffed. Silent. But still powered.";

    protected override string firstWhyOption1() =>
        "Why was it left on?";

    protected override string firstWhyOption2() =>
        "Why record anything at all?";

    protected override string secondWhy1A() =>
        "Someone must have used it recently. But why here? Why now?";

    protected override string secondWhy1B() =>
        "Maybe it was recording more than sound.";

    protected override string secondWhy2A() =>
        "A confession? A message? A warning?";

    protected override string secondWhy2B() =>
        "Some truths are easier said to no one.";

    protected override string secondWhy1A_Reveal() =>
        "Because I needed to remember.\nI left myself this voice.";

    protected override string secondWhy1B_Reveal() =>
        "When I play it back, I hear someone else.\nBut it’s me.";

    protected override string secondWhy2A_Reveal() =>
        "This recording is the lock. And I... I am the key.";

    protected override string secondWhy2B_Reveal() =>
        "Play it.\nAnd everything ends.";

    protected override void TriggerFinalSequence()
    {
        Debug.Log("TriggerFinalSequence() called.");

        var uiManager = FindFirstObjectByType<InteractionUIManager>();
        if (uiManager == null)
        {
            Debug.LogError("InteractionUIManager not found.");
            return;
        }

        Debug.Log("Found UI Manager. Showing final message.");

        uiManager.displayInt(
            "You were never sent here.\nYou were always here.\n\nYou were never the investigator.\nYou were the experiment.\n\nTime is not real.\nYou are not moving.\nYou are only remembering... remembering... remembering...",
            "", "", null, null
        );

        uiManager.StartCoroutine(DelayedSceneLoad("Main Menu", 5f)); // Make sure "MainMenu" is in Build Settings
    }

    private System.Collections.IEnumerator DelayedSceneLoad(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}