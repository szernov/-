using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реестр_космических_аппаратов
{
        public class Spacestation:Spaceobject
        {
            
            private int _Crew;
           

           

            public int Crew
            {
                get { return _Crew; }
                set { _Crew = value; }
            }

            public Spacestation(string ca, int cr, int la, int re, int da):base(ca,la,re,da)
            {
                Crew = cr;
            }

            public void show(MainWindow wnd)
            {
                wnd.info.Text += "Название: " + Callsign + "\n";
                wnd.info.Text += "Колличество человек на борту: " + Crew + "\n";
                wnd.info.Text += "Дата запуска: " + Launch + "\n";
                wnd.info.Text += "Дата посадки: " + Reentry + "\n";
                wnd.info.Text += "Дней на орбите: " + Daysinorbit + "\n";

        }

        }
    }




