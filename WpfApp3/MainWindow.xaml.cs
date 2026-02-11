using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DateTime startTime;
        DateTime stopTime;
        public bool start = true;
        public bool stop = false;
        double realnyCas;
        double realnyCasMS;
        string jednotka = "ms";

        public MainWindow()
        {
            InitializeComponent();
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
            Reset.IsEnabled = false;
        }






        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            if (start = true)
            {
                startTime = DateTime.Now;
                ResultLabel.Content = "Cas bezi...";
                Start.IsEnabled = false;
                Stop.IsEnabled = true;
                Reset.IsEnabled = true;
            }
        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            if (stop = true)
            {
                stopTime = DateTime.Now;
                TimeSpan elapsed = stopTime - startTime;
                realnyCasMS = elapsed.TotalMilliseconds;
                realnyCasMS = Math.Round(realnyCasMS, 0);
                AnsBox.Text = "Sem napis svoj tip";
                AnsBox.IsEnabled = true;
                AktualizujZobrazenie();
                Start.IsEnabled = true;
                Stop.IsEnabled = false;
            }
        }

        private void Check_Button_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(AnsBox.Text, out int tip))
            {
                double zobrazovanyCas = 0;

                if (SCheckBox.IsChecked == true)
                {
                    SCheckBox.Content = "sekundy";
                    zobrazovanyCas = realnyCasMS / 1000.0;
                    jednotka = "s";

                }
                if (SCheckBox.IsChecked == false)
                {
                    zobrazovanyCas = realnyCasMS;
                    jednotka = "ms";
                }
                ResultLabel.Content = ($"Tvoj tip je: {tip}");
                double rozdiel = Math.Abs(zobrazovanyCas - tip);
                rozdiel = Math.Round(rozdiel, 0);
                if (rozdiel == tip)
                {
                    AnsBox.Text = "Gratulujem uhadol si";
                }
                else
                {
                    ResultLabel.Content = "Neuhadol si, tvoj tip bol o " + rozdiel.ToString() + " " + jednotka + " vedľa";

                }
            }
            else
            {
                ResultLabel.Content = "Zadaj platny tip";
            }
        }
        private void AktualizujZobrazenie()
        {
            if (realnyCasMS == 0) return;
            if (SCheckBox.IsChecked == true)
            {
                double sekundy = realnyCasMS / 1000.0;
                ResultLabel.Content = sekundy.ToString("F2") + " s";
            }
            else
            {
                ResultLabel.Content = realnyCasMS.ToString("F0") + " ms";
            }
        }

        private void AnsBox_GotFocus(object sender, RoutedEventArgs e)
        {
            AnsBox.Clear();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
            Reset.IsEnabled = false;
            realnyCas = 0;
            ResultLabel.Content = "";
            AnsBox.Text = "Zatial sa tu neda pisat";
        }

        private void SCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SCheckBox.Content = "seconds";
        }

        private void SCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SCheckBox.Content = "milliseconds";
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}