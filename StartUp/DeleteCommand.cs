namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class DeleteCommand : Command
    {
        public void DeleteIndex(List<string> inputLine, int v)
        {;
            inputLine.RemoveAt(v);
        }
    }
}
