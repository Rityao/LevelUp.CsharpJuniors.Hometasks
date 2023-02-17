// See https://aka.ms/new-console-template for more information
using Lesson3.Categories.Subcategories;

DateTime dateExpired = new(2024, 7, 20);
var protein = new Protein(dateExpired, "LevelUp", "sweety and healthy", 1231, 12312);
protein.PrintInfo();
