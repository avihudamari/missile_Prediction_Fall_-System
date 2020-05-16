using BE;
using Microsoft.Maps.MapControl.WPF;
using PL.Models;
using PL.ViewModels;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for GoogleMapsUC.xaml
    /// </summary>
    public partial class GoogleMapsUC : UserControl
    {
        public PredictionAndRealFallsVM CurrentVM { get; set; }
        List<iLocationClass> BlackPushpins { get; set; } // REAL
        List<iLocationClass> BluePushpins { get; set; }  // PREDICTION
        List<iLocationClass> RedPushpins { get; set; }   // REPORT

        public GoogleMapsUC()
        {
            InitializeComponent();
            CurrentVM = PredictionAndRealFallsVM.Instance;
            this.DataContext = CurrentVM;
            InitEmptyCtorLists();
            AddPushpins();
            TodayOnly();
        }

        public void Load()
        {
            CurrentVM = PredictionAndRealFallsVM.Instance;
            this.DataContext = CurrentVM;
            InitEmptyCtorLists();
            AddPushpins();
            TodayOnly();
        }

        private void InitEmptyCtorLists()
        {
            foreach (Locations lacation in CurrentVM.Locations)
            {
                if (lacation.Status == Locations.FallStatus.REAL)
                    BlackPushpins = lacation.TheObject;
                if (lacation.Status == Locations.FallStatus.PREDICTION)
                    BluePushpins = lacation.TheObject;
                if (lacation.Status == Locations.FallStatus.REPORT)
                    RedPushpins = lacation.TheObject;
            }
        }

        private void InitValueCtorLists(int fallId)
        {
            foreach (Locations lacation in CurrentVM.Locations)
            {
                if (lacation.Status == Locations.FallStatus.REAL)
                    BlackPushpins = lacation.TheObject;
                if (lacation.Status == Locations.FallStatus.PREDICTION)
                    BluePushpins = lacation.TheObject;
                if (lacation.Status == Locations.FallStatus.REPORT)
                    RedPushpins = lacation.TheObject;
            }
            foreach (Fall item in BlackPushpins)
            {
                if (item.FallId != fallId)
                    BlackPushpins.Remove(item);
            }
            foreach (FallPrediction item in BlackPushpins)
            {
                if (item.FallPredictionFallKey != fallId)
                    BluePushpins.Remove(item);
            }

            int predictionCode = ((FallPrediction)BluePushpins.First()).FallPredictionId;
            foreach (FallReport item in BlackPushpins)
            {
                if (item.FallReportId != predictionCode)
                    RedPushpins.Remove(item);
            }
        }

        private void StatlliteModeButten_Click(object sender, RoutedEventArgs e)
        {
            this.MapModeButten.Visibility = Visibility.Visible;
            this.MainMap.Mode = new AerialMode(true);
            this.StatlliteModeButten.Visibility = Visibility.Hidden;
        }

        private void MapModeButten_Click(object sender, RoutedEventArgs e)
        {
            this.MapModeButten.Visibility = Visibility.Hidden;
            this.MainMap.Mode = new Microsoft.Maps.MapControl.WPF.RoadMode();
            this.StatlliteModeButten.Visibility = Visibility.Visible;
        }

        public void TodayOnly()
        {
            CurrentVM = PredictionAndRealFallsVM.Instance;
            BlackPushpins.Clear();
            BluePushpins.Clear();
            RedPushpins.Clear();

            foreach (Locations location in CurrentVM.Locations)
            {
                if (location.Status == Locations.FallStatus.REAL)
                    foreach (Fall fall in location.TheObject)
                        if (fall.FallTime.Date.Year == DateTime.Today.Date.Year &&
                            fall.FallTime.Date.Month == DateTime.Today.Date.Month &&
                            fall.FallTime.Date.Day == DateTime.Today.Date.Day)
                            BlackPushpins.Add(fall);

                if (location.Status == Locations.FallStatus.PREDICTION)
                    foreach (FallPrediction fallPrediction in location.TheObject)
                        if (fallPrediction.FallPredictionTime.Date.Year == DateTime.Today.Date.Year &&
                            fallPrediction.FallPredictionTime.Date.Month == DateTime.Today.Date.Month &&
                            fallPrediction.FallPredictionTime.Date.Day == DateTime.Today.Date.Day)
                            BluePushpins.Add(fallPrediction);
                if (location.Status == Locations.FallStatus.REPORT)
                    foreach (FallReport fallReport in location.TheObject)
                        if (fallReport.ReportTime.Date.Year == DateTime.Today.Date.Year &&
                            fallReport.ReportTime.Date.Month == DateTime.Today.Date.Month &&
                            fallReport.ReportTime.Date.Day == DateTime.Today.Date.Day)
                            RedPushpins.Add(fallReport);
            }
            AddPushpins();
        }

        private void AddPushpins()
        {
            MainMap.Children.Clear();
            foreach (Fall item in BlackPushpins)
            {
                var location = new Location(item.FallLocation.Latitude, item.FallLocation.Longitude);
                var pushpin = new Pushpin();
                pushpin.Location = location;
                pushpin.Background = new SolidColorBrush(Colors.Black);
                MainMap.Children.Add(pushpin);
            }

            List<iLocationClass> BluePushpins1 = (List<iLocationClass>)BluePushpins;
            foreach (FallPrediction item in BluePushpins1)
            {
                var location = new Location(item.FallPredictionLocation.Latitude, item.FallPredictionLocation.Longitude);
                var pushpin = new Pushpin();
                pushpin.Location = location;
                pushpin.Background = new SolidColorBrush(Colors.Blue);
                MainMap.Children.Add(pushpin);
            }
            foreach (FallReport item in RedPushpins)
            {
                var location = new Location(item.ReportLocation.Latitude, item.ReportLocation.Longitude);
                var pushpin = new Pushpin();
                pushpin.Location = location;
                pushpin.Background = new SolidColorBrush(Colors.Red);
                MainMap.Children.Add(pushpin);
            }
        }

        public void Update(int fallId)
        {
            List<iLocationClass> BlackPushpins1 = new List<iLocationClass>();  // REAL
            List<iLocationClass> BluePushpins1 = new List<iLocationClass>();   // PREDICTION
            List<iLocationClass> RedPushpins1 = new List<iLocationClass>();    // REPORT
            foreach (Locations location in CurrentVM.Locations)
            {
                if (location.Status == Locations.FallStatus.REAL)
                    BlackPushpins = location.TheObject;
                if (location.Status == Locations.FallStatus.PREDICTION)
                    BluePushpins = location.TheObject;
                if (location.Status == Locations.FallStatus.REPORT)
                    RedPushpins = location.TheObject;
            }
            foreach (Fall item in BlackPushpins)
            {
                if (item.FallId == fallId)
                    BlackPushpins1.Add(item);
            }
            foreach (FallPrediction item in BluePushpins)
            {
                if (item.FallPredictionFallKey == fallId)
                    BluePushpins1.Add(item);
            }
            if (BluePushpins1.Count != 0)
            {
                int predictionCode = ((FallPrediction)BluePushpins1.First()).FallPredictionId;
                foreach (FallReport item in RedPushpins)
                {
                    if (item.FallPredictionId == predictionCode)
                        RedPushpins1.Add(item);
                }
            }
            RedPushpins = RedPushpins1;
            BlackPushpins = BlackPushpins1;
            BluePushpins = BluePushpins1;
            AddPushpins();
        }

        public void ShowAllData()
        {
            InitEmptyCtorLists();
            AddPushpins();
        }
    }
}
