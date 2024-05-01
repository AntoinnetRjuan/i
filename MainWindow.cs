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
using gepers.View.UserControls;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;

namespace gepers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            /* ClearTextBox1.DataChanged += (sender, data) =>
            {
               
            };
            ClearTextBox2.DataChanged += (sender, data) =>
            {

            };
            ClearTextBox3.DataChanged += (sender, data) =>
            {

            };
            ClearTextBox4.DataChanged += (sender, data) =>
            {

            };*/
        }

        /*private void InsertDataIntoDatabase(string data)
        {
            string connectionString = "database=antoinnet; server=localhost; user id=root; pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("INSERT INTO utilisateur (nom_entreprise, gerant(e), type_entreprise, mot_de_passe) VALUE (@nom_entreprise, @gerant(e), @type_entreprise, @mot_de_passe)", connection))
                {
                    command.Parameters.AddWithValue("@nom_entreprise", data);
                    command.Parameters.AddWithValue("@gerant(e)", data);
                    command.Parameters.AddWithValue("@type_entreprise", data);
                    command.Parameters.AddWithValue("@mot_de_passe", data);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string data = .Text;
           // MySqlConnection connexion = new MySqlConnection("database=antoinnet; server=localhost; user id=root; pwd=");
            //try
            //{
                //connexion.Open();
                InsertDataIntoDatabase(data);
                //string query = "INSERT INTO utilisateur (nom_entreprise, gerant(e), type_entreprise, mot_de_passe) VALUE (@nom_entreprise, @gerant(e), @type_entreprise, @mot_de_passe)";
               // MessageBox.Show("connecté");
            //}catch(Exception ex)
            //{
               // MessageBox.Show(ex.ToString());
               // MessageBox.Show("Non connecté");
            //}
        }*/
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string nom_entreprise = ClearTextBox.Texte;
            string connectionString = "database=antoinnet; server=localhost; user id=root; pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "INSERT INTO utilisateur (nom_entreprise, gerant(e), type_entreprise, mot_de_passe) VALUE (@nom_entreprise, @gerant(e), @type_entreprise, @mot_de_passe)";

            using (connection)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nom_entreprise",Name);
                    command.Parameters.AddWithValue("@gerant(e)", Name);
                    command.Parameters.AddWithValue("@type_entreprise", Name);
                    command.Parameters.AddWithValue("@mot_de_passe", Name);
                    //command.Parameters.AddWithValue("@Value5", txtInput5.Text);
                    command.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("un probleme est survenu");
                }
               
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}