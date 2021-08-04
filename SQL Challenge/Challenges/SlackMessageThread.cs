using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class SlackMessageThread
    {
        public int MessageThreadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModigiedOn { get; set; }
        public List<SlackUser> User { get; set; }
    }
}
