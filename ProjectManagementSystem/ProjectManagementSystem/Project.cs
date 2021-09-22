using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int ProjectID { get; set; }
        public string Name { get; set; }
       
    }
}
