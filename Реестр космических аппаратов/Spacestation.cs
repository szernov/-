using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реестр_космических_аппаратов
{
        public class Spacestation
        {
            private string _Callsign;
            private int _Crew;
            private int _Launch;
            private int _Reentry;
            private int _Daysinorbit;

            public string Callsign
            {
                get { return _Callsign; }
                set { _Callsign = value; }
            }

            public int Crew
            {
                get { return _Crew; }
                set { _Crew = value; }
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



            public Spacestation(string ca, int cr, int la, int re, int da)
            {
                Callsign = ca;
                Crew = cr;
                Launch = la;
                Reentry = re;
                Daysinorbit = da;
            }

            public void show(MainWindow wnd)
            {
                wnd.info.Text += "Космическая станция: " + Callsign + "\n";
                wnd.info.Text += "Колличество человек на борту: " + Crew + "\n";
                wnd.info.Text += "Дата запуска: " + Launch + "\n";
                wnd.info.Text += "Дата посадки: " + Reentry + "\n";
                wnd.info.Text += "Дней на орбите: " + Daysinorbit + "\n";

        }

        }
    }




