using System;
using System.Collections.Generic;
using System.Text;
using Console = System.Console;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static string fullName = "";
        static int Age;
        static double height;
        static double weight;
        static double BMI;

        public static void Demo()
        {
            greetingMaker();
            dataCollection();
            calculateBMI(height, weight);
            informationDisplay();
        }



        //Greeting makers function to introduce the program, only run ones for the two bmi checks
        public static void greetingMaker()
        {
            Console.WriteLine("Welcome to my BMI Checker, made by Syedog");
            return;
        }



        //This will type out the inputted string, usually used to ask for inputs from the user on the same line as the last
        public static void inputPromptText (string promptMessage)
        {
            Console.Write(promptMessage);
        }



        //Handles collection of the variables for this BMI calculator
        public static void dataCollection()
        {
            inputPromptText("Please input your full name: ");
            fullName = Convert.ToString(Console.ReadLine());

            inputPromptText("Please input your age in years: ");
            Age = Convert.ToInt32(Console.ReadLine());

            inputPromptText("Please input your Height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            inputPromptText("Please input your Weight in kg: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            return;
        }



        public static double calculateBMI(double height, double weight)
        {
            BMI = (weight / height / height);
            return BMI;
        }



        public static void informationDisplay()
        {
            Console.WriteLine("Result for " + fullName + ": ");
            Console.WriteLine("Age: " + Age + " Height: " + height + " Weight: " + weight);
            Console.WriteLine("BMI Calculated to: " + Math.Round(BMI, 1));
            Console.WriteLine("");
            return;
        }
    }
}
