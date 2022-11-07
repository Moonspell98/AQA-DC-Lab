// See https://aka.ms/new-console-template for more information
using Homework4.Factories;
using Homework4Library;

Worker[] workers = new Worker[4];
workers[0] = new Worker("Jack", "Jhones", "Locksmith", 25);
workers[1] = new Worker("Gill", "O'Niel", "Welder", 34);
workers[2] = new Worker("Luke", "Brian", "Director", 43);
workers[3] = new Worker("John", "Silver");
Factory factory = new Factory(workers, "Fragile");
factory.ShowFactoryName();
factory.GetWorker(0).ShowWorkerFullName();
factory.GetWorker(3).ShowWorkerFullName();
factory.GetWorker(3).ShowWorkerAge();
factory.GetWorker(3).ShowWorkerTitle();
factory.ShowNumberOfWorkers();
factory.AddWorkers(5);

//Factory factory1 = new Factory("Bridges");
//factory1.AddWorkers(5);
//factory1.ShowFactoryName();
//factory1.GetWorker(0).ShowWorkerFullName();
