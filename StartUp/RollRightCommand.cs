namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class RollRightCommand : Command
    {
        public List<string> RollRight(string[] inputLine)
        {
            List<string> list = inputLine.ToList();
            string LastToFirst = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, LastToFirst);

            return list;
        }   
    }
}
