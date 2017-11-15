using System;

namespace ListProcessing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(String.Join(' ', inputLine));
			var commandInput = "";
			while ((commandInput = Console.ReadLine()) != "end")
			{
				var commands = commandInput.Split(' ');
				switch(commands[0])
				{
					case "append": AddStringAtTheEnd(commands[1], inputLine); break;
					case "prepend": InsertStringInTheStart(commands[1], inputLine); break;
					case "reverse": ReverseList(inputLine); break;
					case "insert": InsertStringAtThePosition(inputLine, commands[1]); break;
					case "delete": DeleteIndex(inputLine, commands[1]); break;
					case "roll": 
						{
							if (commands[1] == "left") RollLeft(inputLine);
							else RollRight(inputLine);
						}
						break;
					case "sort": SortList(inputLine);break;
					case "count": CountString(inputLine, commands[1]);break;
					default: ErrorMessage(); break;
				}
			}
        }
    }
}
