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
    public partial class P_UpdateRecruitment : Form
    {
        Recruitment curRec;
        List<PostedJob> jobList;
        int clickedRow = -1;
        BindingSource jobListBinding = new BindingSource();
        public P_UpdateRecruitment(Contract contract)
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
            LoadComboBox(contract);
            LoadGrid();
        }
        void LoadTextbox(Contract contract)
        {
            tb_regID.Text = contract.registerID;
            tb_compName.Text = contract.compName;
            dt_date.Text = curRec.postdate.ToString();
        }
        void LoadComboBox(Contract contract)
        {
            cbB_state.Items.Add("Chưa đăng");
            cbB_state.Items.Add("Đã đăng");
            if (contract.state == "Đã đăng")
                cbB_state.SelectedIndex = 1;
            else
                cbB_state.SelectedIndex = 0;
            List<AdForm> adFormList = AdForm.GetAdFormList();
            for (int i = 0; i < adFormList.Count(); i++)
            {
                cbB_formpost.Items.Add(adFormList[i].formName);
                if (adFormList[i].formID == curRec.formID)
                    cbB_formpost.SelectedIndex = i;
            }
        }
        void LoadGrid()
        {
            dtGrid_jobList.DataSource = jobListBinding;
            jobList = PostedJob.GetPostedJobsByRegID(curRec.regID);
            jobListBinding.DataSource = jobList;
            dtGrid_jobList.Columns[0].Visible = false;
            dtGrid_jobList.Columns[3].Visible = false;
            dtGrid_jobList.Columns[4].Visible = false;
            dtGrid_jobList.Columns[5].Visible = false;
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
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrid_jobList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRow = e.RowIndex;
            tb_criteria.Text = jobList[clickedRow].criteria;
            tb_quantity.Text = jobList[clickedRow].quantity.ToString();
            tb_vacancy.Text = jobList[clickedRow].jobName;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int quantity;
            try
            {
                quantity = int.Parse(tb_quantity.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng tuyển dụng không hợp lệ!", "Lỗi");
                return;
            }
            PostedJob updatedJob = new PostedJob(tb_regID.Text, tb_vacancy.Text, quantity, tb_criteria.Text, "", dt_date.Value, cbB_state.Text);
            OpenChildForm(new P_UpdateRecruitmentContent(updatedJob, curRec.content, jobList[clickedRow].jobName, cbB_formpost.Text));
        }
    }
}
