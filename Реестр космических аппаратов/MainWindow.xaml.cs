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
using System.IO;

namespace Реестр_космических_аппаратов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Spaceobject> spaceObjets = new List<Spaceobject>();
            List<Sputnik> sputniks = new List<Sputnik>();
            List<Spacestation> spacestation = new List<Spacestation>();

            InitializeComponent();

            using (FileStream fs = new FileStream(@"../../Реестр.txt", FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);

                string[] data;

                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(';');
                    if (data[0] == "Спутник")
                    {
                        Sputnik sp = new Sputnik(data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), data[5], int.Parse(data[6]));
                        spaceObjets.Add(sp);
                        sputniks.Add(sp);

                    }
                    else if (data[0] == "Станция")
                    {
                        Spacestation st = new Spacestation(data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                        spaceObjets.Add(st);
                        spacestation.Add(st);
                    }

                }
                    sr.Close();
                }

                }

        private void buttonsputnik_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Таблица_спутников();
        }

        private void buttonspacestation_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Таблица_космических_станций();
        }
    }

        }
    
    


    
