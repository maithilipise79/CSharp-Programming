using EmployeeManagement.DAL;
using EmployeeManagement.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public class EmployeeService
    {
        EmployeeRepository repo = new EmployeeRepository();

        public void Add(Employee e)
        {
            if (string.IsNullOrEmpty(e.Name))
            {
                Console.WriteLine("Invalid Name");
                return;
            }
            repo.Add(e);
        }

        public List<Employee> GetAll() => repo.GetAll();
        public void Update(Employee e) => repo.Update(e);
        public void Delete(int id) => repo.Delete(id);

    }
}
