using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing
{
  public  class SortCommand : Command
    {
        public void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine(string.Join(' ', list));
        }
    }
}
