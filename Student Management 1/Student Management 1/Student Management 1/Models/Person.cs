using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_1
{
    public class Person
    {
      



        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }   
        public int Department { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; } 
        
         
       
    }
}
