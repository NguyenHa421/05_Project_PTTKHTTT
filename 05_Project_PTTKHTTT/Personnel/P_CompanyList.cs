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
    public partial class P_CompanyList : Form
    {
        BindingSource companyList = new BindingSource();
        int clickedRow = 0;
        List<Company> companies;
        public P_CompanyList()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dtGrid_companyList.DataSource = companyList;
            companies = DTO_PTTKHTTT.Company.GetCompanyList();
            companyList.DataSource = companies;
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
        private void ptn_refresh_Click(object sender, EventArgs e)
        {
            tb_compName.Clear();
            dtGrid_companyList.DataSource = companyList;
            companies = DTO_PTTKHTTT.Company.GetCompanyList();
            companyList.DataSource = companies;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            dtGrid_companyList.DataSource = companyList;
            companies = DTO_PTTKHTTT.Company.SearchCompany(tb_compName.Text);
            companyList.DataSource = companies;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personnel.P_AddCompany("", "", "", "", ""));
        }

        private void dtGrid_companyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRow = e.RowIndex;
        }
    }
}
