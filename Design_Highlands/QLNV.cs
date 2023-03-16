using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    internal partial class QLNV : Form
    {
        Staff staff;
        public QLNV()
        {
            InitializeComponent();
        }
        public QLNV(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

    }
}
