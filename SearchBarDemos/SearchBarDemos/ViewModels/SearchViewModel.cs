using SearchBarDemos.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace SearchBarDemos.ViewModels
{
    public class SearchViewModel : INotifyPropertyChanged
    {
        #region Unchanged from MS Docs Sample...
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // I wrote this in a different form, to make it more clear for myself... because I'm a newb.
        //public ICommand PerformSearch => new Command<string>((string query) =>
        //{
        //   SearchResults = DataService.GetSearchResults(query);
        //});


        #endregion

        // SearchBar SearchCommand="{Binding PerformSearch}" 
        public ICommand PerformSearch { get; }

        // CollectionView ( MS Docs uses a ListView & Lists ) ItemsSource="{Binding SearchResults}" 
        ObservableCollection<string> searchResults; // = DataService.Fruits; (moved to CTOR)
        public ObservableCollection<string> SearchResults
        {
            get
            {
                return searchResults;
            }
            set
            {
                searchResults = value;
                NotifyPropertyChanged();
            }
        }










        // CollectionView SelectionChangedCommand="{Binding MySelectionChangedCommand}"             
        public ICommand MySelectionChangedCommand { get; set; }

        // CollectionView SelectionMode="Multiple" SelectedItems="{Binding MySelectedItems, Mode=TwoWay}"                              
        ObservableCollection<object> _mySelectedItems; 
        public ObservableCollection<object> MySelectedItems 
        {
            get
            {
                return _mySelectedItems;
            }
            set
            {
                if (_mySelectedItems != value)
                {
                    _mySelectedItems = value;
                }
            }
        }






        public SearchViewModel()
        {

            PerformSearch = new Command<string>(OnSearchCommand);
            MySelectionChangedCommand = new Command(OnMySelectionChangedCommand);

            this.SearchResults = new ObservableCollection<string>(DataService.Fruits);

            this.MySelectedItems = new ObservableCollection<object>() { };
        }










        public void OnSearchCommand(string query)
        {
            SearchResults = DataService.GetSearchResults(query);
        }


                
        private void OnMySelectionChangedCommand()
        {                        
            Debug.WriteLine("~~~~~~~~~ MySelectedItems Include : ");
            foreach (var item in MySelectedItems)
            {
                Debug.WriteLine("~~~~~~~~~ " + item.ToString());
            }

        }










    }
}
