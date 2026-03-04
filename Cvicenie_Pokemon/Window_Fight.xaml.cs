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
using System.Windows.Shapes;

namespace Cvicenie_Pokemon
{
    public partial class Window_Fight : Window
    {

        public Hero MyActualHero { get; set; }
        public Enemy Enemy { get; set; }
        public Window_Fight(Hero hero, Enemy enemy)
        {
            InitializeComponent();
            MyActualHero = hero;
            Enemy = enemy;
            ProgressBar_Hero.Value = hero.Health;
            ProgressBar_Hero.Maximum = hero.Health_Max;
            ProgressBar_Enemy.Value = enemy.Health_Max;
            ProgressBar_Enemy.Maximum = enemy.Health_Max;


        }
        private void Hero_LightAttack_Click(object sender, RoutedEventArgs e)
        {
            EnemyAttackHero();
            HeroAttackEnemy(1);
            CheckHealthStatus();
        }
        private void HeroAttackEnemy(int damagescale)
        {
            if (MyActualHero.Energy <= 0)
            {
                Label_GameStatus.Content = "Nemas energiu";
                return;
            }
            else
            {
                Enemy.Health_Max -= MyActualHero.Damage * damagescale;
                ProgressBar_Enemy.Value = Enemy.Health_Max;
                MyActualHero.Energy -= 10 * damagescale;
                ProgressBar_Energy.Value = MyActualHero.Energy;
            }

        }
        private void EnemyAttackHero()
        {
            MyActualHero.Health -= Enemy.Damage;
            ProgressBar_Hero.Value = MyActualHero.Health;
        }
        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HeroAttackEnemy(2);
            EnemyAttackHero();
            CheckHealthStatus();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HeroAttackEnemy(5);
            EnemyAttackHero();
            CheckHealthStatus();
        }

        private void CheckHealthStatus()
        {
            if (MyActualHero.Health <= 0)
            {
                Label_GameStatus.Content = "Zdochol si";
            }
            if (Enemy.Health_Max <= 0)
            {
                Label_GameStatus.Content = "Sovik zdochol";
            }
        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
