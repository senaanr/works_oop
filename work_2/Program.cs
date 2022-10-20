using System.ComponentModel;
using Emp;

class Program
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager();

        Employee employee = new Employee(0, "Hasan", "Kemik");
        Employee employee1 = new Employee(1, "Leyla", "Çoban");
        Employee employee2 = new Employee(2, "Sevgi", "Al");
        Employee employee3 = new Employee(3, "Kara", "Ver");
        Console.WriteLine(employee.FirstName);
        Console.WriteLine(employee1.FirstName);
        Console.WriteLine(employee2.FirstName);
        Console.WriteLine(employee3.FirstName);

        manager.Add(employee);
        manager.Add(employee1);
        
        manager.Show();
        manager.Remove(3);
        manager.Show();


    }
}
