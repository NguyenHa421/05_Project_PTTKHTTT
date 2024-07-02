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
    public partial class C_AppliedCV : Form
    {
        BindingSource applicationList = new BindingSource();
        public C_AppliedCV()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dtGrid_jobList.DataSource = applicationList;
            applicationList.DataSource = DTO_PTTKHTTT.Application.CandidateGetApplicationList(Login.loggedInAcc.Username);
            
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptn_refresh_Click(object sender, EventArgs e)
        {
            tb_compName.Clear();
            tb_job.Clear();
            dtGrid_jobList.DataSource = applicationList;
            applicationList.DataSource = DTO_PTTKHTTT.Application.CandidateGetApplicationList(Login.loggedInAcc.Username);
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dtGrid_jobList.DataSource = applicationList;
            applicationList.DataSource = DTO_PTTKHTTT.Application.CandidateSearchApplicationn(Login.loggedInAcc.Username, tb_compName.Text, tb_job.Text);
            
        }
    }
}
