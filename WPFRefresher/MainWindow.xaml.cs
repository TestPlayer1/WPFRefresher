using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WPFRefresher.Classes;
using WPFRefresher.Demo;
using WPFRefresher.Demo.RelayCommandDemo;
using WPFRefresher.Demo.ViewModelDemo;

namespace WPFRefresher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        #region PropertyNotifier
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private object _currectView;

        public object CurrentView
        {
            get { return _currectView;}
            set { _currectView = value;
                NotifyPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            //CurrentView = new RelayCommandDemo();
            //CurrentView = new DockPanelDemo();
            //CurrentView = new GridDemo();
            //CurrentView = new StackPanelDemo();
            //CurrentView = new ViewBoxDemo();
            CurrentView = new SampleView();
        }
    }
}
