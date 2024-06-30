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
    public partial class C_Homepage : Form
    {
        public C_Homepage()
        {
            InitializeComponent();
        }

        private void btn_findjob_Click(object sender, EventArgs e)
        {
            Candidate.C_ViewJob view_Job = new Candidate.C_ViewJob();
            this.Hide();
            view_Job.ShowDialog();
            this.Show();
        }

        private void btn_applied_Click(object sender, EventArgs e)
        {
            Candidate.C_AppliedCV appliedCV = new Candidate.C_AppliedCV();
            this.Hide();
            appliedCV.ShowDialog();
            this.Show();
        }
    }
}
