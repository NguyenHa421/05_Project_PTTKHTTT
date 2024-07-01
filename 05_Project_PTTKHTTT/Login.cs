using _05_Project_PTTKHTTT.Candidate;
using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using _05_Project_PTTKHTTT.Personnel;
using System.Windows.Forms;

namespace _05_Project_PTTKHTTT
{
    public partial class Login : Form
    {

        public static Account loggedInAcc = new Account();

        public Login()
        {
            InitializeComponent();
            Load();
        }
        bool Login_Success(string user, string pass)
        {
            return Account.Login(user, pass);
        }
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Load()
        {
            tb_pass.UseSystemPasswordChar = true;
            tb_user.Text = "";
            tb_pass.Text = "";
            //pic_Hide.Visible = false;
            //pic_Show.Visible = true;
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            C_RegisterAccount register = new C_RegisterAccount();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string password = tb_pass.Text;
            if (username == "")
            {
                MessageBox.Show("Username không được trống!");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Password không được trống!");
                return;
            }
            bool success = Login_Success(username, password);
            if (success)
            {
                loggedInAcc.Username = username;
                loggedInAcc.Role = Account.GetRole(username);
                MainBase mainBase = new MainBase();
                this.Hide();
                mainBase.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
        }

    }
}
