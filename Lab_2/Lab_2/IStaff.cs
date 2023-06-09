using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public interface IStaff
    {
        List<JobVacancy> getJobVacancies();
        List<Employee> getEmployees();
        List<JobTitle> GetJobTitles();
        int addJobTitle(JobTitle ex);
        string printJobVacancies();
        bool delJobTitle();
        void openJobVacancy(JobVacancy ex);
        bool closeJobVacancy(int q);
        Employee recruit(JobVacancy ex, Person exP);
        bool dismiss(int q, Reason ex);
    }
}
