using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19_05_ExercicioGlicemiaTerminal
{
    internal class Estatistica
    {
        public static double CalcularMedia(List<Glicemia> lista)
        {
            /* try
            {
                double media = 0;
                foreach (var item in lista)
                {
                    media += item.valor;
                }
                return media / lista.Count;
            }
            catch (System.Exception)
            {
                return 0; 
            } */

            if (lista.Count == 0) { return 0; }
            else { return lista.Sum(item => item.valor)/lista.Count; }
        }

        public static double CalcularMediana(List<Glicemia> lista) 
        {
            List<Glicemia> listaTemp = new List<Glicemia>();
            listaTemp.AddRange(lista);
            listaTemp.Sort();
            int i;
            for (i = 0; i < lista.Count / 2; i++) ;
            return (double)lista[i].valor;
        }


    }
}
