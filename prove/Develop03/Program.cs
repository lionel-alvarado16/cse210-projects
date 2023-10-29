using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference newReference = new Reference("Jhon", 3, 19, 21);
        string textReference = newReference.GetReference();

        string script = "And this is the condemnation, that light is come into the world, and men loved darkness rather than light, because their deeds were evil. For every one that doeth evil hateth the light, neither cometh to the light, lest his deeds should be reproved. But he that doeth truth cometh to the light, that his deeds may be made manifest, that they are wrought in God.";

        Scripture newScripture = new Scripture(textReference, script);
       
        string input = " ";

        do
        {
            newScripture.GetRenderedText();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            if (input == "")
            {
                newScripture.HideWords();

                if (newScripture.CompletelyHidden() == true)
                {
                    newScripture.GetRenderedText();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    input = Console.ReadLine();
                    break;
                }
            }
        } while (input != "quit");
    }
}