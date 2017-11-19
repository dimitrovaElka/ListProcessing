namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class RollRightCommand : Command
    {
        public void RollRight(List<string> inputLine)
        {
            string LastToFirst = inputLine[inputLine.Count - 1];
            inputLine.RemoveAt(inputLine.Count - 1);
            inputLine.Insert(0, LastToFirst);
        }   
    }
}
