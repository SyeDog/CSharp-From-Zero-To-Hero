using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static string fullName = "";
        public static int age;
        public static string ageValidationInput;
        public static bool isVaildAge;
        public static float height;
        public static float weight;
        public static float BMI;
        public static bool isNumber;
        public static string ageValue;

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
        public static void inputPromptText(string promptMessage)
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

            if (string.IsNullOrEmpty(fullName))
            {
                Console.WriteLine("Name Cannot be Empty"); return "-";
            }
            else
            {
                return fullName;
            }
        }

        public static string ageTaker()
        {
            inputPromptText("Please input your age in years: ");

            ageValidationInput = Console.ReadLine();
            age = ParseAge(ageValidationInput);

            if (age == -1)
            {
                ageValue = "Age is Invalid";
            }
            else
            {
                ageValue = age.ToString();
            }
            return ageValue;

            static int ParseAge(string ageValidationInput)
            {
                var isNumber = int.TryParse(ageValidationInput, out age);
                Console.WriteLine(isNumber);
                Console.WriteLine(age);

                if (!isNumber) return age = -1;
                bool isValidAge = age < 200 && age >= 0;
                if (!isValidAge) return age = -1;
                Console.WriteLine(age);
                return age;
            }
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
            Console.WriteLine("Age: " + ageValue + " Height: " + height + " Weight: " + weight);
            Console.WriteLine("BMI Calculated to: " + Math.Round(BMI, 1));
            Console.WriteLine("");
            return;
        }
    }
}
