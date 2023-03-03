using Lesson3.Categories.Subcategories;

DateTime dateExpired = new(2024, 7, 20);
var protein = new Protein(dateExpired, "LevelUp", "sweety and healthy", 999, 999);
protein.PrintInfo();
protein.Expired(dateExpired);