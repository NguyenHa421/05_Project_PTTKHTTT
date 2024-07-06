namespace _05_Project_PTTKHTTT
{
    partial class MainBase
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
            pn_main = new Panel();
            pn_parents = new Panel();
            pic_Logout = new PictureBox();
            lb_hello = new Label();
            tb_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logout).BeginInit();
            SuspendLayout();
            // 
            // pic_logo
            // 
            pic_logo.Image = Properties.Resources.logo2;
            pic_logo.Location = new Point(10, 8);
            pic_logo.Margin = new Padding(3, 2, 3, 2);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(93, 76);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 4;
            pic_logo.TabStop = false;
            // 
            // pn_main
            // 
            pn_main.BackgroundImage = Properties.Resources.Bg_hp2;
            pn_main.BackgroundImageLayout = ImageLayout.Zoom;
            pn_main.Controls.Add(pn_parents);
            pn_main.Location = new Point(10, 87);
            pn_main.Margin = new Padding(3, 2, 3, 2);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(816, 346);
            pn_main.TabIndex = 5;
            // 
            // pn_parents
            // 
            pn_parents.BackColor = Color.White;
            pn_parents.Location = new Point(15, 14);
            pn_parents.Margin = new Padding(3, 2, 3, 2);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(783, 319);
            pn_parents.TabIndex = 0;
            // 
            // pic_Logout
            // 
            pic_Logout.Image = Properties.Resources.Exit;
            pic_Logout.Location = new Point(789, 9);
            pic_Logout.Margin = new Padding(3, 2, 3, 2);
            pic_Logout.Name = "pic_Logout";
            pic_Logout.Size = new Size(38, 28);
            pic_Logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Logout.TabIndex = 6;
            pic_Logout.TabStop = false;
            pic_Logout.Click += pic_Logout_Click;
            // 
            // lb_hello
            // 
            lb_hello.AutoSize = true;
            lb_hello.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_hello.ForeColor = Color.White;
            lb_hello.Location = new Point(108, 16);
            lb_hello.Name = "lb_hello";
            lb_hello.Size = new Size(76, 21);
            lb_hello.TabIndex = 7;
            lb_hello.Text = "Xin chào, ";
            // 
            // tb_name
            // 
            tb_name.BackColor = Color.FromArgb(42, 107, 167);
            tb_name.BorderStyle = BorderStyle.None;
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.ForeColor = Color.White;
            tb_name.Location = new Point(188, 16);
            tb_name.Margin = new Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Full Name";
            tb_name.Size = new Size(342, 22);
            tb_name.TabIndex = 8;
            // 
            // MainBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(837, 442);
            Controls.Add(tb_name);
            Controls.Add(lb_hello);
            Controls.Add(pic_Logout);
            Controls.Add(pn_main);
            Controls.Add(pic_logo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainBase";
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_logo;
        private Panel pn_main;
        private PictureBox pic_Logout;
        private Label lb_hello;
        private TextBox tb_name;
        private Panel pn_parents;
    }
}