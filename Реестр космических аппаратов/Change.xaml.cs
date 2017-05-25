using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Реестр_космических_аппаратов
{
    /// <summary>
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Change : Page
    {
        MainWindow mw;

        public Change(MainWindow u)
        {
            InitializeComponent();
            mw = u;
        }

        private void ChangeElementButton_Click(object sender, RoutedEventArgs e)

        {
           int i = 0;
           int j = 0;
            try
            {

                foreach (Sputnik sm in mw.sputniks.ToArray())
                {
                    if (sm.Callsign == callsignt.Text)
                    {
                        sm.Launch = int.Parse(launcht.Text);
                        sm.Reentry = int.Parse(reenteryt.Text);
                        sm.Daysinorbit = int.Parse(daysinorbitt.Text);
                        sm.Rocket = rockett.Text;
                        sm.Launchmass = int.Parse(launchmasst.Text);
                        mw.Write();
                        mw.Writeser();
                        i += 1;

                    }



                }
                foreach (Spacestation sv in mw.spacestations.ToArray())
                {
                    if (sv.Callsign == callsignt.Text)
                    {
                        sv.Launch = int.Parse(launcht.Text);
                        sv.Reentry = int.Parse(reenteryt.Text);
                        sv.Daysinorbit = int.Parse(daysinorbitt.Text);
                        sv.Crew = int.Parse(crewt.Text);
                        mw.Write();
                        mw.Writeser();
                        j = +1;




                    }
                }
                if (i == 0 && j == 0)
                {
                    MessageBox.Show("Изменяемого объекта нет");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }




           


        private void ElementTypeChangePage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ElementTypeChangePage.SelectedIndex == 0)
            {
                launchmass.Visibility = Visibility.Visible;
                rocket.Visibility = Visibility.Visible;
                crew.Visibility = Visibility.Collapsed;
                rockett.Visibility = Visibility.Visible;
                launchmasst.Visibility = Visibility.Visible;
                crewt.Visibility = Visibility.Collapsed;
            }
            else
            {
                launchmass.Visibility = Visibility.Collapsed;
                rocket.Visibility = Visibility.Collapsed;
                crew.Visibility = Visibility.Visible;
                rockett.Visibility = Visibility.Collapsed;
                launchmasst.Visibility = Visibility.Collapsed;
                crewt.Visibility = Visibility.Visible;
            }
        }
    }
}

