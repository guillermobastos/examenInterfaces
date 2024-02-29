using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosComponentes
{
    internal class sFriki
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public eAficion AficionPrincipal { get; set; }
        public eSexo Sexo { get; set; }
        public eSexo SexoOpuesto { get; set; }
        public string Foto { get; set; }

        public sFriki(string nombre, int edad, eAficion aficionPrincipal, eSexo sexo, eSexo sexoOpuesto, string foto)
        {
            Nombre = nombre;
            Edad = edad;
            AficionPrincipal = aficionPrincipal;
            Sexo = sexo;
            SexoOpuesto = sexoOpuesto;
            Foto = foto;
        }

        public enum eAficion
        {
            Manga, SciFi, RPG, Fantasia, Terror, Tecnologia
        }

        public enum eSexo
        {
            Hombre, Mujer
        }
    }
}
