using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Futbolista
{
    abstract class Estado
    {
       public abstract void CansarA(Futbolista futbolista);
        public abstract void DescansarA(Futbolista futbolista);
        public virtual bool PuedoJugar() {
            return true;
        }
    }
    class Activo : Estado
    {
        public override void CansarA(Futbolista futbolista)
        {
            futbolista.Estado = new Cansado();
        }
        public override void DescansarA (Futbolista futbolista)
        {
            //No hago nada porque si esta activo no necesita descansar
        }
    }
    class Cansado : Estado
    {
        private int cantpartidosjugados = 0;
        public override void CansarA(Futbolista futbolista)
        {
            cantpartidosjugados++;
            if (cantpartidosjugados > 1)
            {
                futbolista.Estado = new Lesionado();
            }
            

        }
        public override void DescansarA(Futbolista futbolista)
        {
            futbolista.Estado = new Activo();
        }
    }

    class Lesionado : Estado
    {
        public override void CansarA(Futbolista futbolista)
        {
            //No puedo cansar a un jugador lesionado
        }
        public override void DescansarA(Futbolista futbolista)
        {
            futbolista.Estado = new Cansado();
            //De lesionado pasa a cansado
        }
        public override bool PuedoJugar()
        {
            return false;
        }
    }
}
