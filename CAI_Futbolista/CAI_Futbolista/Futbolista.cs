using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Futbolista
{
    abstract class Futbolista
    {
        private string nombre;
        private string equipo;
        private Estado estado;
        private int goles;
        private int cantidadpartidos;

        public Futbolista(string nombre, string equipo)
        {
            this.nombre = nombre;
            this.equipo = equipo;
            this.estado = new Activo();
            this.goles = 0;
        }
        public Estado Estado
        {
            get {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Equipo
        {
            get
            {
                return this.equipo;
            }
        }
        public int Goles
        {
            get
            {
                return this.goles;
            }
        }
        public void JugarPartido()
        {
            if (estado.PuedoJugar())
            {
                goles += GolesPorPartido();
                Cansarse();
            }
            else
            {
                throw new ArgumentException("El jugador esta lesionado, no puede jugar");
            }

        }
        public abstract int GolesPorPartido();
        public void Cansarse() {
            estado.CansarA(this);
        }
        public void Descansar()
        {
            estado.DescansarA(this);
        }
    }
}
