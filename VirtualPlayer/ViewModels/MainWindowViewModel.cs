using Prism.Mvvm;

namespace VirtualPlayer.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private string _title = "Virtual Player";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
