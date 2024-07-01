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
            List<AdForm> list = AdForm.GetAdFormList();
            foreach (AdForm adForm in list)
            {
                cbB_formpost.Items.Add(adForm.formName);
            }
            cbB_formpost.SelectedIndex = 0;
        }
    }
}
