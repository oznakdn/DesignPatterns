public class Employee
{
    public int No { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    public string DepartmentManaged { get; set; }
    public double Bonus { get; set; }

    public void Work(){}
    public int GetNo(int no){return no;}
    public string GetName(string name){return name;}
    public int GetYear(int year){return year;}


}

public class HR
{
    public HR()
    {
        
    }

    public List<Employee>GetEmployees(){return null;}
    public Employee GetNumberOfEmployee(int id){return null;}
    public void AddNewEmployee(Employee employee){}
}

public class Manager
{
    public Manager()
    {
        
    }

    public void Work(){}
    public void Manage(){}
    public double CalucalateSalary(){return 1;}
}

