using Business.Concrete;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleUI
{
    class Program
    {
        static int getDelayAmountFromUser()
        {
            int delayAmount = 0;
            bool userEnteredDelayTime = false;
            do
            {
                try
                {
                    Console.WriteLine("Please enter the time waiting time for each example to display on the screen: ");
                    delayAmount = Convert.ToInt32(Console.ReadLine());
                    delayAmount *= 1000;
                    userEnteredDelayTime = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter the correct input !!!");
                }

            } while (userEnteredDelayTime == false);

            return delayAmount;
        }

        static void Question1()
        {
            CarManager carManager = new CarManager(new LocalFakeDbCarDal());

            int carCount = 0;
            Console.WriteLine("\n******       First Example All cars:       ******\n");
            foreach (var car in carManager.ReturnAll())
            {
                Console.WriteLine("__________________________________________");
                Console.WriteLine(++carCount + ". Car's Details: ");
                Console.WriteLine("Car ID: " + car.CarId);
                Console.WriteLine("BrandID: " + car.BrandId);
                Console.WriteLine("ColorID: " + car.ColorId);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("ModelYear: " + car.ModelYear);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("__________________________________________");
            }
            Console.WriteLine(carCount + " Cars Found.");
        }

        static void Question2()
        {
            CarManager carManager = new CarManager(new LocalFakeDbCarDal());

            int carCount = 0;
            int desiredId = 222;
            Console.WriteLine("\n******       Second Example Car whose ID is " + desiredId + ":       ******\n");

            Car searchedCar = new Car
            {
                BrandId = 0,
                CarId = 0,
                ColorId = 0,
                DailyPrice = 0,
                Description = "None",
                ModelYear = "0000"
            };
            searchedCar = carManager.ReturnAllBySelf(desiredId);
            if (searchedCar != null)
            {
                Console.WriteLine("__________________________________________");
                Console.WriteLine(++carCount + ". Car's Details: ");
                Console.WriteLine("Car ID: " + searchedCar.CarId);
                Console.WriteLine("Description: " + searchedCar.Description);
                Console.WriteLine("__________________________________________");
                Console.WriteLine(carCount + " Cars Found.");
            }
            else
            {
                Console.WriteLine("There is no such car with given ID");
            }
        }

        static void Question3()
        {
            CarManager carManager = new CarManager(new LocalFakeDbCarDal());

            int carCount = 0;
            Console.WriteLine("\n******       Third Example All cars whose colorId is 3:       ******\n");

            foreach (var car in carManager.ReturnAllByColor(3))
            {
                Console.WriteLine("__________________________________________");
                Console.WriteLine(++carCount + ". Car's Details: ");
                Console.WriteLine("Car ID: " + car.CarId);
                Console.WriteLine("ColorID: " + car.ColorId);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("__________________________________________");
            }
            Console.WriteLine(carCount + " Cars Found.");
        }

        static void Question4()
        {
            CarManager carManager = new CarManager(new LocalFakeDbCarDal());

            int carCount = 0;
            Console.WriteLine("\n******       Fourth Example All cars whose brandId is 2:       ******\n");

            foreach (var car in carManager.ReturnAllByBrand(2))
            {
                Console.WriteLine("__________________________________________");
                Console.WriteLine(++carCount + ". Car's Details: ");
                Console.WriteLine("Car ID: " + car.CarId);
                Console.WriteLine("Brand ID: " + car.BrandId);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("__________________________________________");
            }
            Console.WriteLine(carCount + " Cars Found.");
        }

        static void WaitAndGetNextQuestion(int afterMiliseconds, List<Action> allQuestions)
        {
            foreach (var question in allQuestions)
            {
                question.DynamicInvoke();
                Thread.Sleep(afterMiliseconds);
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            //IEntity entity = new Brand();
            int delayAmount = getDelayAmountFromUser();

            CarManager carManager = new CarManager(new LocalFakeDbCarDal());

            List<Action> allQuestions = new List<Action>();
            allQuestions.Add(Question1);
            allQuestions.Add(Question2);
            allQuestions.Add(Question3);
            allQuestions.Add(Question4);

            WaitAndGetNextQuestion(delayAmount, allQuestions);
        }
    }
}
