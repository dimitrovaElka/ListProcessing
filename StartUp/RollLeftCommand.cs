namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class RollLeftCommand : Command
    {
        public List<string> RollLeft(string[] inputLine)
        {
            List<string> list = inputLine.ToList();
            string firstToLast = list[0];
            list.RemoveAt(0);
            list.Add(firstToLast);

            return list;
        }
    }
}
