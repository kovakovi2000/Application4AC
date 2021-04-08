using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application4AC
{
    public partial class AP4AC : Form
    {
        private Dictionary<string, LicState> WORKINGCODES = new Dictionary<string, LicState>();

        enum LicState
        {
            NoAccess = 0,
            Normal,
            Premium
        }

        public AP4AC()
        {
            InitializeComponent();
        }

        private void AP4AC_Load(object sender, EventArgs e)
        {
            SetAccess(LicState.NoAccess);
            WORKINGCODES.Add("NC-h3a7g2", LicState.Normal);
            WORKINGCODES.Add("PC-Dr5L31", LicState.Premium);
        }

        private void SetAccess(LicState LS)
        {
            switch (LS)
            {
                case LicState.NoAccess:
                    {
                        lbl_Aim.ForeColor = Color.Red;
                        lbl_Wh.ForeColor = Color.Red;
                        lbl_Exp.ForeColor = Color.Red;
                        break;
                    }
                case LicState.Normal:
                    {
                        lbl_Aim.ForeColor = Color.Green;
                        lbl_Wh.ForeColor = Color.Green;
                        lbl_Exp.ForeColor = Color.Red;
                        break;
                    }
                case LicState.Premium:
                    {
                        lbl_Aim.ForeColor = Color.Green;
                        lbl_Wh.ForeColor = Color.Green;
                        lbl_Exp.ForeColor = Color.Green;
                        break;
                    }
                default:
                    break;
            }
        }

        private void btn_TestLicense_Click(object sender, EventArgs e)
        {
            if (WORKINGCODES.ContainsKey(tb_License.Text))
            {
                var tempLic = WORKINGCODES[tb_License.Text];
                SetAccess(tempLic);
                MessageBox.Show("Your access: " + tempLic.ToString());
            }
            else
            {
                SetAccess(LicState.NoAccess);
                MessageBox.Show("You entered an invaild license!");
            }
        }
    }
}
