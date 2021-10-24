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
using TicketPurchaseSystem.DataAccess.SqlServer;
using TicketPurchaseSystem.Domain.AdditionalClass;
using TicketPurchaseSystem.Domain.Entities;
using TicketPurchaseSystem.Domain.Entities.Views;

namespace TicketPurchaseSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirplaneRepostory AirplaneRepostory = new AirplaneRepostory();
        CityRepostory CityRepostory = new CityRepostory();
        ScheludeRepostory ScheludeRepostory = new ScheludeRepostory();
        PilotRepostory PilotRepostory = new PilotRepostory();
        DBEntities1 DBEntities = new DBEntities1();
        City City = new City();
        Airplane Airplane = new Airplane();
        Schedule Schedule = new Schedule();
        public MainWindow()
        {
            InitializeComponent();
            CitiesCombobox.ItemsSource = CityRepostory.GetAllData();
            SchedulesComboBox.ItemsSource = ScheludeRepostory.GetAllData();
            AirplaneComboBox.ItemsSource = AirplaneRepostory.GetAllData();
        }

        private void CitiesCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var currentCities = CitiesCombobox.SelectedItem as City;
                var currentairplanes = DBEntities.Airplanes.Where(a => a.Id == currentCities.AirplaneId);
                var data = ObserverHelper.ToObservableCollection(currentairplanes);
                AirplaneComboBox.ItemsSource = data;
                var currentsch = DBEntities.Schedules.Where(s => s.Id == currentCities.ScheludeId);
                var data2 = ObserverHelper.ToObservableCollection(currentsch);

                SchedulesComboBox.ItemsSource = data2;
                City = currentCities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SchedulesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var curretnsch = SchedulesComboBox.SelectedItem as Schedule;
            Schedule = curretnsch;
        }

        private void AirplaneComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var pilots = PilotRepostory.GetAllData();
                var currentAirplane = AirplaneComboBox.SelectedItem as Airplane;
                var currentpilot = DBEntities.Pilots.FirstOrDefault(a => a.Id == currentAirplane.PilotId);



                NameTxtBlock.Text = currentpilot.Name;
                SurnameTxtBlock.Text = currentpilot.Surename;
                Airplane = currentAirplane;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ticket Purchased");
            TicketUserControl showTicket = new TicketUserControl();
            showTicket.mainListBox.Items.Add(
            new Ticket
            {
                Airplane = Airplane,
                AirplaneId = Airplane.Id,
                Schedule = Schedule,
                ScheludeId = Schedule.Id,
                City = City,
                CityId = City.Id,
            }
            );
            MainGrid.Children.Add(showTicket);


        }
    }
}
