using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Regions;
using Prism.Unity;

namespace VirtualPlayer.Views {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IUnityContainer _container;
        IRegionManager _regionManager;

        public MainWindow(IUnityContainer container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;
        }

    }
}
