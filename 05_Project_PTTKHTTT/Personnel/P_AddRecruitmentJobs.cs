using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
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
    public partial class P_AddRecruitmentJobs : Form
    {
        Contract newContract;
        string form;
        string content;
        DateTime postDate;
        int clickedRow = -1;
        DataTable jobList;
        public P_AddRecruitmentJobs(Contract newContract, string form, string content, DateTime postDate)
        {
            InitializeComponent();
            LoadAttributes(newContract, form, content, postDate);
            LoadGrid();
        }
        void LoadAttributes(Contract newContract, string form, string content, DateTime postDate)
        {
            this.newContract = newContract;
            this.form = form;
            this.content = content;
            this.postDate = postDate;
        }
        void LoadGrid()
        {
            jobList = new DataTable();
            jobList.Columns.Add("jobName", typeof(string));
            jobList.Columns.Add("amount", typeof(int));
            jobList.Columns.Add("criteria", typeof(string));
            dtGrid_jobList.DataSource = jobList;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_criteria.Text == "" || tb_quantity.Text == "" || tb_vacancy.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin!", "Lỗi");
                return;
            }
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
            jobList.Rows.Add(tb_vacancy.Text, quantity, tb_criteria.Text);
        }

        private void dtGrid_jobList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRow = e.RowIndex;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (clickedRow >= 0)
                jobList.Rows.RemoveAt(clickedRow);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string curCounter = ContractDAO.Instance.GetCurrentCounter();
            string newCounter = Contract.CreateNewID(curCounter);
            newContract.registerID = newCounter;
            Contract.AddContract(newContract);
            Contract.AddRecruitmentPost(newContract.registerID, form, content, postDate);
            foreach (DataRow row in jobList.Rows)
            {
                PostedJob newJob = new PostedJob(newContract.registerID, row["jobName"].ToString(), (int)row["amount"], row["criteria"].ToString());
                PostedJob.PostJob(newJob);
            }
            Success success = new Success();
            success.ShowDialog();
            this.Close();
        }
    }
}
