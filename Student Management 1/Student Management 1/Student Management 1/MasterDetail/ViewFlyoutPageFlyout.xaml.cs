using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Student_Management_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public ViewFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new ViewFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ViewFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ViewFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public ViewFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ViewFlyoutPageFlyoutMenuItem>(new[]
                {
                    new ViewFlyoutPageFlyoutMenuItem { Id = 0, Title = "Home",TargetType=typeof(ViewFlyoutPageDetail), },
                    new ViewFlyoutPageFlyoutMenuItem { Id = 1, Title = "About",TargetType=typeof(ViewFlyoutPageDetail) },
                    new ViewFlyoutPageFlyoutMenuItem { Id = 2, Title = "Student",TargetType=typeof(SearchBarPage1) },
                   
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}