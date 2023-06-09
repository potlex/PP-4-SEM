using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Organization : IStaff
    {
        public int id { get; set; }
        public string name { get; set; }
        public object shortName { get; set; }
        public string address { get; set; }
        public DateTime timeStamp { get; set; }

        public List<JobVacancy> getJobVacancies()
        {
            return null;
        }
        public List<Employee> getEmployees()
        {
            return null;
        }
        public List<JobTitle> GetJobTitles()
        {
            return null;
        }
        public int addJobTitle(JobTitle some)
        {
            return 0;
        }
        public string printJobVacancies()
        {
            return "";
        }
        public bool delJobTitle()
        {
            return false;
        }
        public void openJobVacancy(JobVacancy some)
        { 
        }
        public bool closeJobVacancy(int q)
        {
            return false;
        }
        public Employee recruit(JobVacancy some, Person someP)
        {
            return null;
        }
        public bool dismiss(int q, Reason some)
        {
            return false;
        }

        public Organization() { }
        public Organization(Organization example)
        {
            id = example.id;
            name = example.name;
            address = example.address;
            timeStamp = example.timeStamp;
        }
        public Organization(int id, string name, string shortName, string address, DateTime timeStamp)
        {
            this.id = id;
            this.name = name;
            this.shortName = shortName;
            this.address = address;
            this.timeStamp = timeStamp;
        }
    }
}
