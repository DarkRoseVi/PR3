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
using PR3.Components;
using PR3.Mypages;


namespace PR3.Mypages
{
    /// <summary>
    /// Логика взаимодействия для EditSelterPage.xaml
    /// </summary>
    public partial class EditSelterPage : Page
    {
        public Components.Slider slider { get; set; }
        public EditSelterPage(Components.Slider _slider)
        {
           slider = _slider;
            InitializeComponent();
            TypeCb.ItemsSource = BdConect.db.Type.ToList();
            TypeCb.DisplayMemberPath = "Title";
            TypeCb.SelectedItem = BdConect.db.Type.ToList().FirstOrDefault(x=>x.Id == slider.Id);
            CokorCb.ItemsSource = BdConect.db.Color.ToList();
            CokorCb.DisplayMemberPath = "Title";
            CokorCb.SelectedItem = BdConect.db.Color.ToList().FirstOrDefault(x => x.Id == slider.Id);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           var seid = BdConect.db.Slider.Where(x=>x.Id == slider.Id).FirstOrDefault();  
            if (seid == null)
            {
                BdConect.db.Slider.Add(slider);

                BdConect.db.Characteristic.Add(new Characteristic
                {
                    Slider = slider,
                    Type = TypeCb.SelectedItem as Components.Type,
                    Color = TypeCb.SelectedItem as Components.Color,

                }) ;
                BdConect.db.SaveChanges();
                MessageBox.Show("Создано");
                NavigationService.Navigate(new ListsliderPage());
            }
            else 
            { 
                
            BdConect.db.SaveChanges();
                MessageBox.Show("Редактирование сохранено");
                NavigationService.Navigate(new ListsliderPage());
            } 
                

        }
    }
}
