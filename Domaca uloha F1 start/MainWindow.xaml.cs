using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Domaca_uloha_F1_start
{
    public partial class MainWindow : Window
    {
        // pri vela veciach mi pomahalo AI hlavne pochopit co to je preco to tak je ako sa to robi pretoze som si s tym dlho lamal hlavu preco mi to nejde dufam ze sa nebudete hnevat
        private Stopwatch stopky = new Stopwatch();
        private DispatcherTimer casovac = new DispatcherTimer();
        private int indexSvetla = 0;
        private Random r = new Random();
        private bool Klik = false; 

        public MainWindow()
        {
            InitializeComponent();
            casovac.Interval = TimeSpan.FromSeconds(1);
            casovac.Tick += Timer_Tick;

            SetAllOff(); 
        }

       
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            indexSvetla = 0;      
            Klik = false;  
            stopky.Reset();       
            TimeLabel.Content = "00:00.000"; 
            SetAllOff();          

            casovac.Interval = TimeSpan.FromSeconds(1); 
            casovac.Start();      
        }

        // 3. LOGIKA SVETIEL (Čo sa deje v každom kroku časovača)
        private void Timer_Tick(object sender, EventArgs e)
        {
            indexSvetla++;

            if (indexSvetla <= 5)
            {
                ShowNext(indexSvetla);
            }
            else if (indexSvetla == 6)
            {
                casovac.Stop();
                int waiting = r.Next(500, 3000); 
                casovac.Interval = TimeSpan.FromMilliseconds(waiting);
                casovac.Start();
            }
            else
            {
                casovac.Stop();   
                SetAllOff();     
                Klik = true; 
                stopky.Start();    

                DispatcherTimer plynulyCas = new DispatcherTimer();
                plynulyCas.Interval = TimeSpan.FromMilliseconds(10);
                plynulyCas.Tick += (s, args) => {
                    TimeLabel.Content = stopky.Elapsed.ToString(@"ss\.fff");
                };
                plynulyCas.Start();

            }
        }

        private void KlikButton_Click(object sender, RoutedEventArgs e)
        {
            if (Klik == true)
            {
                stopky.Stop();
                Klik = false;
                TimeLabel.Content = stopky.Elapsed.ToString(@"ss\.fff"); 
            }
            else if (indexSvetla > 0)
            {
                casovac.Stop();
                stopky.Stop();
                SetAllOff();
                TimeLabel.Content = "JUMP START!";
                indexSvetla = 0; 
            }
        }


        private void SetAllOff()
        {
            Light1.Fill = Light11.Fill = Brushes.DimGray;
            Light2.Fill = Light22.Fill = Brushes.DimGray;
            Light3.Fill = Light33.Fill = Brushes.DimGray;
            Light4.Fill = Light44.Fill = Brushes.DimGray;
            Light5.Fill = Light55.Fill = Brushes.DimGray;
        }

        private void ShowNext(int index)
        {
            if (index == 1) Light1.Fill = Light11.Fill = Brushes.Red;
            if (index == 2) Light2.Fill = Light22.Fill = Brushes.Red;
            if (index == 3) Light3.Fill = Light33.Fill = Brushes.Red;
            if (index == 4) Light4.Fill = Light44.Fill = Brushes.Red;
            if (index == 5) Light5.Fill = Light55.Fill = Brushes.Red;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}