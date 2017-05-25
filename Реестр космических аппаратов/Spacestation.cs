using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реестр_космических_аппаратов
{ [Serializable]
        public class Spacestation:Spaceobject
        {
            
            private int _Crew;
           

           
            public int Crew
            {
                get { return _Crew; }
                set { _Crew = value; }
            }

            public Spacestation(string ca, int la, int re, int da,int ty, int cr):base(ca,la,re,da,ty)
            {
                Crew = cr;
            }

        public string GetInfo()
        {
            return String.Format("{0};{1};{2};{3};{4};{5}", Callsign, Launch, Reentry, Daysinorbit, 1, Crew);
        }

    }
    }




