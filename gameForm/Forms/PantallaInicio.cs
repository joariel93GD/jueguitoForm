using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager;

namespace Forms
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {

            start.Visible = false;
            botonAbD.Visible = true;
            botonAbI.Visible = true;
            botonCentro.Visible = true;
            botonArD.Visible = true;
            botonArI.Visible = true;

        }
        

    }
}
