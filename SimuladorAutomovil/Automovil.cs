using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAutomovil
{
    public class Automovil
    {
        private string _marca;
        private bool _motorEncendido;
        private int _velocidadActual;
        private bool _cajaAutomatica;
        private bool _modoCrucero;

        public string Marca 
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public bool CajaAutomatica 
        {
            get { return _cajaAutomatica; }
            set { _cajaAutomatica = value; }
        }
        public string Identificador{
            get
            {
                string tipoCaja;
                if (CajaAutomatica == true)
                {
                    tipoCaja = "AUTO";
                }
                else
                {
                    tipoCaja = "MAN";
                }
                return Marca+"-"+tipoCaja+"-2026";
            }
        }

        //Constructor
        public Automovil (string _marca, bool _cajaAutomatica){
            this._marca = _marca.ToUpper().Substring(0,3);
            this._cajaAutomatica = _cajaAutomatica;
            _motorEncendido = false;
            _velocidadActual = 0;
            _modoCrucero = false;
        }
    }
}
