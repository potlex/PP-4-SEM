using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class University : Organization, IStaff
    {
        protected List<Faculty> faculties = new List<Faculty>();
        public int addFaculty(Faculty a)
        {
            return 0;
        }
        public bool delFaculty(int a)
        {
            return false;
        }
        public bool updFaculty(Faculty a)
        {
            return true;
        }
        private bool verFaculty(int a)
        {
            return true;
        }
        public List<Faculty> getFaculties()
        {
            return faculties;
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
        public bool delJobTitle(int g)
        {
            return false;
        }
        public int openJobVacancy(JobVacancy ex)
        {
            return 0;
        }
        public bool closeJobVacancy(int a)
        {
            return false;
        }
        public Employee recruit(JobVacancy exJ, Person ex)
        {
            return null;
        }
        public void dismiss(int a, Reason ex)
        { 
        }
        public University() { }
        public University(University example)
        {

        }
        public University(string name, string shortName, string address)
        { 
            this.name = name;
            this.shortName = shortName;
            this.address = address;
        }
    }
}
