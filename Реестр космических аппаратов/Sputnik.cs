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
        public Sputnik(string ca, int la, int re, int da,int ty, string ro, int lau) : base(ca, la, re, da,ty)
        {
            Rocket = ro;
            Launchmass = lau;
        }
        public string GetInfo()
        {
            return String.Format("Спутник;{0};{1};{2};{3};{4};{5}", Callsign, Launch, Reentry, Daysinorbit, Rocket, Launchmass);
        }
    }
}
