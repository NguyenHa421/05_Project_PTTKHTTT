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
    public partial class P_RecruitmentDetail : Form
    {
        Recruitment curRec;
        List<PostedJob> jobList;
        BindingSource jobListBinding = new BindingSource();
        public P_RecruitmentDetail(Contract contract)
        {
            InitializeComponent();
            try
            {
                curRec = Recruitment.GetRecruitmentByID(contract.registerID);
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("There is no row at position 0"))
                {
                    MessageBox.Show("Phiếu đăng ký này chưa có bài đăng!", "Lỗi");
                    return;
                }
            }
            LoadTextbox(contract);
            LoadGrid();
        }
        void LoadTextbox(Contract contract)
        {
            tb_compName.Text = contract.compName;
            tb_date.Text = curRec.postdate.ToString();
            tb_formpost.Text = AdForm.GetAdFormNameByID(curRec.formID);
            tb_state.Text = curRec.state;
        }
        void LoadGrid()
        {
            dtGrid_vacancyList.DataSource = jobListBinding;
            jobList = PostedJob.GetPostedJobsByRegID(curRec.regID);
            jobListBinding.DataSource = jobList;
            dtGrid_vacancyList.Columns[0].Visible = false;
            dtGrid_vacancyList.Columns[3].Visible = false;
            dtGrid_vacancyList.Columns[4].Visible = false;
            dtGrid_vacancyList.Columns[5].Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrid_vacancyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tb_criteria.Text = jobList[e.RowIndex].criteria;
        }
    }
}
