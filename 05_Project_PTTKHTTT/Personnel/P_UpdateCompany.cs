using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _05_Project_PTTKHTTT.Personnel
{
    public partial class P_UpdateCompany : Form
    {
        public P_UpdateCompany(string id, string name, string tax, string manager, string address, string email)
        {
            InitializeComponent();
            Load(id, name, tax, manager, address, email);
        }
        private void Load(string id, string name, string tax, string manager, string address, string email)
        {
            tb_compID.Text = id;
            tb_name.Text = name;
            tb_tax.Text = tax;
            tb_manager.Text = manager;
            tb_address.Text = address;
            tb_email.Text = email;
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
                        DTO_PTTKHTTT.Company.UpdateCompany(tb_compID.Text, tb_name.Text, tb_tax.Text, tb_manager.Text, tb_address.Text, tb_email.Text);
                    }
                    catch (Exception ex)
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
