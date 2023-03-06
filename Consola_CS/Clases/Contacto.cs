using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_CS.Clases
{
    public class Contacto : Persona
    {
        private string _telefono;
        private string _correo;
        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value.Replace(" ", "").Replace("-", "");
            }
        }
        public string Correo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
            }
        }
        public Contacto() : base()
        {
            _telefono = string.Empty;
        }

        public Contacto(string _name, DateTime? _fechaNacimiento, string _telefono) : base(_name, _fechaNacimiento)
        {
            this._telefono = _telefono;
        }

        public override string ToString()
        {
            return base.ToString() + " " + _telefono + " " + _correo;
        }
    }
}
