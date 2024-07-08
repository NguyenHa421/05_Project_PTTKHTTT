using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _05_Project_PTTKHTTT.Candidate
{
    public partial class C_RegisterAccount : Form
    {
        public static DTO_PTTKHTTT.Candidate cdd = new DTO_PTTKHTTT.Candidate();
        public C_RegisterAccount()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            pic_hide.Visible = true;
            pic_show.Visible = false;
            pic_hide2.Visible = true;
            pic_show2.Visible = false;
            tb_password.UseSystemPasswordChar = true;
            tb_confirm.UseSystemPasswordChar = true;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_birthyear.Text == "" || tb_phone.Text == "" || tb_email.Text == "" || tb_address.Text == "" || tb_password.Text == "" || tb_confirm.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
                return;
            }

            cdd.CandidateName = tb_name.Text;
            cdd.YearofBirth = int.Parse(tb_birthyear.Text);
            cdd.PhoneNumber = tb_phone.Text;
            cdd.Email = tb_email.Text;
            cdd.Address = tb_address.Text;
            string pwd = tb_password.Text;
            string confirm_pwd = tb_confirm.Text;

            if (pwd != confirm_pwd)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khầu không giống nhau. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                bool addCdd = DTO_PTTKHTTT.Candidate.AddCandidate(cdd);
                bool addAcc = DTO_PTTKHTTT.Account.AddAccountTV(pwd);
                if (addCdd && addAcc)
                {
                    string username = DTO_PTTKHTTT.Account.GetMaxID();
                    MessageBox.Show($"Đăng ký thành công! Username của bạn là: {username}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_show_Click(object sender, EventArgs e)
        {
            pic_show.Visible = false;
            pic_hide.Visible = true;
            tb_password.UseSystemPasswordChar = true;
        }

        private void pic_hide_Click(object sender, EventArgs e)
        {
            pic_show.Visible = true;
            pic_hide.Visible = false;
            tb_password.UseSystemPasswordChar = false;
        }

        private void pic_show2_Click(object sender, EventArgs e)
        {
            pic_show2.Visible = false;
            pic_hide2.Visible = true;
            tb_confirm.UseSystemPasswordChar = true;
        }

        private void pic_hide2_Click(object sender, EventArgs e)
        {
            pic_show2.Visible = true;
            pic_hide2.Visible = false;
            tb_confirm.UseSystemPasswordChar = false;
        }
    }
}
