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

        private void btn_Enterprise_Click(object sender, EventArgs e)
        {
            Personnel.P_CompanyList companyList = new Personnel.P_CompanyList();
            this.Hide();
            companyList.ShowDialog();
            this.Show();
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            Personnel.P_ExpiredContract expiredContract = new Personnel.P_ExpiredContract();
            this.Hide();    
            expiredContract.ShowDialog();
            this.Show();
        }

        private void btn_cv_Click(object sender, EventArgs e)
        {
            Personnel.P_Application application = new Personnel.P_Application();
            this.Hide();
            application.ShowDialog();
            this.Show();
        }

        private void btn_recruit_Click(object sender, EventArgs e)
        {
            Personnel.P_Recruitment recruitment = new Personnel.P_Recruitment();
            this.Hide();
            recruitment.ShowDialog();
            this.Show();
        }
    }
}
