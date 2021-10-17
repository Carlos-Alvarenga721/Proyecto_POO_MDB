using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_POO
{//ESTA CLASE ME SIRVE PARA HACER LA CONEXION CON LA BASE DE DATOS
    class Conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;

        public void conec()
        {
            servidor = "CARLOS-COMPUTER";
            db = "PROYECTO_POO";
            usuario = "sa";
            clave = "C1a2a3c4";
            cadena = $"server={servidor};uid={usuario};pwd={clave};database={db}";
        }
    }
}
