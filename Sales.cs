using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugaslab8
{
    class Sales : Karyawan
    {
        public double TotalPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return TotalPenjualan * Komisi;
        }
    }
}
