using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1.Classes
{   //Class.ımızın içine metod ekledik.
    public class Uc
    {
        public static void Uc_Ekle(Grid grd,UserControl uc1) // farklı bir butona tıkladığımızda datagrid çöplüğe dönmesin diye yazdığımız bir metod.
        {
            if(grd.Children.Count > 0)
            {
                grd.Children.Clear(); // ekranı temizle 
                grd.Children.Add(uc1); // benim çağırdığım usercontrol.ü ekrana getir. 
            }
            else { grd.Children.Add(uc1); }
        }
    }
}
