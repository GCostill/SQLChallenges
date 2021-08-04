using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class SlackUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinedOn { get; set; }
        public List<SlackMessageThread> MessageThread { get; set; }
    }
}
