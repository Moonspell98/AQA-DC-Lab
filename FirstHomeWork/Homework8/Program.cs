﻿// See https://aka.ms/new-console-template for more information
using Homework8.Dictionary;
using Homework8.LinkedList;
using Homework8.List;
// List Task 1/2
//List<int> list = new List<int>() { 1, 5, 2, 4, 6, 1, 19, 32, 3, 23, 3 };
//Console.WriteLine(Task1Class.SumOfEvenNumberInList(list));

// List Task 3
//List<string> listOfStrings = new List<string>() { "Hello", "Test", "Morning", "Well", "Keyboard", "Blabl", "Krato" };
//ListTask2.WriteFiveSymbolsStrings(listOfStrings);
// Using refactored method
//ListTask2.WriteStringsAsUserWants(listOfStrings);

// Linked List Task 1
//var justList = new List<int> { 1, 2, 3 };
//LinkedList<int> linkedList = new LinkedList<int>(justList);

//LinkedListTask1.InsetElements(1, 2, linkedList);

//foreach(var employee in linkedList)
//{
//    Console.WriteLine(employee);
//}

// Dictionary Task 3

var cities = new Dictionary<string, City>
{
    { "Minsk", new City(20, 200) },
    { "Warsaw", new City(21, 210) },
    { "Wroclaw", new City(10, 120) },
    { "Vilnus", new City(12, 100) },
    { "Milan", new City(9, 60) }
};

// Sort by square
var sortedCities = cities.OrderBy(_ => _.Value.sqaure).ToDictionary(_ => _.Key, _ => _.Value);
PrintDictionary(sortedCities);

// Sort by population desc

sortedCities = cities.OrderByDescending(_=>_.Value.population).ToDictionary(_ => _.Key, _ => _.Value);
PrintDictionary(sortedCities);

// Overall population

var overallPopulation = cities.Sum(_=>_.Value.population);
Console.WriteLine($"Overall Population is {overallPopulation}");

void PrintDictionary(Dictionary<string, City> dictionary)
{
    foreach (var item in dictionary)
    {
        Console.WriteLine($"Key is: {item.Key}, value {item.Value}");
    }
    Console.WriteLine();
}