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
    internal partial class UpdateStaff : Form
    {
        Staff staff;
        public UpdateStaff()
        {
            InitializeComponent();
        }

        public UpdateStaff(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            txt_updateNameStaff.Text = staff.name;
            txt_updateBirthYearStaff.Text = staff.birthYear;
            txt_updateIdentityStaff.Text = staff.identity;
            txt_updateAddressStaff.Text = staff.address;
            txt_updatePhone.Text = staff.phone;
            txt_updateRoleStaff.Text = staff.role;
            txt_updatePasswordStaff.Text = staff.password;

        }

        private void btn_cancelUpdateStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
