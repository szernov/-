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
        public Addobject()
        {
            InitializeComponent();
            element_type.Items.Add("Спутник");
            element_type.Items.Add("Космическая станция");

        }

       

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
