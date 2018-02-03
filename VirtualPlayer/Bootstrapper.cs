using Microsoft.Practices.Unity;
using Prism.Unity;
using VirtualPlayer;
using System.Windows;

namespace VirtualPlayer
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
