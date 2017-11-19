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
            // Print the list immediately after you read it (space separated).
            Console.WriteLine(String.Join(' ', inputLine));

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
                        case "append":
                            var appComm = new AppendCommand();
                            appComm.AddStringAtTheEnd(command[1], listToFill); break;
                        //case "prepend": InsertStringInTheStart(commands[1], inputLine); break;
                        case "prepend":
                            var prepComm = new PrependCommand();
                            prepComm.AddStringAtTheStart(command[1], listToFill); break;
                        case "reverse":
                            //ReverseList(inputLine); 
                            var rev = new ReverseCommand();
                            rev.Reverse(listToFill);
                            print.Print(listToFill);
                            break;
                        case "insert":
                            //InsertStringAtThePosition(inputLine, commands[1]); 
                            var index = 0;
                            var indexIsNumber = int.TryParse(command[1], out index);
                            if (!indexIsNumber)
                            {
                                string message = $"invalid index {index}";
                                print.PrintErrorMessage(message);
                            }
                            if (command.Length < 3)
                            {
                                string message = $"invalid command parameters";
                                print.PrintErrorMessage(message);
                            }
                            var stringToInsert = command[2];
                            var ins = new InsertCommand();
                            ins.InsertIndex(index, stringToInsert, listToFill);
                            print.Print(listToFill);
                            break;
                        case "delete":
                            var del = new DeleteCommand();
                            inputLine = del.DeleteIndex(listToFill, command[1]).ToArray();
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
                                else if (command[1] == "right")
                                {
                                    var rollRight = new RollRightCommand();
                                    inputLine = rollRight.RollRight(inputLine).ToArray();
                                    print.Print(inputLine.ToList());
                                }
                                else
                                {
                                    // Error: invalid command parameters
                                }
                            }
                            break;
                        //case "sort": SortList(inputLine);break;
                        case "sort":
                            var sortComm = new SortCommand();
                            var lenght = command.Length;
                            if (lenght > 1)
                            {
                                print.PrintErrorMessage("invalid command parameters");
                            }
                            else
                            {
                                sortComm.Sort(listToFill);
                            }
                            break;
                        case "count":
                            var comm = new CountCommand();
                            Console.WriteLine(comm.HowManyTimes(listToFill, command[1])); break;
                        default:
                            print.PrintErrorMessage("Error: invalid command");
                            break;
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


