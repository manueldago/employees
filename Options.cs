using System;
using Alba.CsConsoleFormat;
using System.Collections.Generic;
using System.Linq;
public static class Options {

    public static void ShowRaiseInfo(){
      Console.Clear();
      Console.WriteLine("Raise salary applies!");
      Console.ReadKey();
    }

    public static void write(){
        Console.Clear();
        
        Console.WriteLine("*******   Choose one option:   *******");      
        Console.WriteLine("                                       ");
        Console.WriteLine("1. List all employees");
        Console.WriteLine("2. Give a raise in salary");
        Console.WriteLine("3. Add employee");
        Console.WriteLine("4. Quit the application");
        Console.WriteLine("                                       ");        
    }

    public static void showError(string message)
    {      
        Console.WriteLine(message);
        Console.ReadKey();
    }

    public static void showAllEmployees(){       
        Console.Clear();
        ConsoleRenderer.RenderDocument (        
            new Document (
                 new Grid () {                     
                     Stroke=LineThickness.Double,
                     StrokeColor=ConsoleColor.DarkGray,
                     Columns= {
                         new Column(){ Width = GridLength.Auto},
                         new Column(){ Width = GridLength.Auto},
                         new Column(){ Width = GridLength.Auto},
                         new Column(){ Width = GridLength.Auto},
                         new Column(){ Width = GridLength.Auto},
                         new Column(){ Width = GridLength.Auto},
                         new Column(){ Width = GridLength.Auto},
                     },
                     Children={   
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, Children={ new Div("FirstName")}},                   
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, Children={ new Div("LastName")}},                   
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, Children={ new Div("Experience Years")}},
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, TextAlign=TextAlign.Center, Children={ new Div("Union Builders")}},
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, Children={ new Div("Salary")}},
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, Children={ new Div("Tax")}},
                         new Cell {Stroke=LineThickness.Double, Color=ConsoleColor.White, Children={ new Div("SalaryAfterTax")}},
                         Environment.StoreListEmployee.Select(e=> new object[]{                                                                                       
                            new Cell {Stroke=LineThickness.Single, 
                                       Color=ConsoleColor.DarkGray,                                        
                                       Children= {new Div(e.FirstName)}},

                            new Cell {Stroke=LineThickness.Single, 
                                       Color=ConsoleColor.DarkGray,                                        
                                       Children= {new Div(e.LastName)}},

                             new Cell {Stroke=LineThickness.Single, 
                                       Color=ConsoleColor.DarkGray,                                        
                                       Children= {new Div(e.Salary.ExperienceYears)}},
                             
                             new Cell {Stroke=LineThickness.Single, 
                                       Color=ConsoleColor.DarkGray,
                                       TextAlign=TextAlign.Center,                                        
                                       Children= {new Div(e.Salary.hasUnionBuilders?"√":"x")}},
                            
                            new Cell {Stroke=LineThickness.Single,

                                       Color=ConsoleColor.DarkBlue,                                        
                                       Children= {new Div(" $" + Math.Round(e.Salary.SalaryBaseAmount,2))}},
                            
                            new Cell {Stroke=LineThickness.Single, 
                                       Color=ConsoleColor.DarkBlue,                                        
                                       Children= {new Div(" %" + e.Salary.Tax)}},
                            
                            new Cell {Stroke=LineThickness.Single, 
                                       Color=ConsoleColor.DarkBlue,                                        
                                       Children= {new Div(" $" + Math.Round(e.Salary.GetSalaryAfterTaxes(),2))}},           
                         })
                     }
                 } 
                            
            )        
        );      
        Console.ReadKey();
    }
}