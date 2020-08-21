using System;
using System.Windows.Input;

namespace ChatApplication.Core
{
    public class RelayParameterizedCommand : ICommand
    {
        #region Private members

        private readonly Action<object> r_Action;

        #endregion

        public event EventHandler CanExecuteChanged;

        #region Constructor
        public RelayParameterizedCommand(Action<object> i_Action)
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
            r_Action.Invoke(i_Parameter);
        }

        #endregion
    }
}
