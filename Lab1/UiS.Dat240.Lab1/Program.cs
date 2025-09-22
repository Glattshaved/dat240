using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;
using UiS.Dat240.Lab1;
using UiS.Dat240.Lab1.Commands;
using UiS.Dat240.Lab1.Queues;

var provider = TestSubmissions.CreateServiceProvider();
var commandsHandler = provider.GetServices<ICommandHandler>();
string userInput;

// Console.WriteLine("\nPlease write one of the following commands:\n");
// Console.WriteLine("List of commands:");
// Console.WriteLine("add: To save the following string.");
// Console.WriteLine("rem: Removes last string input");
// Console.WriteLine("size: Writes how many string inputs there are");
// Console.WriteLine("exit: Terminates the Program\n");
// Console.WriteLine(">");

// GenericQueue<string> queue = new GenericQueue<string>();

do
{
    Console.Write(">");
    userInput = Console.ReadLine();
    string[] data = userInput.Split(' ', 2);
    // var handler = handlers.FirstOrDefault(handler => handler.Name == command[0]);

    foreach (var command in commandsHandler)
    {
        if (command.Name == data[0])
        {
            string argument = data.Length > 1 ? data[1] : string.Empty;
            command.Handle(argument);
            break;
        }
    }

    
    

    // if (command[0] == "add")
    // {
    //     if (command.Length > 1)
    //     {
    //         queue.Enqueue(command[1]);
    //         Console.WriteLine($"\nYou added: \"{command[1]}\".");
    //         Console.WriteLine("Type \"exit\" to terminate the program, or continue using the commands.");

    //     }
    //     else
    //     {
    //         Console.WriteLine("\nPlease write what to add after the command");
    //     }
    // }
    // else if (command[0] == "rem")
    // {
    //     // Casting with object to (string)
    //     string removedValue = (string)queue.Dequeue();
    //     Console.WriteLine($"\nYou removed \"{removedValue}\" from the head of the string.");
    // }
    // else if (command[0] == "size")
    // {
    //     Console.WriteLine($"\nThe size of the queue is {queue.Length}.");
    //     // Console.WriteLine($"The size of the data array is {data.Length()}")
    // }
    // else if (command[0] != "exit")
    // {
    //     Console.WriteLine($"\n\"{userInput}\" is not a command. \nPlease write one of the mentioned commands, \"add\", \"rem\", \"size\" or type \"exit\" to terminate the program:");
    // }

} while (userInput != "exit");

Console.WriteLine("\nTerminating program...\n");