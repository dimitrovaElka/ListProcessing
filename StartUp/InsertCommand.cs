using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing
{
  public  class InsertCommand : Command
    {
        public void InsertIndex(int index, string inputString, List<string> list)
        {
            if (index <0 || index >= list.Count)
            {
                string message = $"invalid index {index}";
                PrintErrorMessage(message);
            }
            list.Insert(index, inputString);
        }
    }
}
