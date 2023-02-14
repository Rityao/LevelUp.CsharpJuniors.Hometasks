// See https://aka.ms/new-console-template for more information
using Lesson3.Models;
DateTime dateExpired = new DateTime(2024, 7, 20);
var food = new Food(DateTime.Today, dateExpired);
food.PrintInfo();
