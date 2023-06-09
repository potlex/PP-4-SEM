using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Faculty : Organization, IStaff
    {
        protected List<Department> departments = new List<Department>();

        public int addDepartment(Department ex)
        {
            return 0;
        }
        public bool delDepartment(int q)
        {
            return false;
        }
        public bool updDepartment(Department ex)
        {
            return false;
        }
        private bool verDepartment(int q)
        {
            return false;
        }
        public List<Department> getDepartments() 
        {
            return departments;
        }
        public void printInfo()
        {

        }
        public List<JobVacancy> getJobVacancies() 
        {
            return null;
        }
        public int addJobTitle(JobTitle ex)
        {
            return 0;
        }
        public bool delJobTitle()
        {
            return false;
        }
        public int openJobVacancy(JobVacancy ex)
        {
            return 0;
        }
        public bool closeJobVacancy(int q)
        {
            return false;
        }
        public Employee recruit(JobVacancy ex)
        {
            return null;
        }
        public void dismiss(int q, Reason ex)
        { 
        }

        public Faculty() { }
        public Faculty(string name, string shortName, string address) 
        {
            this.name = name;
            this.shortName = shortName;
            this.address = address;
        }
    }
}
