using UnityEngine;

public class BooksInteraction : Interactable
{
    protected override string initDialogue() => 
        "Walls lined with books: physics, metaphysics, philosophy. Heavy and dust-covered.";

    protected override string firstWhyOption1() => 
        "Why did he read so much?";

    protected override string firstWhyOption2() => 
        "Why is it all still here?";

    protected override string secondWhy1A() => 
        "He was desperate for answers. Theory gave him comfort.";

    protected override string secondWhy1B() => 
        "Maybe knowledge felt like control — even if it wasn’t.";

    protected override string secondWhy2A() => 
        "He never planned to leave. Not really.";

    protected override string secondWhy2B() => 
        "Books don’t betray. They just wait.";

    protected override string secondWhy1A_Reveal() => 
        "Because no book could teach me how to forget.";

    protected override string secondWhy1B_Reveal() => 
        "No theory could erase what I already knew.";

    protected override string secondWhy2A_Reveal() => 
        "Because I was never planning to leave.";

    protected override string secondWhy2B_Reveal() => 
        "I left the books... because they were me.";
}
