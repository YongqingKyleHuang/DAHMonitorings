using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SQLite;

namespace DAHMonitorings
{
    public class Monitoring
    {
      //  [PrimaryKey]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Subject { get; set; }
        public string Reporter { get; set; }
    }
}
