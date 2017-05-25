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
using System.Runtime.Serialization.Formatters.Binary;

namespace Реестр_космических_аппаратов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Spaceobject> spaceObjets = new List<Spaceobject>();
        public List<Sputnik> sputniks = new List<Sputnik>();
        public List<Spacestation> spacestations = new List<Spacestation>();
        Sputnik_table sputnikPage;
        Spacestation_table spacestationPage;
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
                        Sputnik sp = new Sputnik(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), 0, data[5], int.Parse(data[6]));
                        spaceObjets.Add(sp);
                        sputniks.Add(sp);

                    }
                    else if (data[4] == "1")
                    {
                        Spacestation st = new Spacestation(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), 1, int.Parse(data[5]));
                        spaceObjets.Add(st);
                        spacestations.Add(st);
                    }

                }
                sr.Close();
            }

        }

        private void SputnikButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Sputnik_table(this);
        }

        private void SpacestationButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Spacestation_table(this);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Addobject(this);

        }
        public void Write()
        {
            using (FileStream fs = new FileStream(@"../../Реестр.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (Spacestation st in spacestations)
                        sw.WriteLine(st.GetInfo());
                    foreach (Sputnik sp in sputniks)
                        sw.WriteLine(sp.GetInfo());
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Sputnik sp in sputniks.ToArray())
                if (sp.Callsign == DeleteTextBox.Text)
                { sputniks.Remove(sp); }

            foreach (Spacestation st in spacestations.ToArray())
                if (st.Callsign == DeleteTextBox.Text)
                {
                    spacestations.Remove(st);
                }
            Write();
            Writeser();

        }
        public void Writeser()
        {
            using (FileStream fs = new FileStream(@"../../Реестр.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bi = new BinaryFormatter();
                bi.Serialize(fs, spaceObjets);

            }
        }
        public void Readser()
        {
            using (FileStream fs = new FileStream(@"../../Реестр.dat", FileMode.Create, FileAccess.Write))
            {
                spacestations.Clear();
                sputniks.Clear();
                Refresh();
                BinaryFormatter bi = new BinaryFormatter();
                spaceObjets = bi.Deserialize(fs) as List<Spaceobject>;
                foreach (Spaceobject item in spaceObjets)
                {
                    if (item._Type == 0)
                    {
                        Sputnik sp = item as Sputnik;
                        sputniks.Add(sp);

                    }
                    else
                    {
                        Spacestation st = item as Spacestation;
                        spacestations.Add(st);
                    }

                }

            }
        }
        public void Refresh()
        {
            sputnikPage.Refresh();
            spacestationPage.Refresh();

        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Change(this);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {int i = 0;
          int j = 0;
            foreach (Sputnik sp in sputniks)
            {
                
                if (sp.Callsign == SearchTextBox.Text)
                {
                    MessageBox.Show(String.Format("{0};{1};{2};{3};{4};{5}", sp.Callsign, sp.Launch, sp.Reentry, sp.Daysinorbit, sp.Rocket, sp.Launchmass));
                    i += 1;
                }

            }
            foreach (Spacestation st in spacestations)
            {
                
                if (st.Callsign == SearchTextBox.Text)
                {
                    MessageBox.Show(String.Format("{0};{1};{2};{3};{4}", st.Callsign, st.Launch, st.Reentry, st.Daysinorbit, st.Crew));
                    j += 1;
                }

            }
            if(j==0 && i==0)
            { MessageBox.Show("Такого объекта нет");}
            
        }
    }
}











