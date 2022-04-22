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

namespace WPFRefresher.Demo.ViewModelDemo
{
    /// <summary>
    /// Interaction logic for SampleView.xaml
    /// </summary>
    public partial class SampleView : UserControl
    {
        public SampleView()
        {
            InitializeComponent();

            DataContext = new SampleViewModel() 
            { 
                StringField1 = "String Field Value 1",
                StringField2 = "String Field Value 2",
                StringField3 = "String Field Value 3",
                IntField1 = 100,
                IntField2 = 500,
                BoolField1 = true,
                BoolField2 = false,
                BoolField3 = false
            };

        }

        private void LoadVaues()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
