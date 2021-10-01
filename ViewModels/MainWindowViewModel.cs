using NCM_Utilities.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NCM_Utilities.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string FirstName => "a";
    


        public ObservableCollection<SingleSongInfoDataGrid> SingleDataGrid { get; }

        public MainWindowViewModel()
        {
            SingleDataGrid = new ObservableCollection<SingleSongInfoDataGrid>(GenerateMockPeopleTable());
        }

        public static void add(string a, string b)
        {
MainWindowViewModel.SingleDataGrid.Add(
    new SingleSongInfoDataGrid()
    {
        Info = "New First Name",
        Value = "New Last Name"
    });
        }

        private IEnumerable<SingleSongInfoDataGrid> GenerateMockPeopleTable()
        {
            var defaultPeople = new List<SingleSongInfoDataGrid>()
            {
                new SingleSongInfoDataGrid()
                {
                    Info = "NM$L",
                    Value = "Sabeee"

                }
            };
            
            return defaultPeople;
        }




    }
}
