using System;

namespace addingOneToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 9, 9, 9, 9, 9 };
            var outputArray = AddOneToArray(inputArray);
            Console.WriteLine(Environment.NewLine);
            foreach (var num in outputArray)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static int[] AddOneToArray(int[] givenArray)
        {
            int currentIndex = givenArray.Length - 1;
            // int[] newArray = new int[givenArray.Length];
            int carry = 1;

            for (int i = currentIndex; i >= 0; i--)
            {
                int total = givenArray[i] + carry;
                if (total == 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                givenArray[i] = total % 10;
            }
            if (carry == 1)
            {
                int[] newArray = new int[givenArray.Length + 1];
                newArray[0] = 1;
                return newArray;
            }
            else
            {
                return givenArray;
            }
        }
    }
}
