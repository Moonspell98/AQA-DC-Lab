// See https://aka.ms/new-console-template for more information
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

var employees = new List<int> { 1, 2, 3 };
LinkedList<int> people = new LinkedList<int>(employees);

LinkedListTask1.InsetElements(1, 2, people);

foreach(var employee in people)
{
    Console.WriteLine(employee);
}