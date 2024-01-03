using HRAPP.Entities;
using HRAPP.Services;
using HRAPP.Controllers;
using HRAPP.Views;
using System;

public class Program{
    static void Main()
    {
        int choice;
do{
Console.WriteLine("Welcome to MVC in C#");
Console.WriteLine("Welcome");
Console.WriteLine("Enter Your Choice");
Console.WriteLine("0: EXIT 1: Add Employee 2: Show All Employees 3:Delete Employee");
choice=int.Parse(Console.ReadLine());
switch(choice)
{
    case 1:
    IEmployeeService svc=new EmployeeService();
    EmployeesController controller=new EmployeesController(svc);
    Console.WriteLine("Enter Employee ID,name,Department,email");
    Employee emp=new Employee(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
    controller.Insert(emp);
    break;

    case 2:
    IEmployeeService svc2=new EmployeeService();
    EmployeesController controller2=new EmployeesController(svc2);
    List<Employee> model=controller2.GetAll();
    ListView view=new ListView(model);
    view.Render();
    break;

    case 3:
    IEmployeeService svc3=new EmployeeService();
    EmployeesController controller3=new EmployeesController(svc3);
    Console.WriteLine("Enter the Employee ID");
    controller3.Delete(int.Parse(Console.ReadLine()));
    break;

    case 0:
    Console.WriteLine("ThankYou");
    break;

    default:
    Console.WriteLine("Please Enter correct Choice");
    break;

}

Console.WriteLine("Welcome to MVC in C#");
}while(choice!=0);
    }
}


