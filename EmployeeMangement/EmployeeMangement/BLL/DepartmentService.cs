using EmployeeManagement.DAL;
using EmployeeManagement.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public class DepartmentService
    {
        DepartmentRepository repo = new DepartmentRepository();

        public void Add(Department d)
        {
            if (string.IsNullOrEmpty(d.DepartmentName))
            {
                Console.WriteLine("Invalid Name");
                return;
            }
            repo.Add(d);
        }

        public List<Department> GetAll() => repo.GetAll();
        public void Update(Department d) => repo.Update(d);
        public void Delete(int id) => repo.Delete(id);
    }


}
