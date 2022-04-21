using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2596
{
    class Karyawan
    {
        public string Nik;
        public string Nama;
        public int gaji_bulanan;
        public Karyawan(string nik, string nama, int gaji_bulanan)
        {
            this.Nik = nik;
            this.Nama = nama;
            if (gaji_bulanan < 0)
            {
                this.Nik = "0";
            }
            else
            {
                this.gaji_bulanan = gaji_bulanan;
            }
        }
    }
}
