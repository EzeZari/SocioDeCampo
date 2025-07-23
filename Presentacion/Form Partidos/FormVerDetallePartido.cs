using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormVerDetallePartido : Form
    {
        private Partido partido;
        public FormVerDetallePartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }
    }
}
