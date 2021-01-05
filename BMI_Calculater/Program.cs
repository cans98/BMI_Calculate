using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
			
				double height;
				double weight;


				//prompting user for weight in kg and height in cm
				try
				{
					Console.WriteLine("Enter your height in meter: ");
					height = Convert.ToDouble(Console.ReadLine());
				    height = height / 100;

					Console.WriteLine("Enter your weight in kg: ");
					weight = Convert.ToDouble(Console.ReadLine());

					//bmi formula
					double bmi = weight / (height * height);

				    



					//using if statements to determine whether the user is normal weight, underweight, overweight or obesity


					if (bmi < 18)

					{


						Console.WriteLine("Your BMI is {0}. You are underweight.", bmi);



					}
					else if (bmi >= 18 && bmi < 25)
					{

						Console.WriteLine("Your BMI is {0}. You are normal weight.", bmi);

					}
					else if (bmi >= 25 && bmi < 30)

					{


						Console.WriteLine("Your BMI is {0}. You are overweight.", bmi);


					}
					else if (bmi >= 30 && bmi < 35)

					{


						Console.WriteLine("Your BMI is {0}. You are obesity class I.", bmi);


					}
					else if (bmi >= 35 && bmi < 40)

					{


						Console.WriteLine("Your BMI is {0}. You are obesity class II.", bmi);


					}
					else
					{
						Console.WriteLine("Your BMI is {0}. You are obesity class III.", bmi);
					}


				}

				catch (Exception error)
				{
					Console.WriteLine("An error occurred" + error.Message);

				}



				Console.ReadLine();

			
		}
	}
}
    

