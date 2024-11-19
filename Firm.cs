using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class Firm
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Direction { get; set; }
        public string Adress { get; set; }
        public string Director { get; set; }
        public int WorkersCount { get; set; }
        public List<Worker> Workers { get; set; }

public Firm(){
WriteLine("Enter the name: ");
Name = ReadLine();

WriteLine("Enter a date of the foundation: ");
string t = ReadLine();
DateTime time = DateTime.Parse(t);
Created = time;

WriteLine("Enter the direction: ");
Direction = ReadLine();

WriteLine("Enter the adress: ");
Adress = ReadLine();

WriteLine("Enter the director: ");
Director = ReadLine();

WriteLine("Enter count of workers: ");
string w = ReadLine();
int workers = int.Parse(w);
WorkersCount = workers;
Workers = new List<Worker>();

}

public Firm(string name, DateTime created, string direction, string adress, string director, int workersCount){
    Name = name;
    Created = created;
    Direction = direction;
    Adress = adress;
    Director = director;
    WorkersCount = workersCount;
    Workers = new List<Worker>();
}


    }


    class Program
{
    static void Main()
    {
//  Получить информацию обо всех фирмах
//  Получить фирмы, у которых в названии есть слово Food
//  Получить фирмы, которые работают в области маркетинга
//  Получить фирмы, которые работают в области маркетинга или IT
//  Получить фирмы с количеством сотрудников, большем 100
//  Получить фирмы с количеством сотрудников в диапазоне от
// 100 до 300
//  Получить фирмы, которые находятся в Лондоне
//  Получить фирмы, у которых фамилия директора White
//  Получить фирмы, которые основаны больше двух лет назад
//  Получить фирмы со дня основания, которых прошло 123 дня
//  Получить фирмы, у которых фамилия директора Black и
// название фирмы содержит слово White

//  Получить всех сотрудников конкретной фирмы
//  Получить всех сотрудников конкретной фирмы, у которых
// заработные платы больше заданной
//  Получить сотрудников всех фирм, у которых должность
// менеджер
//  Получить сотрудников, у которых телефон начинается с 123
//  Получить сотрудников, у которых Email начинается с di
//  Получить сотрудников, у которых имя Lionel

 Firm[] firms = new Firm[]
{
    new Firm("Tech Solutions", new DateTime(2005, 3, 15), "IT Services", "123 Elm St, London", "John Doe", 150),
    new Firm("Green Food Co.", new DateTime(2010, 6, 20), "Food Industry", "456 Oak Ave, New York", "Jane Smith", 50),
    new Firm("Urban Builders", new DateTime(1998, 11, 1), "Construction", "789 Pine Rd, Springfield", "Alice Johnson", 200),
    new Firm("Healthy Foods", new DateTime(2022, 7, 1), "Food Services", "321 Maple St, London", "Bob Brown", 75),
    new Firm("White Marketing", new DateTime(2021, 1, 10), "Marketing", "222 Cherry St, London", "Jack White", 120)
};

     
        List<Worker> workers = new List<Worker> {
new Worker("Alice Johnson", "Engineer", "123-456-7890", "alice.johnson@example.com", 60000), 
new Worker("Bob Williams", "Manager", "987-654-3210", "bob.williams@example.com", 80000),
new Worker("Charlie Brown", "Developer", "555-555-5555", "charlie.brown@example.com", 70000),
new Worker("Aarne Cooper", "Director", "777-777-7777", "aarne.cooper@example.com", 100000),
new Worker("Drake Metroboomim", "Singer", "111-111-1111", "drake.metro@example.com", 999999),
       };


//  Получить информацию обо всех фирмах

        // var task1 = from f in firms select f;
        // var task1 = firms.Select(f => f);
        // foreach(var f in task1){
        //     Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
        // }


//  Получить фирмы, у которых в названии есть слово Food

// var task2 = from f in firms where f.Name.Contains("Food") select f;
// var task2 = firms.Where(f => f.Name.Contains("Food"));
  // foreach(var f in task2){
        //     Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
        // }


        //  Получить фирмы, которые работают в области маркетинга
        
        // var task3 = from f in firms where f.Direction == "Marketing" select f;
        // var task3 = firms.Where(f => f.Direction == "Marketing");
          // foreach(var f in task3){
        //     Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
        // }


//  Получить фирмы, которые работают в области маркетинга или IT

//  var task3 = from f in firms where f.Direction == "Marketing" && f.Direction == "IT" select f;
//         var task3 = firms.Where(f => f.Direction == "Marketing" && f.Direction == "IT");
//           foreach(var f in task3){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }



//  Получить фирмы с количеством сотрудников, большем 100

// var task4 = from f in firms where f.WorkersCount > 100 select f;
// var task4 = firms.Where(f => f.WorkersCount > 100);
//           foreach(var f in task4){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }



//  Получить фирмы с количеством сотрудников в диапазоне от
// 100 до 300

// var task5 = from f in firms where f.WorkersCount > 100 && WorkersCount < 300 select f;
// var task5 = firms.Where(f => f.WorkersCount > 100 && f.WorkersCount < 300);
//           foreach(var f in task5){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }


//  Получить фирмы, которые находятся в Лондоне

// var task6 = from f in firms where f.Adress.Contains("London") select f;
// var task6 = firms.Where(f => f.Adress.Contains("London"));
//           foreach(var f in task6){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }


//  Получить фирмы, у которых фамилия директора White

// var task7 = from f in firms where f.Director.Contains("White") select f;
// var task7 = firms.Where(f => f.Director.Contains("White"));
//           foreach(var f in task7){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }

//  Получить фирмы, которые основаны больше двух лет назад

// var twoYearsAgo = DateTime.Now.AddYears(-2);
// var task8 = from f in firms where f.Created > twoYearsAgo select f;
// var task8 = firms.Where(f => f.Created > twoYearsAgo);
//           foreach(var f in task8){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }


//  Получить фирмы со дня основания, которых прошло 123 дня

// var task9 = from f in firms where (DateTime.Now - f.Created).TotalDays == 123 select f;
// var task9 = firms.Where(f => (DateTime.Now - f.Created).TotalDays == 123);
//           foreach(var f in task9){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }



//  Получить фирмы, у которых фамилия директора Black и
// название фирмы содержит слово White

// var task10 = from f in firms where f.Direction.Contains("Black") && f.Name.Contains("White") select f;
// var task10 = firms.Where(f => f.Direction.Contains("Black") && f.Name.Contains("White"));
//           foreach(var f in task10){
//             Write(f.Name + f.Created + f.Direction + f.Adress + f.Director + f.WorkersCount + "\t");
//         }






//  Получить всех сотрудников конкретной фирмы

// var firm = firms[0];
// firm.Workers = workers;
// var task11 = from w in firm.Workers select w;
// var task11 = firm.Workers.Select(w => w);
//           foreach(var w in task11){
//             Write(w.Name + w.Position + w.Phone + w.Salary + "\t");
//         }




//  Получить всех сотрудников конкретной фирмы, у которых
// заработные платы больше заданной

// int salary = 50000;
// var firm = firms[0];
// firm.Workers = workers;
// var task12 = from w in firm.Workers where w.Salary > salary select w;
// var task11 = firm.Workers.Select(w => w);
//           foreach(var w in task12){
//             Write(w.Name + w.Position + w.Phone + w.Salary + "\t");
//         }



//  Получить сотрудников всех фирм, у которых должность
// менеджер

// var task13 = from firm in firms from worker in firm.Workers where worker.Position == "Manager" select worker;
// var task13 = firms.Select(firm => firm.Workers).Where(worker => worker.Position == "Manager");

//           foreach(var w in task13){
//             Write(w.Name + w.Position + w.Phone + w.Salary + "\t");
//         }



//  Получить сотрудников, у которых телефон начинается с 123
// var task14 = from firm in firms from worker in workers where worker.Phone.StartsWith("123") select worker;
// var task14 = firms.SelectMany(firm => firm.Workers).Where(worker => worker.Phone.StartsWith("123"));
//           foreach(var w in task14){
//             Write(w.Name + w.Position + w.Phone + w.Salary + "\t");
//         }



//  Получить сотрудников, у которых Email начинается с di

// var task15 = from w in workers where w.Email.ToLower().StartsWith("di") select w;
// var task15 = workers.Where(w => w.Email.ToLower().StartsWith("di"));
//           foreach(var w in task15){
//             Write(w.Name + w.Position + w.Phone + w.Salary + "\t");
//         }


//  Получить сотрудников, у которых имя Lionel
// var task16 = from w in workers where w.Name.ToUpper().Contains("Lionel") select w;
// var task16 = workers.Where(w => w.Name.ToUpper().Contains("Lionel"));
//           foreach(var w in task16){
//             Write(w.Name + w.Position + w.Phone + w.Salary + "\t");
//         }
    }
}
}