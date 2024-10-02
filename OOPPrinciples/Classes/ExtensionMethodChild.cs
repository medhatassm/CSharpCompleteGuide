using System;

namespace OOPPrinciples.Classes;

static public class ExtensionMethodChild
{
    public static void SayWelcomeAndHello(this ExtensionMethodParent extentionMethodParent)
    {
        Console.WriteLine("Hello And Welcome");
    }

}
