using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFRefresher.Classes;
using WPFRefresher.Demo.RelayCommandDemo;

namespace WPFRefresher.Demo.ViewModelDemo
{
    public class SampleViewModel : ViewModelBase
    {
        public RelayCommand SubmitCommand { get; set; }

        private string _testString;

        public string TestString
        {
            get { return _testString; }
            set { _testString = value; }
        }

        public SampleViewModel()
        {
            SubmitCommand = new RelayCommand(TestMethodForSaveOrLoad);
        }

        private void TestMethodForSaveOrLoad(object obj)
        {
            MessageBox.Show("The value inside the textbox is : " + this._testString);
            Console.WriteLine("TestMethodForSaveOrLoad called using RelayCommand");
        }

        private string _stringField1;
        private string _stringField2;
        private string _stringField3;

        private int _intField1;
        private int _intField2;

        private bool _boolField1;
        private bool _boolField2;
        private bool _boolField3;

        private bool _isShowGrid1;
        private bool _isShowGrid2;

        private bool _checkBox1;
        private bool _checkBox2;
        private bool _checkBox2_1;
        private bool _checkBox3;
        private bool _checkBox3_1;

        private Visibility _showHideGrid2;


        public string StringField1
        {
            get { return _stringField1; }
            set { _stringField1 = value; }
        }

        public string StringField2
        {
            get { return _stringField2; }
            set { _stringField2 = value; }
        }

        public string StringField3
        {
            get { return _stringField3; }
            set { _stringField3 = value; }
        }

        public int IntField1
        {
            get { return _intField1; }
            set { _intField1 = value; }
        }

        public int IntField2
        {
            get { return _intField2; }
            set { _intField2 = value; }
        }

        public bool BoolField1
        {
            get { return _boolField1; }
            set { _boolField1 = value; }
        }

        public bool BoolField2
        {
            get { return _boolField2; }
            set { _boolField2 = value; }
        }
        public bool BoolField3
        {
            get { return _boolField3; }
            set { _boolField3 = value; }
        }

        public bool IsShowGrid1
        {
            get { return _isShowGrid1; }
            set
            {
                _isShowGrid1 = value;
                OnPropertyChanged("IsShowGrid1");
            }
        }

        public bool IsShowGrid2
        {
            get { return _isShowGrid2; }
            set
            {
                _isShowGrid2 = value;
                OnPropertyChanged();
                OnPropertyChanged("ShowHideGrid2");
            }
        }

        public bool CheckBox1
        {
            get { return _checkBox1; }
            set { 
                _checkBox1 = value;
                _checkBox2 = false;
                _checkBox2_1 = false;
                _checkBox3 = false;
                _checkBox3_1 = false;
                OnPropertyChanged("CheckBox1");
                OnPropertyChanged("CheckBox2");
                OnPropertyChanged("CheckBox2_1");
                OnPropertyChanged("CheckBox3");
                OnPropertyChanged("CheckBox3_1");
            }
        }

        public bool CheckBox2
        {
            get { return _checkBox2; }
            set
            {
                _checkBox1 = false;
                _checkBox2_1 = false;
                _checkBox3 = false;
                _checkBox2 = value;
                _checkBox3_1 = false;
                OnPropertyChanged("CheckBox1");
                OnPropertyChanged("CheckBox2");
                OnPropertyChanged("CheckBox2_1");
                OnPropertyChanged("CheckBox3");
                OnPropertyChanged("CheckBox3_1");
            }
        }

        public bool CheckBox2_1
        {
            get { return _checkBox2_1; }
            set
            {
                _checkBox2_1 = value;
                OnPropertyChanged();
            }
        }

        public bool CheckBox3
        {
            get { return _checkBox3; }
            set
            {
                _checkBox1 = false;
                _checkBox2 = false;
                _checkBox2_1 = false;
                _checkBox3 = value;
                _checkBox3_1 = false;
                OnPropertyChanged("CheckBox1");
                OnPropertyChanged("CheckBox2");
                OnPropertyChanged("CheckBox2_1");
                OnPropertyChanged("CheckBox3");
                OnPropertyChanged("CheckBox3_1");
            }
        }

        public bool CheckBox3_1
        {
            get { return _checkBox3_1; }
            set
            {
                _checkBox3_1 = value;
                OnPropertyChanged();
            }
        }

        public Visibility ShowHideGrid2
        {
            get { return IsShowGrid2 ? Visibility.Visible : Visibility.Hidden; }
        }
    }
}
