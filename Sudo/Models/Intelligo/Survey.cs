using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sudo.Models.Intelligo
{
    public class Survey
    {
        public Question Question { get; set; }
        public List<Answer> Options { get; set; }
        public List<UserResponses> Responses { get; set; }
        public DateTime StartTime { get; set; }
    }
}
