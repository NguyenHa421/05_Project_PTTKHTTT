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
    public partial class C_JobContents : Form
    {
        PostedJob curJob;
        public C_JobContents(PostedJob curJob)
        {
            InitializeComponent();
            this.curJob = curJob;
            LoadTextbox();
        }
        void LoadTextbox()
        {
            tb_content.Text = curJob.content;
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Candidate.C_JobDetail(curJob));
        }
    }
}
