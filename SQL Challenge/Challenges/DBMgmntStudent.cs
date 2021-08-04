using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class DBMgmntStudent
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AdvisorId { get; set; }
        public DBMgmntProfessor Professor { get; set; }
        public List<DBMgmntStudentCourse> StudendCourses { get; set; }
    }
}
