using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реестр_космических_аппаратов
{ [Serializable]
   public class Spaceobject
    {
        private string _Callsign;
        private int _Launch;
        private int _Reentry;
        private int _Daysinorbit;
        public int _Type;


        public string Callsign
        {
            get { return _Callsign; }
            set { _Callsign = value; }
        }
        public int Launch
        {
            get { return _Launch; }
            set { _Launch = value; }
        }
        public int Reentry
        {
            get { return _Reentry; }
            set { _Reentry = value; }
        }

        public int Daysinorbit
        {
            get { return _Daysinorbit; }
            set { _Daysinorbit = value; }
        }

        public Spaceobject(string ca, int la, int re, int da,int ty)
        {
            Callsign = ca;
            Launch = la;
            Reentry = re;
            Daysinorbit = da;
            _Type = ty;
        }
    }
}
