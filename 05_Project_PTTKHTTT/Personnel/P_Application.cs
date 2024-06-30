using _05_Project_PTTKHTTT.BUS_PTTKHTTT;
using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
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
    public partial class P_Application : Form
    {
        BindingSource applicationList = new BindingSource();
        int clickedRow = 0;
        List<ApplicationDTO> application;
        public P_Application()
        {
            InitializeComponent();
            LoadComboBox();
            LoadGrid();
        }
        private void LoadComboBox()
        {
            cbB_compName.Items.Add("NGÂN HÀNG TMCP NGOẠI THƯƠNG VIỆT NAM");
            cbB_compName.Items.Add("tập");
            //List<CompanyDTO> companies = CompanyDAO.Instance.GetCompanyList();
            //foreach (CompanyDTO c in list)
            //  cbB_compName.Items.Add(c.TenDoanhNghiep);
            //cbB_compName.SelectedIndex = 0;
        }
        private void LoadGrid()
        {
            dtGrid_application.DataSource = applicationList;
            application = ApplicationBUS.Instance.GetApplicationList();
            applicationList.DataSource = application;
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
            dtGrid_application.DataSource = applicationList;
            application = ApplicationBUS.Instance.GetApplicationList();
            applicationList.DataSource = application;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dtGrid_application.DataSource = applicationList;
            application = ApplicationBUS.Instance.SearchApplicationn(cbB_compName.Text);
            applicationList.DataSource = application;
        }

        private void dtGrid_application_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clickedRow = e.RowIndex;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (clickedRow >= 0)
            {
                OpenChildForm(new Personnel.P_UpdateApplication(application[clickedRow].applicationID, application[clickedRow].registerID, application[clickedRow].compName, application[clickedRow].candID, application[clickedRow].candName, application[clickedRow].vancancyName, application[clickedRow].state));
            }
        }
    }
}
