using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SocioDeCampo1
{
    public partial class form2 : Form
    {

        private IconButton currentBtn;
        private Panel leftborderBtn;

        public form2()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftborderBtn);
        }
        //Metodos
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
