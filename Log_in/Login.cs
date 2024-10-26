using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in
{
    public partial class Login: UserControl
    {
        public Login()
        {
            InitializeComponent();
            btn_DangNhap.Click += Btn_DangNhap_Click;
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            
        }
    }
}
