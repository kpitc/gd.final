using UnityEngine;

public class DeskInteraction : Interactable
{
    protected override string initDialogue() => 
        "You feel something strange about this desk...";

    protected override string firstWhyOption1() => 
        "Why is it important?";
    
    protected override string firstWhyOption2() => 
        "Why was it left behind?";

    protected override string secondWhy1A() => 
        "He thought it held the key to the whole pattern.";

    protected override string secondWhy1B() => 
        "A place where he once made sense of things — or tried to.";

    protected override string secondWhy2A() => 
        "It was the last place he wrote anything down.";

    protected override string secondWhy2B() => 
        "He couldn’t take it with him — but maybe he never left.";

    protected override string secondWhy1A_Reveal() =>
        "Because I thought if I could find the pattern, I could escape.";

    protected override string secondWhy1B_Reveal() =>
        "Time wasn't a river. It was a prison. And I was its prisoner.";

    protected override string secondWhy2A_Reveal() =>
        "Because it was the last real thing I had.";

    protected override string secondWhy2B_Reveal() =>
        "Even when I left, part of me stayed here, buried in ink and memory.";
}
