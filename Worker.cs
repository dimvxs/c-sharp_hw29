using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace hw1
{
    public class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }


        public Worker(){
            WriteLine("Enter name: ");
            Name = ReadLine();  

            WriteLine("Enter surname: ");
            Position = ReadLine();  

            WriteLine("Enter phone: ");
            Phone = ReadLine();  

            WriteLine("Enter email: ");
            Email = ReadLine();  

            WriteLine("Enter salary: ");
            string s = ReadLine();   
            int salary = int.Parse(s);
            Salary = salary;         
        }

        public Worker(string name, string position, string phone, string email, int salary){
            Name = name;
            Position = position;
            Phone = phone;
            Email = email;
            Salary = salary;
        }
        
  
        }
        
    
 
}