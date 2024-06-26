namespace _05_Project_PTTKHTTT.Candidate
{
    partial class C_RegisterAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic_logo = new PictureBox();
            pn_name = new Panel();
            tb_name = new TextBox();
            pn_phone = new Panel();
            tb_phone = new TextBox();
            pn_email = new Panel();
            tb_email = new TextBox();
            pn_birthyear = new Panel();
            tb_birthyear = new TextBox();
            pn_address = new Panel();
            tb_address = new TextBox();
            lb_main = new Label();
            pn_password = new Panel();
            tb_password = new TextBox();
            pn_confirm = new Panel();
            tb_confirm = new TextBox();
            btn_confirm = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            pn_name.SuspendLayout();
            pn_phone.SuspendLayout();
            pn_email.SuspendLayout();
            pn_birthyear.SuspendLayout();
            pn_address.SuspendLayout();
            pn_password.SuspendLayout();
            pn_confirm.SuspendLayout();
            SuspendLayout();
            // 
            // pic_logo
            // 
            pic_logo.Image = Properties.Resources.Logo_Reg1;
            pic_logo.Location = new Point(42, 42);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(146, 54);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 0;
            pic_logo.TabStop = false;
            // 
            // pn_name
            // 
            pn_name.BackgroundImage = Properties.Resources.Line1;
            pn_name.BackgroundImageLayout = ImageLayout.Zoom;
            pn_name.Controls.Add(tb_name);
            pn_name.Location = new Point(59, 141);
            pn_name.Name = "pn_name";
            pn_name.Size = new Size(405, 50);
            pn_name.TabIndex = 237;
            // 
            // tb_name
            // 
            tb_name.BackColor = Color.White;
            tb_name.BorderStyle = BorderStyle.None;
            tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(13, 9);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Họ và tên";
            tb_name.Size = new Size(376, 31);
            tb_name.TabIndex = 1;
            tb_name.TabStop = false;
            // 
            // pn_phone
            // 
            pn_phone.BackgroundImage = Properties.Resources.Line1;
            pn_phone.BackgroundImageLayout = ImageLayout.Zoom;
            pn_phone.Controls.Add(tb_phone);
            pn_phone.Location = new Point(59, 219);
            pn_phone.Name = "pn_phone";
            pn_phone.Size = new Size(405, 50);
            pn_phone.TabIndex = 238;
            // 
            // tb_phone
            // 
            tb_phone.BackColor = Color.White;
            tb_phone.BorderStyle = BorderStyle.None;
            tb_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(13, 9);
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "Số điện thoại";
            tb_phone.Size = new Size(376, 31);
            tb_phone.TabIndex = 1;
            tb_phone.TabStop = false;
            // 
            // pn_email
            // 
            pn_email.BackgroundImage = Properties.Resources.Line1;
            pn_email.BackgroundImageLayout = ImageLayout.Zoom;
            pn_email.Controls.Add(tb_email);
            pn_email.Location = new Point(495, 219);
            pn_email.Name = "pn_email";
            pn_email.Size = new Size(405, 50);
            pn_email.TabIndex = 239;
            // 
            // tb_email
            // 
            tb_email.BackColor = Color.White;
            tb_email.BorderStyle = BorderStyle.None;
            tb_email.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(13, 9);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Email";
            tb_email.Size = new Size(376, 31);
            tb_email.TabIndex = 1;
            tb_email.TabStop = false;
            // 
            // pn_birthyear
            // 
            pn_birthyear.BackgroundImage = Properties.Resources.Line1;
            pn_birthyear.BackgroundImageLayout = ImageLayout.Zoom;
            pn_birthyear.Controls.Add(tb_birthyear);
            pn_birthyear.Location = new Point(495, 141);
            pn_birthyear.Name = "pn_birthyear";
            pn_birthyear.Size = new Size(405, 50);
            pn_birthyear.TabIndex = 240;
            // 
            // tb_birthyear
            // 
            tb_birthyear.BackColor = Color.White;
            tb_birthyear.BorderStyle = BorderStyle.None;
            tb_birthyear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_birthyear.Location = new Point(13, 9);
            tb_birthyear.Name = "tb_birthyear";
            tb_birthyear.PlaceholderText = "Năm sinh";
            tb_birthyear.Size = new Size(376, 31);
            tb_birthyear.TabIndex = 1;
            tb_birthyear.TabStop = false;
            // 
            // pn_address
            // 
            pn_address.BackgroundImage = Properties.Resources.Line2;
            pn_address.BackgroundImageLayout = ImageLayout.Zoom;
            pn_address.Controls.Add(tb_address);
            pn_address.Location = new Point(59, 302);
            pn_address.Name = "pn_address";
            pn_address.Size = new Size(841, 50);
            pn_address.TabIndex = 241;
            // 
            // tb_address
            // 
            tb_address.BackColor = Color.White;
            tb_address.BorderStyle = BorderStyle.None;
            tb_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_address.Location = new Point(13, 9);
            tb_address.Name = "tb_address";
            tb_address.PlaceholderText = "Địa chỉ";
            tb_address.Size = new Size(812, 31);
            tb_address.TabIndex = 1;
            tb_address.TabStop = false;
            // 
            // lb_main
            // 
            lb_main.AutoSize = true;
            lb_main.BackColor = Color.White;
            lb_main.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_main.ForeColor = Color.FromArgb(42, 107, 167);
            lb_main.Location = new Point(382, 42);
            lb_main.Name = "lb_main";
            lb_main.Size = new Size(179, 54);
            lb_main.TabIndex = 3;
            lb_main.Text = "Đăng ký";
            // 
            // pn_password
            // 
            pn_password.BackgroundImage = Properties.Resources.Line1;
            pn_password.BackgroundImageLayout = ImageLayout.Zoom;
            pn_password.Controls.Add(tb_password);
            pn_password.Location = new Point(59, 385);
            pn_password.Name = "pn_password";
            pn_password.Size = new Size(405, 50);
            pn_password.TabIndex = 241;
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.White;
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_password.Location = new Point(13, 9);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "Nhập mật khẩu mới";
            tb_password.Size = new Size(376, 31);
            tb_password.TabIndex = 1;
            tb_password.TabStop = false;
            // 
            // pn_confirm
            // 
            pn_confirm.BackgroundImage = Properties.Resources.Line1;
            pn_confirm.BackgroundImageLayout = ImageLayout.Zoom;
            pn_confirm.Controls.Add(tb_confirm);
            pn_confirm.Location = new Point(495, 385);
            pn_confirm.Name = "pn_confirm";
            pn_confirm.Size = new Size(405, 50);
            pn_confirm.TabIndex = 242;
            // 
            // tb_confirm
            // 
            tb_confirm.BackColor = Color.White;
            tb_confirm.BorderStyle = BorderStyle.None;
            tb_confirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_confirm.Location = new Point(13, 9);
            tb_confirm.Name = "tb_confirm";
            tb_confirm.PlaceholderText = "Nhập lại mật khẩu";
            tb_confirm.Size = new Size(376, 31);
            tb_confirm.TabIndex = 1;
            tb_confirm.TabStop = false;
            // 
            // btn_confirm
            // 
            btn_confirm.BackgroundImage = Properties.Resources.b_r;
            btn_confirm.BackgroundImageLayout = ImageLayout.Zoom;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(508, 479);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(141, 54);
            btn_confirm.TabIndex = 243;
            btn_confirm.Text = "Đăng ký";
            btn_confirm.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.BackgroundImage = Properties.Resources.b_r;
            btn_back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(307, 479);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(141, 54);
            btn_back.TabIndex = 244;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // C_RegisterAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background1;
            ClientSize = new Size(957, 590);
            Controls.Add(btn_back);
            Controls.Add(btn_confirm);
            Controls.Add(pn_confirm);
            Controls.Add(pn_password);
            Controls.Add(lb_main);
            Controls.Add(pn_address);
            Controls.Add(pn_birthyear);
            Controls.Add(pn_email);
            Controls.Add(pn_phone);
            Controls.Add(pn_name);
            Controls.Add(pic_logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "C_RegisterAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C_RegisterAccount";
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            pn_name.ResumeLayout(false);
            pn_name.PerformLayout();
            pn_phone.ResumeLayout(false);
            pn_phone.PerformLayout();
            pn_email.ResumeLayout(false);
            pn_email.PerformLayout();
            pn_birthyear.ResumeLayout(false);
            pn_birthyear.PerformLayout();
            pn_address.ResumeLayout(false);
            pn_address.PerformLayout();
            pn_password.ResumeLayout(false);
            pn_password.PerformLayout();
            pn_confirm.ResumeLayout(false);
            pn_confirm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_logo;
        private Panel pn_name;
        private TextBox tb_name;
        private Panel pn_phone;
        private TextBox tb_phone;
        private Panel pn_email;
        private TextBox tb_email;
        private Panel pn_birthyear;
        private TextBox tb_birthyear;
        private Panel pn_address;
        private TextBox tb_address;
        private Label lb_main;
        private Panel pn_password;
        private TextBox tb_password;
        private Panel pn_confirm;
        private TextBox tb_confirm;
        private Button btn_confirm;
        private Button btn_back;
    }
}