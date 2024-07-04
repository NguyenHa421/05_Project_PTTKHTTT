using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Project_PTTKHTTT.Personnel
{
    public partial class P_Homepage : Form
    {
        public P_Homepage()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_parents.Controls.Add(childForm);
            pn_parents.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Enterprise_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personnel.P_CompanyList());
            
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personnel.P_ExpiredContract());
        }

        private void btn_cv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personnel.P_Application());
        }

        private void btn_recruit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personnel.P_Recruitment());
        }
    }
}
