using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InfoForm : Form
    {

        Element elementToShow;

        public InfoForm(Element e)
        {
            InitializeComponent();
            elementToShow = e;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NameLabel.Text = elementToShow.name;
            SymbolLabel.Text = elementToShow.symbol;
            AtomicNumberLabel.Text = "Atomic Number: "+elementToShow.number.ToString();
            AtomicMassLabel.Text = "Atomic Mass: "+elementToShow.atomic_mass.ToString();
            CategoryLabel.Text = "Category: " + elementToShow.category;
            DiscoverLabel.Text = elementToShow.discovered_by;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
