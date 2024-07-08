namespace _05_Project_PTTKHTTT
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic_Exit = new PictureBox();
            lb_main = new Label();
            pic_main = new PictureBox();
            tb_user = new TextBox();
            pn_user = new Panel();
            pn_pass = new Panel();
            pic_hide = new PictureBox();
            pic_show = new PictureBox();
            tb_pass = new TextBox();
            btn_login = new Button();
            btn_register = new Button();
            pn_line = new Panel();
            pic_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_main).BeginInit();
            pn_user.SuspendLayout();
            pn_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_hide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // pic_Exit
            // 
            pic_Exit.Image = Properties.Resources.Exit1;
            pic_Exit.Location = new Point(740, 32);
            pic_Exit.Margin = new Padding(3, 2, 3, 2);
            pic_Exit.Name = "pic_Exit";
            pic_Exit.Size = new Size(52, 37);
            pic_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Exit.TabIndex = 0;
            pic_Exit.TabStop = false;
            pic_Exit.Click += pic_Exit_Click;
            // 
            // lb_main
            // 
            lb_main.AutoSize = true;
            lb_main.BackColor = Color.White;
            lb_main.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_main.ForeColor = Color.FromArgb(42, 107, 167);
            lb_main.Location = new Point(340, 47);
            lb_main.Name = "lb_main";
            lb_main.Size = new Size(184, 45);
            lb_main.TabIndex = 2;
            lb_main.Text = "Đăng nhập";
            // 
            // pic_main
            // 
            pic_main.Image = Properties.Resources.Home_Pic1;
            pic_main.Location = new Point(66, 116);
            pic_main.Margin = new Padding(3, 2, 3, 2);
            pic_main.Name = "pic_main";
            pic_main.Size = new Size(363, 238);
            pic_main.SizeMode = PictureBoxSizeMode.Zoom;
            pic_main.TabIndex = 3;
            pic_main.TabStop = false;
            // 
            // tb_user
            // 
            tb_user.BackColor = Color.White;
            tb_user.BorderStyle = BorderStyle.None;
            tb_user.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(12, 7);
            tb_user.Margin = new Padding(3, 2, 3, 2);
            tb_user.Name = "tb_user";
            tb_user.PlaceholderText = "Tên đăng nhập";
            tb_user.Size = new Size(256, 25);
            tb_user.TabIndex = 1;
            tb_user.TabStop = false;
            // 
            // pn_user
            // 
            pn_user.BackgroundImage = Properties.Resources.Line;
            pn_user.Controls.Add(tb_user);
            pn_user.Location = new Point(473, 138);
            pn_user.Margin = new Padding(3, 2, 3, 2);
            pn_user.Name = "pn_user";
            pn_user.Size = new Size(281, 38);
            pn_user.TabIndex = 5;
            pn_user.Paint += pn_user_Paint;
            // 
            // pn_pass
            // 
            pn_pass.BackgroundImage = Properties.Resources.Line;
            pn_pass.Controls.Add(pic_hide);
            pn_pass.Controls.Add(pic_show);
            pn_pass.Controls.Add(tb_pass);
            pn_pass.Location = new Point(473, 208);
            pn_pass.Margin = new Padding(3, 2, 3, 2);
            pn_pass.Name = "pn_pass";
            pn_pass.Size = new Size(281, 38);
            pn_pass.TabIndex = 6;
            // 
            // pic_hide
            // 
            pic_hide.Image = Properties.Resources.eye1;
            pic_hide.Location = new Point(234, 4);
            pic_hide.Margin = new Padding(3, 2, 3, 2);
            pic_hide.Name = "pic_hide";
            pic_hide.Size = new Size(36, 28);
            pic_hide.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hide.TabIndex = 12;
            pic_hide.TabStop = false;
            pic_hide.Click += pic_hide_Click;
            // 
            // pic_show
            // 
            pic_show.Image = Properties.Resources.visual1;
            pic_show.Location = new Point(234, 4);
            pic_show.Margin = new Padding(3, 2, 3, 2);
            pic_show.Name = "pic_show";
            pic_show.Size = new Size(36, 28);
            pic_show.SizeMode = PictureBoxSizeMode.Zoom;
            pic_show.TabIndex = 11;
            pic_show.TabStop = false;
            pic_show.Click += pic_show_Click;
            // 
            // tb_pass
            // 
            tb_pass.BackColor = Color.White;
            tb_pass.BorderStyle = BorderStyle.None;
            tb_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pass.Location = new Point(12, 7);
            tb_pass.Margin = new Padding(3, 2, 3, 2);
            tb_pass.Name = "tb_pass";
            tb_pass.PlaceholderText = "Mật khẩu";
            tb_pass.Size = new Size(256, 25);
            tb_pass.TabIndex = 1;
            tb_pass.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackgroundImage = Properties.Resources.b_r;
            btn_login.BackgroundImageLayout = ImageLayout.Zoom;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(545, 277);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(144, 49);
            btn_login.TabIndex = 7;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackgroundImage = Properties.Resources.button_regis;
            btn_register.BackgroundImageLayout = ImageLayout.Zoom;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(517, 368);
            btn_register.Margin = new Padding(3, 2, 3, 2);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(201, 34);
            btn_register.TabIndex = 8;
            btn_register.Text = "Tạo tài khoản mới";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // pn_line
            // 
            pn_line.BackgroundImage = Properties.Resources.line_login2;
            pn_line.Location = new Point(473, 339);
            pn_line.Margin = new Padding(3, 2, 3, 2);
            pn_line.Name = "pn_line";
            pn_line.Size = new Size(281, 15);
            pn_line.TabIndex = 9;
            // 
            // pic_logo
            // 
            pic_logo.Image = Properties.Resources.Logo_Reg1;
            pic_logo.Location = new Point(37, 32);
            pic_logo.Margin = new Padding(3, 2, 3, 2);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(128, 40);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 10;
            pic_logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background1;
            ClientSize = new Size(837, 442);
            Controls.Add(pic_logo);
            Controls.Add(pn_line);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(pn_pass);
            Controls.Add(pn_user);
            Controls.Add(pic_main);
            Controls.Add(lb_main);
            Controls.Add(pic_Exit);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pic_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_main).EndInit();
            pn_user.ResumeLayout(false);
            pn_user.PerformLayout();
            pn_pass.ResumeLayout(false);
            pn_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_hide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_show).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Exit;
        private Label lb_main;
        private PictureBox pic_main;
        private TextBox tb_user;
        private Panel pn_user;
        private Panel pn_pass;
        private TextBox tb_pass;
        private Button btn_login;
        private Button btn_register;
        private Panel pn_line;
        private PictureBox pic_logo;
        private PictureBox pic_show;
        private PictureBox pic_hide;
    }
}
