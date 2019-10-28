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
using WpfApplication1.Classes;
using WpfApplication1.UControl;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { //constructor
            InitializeComponent();
            // boyutunu görev çubuğuna göre ayarla.
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void Btn_kpt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Menubuton_kitaplar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menubuton_KitapTeslimi_Click(object sender, RoutedEventArgs e)
        {
            Uc.Uc_Ekle(icerik, new Uc_KitapTeslimi());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Uc.Uc_Ekle(icerik, new Uc_KitapTeslimi());
        }

        private void Btn_hakkinda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_boyut_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                MiniBtnGrd.VerticalAlignment = VerticalAlignment.Top;
                grd_harita.;
            }
            else
            {
                this.WindowState = WindowState.Normal;

            }
        }

        private void Btn_simge_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
