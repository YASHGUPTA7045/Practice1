using System;

class anagram

{
    public static void Interger()
    {
        int[] arr1 = { 1, 2000, 3, 4 };
        int[] arr2 = { 2, 3000, 3, 4 };

        if (arr1.Length != arr2.Length)
        {
            Console.WriteLine("Not anagram");
            return;
        }
        else
        {
            int[] countArr = new int[20000]; // Frequency array

            for (int i = 0; i < arr1.Length; i++)
            {
                countArr[arr1[i]]++;  // Increment for arr1
                countArr[arr2[i]]--;  // Decrement for arr2
            }

            foreach (int count in countArr)
            {
                if (count != 0)
                {
                    Console.WriteLine("Not anagram");
                    return;
                }
            }

            Console.WriteLine("Anagram");
        }
    }

  
}
