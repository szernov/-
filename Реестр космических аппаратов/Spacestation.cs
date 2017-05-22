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

            public Spacestation(string ca, int la, int re, int da, int cr):base(ca,la,re,da)
            {
                Crew = cr;
            }

        

        }
    }




