using UnityEngine;



//template(father script of all interactables, only handles code for desk tho)
public class Interactable : MonoBehaviour
{

    protected bool chosenOnce = false;    //what tree level are we at 
    protected int optionNum = 0;        //which option 1 or 2( A or B )respectively

    public virtual void Interact() {
        Debug.Log("Interact method triggered on " + gameObject.name);

        if (!chosenOnce)
        {
            FindFirstObjectByType<InteractionUIManager>().displayInt(
                initDialogue(),
                firstWhyOption1(),
                firstWhyOption2(),
                () => { optionNum = 1; chosenOnce = true; ShowSecondLayer(); },
                () => { optionNum = 2; chosenOnce = true; ShowSecondLayer(); }
            );
        } else {
            ShowSecondLayer();  //keep shoing second layer if already chosen
        }

    }


    //shows second lauer of options based on which "why?" was chosen
    private void ShowSecondLayer()
{
    Tracker tracker = FindFirstObjectByType<Tracker>();
    string topText = initDialogue();


    if (optionNum == 1)
    {
        if (tracker.revealFlag)
        {
            FindFirstObjectByType<InteractionUIManager>().displayInt(
                topText,
                secondWhy1A_Reveal(),
                secondWhy1B_Reveal(),
                () => FindFirstObjectByType<InteractionUIManager>().hideInt(),
                () => FindFirstObjectByType<InteractionUIManager>().hideInt()
            );
        }
        else
        {
            FindFirstObjectByType<InteractionUIManager>().displayInt(
                topText,
                secondWhy1A(),
                secondWhy1B(),
                () => FindFirstObjectByType<InteractionUIManager>().hideInt(),
                () => FindFirstObjectByType<InteractionUIManager>().hideInt()
            );
        }
    }
        else if (optionNum == 2)
    {
        if (tracker.revealFlag)
        {
            // Check for final interaction case
            if (this is RecorderInteraction)
            {
                FindFirstObjectByType<InteractionUIManager>().displayInt(
                    topText,
                    "This recording is the lock. And I... I am the key.",
                    "Play it.\nAnd everything ends.",
                    () => FindFirstObjectByType<InteractionUIManager>().hideInt(),
                    () => {
                        TriggerFinalSequence();
                        FindFirstObjectByType<InteractionUIManager>().hideInt();
                    }
                );
            }
            else
            {
                FindFirstObjectByType<InteractionUIManager>().displayInt(
                    topText,
                    secondWhy2A_Reveal(),
                    secondWhy2B_Reveal(),
                    () => FindFirstObjectByType<InteractionUIManager>().hideInt(),
                    () => FindFirstObjectByType<InteractionUIManager>().hideInt()
                );
            }
        }
        else
        {
            FindFirstObjectByType<InteractionUIManager>().displayInt(
                topText,
                secondWhy2A(),
                secondWhy2B(),
                () => FindFirstObjectByType<InteractionUIManager>().hideInt(),
                () => FindFirstObjectByType<InteractionUIManager>().hideInt()
            );
        }
    }

    tracker.RegisterInteraction();
}

    // Override these in child classes
    protected virtual string initDialogue() => "";

    protected virtual string firstWhyOption1() => "";
    protected virtual string firstWhyOption2() => "";

    protected virtual string secondWhy1A() => "";
    protected virtual string secondWhy1B() => "";
    protected virtual string secondWhy2A() => "";
    protected virtual string secondWhy2B() => "";

    protected virtual string secondWhy1A_Reveal() => "";
    protected virtual string secondWhy1B_Reveal() => "";
    protected virtual string secondWhy2A_Reveal() => "";
    protected virtual string secondWhy2B_Reveal() => "";

    protected virtual void TriggerFinalSequence() {
        //do nothing
    }


}
