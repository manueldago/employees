using System;

namespace ProjEmployees
{
    class Program
    {
        static void Main(string[] args)
        {          
           Environment.AppIsRunning= true;
           BusinessLogic.setAllEmployeesOnStore();  
           while(Environment.AppIsRunning)
           {
             Options.write();
             BusinessLogic.goToOption(Console.ReadKey());                     
           }               
        }
    }
}
