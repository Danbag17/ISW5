using ManteHos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManteHosGUI
{
    public partial class MaestroForm : EmpleadoForm
    {
        public MaestroForm()
        {
            InitializeComponent();
        }

        public MaestroForm(IManteHosService s) : base(s)
        {
            InitializeComponent();
        }
    }
}
