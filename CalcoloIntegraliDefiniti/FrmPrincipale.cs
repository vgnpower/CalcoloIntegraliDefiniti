using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcoloIntegraliDefiniti
{
    public partial class FrmPrincipale : Form
    {
        IntegrazioneNum ObjIntNum = new IntegrazioneNum();

        public FrmPrincipale()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdBtn_Rect.Checked = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            if (rdBtn_Rect.Checked)
                ObjIntNum.MetodoArea = true;
            else
                ObjIntNum.MetodoArea = false;

            try
            {
                txtBx_ris.Text = ObjIntNum.CalcolaAreaTotale(txtBx_eq.Text, Convert.ToInt16(txtBx_a.Text), Convert.ToInt16(txtBx_b.Text), Convert.ToInt32(numUpDwn_n.Value));
            }
            catch {}
        }

        private void rdBtn_Rect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtn_Trap_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
