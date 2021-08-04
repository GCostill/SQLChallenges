using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class DBMgmntProfessor
    {
        public int ProfessorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTenured { get; set; }
        public List<DBMgmntProfessorCourse> ProfessorCourses { get; set; }
    }
}
