using UnityEngine;



//handles interaction script for clock
public class ClockInteraction : Interactable
{
    protected override string initDialogue() => 
        "A grand old clock. The hands are frozen at 12:03 AM. Ticking, but unmoving.";

    protected override string firstWhyOption1() => 
        "Why did it stop?";

    protected override string firstWhyOption2() => 
        "Why 12:03?";

    protected override string secondWhy1A() => 
        "Maybe it’s broken.";

    protected override string secondWhy1B() => 
        "Or maybe time doesn’t matter here.";

    protected override string secondWhy2A() => 
        "That’s when the experiment ended.";

    protected override string secondWhy2B() => 
        "It was the moment he lost something.";

    protected override string secondWhy1A_Reveal() => 
        "Because time isn’t passing.";

    protected override string secondWhy1B_Reveal() => 
        "It’s memory pretending to move. Just like me.";

    protected override string secondWhy2A_Reveal() => 
        "Because everything changed at 12:03.";

    protected override string secondWhy2B_Reveal() => 
        "That’s when I shattered too.";
}