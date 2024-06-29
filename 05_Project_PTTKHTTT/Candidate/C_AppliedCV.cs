using _05_Project_PTTKHTTT.BUS_PTTKHTTT;
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
        List<ApplicationDTO> application;
        public C_AppliedCV()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dtGrid_jobList.DataSource = applicationList;
            application = ApplicationBUS.Instance.CandidateGetApplicationList("TV018");
            applicationList.DataSource = application;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptn_refresh_Click(object sender, EventArgs e)
        {
            dtGrid_jobList.DataSource = applicationList;
            application = ApplicationBUS.Instance.CandidateGetApplicationList("TV018");
            applicationList.DataSource = application;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }
    }
}
