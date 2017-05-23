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
    /// Логика взаимодействия для Таблица_спутников.xaml
    /// </summary>
    public partial class Sputnik_table : Page
    {MainWindow mw;

        public Sputnik_table(MainWindow w)
        {
            InitializeComponent();
            mw = w;
            foreach (Sputnik sp in mw.sputniks)
            {
                listviewsputnik.Items.Add(sp);
            }
        }
    }
}
