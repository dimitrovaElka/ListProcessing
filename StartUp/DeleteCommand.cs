namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class DeleteCommand : Command
    {
        public List<string> DeleteIndex(List<string> inputLine, string v)
        {
          
            int index = int.Parse(v);

            if (index < 0 || index > inputLine.Count - 1)
            {
                string message = $"invalid index {index}";
                PrintErrorMessage(message);
            }

            inputLine.RemoveAt(index);
            return inputLine;
        }
    }
}
