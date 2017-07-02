using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLeague.Domain.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }        
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Defeat { get; set; }
        public int Score { get; set; }
    }
}
