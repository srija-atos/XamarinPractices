using Student_Management_1.OfflineStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Student_Management_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddViewPage : ContentPage
    {
        bool _isReadOnly;
        public AddViewPage(Person person, bool isReadOnly = true)
        {
            InitializeComponent();
            IsEnabled = isReadOnly;
            BindingContext = new ViewModel.AddUpdatePageViewModel(person);
        }
    }
}