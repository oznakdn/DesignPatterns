namespace Uygulama.Department
{
    public class HumanResource
    {
        private List<Employee> employees = new List<Employee>();

		public List<Employee> GetEmployees()
		{
			return employees;
		}

		public int GetNumberOfEmployees()
		{
			return employees.Count;
		}

		public void AddNewEmployee(Employee employee)
		{
			employees.Add(employee);
		}

		public void ListEmployees()
		{
			Console.WriteLine("All Employees");
			foreach (Employee employee in employees)
				Console.WriteLine(employee);
		}
    }
}