using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
        public static string weightValue;
        public static string BMIValue;
        public static string heightValue;
        public static string heightValidationInput;
        public static string weightValidationInput;
        static bool isHeightValid = true;
        static bool isWeightValid = true;
        public static System.Globalization.CultureInfo InvaiantCulture { get; }

        public static void Demo()
        {
            GreetingMaker();
            DataCollection();
            CalculateBMI(weight, height);
            InformationDisplay();
        }



        //Greeting makers function to introduce the program, only run ones for the two bmi checks
        public static void GreetingMaker()
        {
            Console.WriteLine("Welcome to my BMI Checker, made by Syedog");
            return;
        }



        //This will type out the inputted string, usually used to ask for inputs from the user on the same line as the last
        public static void InputPromptText(string promptMessage)
        {
            Console.Write(promptMessage);
        }



        //Handles collection of the variables for this BMI calculator
        public static void DataCollection()
        {
            NameTaker();
            AgeTaker();
            HeightTaker();
            WeightTaker();
            Console.WriteLine("");
            return;
        }


        public static string NameTaker()
        {
            InputPromptText("Please input your full name: ");
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

        public static string AgeTaker()
        {
            InputPromptText("Please input your age in years: ");

            ageValidationInput = Console.ReadLine();
            age = ParseAge(ageValidationInput);

            if (age == -1)
            {
                ageValue = "Age is Invalid";
                Console.WriteLine(ageValue);
            }
            else
            {
                ageValue = age.ToString();
            }
            return ageValue;


            static int ParseAge(string ageValidationInput)
            {
                var isNumber = int.TryParse(ageValidationInput, out age);
                //Console.WriteLine(isNumber);
                //Console.WriteLine(age);

                if (!isNumber) return age = -1;
                bool isValidAge = age < 200 && age >= 0;
                if (!isValidAge) return age = -1;
                //Console.WriteLine(age);
                return age;
            }
        }

        public static double HeightTaker()
        {
            InputPromptText("Please input your Height in meters: ");

            heightValidationInput = Console.ReadLine();
            height = ParseHeight(heightValidationInput);

            if (height == -1)
            {
                heightValue = "Height cannot be equal or less than zero, but was input as " + heightValidationInput;
                Console.WriteLine(heightValue);
            }
            else if (height == -2)
            {
                heightValue = "Height is invalid, height needs to be a number, but was input as " + heightValidationInput;
                Console.WriteLine(heightValue);
            }
            else
            {
                return height;
            }
            return height;


            static float ParseHeight(string heightValidationInput)
            {
                var isNumber = float.TryParse(heightValidationInput, out height);

                if (!isNumber) return height = -2;
                bool isHeightValid = height >= 1;
                if (!isHeightValid) return height = -1;
                return height;
            }

        }

        public static float WeightTaker()
        {
            InputPromptText("Please input your Weight in kg: ");

            weightValidationInput = Console.ReadLine();
            weight = ParseWeight(weightValidationInput);

            if (weight == -1)
            {
                weightValue = "Weight cannot be equal or less than zero, but was input as " + weightValidationInput;
                Console.WriteLine(weightValue);
            }
            else if (weight == -2)
            {
                weightValue = "Weight is invalid, weight needs to be a number, but was input as " + weightValidationInput;
                Console.WriteLine(weightValue);
            }
            else
            {
                return weight;
            }
            return weight;


            static float ParseWeight(string weightValidationInput)
            {
                var isNumber = float.TryParse(weightValidationInput, out weight);

                if (!isNumber) return weight = -2;
                bool isWeightValid = weight >= 1;
                if (!isWeightValid) return height = -1;
                return weight;
            }
        }




        public static float CalculateBMI(float weight, float height)
        {
            if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason: Weight cannot be equal or less than zero, but was input as " + weightValidationInput);
                isWeightValid = false;
            }

            if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason: Height cannot be equal or less than zero, but was input as " + heightValidationInput);
                isHeightValid = false;
                return -1;
            }
            
            if (isHeightValid && isWeightValid)
            {
                BMI = (weight / height / height);
                return BMI;
            }
            return BMI;

        }



        public static void InformationDisplay()
        {
            Console.WriteLine("Result for " + fullName + ": ");
            Console.WriteLine("Age: " + ageValue + " Height: " + height + " Weight: " + weight);

            if (!isWeightValid)
            {
                Console.WriteLine("BMI Failed to Calculate due to Weight Input Error");
            }
            else if (!isHeightValid)
            {
                Console.WriteLine("BMI Failed to Calculate due to Height Input Error");
            }
            else
            {
                Console.WriteLine("BMI Calculated to: " + Math.Round(BMI, 1));
                Console.WriteLine("");
            }
            return;
        }
    }
}
