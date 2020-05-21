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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            
        }


        private void btnReintentar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
