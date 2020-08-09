using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatApplication
{
    public class RelayCommand : ICommand
    {
        private readonly Action r_Action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action i_Action)
        {
            r_Action = i_Action;
        }

        #region ICommand Members

        public bool CanExecute(object i_Parameter)
        {
            return true;
        }

        public void Execute(object i_Parameter)
        {
            r_Action.Invoke();
        }

        #endregion    
    }
}
