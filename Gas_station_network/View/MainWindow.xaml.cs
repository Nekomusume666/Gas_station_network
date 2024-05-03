using Gas_station_network.DataBase.Storage;
using Gas_station_network.DataBase.Storage.Common;
using Gas_station_network.ViewModel;
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

namespace Gas_station_network
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CommonStorage CommonStorage = new CommonStorage();

        public MainWindow()
        {
            CommonStorage.AddPerson(new Model.Person("adm", "adm", Model.Role.Administrator, "Admin",
                "Adminovich", "89999999999"));
            //PersonStorage.AddPerson(new Model.Person("admin", "admin", Model.Role.Administrator));
        }

    }
}