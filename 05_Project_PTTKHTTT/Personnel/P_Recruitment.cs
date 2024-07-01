using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
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
    public partial class P_Recruitment : Form
    {
        List<Contract> contracts;
        BindingSource contractBinding = new BindingSource();
        public P_Recruitment()
        {
            InitializeComponent();
            LoadGrid();
        }
        void LoadGrid()
        {
            dtGrid_recruitmentList.DataSource = contractBinding;
            contracts = Contract.GetContractList();
            contractBinding.DataSource = contracts;
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
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            contracts = Contract.SearchContract(tb_compName.Text);
            contractBinding.DataSource = contracts;
        }

        private void ptn_refresh_Click(object sender, EventArgs e)
        {
            contracts = Contract.GetContractList();
            contractBinding.DataSource = contracts;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new P_AddRecruitment());
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {

        }
    }
}
