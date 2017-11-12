
namespace ListProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class RollAndReverseCommands
    {
        static void RollRight(int count, string[] strings)
        {
            var indexToRoll = 0;
            string[] rolledLeftArr = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                indexToRoll = (i + count) % (strings.Length);
                rolledLeftArr[indexToRoll] = strings[i];
            }
            rolledLeftArr.CopyTo(strings, 0);
        }

        private static void RollLeft(int count, string[] strings)
        {
            var reversedArr = strings.Reverse().ToArray();
            RollRight(count, reversedArr);
            reversedArr.Reverse().ToArray().CopyTo(strings, 0);
        }


        private static void ReverseArray(int start, int count, string[] strings)
        {
            var end = start + count - 1;
            while (start < end)
            {
                var oldItem = strings[start];
                strings[start] = strings[end];
                strings[end] = oldItem;
                start++;
                end--;
            }
        }
        static bool IsInvalidInputParameters(int start, int count, int n)
        {
            var end = start + count - 1;
            if (start < 0 || start >= n || count < 0 || end >= n)
            {
                Console.WriteLine("Invalid input parameters.");
                return true;
            }
            return false;
        }
    }
}
