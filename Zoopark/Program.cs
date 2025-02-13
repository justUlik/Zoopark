using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Zoopark;

namespace Zoo;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<VeterinaryClinic>()
            .AddSingleton<Zoopark.Zoo>()
            .BuildServiceProvider();

        var zoo = serviceProvider.GetService<Zoopark.Zoo>();

        MainMenu(zoo);
    }

    static void MainMenu(Zoopark.Zoo zoo)
    {
        do
        {
            Console.WriteLine("Welcome to the Zoo! Here the actions you can make. Type the action number which you want to perform");
            Console.WriteLine("1. Add new animal");
            Console.WriteLine("2. Get animal food report");
            Console.WriteLine("3. Get the list of animals which can go to petting zoo");
            Console.WriteLine("4. Get inventory list");

            CheckUserAnswer(1, 4, out var userAnswer);

            switch (userAnswer)
            {
                case 1:
                    GetNewAnimal(zoo);
                    break;
                case 2:
                    zoo.PrintFoodReport();
                    break;
                case 3:
                    zoo.PrintContactZooAnimals();
                    break;
                case 4:
                    zoo.PrintInventory();
                    break;
            }
            
            Console.WriteLine("Press any symbol to perform other actions or press ESCAPE to finish program");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }

    static void GetNewAnimal(Zoopark.Zoo zoo)
    {
        Console.WriteLine("We have 4 types of animal. Select one");
        Console.WriteLine("1. Rabbit");
        Console.WriteLine("2. Tiger");
        Console.WriteLine("3. Monkey");
        Console.WriteLine("4. Wolf");

        CheckUserAnswer(1, 4, out var animalType);

        Console.WriteLine($"Input its inventory number from 0 to {int.MaxValue}");
        CheckUserAnswer(0, int.MaxValue, out var inventoryNumber);

        Console.WriteLine($"Input food amount per day from 0 to {int.MaxValue}");
        CheckUserAnswer(0, int.MaxValue, out var amountFood);

        int kindnessLevel = 0;
        if (animalType == 1 || animalType == 3)
        {
            Console.WriteLine($"Input kindness level from 0 to 10");
            CheckUserAnswer(0, 10, out kindnessLevel);
        }

        Animal animal;
        switch (animalType)
        {
            case 1:
                animal = new Rabbit(inventoryNumber, amountFood, kindnessLevel);
                zoo.AddAnimal(animal);
                break;
            case 2:
                animal = new Tiger(inventoryNumber, amountFood);
                zoo.AddAnimal(animal);
                break;
            case 3:
                animal = new Monkey(inventoryNumber, amountFood, kindnessLevel);
                zoo.AddAnimal(animal);
                break;
            case 4:
                animal = new Wolf(inventoryNumber, amountFood);
                zoo.AddAnimal(animal);
                break;
        }
    }

    static void CheckUserAnswer(int low, int high, out int userAnswer) 
    {
        while (!int.TryParse(Console.ReadLine(), out userAnswer) || !(low <= userAnswer && userAnswer <= high))
        {
            Console.WriteLine($"We have only {high} actions. Type just digit:");
        }
    }
}