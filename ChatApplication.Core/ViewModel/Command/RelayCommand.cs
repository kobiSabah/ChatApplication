using System;
using System.Windows.Input;

namespace ChatApplication.Core
{
    public class RelayCommand : ICommand
    {
        #region Private members

        private readonly Action r_Action;

        #endregion

        public event EventHandler CanExecuteChanged;

        #region Constructor
        public RelayCommand(Action i_Action)
        { 
            r_Action = i_Action;
        }
        #endregion

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
