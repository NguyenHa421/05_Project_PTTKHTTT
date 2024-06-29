using _05_Project_PTTKHTTT.BUS_PTTKHTTT;
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
    public partial class P_UpdateApplication : Form
    {
        public P_UpdateApplication(string applicationID, string regID, string compName, string candiID, string candiName, string vacancy, string state)
        {
            InitializeComponent();
            Load(applicationID, regID, compName, candiID, candiName, vacancy, state);
            LoadComboBox();
        }
        private void Load(string applicationID, string regID, string compName, string candiID, string candiName, string vacancy, string state)
        {
            tb_idCV.Text = applicationID;
            tb_idRegister.Text = regID;
            tb_nameComp.Text = compName;
            tb_idCandidate.Text = candiID;
            tb_nameCandidate.Text = candiName;
            tb_vacancy.Text = vacancy;
            cbB_state.Text = state;
        }
        private void LoadComboBox()
        {
            cbB_state.Items.Add("Chưa duyệt");
            cbB_state.Items.Add("Duyệt");
            cbB_state.Items.Add("Không đạt");
            cbB_state.Items.Add("Đạt");
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ApplicationBUS.Instance.UpdateStatte(cbB_state.Text, tb_idCV.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Cập nhật không thành công!", "Lỗi");
                        return;
                    }
                    Success success = new Success();
                    success.ShowDialog();
                }
            }
        }
    }
}
