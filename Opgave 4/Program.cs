using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


class Program
{
    static char ch = '*';//this is a variable for the output, and we use a char since we only need one letter
    static void Output()//this is the method we use for printing the letters in the console
    {
        while (true)//this is a while loop that runs while true, and we never set it to false so it runs infinitely
        {
            Console.Write(ch);//this is used to write the char in console
            Thread.Sleep(10);//Makes the thread sleep for 0.01 seconds
        }
    }

    static void Input()//This is the method we use to read from the console
    {
        string input = "";//variable where we store the users input
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);//waits for the users input and stores the input in the keyinfo variable
            if (keyInfo.Key == ConsoleKey.Enter)//If the user pressed enter we update the "ch" variable with the users input
            {
                ch = input.Length > 0 ? input[0] : '*';//if the user did not input anything it shows the star instead
                input = "";//reset the input variable
            }
            else
            {
                input += keyInfo.KeyChar;//Puts the input into the input variable
            }
        }
    }

    static void Main(string[] args)
    {
        Thread output = new Thread(Output);//Creats the thread for output
        Thread input = new Thread(Input);//creates the thread for input
        //Starts the threads
        output.Start();
        input.Start();
    }
}
