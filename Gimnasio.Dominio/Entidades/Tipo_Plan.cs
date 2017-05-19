using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
   public class Tipo_Plan
    {
        #region Propiedades
        public int ID_TipoPlan { set; get; }
        public string nomb_plan { set; get; }
        public string descripcion { set; get; }
        public double importe_pago { set; get; }
        public int id_ejercicio { set; get; }
        public int id_nutricion { set; get; }
        #endregion
        #region Constructor
        private Tipo_Plan() {
        }
        #endregion
        #region Metodos
        public static Tipo_Plan crear(int ID, string nomb, string desc, double pago, int ejercicio, int nutricion)
        {
            return new Tipo_Plan()
            {
                ID_TipoPlan = ID,
                nomb_plan = nomb,
                descripcion = desc,
                importe_pago = pago,
                id_ejercicio = ejercicio,
                id_nutricion = nutricion
            };
        }
        public void Modificar(int ID, string nomb, string desc, double pago, int ejercicio, int nutricion)
        {

            nomb_plan = nomb;
            descripcion = desc;
            importe_pago = pago;
            id_ejercicio = ejercicio;
            id_nutricion = nutricion;
        }
        #endregion
    }


}
