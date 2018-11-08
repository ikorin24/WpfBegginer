using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBeginner
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Calculator _calculator = new Calculator();
        public event PropertyChangedEventHandler PropertyChanged;

        #region Value1
        /// <summary>第1項の値</summary>
        public double Value1
        {
            get { return _value1; }
            set
            {
                if(_value1 == value) { return; }
                _value1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value1)));
            }
        }
        private double _value1;
        #endregion

        #region Value2
        /// <summary>第2項の値</summary>
        public double Value2
        {
            get { return _value2; }
            set
            {
                if(_value2 == value) { return; }
                _value2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value2)));
            }
        }
        private double _value2;
        #endregion

        #region Answer
        /// <summary>計算結果</summary>
        public double Answer
        {
            get { return _answer; }
            set
            {
                if(_answer == value) { return; }
                _answer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));
            }
        }
        private double _answer;
        #endregion

        #region CalcCommand
        /// <summary>計算コマンド</summary>
        public Command CalcCommand
        {
            get
            {
                if(_calcCommand == null) { _calcCommand = new Command(Calc); }
                return _calcCommand;
            }
            set { _calcCommand = value; }
        }
        private Command _calcCommand;
        #endregion

        /// <summary>計算を実行します</summary>
        private void Calc()
        {
            Answer = _calculator.AddValue(Value1, Value2);
        }
    }
}
