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
    public partial class P_AddCompany : Form
    {
        public P_AddCompany(string name, string tax, string manager, string address, string email)
        {
            InitializeComponent();
            Load(name, tax, manager, address, email);
        }
        private void Load(string name, string tax, string manager, string address, string email)
        {
            tb_name.Text = name;
            tb_tax.Text = tax;
            tb_manager.Text = manager;
            tb_address.Text = address;
            tb_email.Text = email;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DTO_PTTKHTTT.Company newComp = new DTO_PTTKHTTT.Company("", tb_name.Text, tb_tax.Text, tb_manager.Text, tb_address.Text, tb_email.Text);
            DTO_PTTKHTTT.Company.AddCompany(newComp);
            Success success = new Success();
            success.ShowDialog();
            this.Close();
        }
    }
}
