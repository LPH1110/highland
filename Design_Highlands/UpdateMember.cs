using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    internal partial class UpdateMember : Form
    {
        Member member;
        public UpdateMember()
        {
            InitializeComponent();
        }
        public UpdateMember(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        // Events
        private void UpdateMember_Load(object sender, EventArgs e)
        {
            txt_updateNameMem.Text = member.name;
            txt_updatePhoneMem.Text = member.phone;

        }



    }
}
