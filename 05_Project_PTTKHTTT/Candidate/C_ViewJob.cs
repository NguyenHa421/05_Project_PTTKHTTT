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

namespace _05_Project_PTTKHTTT.Candidate
{
    public partial class C_ViewJob : Form
    {
        List<PostedJob> postedJobs;
        BindingSource postedJobBinding = new BindingSource();
        int clickedRow;
        public C_ViewJob()
        {
            InitializeComponent();
            LoadGrid();
            clickedRow = -1;
        }
        void LoadGrid()
        {
            dtGrid_jobList.DataSource = postedJobBinding;
            postedJobs = PostedJob.GetPostedJobList();
            postedJobBinding.DataSource = postedJobs;
            dtGrid_jobList.Columns["regID"].Visible = false;
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            postedJobs = PostedJob.GetPostedJobList();
            postedJobBinding.DataSource = postedJobs;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string compName = tb_compName.Text;
            string jobName = tb_job.Text;
            postedJobs = PostedJob.SearchPostedJob(compName, jobName);
            postedJobBinding.DataSource = postedJobs;
        }

        private void dtGrid_jobList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRow = e.RowIndex;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (clickedRow >= 0)
            {
                OpenChildForm(new Candidate.C_JobContents(postedJobs[clickedRow]));
            }
        }
    }
}
