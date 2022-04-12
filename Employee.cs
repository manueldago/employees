public class Employee {

    public string FirstName { get; set; }
    public string LastName { get; set; }  
    public Salary Salary { get;set; }
    
    public Employee()
    { 
        this.Salary= new Salary();  
    }
}