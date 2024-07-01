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
    public partial class P_AddRecruitment : Form
    {
        List<AdForm> adFormList;
        public P_AddRecruitment()
        {
            InitializeComponent();
            LoadCombobox();
        }
        void LoadCombobox()
        {
            LoadCompany();
            LoadAdForm();
        }
        void LoadCompany()
        {
            List<Company> list = Company.GetCompanyList();
            foreach (Company company in list)
            {
                cbB_compID.Items.Add(company.compID);
                cbB_compName.Items.Add(company.compName);
            }
            cbB_compID.SelectedIndex = 0;
            cbB_compName.SelectedIndex = 0;
        }
        void LoadAdForm()
        {
            adFormList = AdForm.GetAdFormList();
            foreach (AdForm adForm in adFormList)
            {
                cbB_formpost.Items.Add(adForm.formName);
            }
            cbB_formpost.SelectedIndex = 0;
            tb_unit.Text = adFormList[0].unit;
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
        private void cbB_compID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_compName.SelectedIndex = cbB_compID.SelectedIndex;
        }

        private void cbB_compName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_compID.SelectedIndex = cbB_compName.SelectedIndex;
        }

        private void cbB_formpost_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_unit.Text = adFormList[cbB_formpost.SelectedIndex].unit;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            Contract newContract = new Contract("0", cbB_compID.Text, cbB_compName.Text, DateTime.Today, "0");
            string formId = adFormList[cbB_formpost.SelectedIndex].formID;
            OpenChildForm(new P_AddRecruitmentJobs(newContract, formId, tb_content.Text, dt_date.Value));
        }
    }
}
