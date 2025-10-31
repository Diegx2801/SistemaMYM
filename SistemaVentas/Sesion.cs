using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    internal class Sesion
    {
        public static string Usuario { get; set; }
        public static string Rol { get; set; }

        public static bool EsGerencia { get { return Rol == "Gerente"; } }
        public static bool EsAsistente { get { return Rol == "Asistente de Producción"; } }
        public static bool EsAlmacen { get { return Rol == "Almacenero"; } }
        public static bool EsProveedor { get { return Rol == "Proveedor"; } }
        public static bool EsDistribuidor { get { return Rol == "Distribuidor"; } }
    }
}

