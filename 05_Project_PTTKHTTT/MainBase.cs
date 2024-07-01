using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
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

namespace _05_Project_PTTKHTTT
{
    public partial class MainBase : Form
    {
        public MainBase()
        {
            InitializeComponent();
            Load_Form();
        }
        private void Load_Form()
        {
            tb_name.Text = Account.GetName(Login.loggedInAcc.Username, Login.loggedInAcc.Role);
            if (Login.loggedInAcc.Role == "NhanVien")
                OpenChildForm(new Personnel.P_Homepage());
            else
                OpenChildForm(new Candidate.C_Homepage());
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
        private void pic_Logout_Click(object sender, EventArgs e)
        {
            using (Confirm_Logout confirm = new Confirm_Logout())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                        this.Close();
                }
            }
        }
    }
}
