namespace RugbyPlayerList
{
    public class Tools
    {
        public static int counter;
        public static void PrintArray(string[] input)
        {
            //foreach (var item in input) 
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " ");
            }
            //while (counter < input.Length)
            //{
            //    Console.WriteLine(input[counter]);
            //    counter++;
            //}

        }

    }
}
