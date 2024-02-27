using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class MainViewModel : NotificationObject
    {
        private float _numero1; 
        private float _numero2;
        private float _resultado; //Para poder tener el resultado en decimales se convirtieron los números a decimal
        private ICommand sumarCommand;
        private ICommand restarCommand;
        private ICommand multiplicarCommand;
        private ICommand dividirCommand;
        public float Numero1
        {
            get
            {
                return _numero1;
            }
            set
            {
                if (value == _numero1)
                    return;
                _numero1 = value;
                RaisePropertyChanged(() => Numero1); //Avisa a la vista que cambio el valor
            }
        }

        public float Numero2
            {
            get
            {
                return _numero2;
            }
            set
            {
                if (value == _numero2)
                    return;
                _numero2 = value;
                RaisePropertyChanged(() => Numero2);
            }
            }

        public float Resultado
        {
            get
            {
                return _resultado;
            }
            set
            {
                if (value == _resultado)
                    return;
                _resultado = value;
                RaisePropertyChanged(() => Resultado);
            }
        }

        public ICommand SumarCommand
        {
            get
            {
                if (sumarCommand == null) //No esta inicializado. Comando
                {
                    sumarCommand = new DelegateCommand(Sumar, () => true); //() => true es una expresión lambda
                }
                    return sumarCommand;

            }
        }
        public ICommand RestarCommand
        {
            get
            {
                if (restarCommand == null) //No esta inicializado. Comando
                {
                    restarCommand = new DelegateCommand(Restar, () => true); //() => true es una expresión lambda
                }
                return restarCommand;

            }
        }
        public ICommand MultiplicarCommand
        {
            get
            {
                if (multiplicarCommand == null) //No esta inicializado. Comando
                {
                    multiplicarCommand = new DelegateCommand(Multiplicar, () => true); //() => true es una expresión lambda
                }
                return multiplicarCommand;

            }
        }
        public ICommand DividirCommand
        {
            get
            {
                if (dividirCommand == null) //No esta inicializado. Comando
                {
                    dividirCommand = new DelegateCommand(Dividir, () => true); //() => true es una expresión lambda
                }
                return dividirCommand;

            }
        }
        public MainViewModel()
        {
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
        }

        public void Sumar()
        {
            Resultado = Numero1 + Numero2;
        }
        public void Restar()
        {
            Resultado = Numero1 - Numero2;
        }
        public void Multiplicar()
        {
            Resultado = Numero1 * Numero2;
        }
        public void Dividir()
        {
            Resultado = Numero1 / Numero2;
        }
    }
}
