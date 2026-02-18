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
using System.Linq;


namespace Cvicenie_MinecraftDressUp
{
    public partial class MainWindow : Window
    {
        public string ImagePath { get; set; } = "C:\\Users\\tichym25\\Source\\Repos\\csharp67\\Cvicenie_MinecraftDressUp\\obrazocky\\minecraft_armour_sheet_by_dragonshadow3_d8ebr67-414w-2x.png";
        List<ArmorPart> Armors_Helm = new List<ArmorPart>();
        List<ArmorPart> Armors_Body = new List<ArmorPart>();
        List<ArmorPart> Armors_Pant = new List<ArmorPart>();
        List<ArmorPart> Armors_Leg = new List<ArmorPart>();

        public ArmorPart Head { get; set; }
        public ArmorPart Body {  get; set; }
        public ArmorPart Pant {  get; set; }
        public ArmorPart Leg {  get; set; }

        public MainWindow()
        {
            InitializeComponent();



            Armors_Helm.Add(new ArmorPart("Plesaty", 0, EArmorType.None, EArmorPartName.Helmet, 1, 1, 1, 1));
            Armors_Helm.Add(new ArmorPart("Helma bronzova", 1, EArmorType.Bronze, EArmorPartName.Helmet, 28, 29, 100, 90));
            Armors_Helm.Add(new ArmorPart("Helma retiazkova", 2, EArmorType.Chain, EArmorPartName.Helmet, 177, 29, 100, 90));
            Armors_Helm.Add(new ArmorPart("Helma zelezna", 5, EArmorType.Iron, EArmorPartName.Helmet, 338, 29, 100, 90));
            Armors_Helm.Add(new ArmorPart("Helma zlata", 10, EArmorType.Gold, EArmorPartName.Helmet, 505, 29, 100, 90));
            Armors_Helm.Add(new ArmorPart("Helma diamantova", 20, EArmorType.Diamond, EArmorPartName.Helmet, 659, 29, 100, 90));
            Combox_HelmPicker.ItemsSource = Armors_Helm;

            Armors_Body.Add(new ArmorPart("Hola hrud", 0, EArmorType.None, EArmorPartName.Body, 0, 0, 0, 0));
            Armors_Body.Add(new ArmorPart("Body bronzove", 5, EArmorType.Bronze, EArmorPartName.Body, 7, 136, 139, 130));
            Armors_Body.Add(new ArmorPart("Body retiazkove", 10, EArmorType.Chain, EArmorPartName.Body, 159, 136, 139, 130));
            Armors_Body.Add(new ArmorPart("Body zelezne", 15, EArmorType.Iron, EArmorPartName.Body, 321, 136, 139, 130));
            Armors_Body.Add(new ArmorPart("Body zlate", 30, EArmorType.Gold, EArmorPartName.Body, 486, 136, 139, 130));
            Armors_Body.Add(new ArmorPart("Body diamantove", 50, EArmorType.Diamond, EArmorPartName.Body, 639, 136, 139, 130));
            Combox_BodyPicker.ItemsSource = Armors_Body;

            Armors_Pant.Add(new ArmorPart("Trenky", 0, EArmorType.None, EArmorPartName.Pant, 0, 0, 0, 0));
            Armors_Pant.Add(new ArmorPart("Nohavice bronzove", 2, EArmorType.Bronze, EArmorPartName.Pant, 26, 279, 100, 131));
            Armors_Pant.Add(new ArmorPart("Nohavice retiazkove", 4, EArmorType.Chain, EArmorPartName.Pant, 179, 279, 100, 131));
            Armors_Pant.Add(new ArmorPart("Nohavice zelezne", 8, EArmorType.Iron, EArmorPartName.Pant, 339, 279, 100, 131));
            Armors_Pant.Add(new ArmorPart("Nohavice zlate", 15, EArmorType.Gold, EArmorPartName.Pant, 506, 279, 100, 131));
            Armors_Pant.Add(new ArmorPart("Nohavice diamantove", 22, EArmorType.Diamond, EArmorPartName.Pant, 657, 279, 100, 131));
            Combox_PantPicker.ItemsSource = Armors_Pant;

            Armors_Leg.Add(new ArmorPart("Sandale", 0, EArmorType.None, EArmorPartName.Leg, 0, 0, 0, 0));
            Armors_Leg.Add(new ArmorPart("Topanky bronzove", 2, EArmorType.Bronze, EArmorPartName.Leg, 2, 425, 140, 100));
            Armors_Leg.Add(new ArmorPart("Topanky retiazkove", 4, EArmorType.Chain, EArmorPartName.Leg, 159, 425, 140, 100));
            Armors_Leg.Add(new ArmorPart("Topanky zelezne", 8, EArmorType.Iron, EArmorPartName.Leg, 319, 425, 140, 100));
            Armors_Leg.Add(new ArmorPart("Topanky zlate", 15, EArmorType.Gold, EArmorPartName.Leg, 484, 425, 140, 100));
            Armors_Leg.Add(new ArmorPart("Topanky diamantove", 22, EArmorType.Diamond, EArmorPartName.Leg, 636, 425, 140, 100));
            Combox_LegPicker.ItemsSource = Armors_Leg;

            

        }

        private void Multiplier()
        {

        }
        private void Combox_HelmPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ArmorPart armorPart = Combox_HelmPicker.SelectedItem as ArmorPart;
            Head = armorPart;
            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();
                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();
                Image_HelmetPlaceHolder.Source = cropped;
                Image_HelmetPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_HelmetPlaceHolder.Visibility = Visibility.Hidden;

            }
            UpdateLabels();
        }

        private void Combox_BodyPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ArmorPart armorPart = Combox_BodyPicker.SelectedItem as ArmorPart;
            Body = armorPart;
            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();
                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();
                Image_BodyPlaceHolder.Source = cropped;
                Image_BodyPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_BodyPlaceHolder.Visibility = Visibility.Hidden;

            }
            UpdateLabels();
        }

        private void Combox_PantPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ArmorPart armorPart = Combox_PantPicker.SelectedItem as ArmorPart;
            Pant = armorPart;
            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();
                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();
                Image_PantPlaceHolder.Source = cropped;
                Image_PantPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_PantPlaceHolder.Visibility = Visibility.Hidden;

            }
            UpdateLabels();
        }

        private void Combox_LegPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ArmorPart armorPart = Combox_LegPicker.SelectedItem as ArmorPart;
            Leg = armorPart;
            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();
                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();
                Image_LegPlaceHolder.Source = cropped;
                Image_LegPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_LegPlaceHolder.Visibility = Visibility.Hidden;

            }
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            var playerSet = new List<ArmorPart>();

            if (Head != null)
                playerSet.Add(Head);
            if (Body != null)
                playerSet.Add(Body);
            if (Pant != null)
                playerSet.Add(Pant);
            if (Leg != null)
                playerSet.Add(Leg);



            var groupedItems = playerSet.GroupBy(p => p.ArmorType, (key, g) => new { ArmorType = key, Items = g.ToList() }).ToList();
            var multiplaierValue = groupedItems.OrderByDescending(x => x.Items.Count).First().Items.Count;
            Label_Multiplier.Content = multiplaierValue;

            var numberOfArmor = playerSet.Sum(x => x.ArmorPower);
            Label_ActualArmor.Content = $"{numberOfArmor} (+{multiplaierValue * numberOfArmor})";
        }

    }
}