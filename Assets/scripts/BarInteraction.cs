using UnityEngine;

public class BarChairInteraction : Interactable
{
    protected override string initDialogue() =>
        "A bar stool lies knocked over near the corner. An empty glass and half-drained whiskey bottle rest on the counter beside it.";

    protected override string firstWhyOption1() =>
        "Why was the stool knocked over?";

    protected override string firstWhyOption2() =>
        "Why was he drinking alone?";

    protected override string secondWhy1A() =>
        "He might’ve fallen. Or thrown it — frustration, maybe.";

    protected override string secondWhy1B() =>
        "Maybe he got up in a hurry... or couldn’t sit still any longer.";

    protected override string secondWhy2A() =>
        "It was how he coped — a ritual when no answers came.";

    protected override string secondWhy2B() =>
        "Sometimes the bottle listens better than people.";

    protected override string secondWhy1A_Reveal() =>
        "Because I couldn’t steady myself. I kept replaying it — over and over.";

    protected override string secondWhy1B_Reveal() =>
        "I stood too fast. Or maybe the room spun too hard. I don't remember.";

    protected override string secondWhy2A_Reveal() =>
        "Because I needed to feel something. Even if it was just the burn.";

    protected override string secondWhy2B_Reveal() =>
        "Because silence is easier to bear when it echoes through glass.";
}
