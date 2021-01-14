using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Driving
    {
        public int Id { get; set; }
        public int Mileage { get; set; }
        public decimal PricePerKM { get; set; }
        public decimal TotalEarning { get; set; }
        public decimal DispatcherEarning { get; set; }
        public int DriverID { get; set; }
    }
}
