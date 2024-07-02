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
    public partial class P_UpdateRecruitmentContent : Form
    {
        PostedJob updatedJob;
        string newForm;
        string oldJobName;
        public P_UpdateRecruitmentContent(PostedJob updatedJob, string content, string oldJobName, string newForm)
        {
            InitializeComponent();
            tb_content.Text = content;
            this.updatedJob = updatedJob;
            this.newForm = newForm;
            this.oldJobName = oldJobName;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            updatedJob.content = tb_content.Text;
            try
            {
                Recruitment.UpdateRecruitment(updatedJob, oldJobName, newForm);
            }
            catch(Exception ex)
            {
                if (ex.ToString().Contains("FK_HS_TTDT"))
                {
                    MessageBox.Show("Vị trí này đã có hồ sơ nộp, không thể chỉnh sửa!", "Lỗi");
                    return;
                }
                else
                    MessageBox.Show(ex.ToString());
            }
        }
    }
}
