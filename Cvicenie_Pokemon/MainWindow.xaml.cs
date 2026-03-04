using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cvicenie_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hero myHero = new Hero(100, 100, 10, 100);
            Enemy enemy = new Enemy(200, 12);




            Window_Fight fight = new Window_Fight(myHero, enemy);
            fight.Show();
            
        }

       /* private void Button_Click(object sender, RoutedEventArgs e)
        {
            string myTextBoxValue = TextBox_MyValue.Text;
            Window_Fight window_Fight = new Window_Fight(myTextBoxValue);
            window_Fight.Show();

        }*/
    }
}