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

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    public static void Main(string[] args)
    {
        bool Check = true;
        while (Check)
        {
            Console.Write("Enter half DNA sequence: ");
            string input = Console.ReadLine();

            if (IsValidSequence(input))
            {
                Console.WriteLine("Current half DNA sequence: " + input);

                Console.Write("Do you want to replicate it? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() == "Y")
                {
                    string replicatedSequence = ReplicateSeqeunce(input);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice.ToUpper() == "N")
                {
                    Console.WriteLine("Skipping DNA replication.");
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            string restartChoice = Console.ReadLine();

            if (restartChoice.ToUpper() == "Y")
            {
                continue;
            }
            else if (restartChoice.ToUpper() == "N")
            {
                Check = false;
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
            }
        }
    }
}
