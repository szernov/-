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
    { public List<Spaceobject> spaceObjets = new List<Spaceobject>();
           public  List<Sputnik> sputniks = new List<Sputnik>();
           public List<Spacestation> spacestations = new List<Spacestation>();
        public MainWindow()
        {
            

            InitializeComponent();

            using (FileStream fs = new FileStream(@"../../Реестр.txt", FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);

                string[] data;

                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(';');
                    if (data[4] == "0")
                    {
                        Sputnik sp = new Sputnik(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]),0, data[5], int.Parse(data[6]));
                        spaceObjets.Add(sp);
                        sputniks.Add(sp);

                    }
                    else if (data[4] == "1")
                    {
                        Spacestation st = new Spacestation(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]),1, int.Parse(data[5]));
                        spaceObjets.Add(st);
                        spacestations.Add(st);
                    }

                }
                    sr.Close();
                }

                }

        private void buttonsputnik_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Sputnik_table(this);
        }

        private void buttonspacestation_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Spacestation_table(this);
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Addobject(this);

        }
    }

        }
    
    


    
