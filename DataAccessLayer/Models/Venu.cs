using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Venu
    {
        public long Id { get; set; }

        public long VenuName { get; set; }

        public long LocationName { get; set; }

        public int Capacity { get; set; }

        public Event Events { get; set; }

    }

}
