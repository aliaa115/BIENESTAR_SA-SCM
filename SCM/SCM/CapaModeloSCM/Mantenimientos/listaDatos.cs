using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaModeloSCM.Mantenimientos.ListaDatos
{
    public class ListaData : IEquatable<ListaData>
    {
        public string titulo { get; set; }

        public string form { get; set; }

        public string ayuda { get; set; }
        public bool Equals(ListaData other)
        {
            throw new NotImplementedException();
        }
    }
}
