using System;
using System.Collections.Generic;
using System.Text;

namespace PF02_Actividad1
{
    public class FuncionesContrasenya
    {

        public bool EsContrasenyaValida(string contrasenya)
        {
            // Devuelve true si cumple todas las condiciones
            return !string.IsNullOrEmpty(contrasenya)
            && contrasenya.Length >= 8
            && contrasenya.Contains("#");
        }
    }
}
