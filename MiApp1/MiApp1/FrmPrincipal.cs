using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiApp1.clases;

namespace MiApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            Persona persona  = new Persona();  
            persona.Nombre = tbNombre.Text;
            persona.FechaNac = dtFechaNac.Value;
            MessageBox.Show(persona.EvaluarEdad());
        }
    }
}
