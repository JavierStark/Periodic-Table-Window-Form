using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Element
    {
        public string name { get; set; }
        public string appearance { get; set; }
        public double atomic_mass { get; set; }
        public double? boil { get; set; }
        public string category { get; set; }
        public string color { get; set; }
        public double? density { get; set; }
        public string discovered_by { get; set; }
        public double? melt { get; set; }
        public double? molar_heat { get; set; }
        public string named_by { get; set; }
        public int number { get; set; }
        public int period { get; set; }
        public string phase { get; set; }
        public string source { get; set; }
        public string spectral_img { get; set; }
        public string summary { get; set; }
        public string symbol { get; set; }
        public int xpos { get; set; }
        public int ypos { get; set; }
        public IList<int> shells { get; set; }
        public string electron_configuration { get; set; }
        public string electron_configuration_semantic { get; set; }
        public double? electron_affinity { get; set; }
        public double? electronegativity_pauling { get; set; }
        public IList<double> ionization_energies { get; set; }
        public string cpk_hex { get; set; }
}
}
