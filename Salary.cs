public class Salary
{
  public double SalaryBaseAmount { get; set; }
  public int  CollectiveAgreementPercent {get;set;}
  public int ExperienceYears {get;set;}
  public bool hasUnionBuilders {get;set;}
  public double Tax {get;set;}
  public double GetSalaryAfterTaxes(){    
    double salary = this.SalaryBaseAmount - (this.SalaryBaseAmount * Tax / 100);        
    var salaryWithExperiencePercent = ApplyExperiencePercentOnSalary(salary);
    return salaryWithExperiencePercent;
  }
  private double ApplyExperiencePercentOnSalary(double salary){

    const int FIVE_YEAR_PERCENT= 5;
    const int TEN_YEAR_PERCENT = 10;
    
    if (ExperienceYears == 5)
        salary = salary + (salary * FIVE_YEAR_PERCENT /100);
    else if (ExperienceYears == 10)
        salary = salary + (salary * TEN_YEAR_PERCENT /100);    
    
    return salary;
  }
}