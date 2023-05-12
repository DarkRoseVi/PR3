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
using PR3.Mypages;
using PR3.Components;

namespace PR3.Mypages
{
    /// <summary>
    /// Логика взаимодействия для ListsliderPage.xaml
    /// </summary>
    public partial class ListsliderPage : Page
    {
        public ListsliderPage()
        {
            InitializeComponent();
            SliderLw.ItemsSource = BdConect.db.Slider.ToList();
         
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var sil = (sender as Button).DataContext as Components.Slider;
            NavigationService.Navigate(new EditSelterPage(sil));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditSelterPage(new Components.Slider()));

        }
    }
}
