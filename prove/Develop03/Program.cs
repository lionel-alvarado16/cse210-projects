using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference newReference = new Reference("Jhon", 3, 17, 18);
        string textReference = newReference.GetReference();

        string script = "For God sent not his Son into the world to condemn the world; but that the world through him might be saved. He that believeth on him is not condemned: but he that believeth not is condemned already, because he hath not believed in the name of the only begotten Son of God.";

        Scripture newScripture = new Scripture(textReference, script);
       
        string input = " ";

        do
        {
            newScripture.GetRenderedText();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

        } while (input != "quit");
    }
}