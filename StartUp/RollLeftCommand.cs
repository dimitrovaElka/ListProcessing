namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class RollLeftCommand : Command
    {
        public void RollLeft(List<string> inputLine)
        {
            string firstToLast = inputLine[0];
            inputLine.RemoveAt(0);
            inputLine.Add(firstToLast);
        }
    }
}
