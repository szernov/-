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
    /// Логика взаимодействия для Spacestation_table.xaml
    /// </summary>
    public partial class Spacestation_table : Page
    {
        MainWindow mw;
        public Spacestation_table(MainWindow m)
        {
            InitializeComponent();
            mw = m;
            Refresh();
        }
        public void Refresh()
        {
            listviewstation.Items.Clear();


            foreach (Spacestation st in mw.spacestations)
            {
                listviewstation.Items.Add(st);
            }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            while (listviewstation.SelectedItems.Count > 0)
            {
                listviewstation.Items.Remove(listviewstation.SelectedItems[0]);
            }
        }
    }
}
