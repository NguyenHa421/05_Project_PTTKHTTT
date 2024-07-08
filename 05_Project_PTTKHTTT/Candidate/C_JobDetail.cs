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
    public partial class C_JobDetail : Form
    {
        PostedJob curJob;
        public C_JobDetail(PostedJob curJob)
        {
            InitializeComponent();
            this.curJob = curJob;
            LoadTextbox();
        }
        void LoadTextbox()
        {
            tb_compName.Text = curJob.compName;
            tb_jobName.Text = curJob.jobName;
            tb_amount.Text = curJob.quantity.ToString();
            tb_criteria.Text = curJob.criteria;
            tb_postdate.Text = curJob.postdate.ToString();
            tb_state.Text = curJob.state;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            DTO_PTTKHTTT.Application newApply = new DTO_PTTKHTTT.Application("0", curJob.regID, Login.loggedInAcc.Username, tb_jobName.Text);
            try
            {
                DTO_PTTKHTTT.Application.AddApplication(newApply);
                Success success = new Success();
                success.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
