using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFRefresher.Demo.RelayCommandDemo
{
    public class RelayCommandViewModel
    {
        public RelayCommand SubmitCommand { get; set; }

        private string _testString;

        public string TestString
        {
            get { return _testString; }
            set { _testString = value; }
        }

        public RelayCommandViewModel()
        {
            SubmitCommand = new RelayCommand(TestMethodForSaveOrLoad);
        }

        private void TestMethodForSaveOrLoad(object obj)
        {
            MessageBox.Show("The value inside the textbox is : " + this._testString);
            Console.WriteLine("TestMethodForSaveOrLoad called using RelayCommand");
        }
    }
}
