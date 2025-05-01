using UnityEngine;


//handles interaction script for Globe
public class GlobeInteraction : Interactable
{
    protected override string initDialogue() =>
        "A faded globe sits forgotten in the corner. Countries are smudged, borders unclear.";

    protected override string firstWhyOption1() =>
        "Why keep a globe here?";

    protected override string firstWhyOption2() =>
        "Why is it pushed aside?";

    protected override string secondWhy1A() =>
        "Maybe he wanted to remember where he started.";

    protected override string secondWhy1B() =>
        "He used to spin it and stop it at random — searching for anywhere else.";

    protected override string secondWhy2A() =>
        "It stopped mattering. Location, time... none of it mattered anymore.";

    protected override string secondWhy2B() =>
        "Because every place became the same once he stopped leaving.";

    protected override string secondWhy1A_Reveal() =>
        "Because I kept thinking I could outrun it.";

    protected override string secondWhy1B_Reveal() =>
        "Because I wanted the illusion of movement.";

    protected override string secondWhy2A_Reveal() =>
        "Because there’s no escape when the prison is your mind.";

    protected override string secondWhy2B_Reveal() =>
        "Because I already knew — no matter where I went, I’d be here.";
}