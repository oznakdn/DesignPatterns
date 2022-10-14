using WithStaticMethods;

Employee employee = Employee.CreateNewEmployee(1,"Ahmet","Koşar","IT");
employee.Salary=2500;
employee.Work(employee.Firstname,employee.Lastname, employee.Department);
employee.TotalSalaryCalculate(employee.Salary);

