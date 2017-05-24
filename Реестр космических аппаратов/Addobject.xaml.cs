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
    /// Логика взаимодействия для Addobject.xaml
    /// </summary>
    public partial class Addobject : Page
    {
        MainWindow mw;
        public Addobject(MainWindow v)
        {
            InitializeComponent();
            mw = v;

        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (element_type.SelectedIndex == 0)
                {
                    Sputnik sp = new Sputnik(callsignt.Text, int.Parse(launcht.Text), int.Parse(reenteryt.Text), int.Parse(daysinorbitt.Text), 0, rockett.Text, int.Parse(launchmasst.Text));
                    mw.sputniks.Add(sp);

                }
                else
                {
                    Spacestation st = new Spacestation(callsignt.Text, int.Parse(launcht.Text), int.Parse(reenteryt.Text), int.Parse(daysinorbitt.Text), 1, int.Parse(crewt.Text));
                    mw.spacestations.Add(st);

                }
              
            } 
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

            

        private void element_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(element_type.SelectedIndex==0)
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
