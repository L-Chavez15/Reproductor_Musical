using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecucion
{
    public partial class Form2 : Form
    {
        ListaDoble ld;
        public Form2(ref ListaDoble ld)
        {
            InitializeComponent();
            this.ld = ld;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
