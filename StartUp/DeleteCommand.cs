namespace ListProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public class DeleteCommand : Command
    {
        public List<string> DeleteIndex(string[] inputLine, string v)
        {
            List<string> list = inputLine.ToList();
            int index = int.Parse(v);

            if (index < 0 || index > list.Count - 1)
            {
                string message = $"invalid index {index}";
                PrintErrorMessage(message);
            }

            list.RemoveAt(index);
            return list;
        }
    }
}
