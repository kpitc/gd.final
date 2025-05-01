using UnityEngine;



//handles interaction script for gramaphone
public class GramophoneInteraction : Interactable
{
    protected override string initDialogue() =>
        "A dusty gramophone rests on a side table. Its needle sits still, waiting.";

    protected override string firstWhyOption1() =>
        "Why is it here?";

    protected override string firstWhyOption2() =>
        "Why isn’t it playing?";

    protected override string secondWhy1A() =>
        "He needed the noise. Silence reminded him too much of truth.";

    protected override string secondWhy1B() =>
        "This room once echoed with Bach and static. He filled it with anything but thought.";

    protected override string secondWhy2A() =>
        "Because the music stopped long before he realized.";

    protected override string secondWhy2B() =>
        "Even the machines gave up eventually.";

    protected override string secondWhy1A_Reveal() =>
        "Because quiet meant remembering.";

    protected override string secondWhy1B_Reveal() =>
        "Because the only thing louder than sound... was absence.";

    protected override string secondWhy2A_Reveal() =>
        "Because I didn’t want to hear it end.";

    protected override string secondWhy2B_Reveal() =>
        "Because if I turned it on again... I’d hear myself.";
}