using System;

namespace ListProcessing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join(' ', inputLine));
            var commandInput = "";
            while ((commandInput = Console.ReadLine()) != "end")
            {
                var commands = commandInput.Split(' ');
                switch (commands[0])
                {
                    case "append": AppendCommand.AddStringAtTheEnd(commands[1], inputLine); break;
                    case "prepend": PrependCommand.InsertStringInTheStart(commands[1], inputLine); break;
                    case "reverse": Reverse.ReverseList(inputLine); break;
                    case "insert": Insert.InsertStringAtThePosition(inputLine, commands[1]); break;
                    case "delete": Delete.DeleteIndex(inputLine, commands[1]); break;
                    case "roll":
                        {
                            if (commands[1] == "left") RollLeftCommand.RollLeft(inputLine);
                            else RollRightCommand.RollRight(inputLine);
                        }
                        break;
                    case "sort": SortCommand.SortList(inputLine); break;
                    case "count": CountCommand.CountString(inputLine, commands[1]); break;
                    default: ErrorMsg.ErrorMessage(); break;
                }
            }
        }
    
    }
}
