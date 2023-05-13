using System;

namespace DNAReplication
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static void Main(string[] args)
        {
            bool continueProgram = true;
            bool continueProgram = true;
            {
                Console.Write("Enter a half DNA sequence: ");
                string halfDNASequence = Console.ReadLine();

                if (IsValidSequence(halfDNASequence))
                {
                    Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                    bool validAnswer = false;
                    while (!validAnswer)
                    {
                        Console.Write("Do you want to replicate it? (Y/N): ");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                        {
                            string replicatedSequence = ReplicateSequence(halfDNASequence);
                            Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                            validAnswer = true;
                        }
                        else if (answer == "N")
                        {
                            validAnswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }

                bool validContinueAnswer = false;
                while (!validContinueAnswer)
                {
                    Console.Write("Do you want to process another sequence? (Y/N): ");
                    string continueAnswer = Console.ReadLine();
                    if (continueAnswer == "Y")
                    {
                        validContinueAnswer = true;
                    }
                    else if (continueAnswer == "N")
                    {
                        continueProgram = false;
                        validContinueAnswer = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}