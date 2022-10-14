using Uygulama.Department;
using Uygulama.Factory;

HumanResource hr = new();
PayRollOffice po = new();

IFactory employeeFactory = new EmployeeFactory();
IFactory managerFactory = new ManagerFactory();
IFactory directorFactory = new DirectorFactory();

// Add more employees
hr.AddNewEmployee(employeeFactory.Create());
hr.AddNewEmployee(managerFactory.Create());
hr.AddNewEmployee(directorFactory.Create());

hr.ListEmployees();

Console.WriteLine();

// Now pay time!
List<Employee> employees = hr.GetEmployees();

foreach (Employee employee in employees)
    po.PaySalary(employee);
