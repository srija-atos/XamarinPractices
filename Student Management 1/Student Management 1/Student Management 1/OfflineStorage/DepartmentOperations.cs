using Student_Management_1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_1.OfflineStorage
{
    public class DepartmentOperations
    {
        public static async void CreateDepartmentsList()
        {
            List<Departments> list = new List<Departments>
            {
                new Departments()
                {
                    ID = 1,
                    DepartmentName = "Information Technology"
                },
                new Departments()
                {
                    ID = 2,
                    DepartmentName = "Computer Science"
                },
                 new Departments()
                {
                    ID = 3,
                    DepartmentName = "Mechanical Engineering"
                },
                  new Departments()
                {
                    ID = 4,
                    DepartmentName = "Civil Engineering"
                },
                   new Departments()
                {
                    ID = 5,
                    DepartmentName = "Electrical Engineering"
                }
            };

           await App.DatabaseConnection.InsertAllAsync(list);
        }

        public static Task<List<Departments>> GetDepartmentsAsync()
        {
            //Get all notes.
            return App.DatabaseConnection.Table<Departments>().ToListAsync();
        }
    }
}
