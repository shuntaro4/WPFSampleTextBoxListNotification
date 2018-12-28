using Prism.Ioc;
using System.Windows;
using WPFSampleTextBoxListNotification.Views;

namespace WPFSampleTextBoxListNotification
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
