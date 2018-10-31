using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XF.ControlesBasicos
{
    public class Email : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool permissao;
        public bool Permissao
        {

            get
            {
                return permissao;
            }
            set
            {
                permissao = value;
                if (!permissao) ContaEmail = string.Empty;
                NotifyPropertyChanged();
            }

        }

        private string contaEmail;
        public string ContaEmail
        {
            get
            {
                return contaEmail;
            }
            set
            {
                contaEmail = value;
                NotifyPropertyChanged();
            }

        }
    }
}
