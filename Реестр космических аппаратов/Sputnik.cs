using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реестр_космических_аппаратов
{ [Serializable]
  public  class Sputnik:Spaceobject
    {
        private string _Rocket;
        private int _Launchmass;

        public string Rocket
        {
            get { return _Rocket; }
            set { _Rocket = value; }
        }
        public int Launchmass
        {
            get { return _Launchmass; }
            set { _Launchmass = value; }
        }
        public Sputnik(string ca, int la, int re, int da, string ro, int lau) : base(ca, la, re, da)
        {
            Rocket = ro;
            Launchmass = lau;
        }
    }
}
