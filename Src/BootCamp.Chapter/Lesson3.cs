using System;
using System.Collections.Generic;
using System.Text;
using Console = System.Console;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static string fullName = "";
        public static Int32 Age;
        public static float height;
        public static float weight;
        public static float BMI;

        public static void Demo()
        {
            greetingMaker();
            dataCollection();
            calculateBMI(weight, height);
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
            nameTaker();
            ageTaker();
            heightTaker();
            weightTaker();
            Console.WriteLine("");
            return;
        }


        public static string nameTaker()
        {
            inputPromptText("Please input your full name: ");
            fullName = Convert.ToString(Console.ReadLine());
            return fullName;
        }

        public static Int32 ageTaker()
        {
            inputPromptText("Please input your age in years: ");
            Age = Convert.ToInt32(Console.ReadLine());
            return Age;
        }

        public static float heightTaker()
        {
            inputPromptText("Please input your Height in meters: ");
            height = float.Parse(Console.ReadLine());
            return height;
        }

        public static float weightTaker()
        {
            inputPromptText("Please input your Weight in kg: ");
            weight = float.Parse(Console.ReadLine());
            return weight;
        }




        public static float calculateBMI(float weight, float height)
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
