using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing
{
   public class Command
    {
        public void Print (List<string> printItems)
        {
            //foreach (var item in printItems)
            //{
                Console.Write(String.Join(' ', printItems));
            //}
        }

        public void PrintErrorMessage (string Message)
        {
            throw new ArgumentException($"Error: {Message}");
        }
    }
}
