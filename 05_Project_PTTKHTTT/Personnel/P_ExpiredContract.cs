﻿using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Project_PTTKHTTT.Personnel
{
    public partial class P_ExpiredContract : Form
    {
        BindingSource expiredContractList = new BindingSource();
        int clickedRow = -1;
        string listDelete = "('0', '0')";
        List<ExpiredContractDTO> expiredContracts;
        public P_ExpiredContract()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dtGrid_expiredComp.DataSource = expiredContractList;
            expiredContracts = ExpiredContractDAO.Instance.GetExpiredContracList();
            expiredContractList.DataSource = expiredContracts;
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
            expiredContracts = ExpiredContractDAO.Instance.SearchxpiredContracList("", listDelete);
            expiredContractList.DataSource = expiredContracts;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            expiredContracts = ExpiredContractDAO.Instance.SearchxpiredContracList(tb_compName.Text, listDelete);
            expiredContractList.DataSource = expiredContracts;
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            listDelete = "('0', '0')";
            expiredContracts = ExpiredContractDAO.Instance.SearchxpiredContracList(tb_compName.Text, listDelete);
            expiredContractList.DataSource = expiredContracts;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (clickedRow < 0)
                return;
            using (Confirm_Delete confirm = new Confirm_Delete())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    if (listDelete.Length > 0)
                    {
                        listDelete += ',';
                    }
                    listDelete += "('" + expiredContracts[clickedRow].expireID + "','" + expiredContracts[clickedRow].registerID + "')" ;
                    expiredContracts = ExpiredContractDAO.Instance.SearchxpiredContracList(tb_compName.Text, listDelete);
                    expiredContractList.DataSource = expiredContracts;
                    Success success = new Success();
                    success.ShowDialog();
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            using (Confirm_Delete confirm = new Confirm_Delete())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    Success success = new Success();
                    success.ShowDialog();
                }
            }
        }

        private void dtGrid_expiredComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && e.ColumnIndex >=0) 
            {
                clickedRow = e.RowIndex;
            }
        }
    }
}
