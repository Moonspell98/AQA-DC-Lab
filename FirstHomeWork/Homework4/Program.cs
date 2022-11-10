// See https://aka.ms/new-console-template for more information
using Homework4.Factories;
using Homework4Library;

Worker worker = new Worker("Jack", "Most", 24, "CTO", 1244);

//worker.ChangeData();
//worker.ShowFullName();
//worker.ShowTitle();

Factory factory = new Factory("Bridges");
factory.AddWorkers(2);
factory.GetWorker(1).ChangeData();
factory.GetWorker(1).ShowFullName();