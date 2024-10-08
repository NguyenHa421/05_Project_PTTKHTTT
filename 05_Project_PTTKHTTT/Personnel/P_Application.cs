﻿using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
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
        List<DTO_PTTKHTTT.Application> application;
        public P_Application()
        {
            InitializeComponent();
            LoadComboBox();
            LoadGrid();
        }
        private void LoadComboBox()
        {
            cbB_compName.Items.Add("All");

            List<Company> companies = DTO_PTTKHTTT.Company.GetCompanyList();
            foreach (Company c in companies)
                cbB_compName.Items.Add(c.compName);
            cbB_compName.SelectedIndex = 0;
        }
        private void LoadGrid()
        {
            dtGrid_application.DataSource = applicationList;
            application = DTO_PTTKHTTT.Application.GetApplicationList();
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
            tb_vancancyName.Clear();
            tb_candidateName.Clear();
            cbB_compName.Text = "All";
            dtGrid_application.DataSource = applicationList;
            application = DTO_PTTKHTTT.Application.GetApplicationList();
            applicationList.DataSource = application;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dtGrid_application.DataSource = applicationList;
            application = DTO_PTTKHTTT.Application.SearchApplicationn(cbB_compName.Text, tb_vancancyName.Text, tb_candidateName.Text);
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
                OpenChildForm(new Personnel.P_UpdateApplication(application[clickedRow].applicationID, application[clickedRow].registerID, application[clickedRow].compName, application[clickedRow].candidateID, application[clickedRow].candidateName, application[clickedRow].vancancyName, application[clickedRow].stateNow));
            }
        }
    }
}
