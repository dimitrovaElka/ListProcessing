using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing
{
     public class ReverseCommand : Command
    {
        public void Reverse(List<string> list)
        {
            list.Reverse();
        }
    }
}
