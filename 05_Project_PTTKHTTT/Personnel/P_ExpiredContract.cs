using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
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
        List<Company> expiredContracts;
        public P_ExpiredContract()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dtGrid_expiredComp.DataSource = expiredContractList;
            expiredContracts = Company.SearchCompany("");
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

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_restore_Click_1(object sender, EventArgs e)
        {
            listDelete = "('0', '0')";
            expiredContracts = Company.SearchCompany(tb_compName.Text);
            expiredContractList.DataSource = expiredContracts;
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
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
                    listDelete += "('" + expiredContracts[clickedRow].expireID + "','" + expiredContracts[clickedRow].registerID + "')";
                    expiredContracts = Company.SearchExpiredCompany(tb_compName.Text, listDelete);
                    expiredContractList.DataSource = expiredContracts;
                    Success success = new Success();
                    success.ShowDialog();
                }
            }
        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            Success success = new Success();
            success.ShowDialog();
        }

        private void ptn_refresh_Click_1(object sender, EventArgs e)
        {
            expiredContracts = Company.SearchExpiredCompany("", listDelete);
            expiredContractList.DataSource = expiredContracts;
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            expiredContracts = Company.SearchExpiredCompany(tb_compName.Text, listDelete);
            expiredContractList.DataSource = expiredContracts;
        }

        private void dtGrid_expiredComp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clickedRow = e.RowIndex;
            }
        }
    }
}
