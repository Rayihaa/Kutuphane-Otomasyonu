using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes
{
    public class DB_baglanti
    {
        public static string DB_Adres = @"DataSource = " + Environment.CurrentDirectory + "\\DB\\kitap.db;Version=5;New=False;Compress=True;Read Only=False";
        public static string BagDurum;

        public static void Baglanti()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(DB_Adres))
            {
                if (baglanti.State == ConnectionState.Closed)// baglanti durumu kontrol edilir. Bağlantı sağlanamamışsa.
                {
                    try
                    {
                        baglanti.Open();
                        BagDurum = "VERİTABANI BAĞLANDI.";
                    }
                    catch (Exception)
                    {
                        BagDurum = "VERİTABANI BAĞLANTI HATASI";
                    }
                }
                else
                {
                    BagDurum = "VERİTABANI BAĞLANDI.";
                }
            }
        }
    }
}
