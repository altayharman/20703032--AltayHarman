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

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pizzacesit.Items.Add(textBox1.Text);
            boyut.Items.Add(textBox2.Text);
            fiyat.Items.Add(textBox3.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        //Tüm listboxlardaki itemleri seçtikten sonra silme işlemini yapıyor komut
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            pizzacesit.Items.RemoveAt(pizzacesit.Items.IndexOf(pizzacesit.SelectedItem));
            boyut.Items.RemoveAt(boyut.Items.IndexOf(boyut.SelectedItem));
            fiyat.Items.RemoveAt(fiyat.Items.IndexOf(fiyat.SelectedItem));
        }

    

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pizzacesit.Items.Add(textBox1.Text);
            boyut.Items.Add(textBox2.Text);
            fiyat.Items.Add(textBox3.Text);


        }
        //Tüm listboxlardaki itemleri seçtikten sonra silme işlemini yapıyor komut
        ck1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = pizzacesit.SelectedItem.ToString();
            textBox2.Text = boyut.SelectedItem.ToString();
            textBox3.Text = fiyat.SelectedItem.ToString();
        }

        private void boyut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
