using System;
using System.Collections.Generic;

public static class Mocks
{
    public static List<Employee> getAllEmployees(){
        
        return new List<Employee>(){

            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=true,
                      CollectiveAgreementPercent=25,
                      ExperienceYears=3,
                      Tax= 25,
                      SalaryBaseAmount=2100
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      Tax= 25,
                      SalaryBaseAmount=1900
                 }
            },

            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=true,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=5,
                      Tax= 25,
                      SalaryBaseAmount=2100
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=10,
                      Tax= 25,
                      SalaryBaseAmount=2100
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      Tax= 25,
                      SalaryBaseAmount=2100
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      Tax= 25,
                      SalaryBaseAmount=2100
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      Tax= 25,
                      SalaryBaseAmount=2100
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      SalaryBaseAmount=2100,
                      Tax= 25
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      SalaryBaseAmount=2100,
                      Tax=25
                 }
            },
            new Employee(){
                 FirstName="Mike",
                 LastName="Douglas",
                 Salary= new Salary(){
                      hasUnionBuilders=false,
                      CollectiveAgreementPercent=20,
                      ExperienceYears=3,
                      SalaryBaseAmount=2100,
                      Tax=25
                 }
            }
        };
    }


}