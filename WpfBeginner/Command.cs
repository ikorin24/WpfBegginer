using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfBeginner
{
    public class Command : ICommand
    {
        private Action _action;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        /// <summary>特定の処理を実行するコマンドを生成します</summary>
        /// <param name="action">実行する処理</param>
        public Command(Action action)
        {
            _action = action;
        }
    }
}
