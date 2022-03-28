using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        static string fullName = "";
        static int Age;
        static double Height;
        static double Weight;
        static double BMI;
        static string welcomeMessage = "Welcome to the BMI calculator made by Syedog";

        public static void Demo()
        {
            greetingMessage();
            inputPromptText("Please input your full name: ", fullName);
        
        }



        public static void greetingMessage()
        {
            Console.WriteLine(welcomeMessage);
            return;
        }

        public static void inputPromptText (string promptMessage, string fullName)
        {
            Console.Write(promptMessage);
            fullName = Console.ReadLine();
            Console.WriteLine(fullName);
        }

        public static void inputPromptInt()
        {

        }
    }
}
