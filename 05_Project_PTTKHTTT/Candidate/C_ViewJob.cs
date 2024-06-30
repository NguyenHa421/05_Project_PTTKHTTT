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
        BindingSource postedJobs = new BindingSource();
        public C_ViewJob()
        {
            InitializeComponent();
            LoadGrid();
        }
        void LoadGrid()
        {
            dtGrid_jobList.DataSource = postedJobs;
            postedJobs.DataSource = PostedJob.GetPostedJobList();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
