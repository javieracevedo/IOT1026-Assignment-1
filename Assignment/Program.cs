namespace Assignment
{
    public static class ArrayReplicator
    {
        /// <summary>
        /// Replicates (deep copies) the incoming array
        /// </summary>
        /// <param name="original">The array to be replicated</param>
        /// <returns>A deep copy of the original array</returns>
        public static int[] ReplicateArray(int[] original)
        {
            int[] new_array = new int[original.Length];
            for (int i=0; i < original.Length; i++)
            {
                new_array[i] = original[i];
            }

            return new_array.ToArray();            
        }

        /// <summary>
        /// Asks the user for a number. Will crash if the user input is not convertible to an int (throw exception?)
        /// </summary>
        /// <param name="text">Text to prompt the user</param>
        /// <returns>The user input as an integer</returns>
        public static int AskForNumber(string text)
        {
            // Maybe we shouldn't throw here? and catch it in the other one? Or both I guess, since this one can be used independently
            string? input = Console.ReadLine();
            try {
                int number = Convert.ToInt32(input);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not converible to an integer.");
                throw new FormatException();
            }
        }

        /// <summary>
        /// Asks the user for a number within a certain range [min, max]. If the number is not in the range, re-prompt the user for a new number.
        /// Will crash if the user input is not convertible to an int (throw exception?)
        /// </summary>
        /// <param name="text">Text to prompt the user</param>
        /// <param name="min">Smallest permissible value</param>
        /// <param name="max">Largest permissible value</param>
        /// <returns>The user input as an integer</returns>
        public static int AskForNumberInRange(string text, int min, int max)
        {
            int number = AskForNumber(text);
            do {
                Console.WriteLine("Please enter a number between {} and {1}: ", min, max);
                number = AskForNumber(text);
                return number;
            } while (number < min || number > max);
        }
    }

    static class Program
    {
        static void Main()
        {
            const int Min = 2;
            const int Max = 10;
            const int PrintOffset = 4;

            int size = ArrayReplicator.AskForNumberInRange("Enter the array size: ", Min, Max);
            int[] original = new int[size];

            // Fill the original array with user specified integers
            for (int item = 0; item < size; ++item)
            {
                original[item] = ArrayReplicator.AskForNumber("Enter a number: ");
            }

            int[] copy = ArrayReplicator.ReplicateArray(original);
            // Verify original and replicated array are the same
            for (int index = 0; index < size; ++index)
                Console.WriteLine($"Original {original[index],-PrintOffset}  {copy[index],4} Copy");
        }
    }
}
