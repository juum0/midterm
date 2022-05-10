using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            string userStatement = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(userStatement));
            
        }

        static string CreateElizaResponse(string userIn)
        {
            if (userIn.Contains(" my ") && (userIn.Contains(" hate ") || userIn.Contains(" love ")))
            {
                int myIndex = userIn.IndexOf("my ");
                string nounHopefully = userIn.Substring(myIndex + 3);
                string elizaResponse = "You have strong feelings about your " + nounHopefully + ". Can you tell me more about your " + nounHopefully + "?";
                return elizaResponse;
            }
            else if (userIn.Contains(" my "))
            {
                int myIndex = userIn.IndexOf("my ");
                string nounHopefully = userIn.Substring(myIndex + 3);
                string elizaResponse = "Can you tell me more about your " + nounHopefully + "?";
                return elizaResponse;
            }
            else if (userIn.Contains(" hate ") || userIn.Contains(" love "))
            {
                string elizaResponse = "You have strong feelings about that!";
                    return elizaResponse;
            }
            else
            {
                string elizaResponse = "Please go on.";
                    return elizaResponse;
            }
        }
    }
}
