using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');
            //Console.WriteLine(String.Join(' ', inputLine));
            List<string> listToFill = new List<string>();
            foreach (var line in inputLine)
            {
                listToFill.Add(line);
            }

            var commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "end")
            {
                try
                {
                    var command = commandInput.Split(' ');
                    var print = new Command();

                    switch (command[0])
                    {
                        //case "append": AddStringAtTheEnd(commands[1], inputLine); break;
                        //case "prepend": InsertStringInTheStart(commands[1], inputLine); break;
                        //case "reverse": ReverseList(inputLine); break;
                        //case "insert": InsertStringAtThePosition(inputLine, commands[1]); break;
                        case "delete":
                            var del = new DeleteCommand();
                            inputLine = del.DeleteIndex(inputLine, command[1]).ToArray();
                            print.Print(inputLine.ToList());
                            break;
                        case "roll":
                            {
                                if (command[1] == "left")
                                {
                                    var rollLeft = new RollLeftCommand();
                                    inputLine = rollLeft.RollLeft(inputLine).ToArray();
                                    print.Print(inputLine.ToList());
                                }
                                else
                                {
                                    var rollRight = new RollRightCommand();
                                    inputLine = rollRight.RollRight(inputLine).ToArray();
                                    print.Print(inputLine.ToList());
                                }
                            }
                            break;
                        //case "sort": SortList(inputLine);break;
                        case "count":
                            var comm = new CountCommand();
                            Console.WriteLine(comm.HowManyTimes(listToFill, command[1])); break;
                        //default: ErrorMessage(); break;
                    }
                }

                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                
            }
            Console.WriteLine("Finished");
        }
    }
}


