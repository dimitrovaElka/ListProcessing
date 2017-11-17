using System;
using System.Collections.Generic;

namespace ListProcessing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join(' ', inputLine));
            List<string> listToFill = new List<string>();
            foreach (var line in inputLine)
            {
                listToFill.Add(line);
            }

            var commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "end")
            {
                var command = commandInput.Split(' ');
                switch (command[0])
                {
                    //case "append": AddStringAtTheEnd(commands[1], inputLine); break;
                    //case "prepend": InsertStringInTheStart(commands[1], inputLine); break;
                    //case "reverse": ReverseList(inputLine); break;
                    //case "insert": InsertStringAtThePosition(inputLine, commands[1]); break;
                    //case "delete": DeleteIndex(inputLine, commands[1]); break;
                    //case "roll": 
                    //	{
                    //		if (commands[1] == "left") RollLeft(inputLine);
                    //		else RollRight(inputLine);
                    //	}
                    //	break;
                    //case "sort": SortList(inputLine);break;
                    case "count":
                        var comm = new CountCommand();
                        Console.WriteLine(comm.HowManyTimes(listToFill, command[1])); break;
                        //default: ErrorMessage(); break;
                }
            }
            Console.WriteLine("Finished");
        }
    }
}


