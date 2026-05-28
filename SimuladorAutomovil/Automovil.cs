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

        //Propiedad solo lectura
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

        //Métodos
        public void EncenderApagar()
        {
            _motorEncendido =! _motorEncendido;

            if (!_motorEncendido)
            {
                _velocidadActual = 0;
                _modoCrucero = false;
            }
        }

        // Acelerar sin parámetro
        public void Acelerar()
        {
            Acelerar(10);
        }

        // Acelerar con parámetro
        public void Acelerar(int velocidad)
        {
            if (!_motorEncendido)
            {
                Console.WriteLine("El motor está apagado");
                return;
            }

            _velocidadActual += velocidad;

            int velocidadMaxima;

            if (_cajaAutomatica)
            {
                velocidadMaxima = 220;
            }
            else
            {
                velocidadMaxima = 180;
            }

            if (_velocidadActual > velocidadMaxima)
            {
                _velocidadActual = velocidadMaxima;
            }
        }

        // Frenar sin parámetro
        public void Frenar()
        {
            if (!_motorEncendido)
            {
                Console.WriteLine("El motor está apagado");
                return;
            }

            _velocidadActual = 0;
            _modoCrucero = false;
        }

        // Frenar con parámetro
        public void Frenar(int velocidad)
        {
            if (!_motorEncendido)
            {
                Console.WriteLine("El motor está apagado");
                return;
            }

            _velocidadActual -= velocidad;

            if (_velocidadActual < 0)
            {
                _velocidadActual = 0;
            }

            _modoCrucero = false;
        }

        // Activar y desactivar modo crucero
        public void ModoCrucero()
        {
            if (_velocidadActual > 60)
            {
                _modoCrucero = !_modoCrucero;
            }
            else
            {
                Console.WriteLine("La velocidad debe superar los 60 km/h");
            }
        }

        // Mostrar estado
        public void MostrarEstado()
        {
            Console.WriteLine("Identificador: " + Identificador);
            Console.WriteLine();

            if (_motorEncendido)
            {
                Console.WriteLine("Motor: ON");
            }
            else
            {
                Console.WriteLine("Motor: OFF");
            }

            Console.WriteLine("Velocidad: " + _velocidadActual + " km/h");

            if (_modoCrucero)
            {
                Console.WriteLine("Modo Crucero: ACTIVADO");
            }
            else
            {
                Console.WriteLine("Modo Crucero: DESACTIVADO");
            }
        }
    }
}

