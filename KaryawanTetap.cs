using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugaslab8
{
    class KaryawanTetap : Karyawan
    {
        public double UpahBulanan { get; set; }
        public override double Gaji()
        {
            return UpahBulanan;
        }
    }
}
