﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class themdulieu
    {
        String MAHDB;
        String MANV;
        String SDT;
        String HOTENKH;
        String NGAYLAP;
        String TONGSLSANPHAM;
        String TONGTIEN;

        public string MAHDB1 { get => MAHDB; set => MAHDB = value; }
        public string MANV1 { get => MANV; set => MANV = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string HOTENKH1 { get => HOTENKH; set => HOTENKH = value; }
        public string NGAYLAP1 { get => NGAYLAP; set => NGAYLAP = value; }
        public string TONGSLSANPHAM1 { get => TONGSLSANPHAM; set => TONGSLSANPHAM = value; }
        public string TONGTIEN1 { get => TONGTIEN; set => TONGTIEN = value; }

        public themdulieu(string mhd, string manv, string sdt, string ht, string nl, string tsp, string tt)
        {
            MAHDB1 = mhd; MANV1 = manv; SDT1 = sdt; HOTENKH1 = ht; NGAYLAP1 = nl; TONGSLSANPHAM1 = tsp; TONGTIEN1 = tt;
        }


    }
}
