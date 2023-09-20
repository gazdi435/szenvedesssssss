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
using MySqlConnector;

namespace kKtyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string kapcsolatLeiro = "datasource=127.0.0.1;port=3306;username=root;password=;database=kutyak;charset=utf8;";
        MySqlConnection SQLkapcsolat;


        public MainWindow()
        {
            InitializeComponent();
            OpenDatabase();
            AtlagEletkor();
            ListabaRak();
            Legidosebb();
            CloseDatabase();
        }

        private void ListabaRak()
        {

            string SQLOsszesTermek = "SELECT count(*) FROM kutyaNevek;";
            MySqlCommand SQLparancs = new MySqlCommand(SQLOsszesTermek, SQLkapcsolat);
            MySqlDataReader adatOlvaso = SQLparancs.ExecuteReader();

            while (adatOlvaso.Read())
            {
                LBdoboz.Content=adatOlvaso.GetInt32(0);   
            }

            adatOlvaso.Close();
        }

        private void AtlagEletkor()
        {
            string SQLOsszesTermek = "SELECT AVG(életkor) FROM kutyak;";
            MySqlCommand SQLparancs = new MySqlCommand(SQLOsszesTermek, SQLkapcsolat);
            MySqlDataReader adatOlvaso = SQLparancs.ExecuteReader();

            while (adatOlvaso.Read())
            {
                LBatlag.Content = adatOlvaso.GetDouble(0);

            }

            adatOlvaso.Close();

        }

        private void Legidosebb()
        {
            string SQLOsszesTermek = "SELECT kutyafajtak.név, kutyanevek.kutyanév FROM kutyak join kutyafajtak join kutyanevek;";
            MySqlCommand SQLparancs = new MySqlCommand(SQLOsszesTermek, SQLkapcsolat);
            MySqlDataReader adatOlvaso = SQLparancs.ExecuteReader();

            while (adatOlvaso.Read())
            {
                LBatlag.Content = adatOlvaso.GetDouble(0);

            }

            adatOlvaso.Close();
        }

       

        private void OpenDatabase()
        {
            try
            {
                SQLkapcsolat = new MySqlConnection(kapcsolatLeiro);
                SQLkapcsolat.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem tud kapcsolódni az adatbázishoz!");
                this.Close();
            }
        }

        private void CloseDatabase()
        {
            SQLkapcsolat.Close();
            SQLkapcsolat.Dispose();
        }
        
    }
}
