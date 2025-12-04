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
    public partial class HospitalApp : ManteHosFormBase
    {
        public HospitalApp()
        {
            InitializeComponent();
        }

        public HospitalApp(IManteHosService s) : base(s)
        {
            InitializeComponent();
        }
    }
}
