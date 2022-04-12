using System;
using System.Collections.Generic;
public static class BusinessLogic {

  public static void goToOption (ConsoleKeyInfo input){

      Console.Clear();
      string option= input.KeyChar.ToString();
      switch (option)
      {
          case "1":
             Options.showAllEmployees();
             break;
          case "2":
             RaiseOnSalary();
             break;
          case "3":
             AddEmployee();
             break;
          case "4":
             Environment.AppIsRunning= false;             
             break;
          default:
           Options.showError("Your selected option is wrong!");
           break;
      }      
  }

   public static void setAllEmployeesOnStore(){
       Environment.StoreListEmployee= Mocks.getAllEmployees();       
   }

   public static void RaiseOnSalary(){

      List<Employee> updateStoreEmployeeList= new List<Employee>();
      foreach (var employee in Environment.StoreListEmployee)
      {
         CalculateRaise(employee.Salary);
         updateStoreEmployeeList.Add(employee); 
      }
      Environment.StoreListEmployee= updateStoreEmployeeList;
      Options.ShowRaiseInfo();
   }

   private static void CalculateRaise(Salary salary){
      const int RAISE_PERCENT= 3;
      double oldSalary =salary.SalaryBaseAmount; 
      double newsalary= oldSalary + (oldSalary * RAISE_PERCENT / 100);
      salary.SalaryBaseAmount= newsalary;
   }

   public static void AddEmployee(){     
      try
      {
         Employee employee= ReadInfoEmployeeWritedByUser();
         Environment.StoreListEmployee.Add(employee);    
      }
      catch (System.Exception ex)
      {                  
      }
     
   }

   private static Employee  ReadInfoEmployeeWritedByUser(){

      Console.Clear();
      Console.WriteLine("IMPORTANT!: Let empty fields and press Enter on all inputs for exit option.");
      Console.Write("First name: ");
      var firstName = Console.ReadLine();
      
      Console.Write("Last name: ");
      var lastName = Console.ReadLine();

      Console.Write("Has UnionBuilders (Yes/Not): ");
      var hasUnionBuilders = Console.ReadLine();

      Console.Write("Collective Agreement Percent: ");
      var collectiveAgreementPercent = Console.ReadLine();

      Console.Write("Experience Years: ");
      var experienceYears = Console.ReadLine();
      
      Console.Write("Tax (%): ");
      var tax = Console.ReadLine();
      
      Console.Write("Salary Base Amount: ");
      var salaryBaseAmount = Console.ReadLine();

      if (firstName==string.Empty &&
         lastName== string.Empty &&
         hasUnionBuilders== string.Empty &&
         collectiveAgreementPercent== string.Empty &&
         experienceYears == string.Empty &&
         tax == string.Empty &&
         salaryBaseAmount == string.Empty) throw new Exception("Data was wrong.Not save employee.");

      return new Employee(){
         FirstName= firstName,
         LastName= lastName,
         Salary= new Salary(){
            CollectiveAgreementPercent=int.Parse(collectiveAgreementPercent),
            ExperienceYears=int.Parse(experienceYears),
            hasUnionBuilders= hasUnionBuilders=="Yes"?true:false,
            SalaryBaseAmount= double.Parse(salaryBaseAmount),
            Tax= int.Parse(tax)         
         }
      };
   }

}