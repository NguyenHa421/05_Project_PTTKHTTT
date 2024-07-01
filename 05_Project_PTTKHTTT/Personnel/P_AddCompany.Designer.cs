namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_AddCompany
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
            lb_tax = new Label();
            tb_email = new TextBox();
            lb_manager = new Label();
            tb_manager = new TextBox();
            tb_address = new TextBox();
            tb_name = new TextBox();
            lb_jobName = new Label();
            lb_name = new Label();
            btn_confirm = new Button();
            btn_Back = new Button();
            lb_email = new Label();
            lb_Info = new Label();
            tb_tax = new TextBox();
            SuspendLayout();
            // 
            // lb_tax
            // 
            lb_tax.AutoSize = true;
            lb_tax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_tax.Location = new Point(25, 111);
            lb_tax.Name = "lb_tax";
            lb_tax.Size = new Size(87, 21);
            lb_tax.TabIndex = 265;
            lb_tax.Text = "Mã số thuế";
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(172, 223);
            tb_email.Margin = new Padding(3, 2, 3, 2);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(585, 29);
            tb_email.TabIndex = 264;
            tb_email.TabStop = false;
            // 
            // lb_manager
            // 
            lb_manager.AutoSize = true;
            lb_manager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_manager.Location = new Point(406, 111);
            lb_manager.Name = "lb_manager";
            lb_manager.Size = new Size(113, 21);
            lb_manager.TabIndex = 262;
            lb_manager.Text = "Người đại diện";
            // 
            // tb_manager
            // 
            tb_manager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_manager.Location = new Point(535, 109);
            tb_manager.Margin = new Padding(3, 2, 3, 2);
            tb_manager.Name = "tb_manager";
            tb_manager.Size = new Size(223, 29);
            tb_manager.TabIndex = 260;
            tb_manager.TabStop = false;
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_address.Location = new Point(172, 164);
            tb_address.Margin = new Padding(3, 2, 3, 2);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(585, 29);
            tb_address.TabIndex = 258;
            tb_address.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(172, 54);
            tb_name.Margin = new Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(585, 29);
            tb_name.TabIndex = 257;
            tb_name.TabStop = false;
            // 
            // lb_jobName
            // 
            lb_jobName.AutoSize = true;
            lb_jobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_jobName.Location = new Point(25, 166);
            lb_jobName.Name = "lb_jobName";
            lb_jobName.Size = new Size(57, 21);
            lb_jobName.TabIndex = 256;
            lb_jobName.Text = "Địa chỉ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(25, 56);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(133, 21);
            lb_name.TabIndex = 255;
            lb_name.Text = "Tên doanh nghiệp";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.White;
            btn_confirm.BackgroundImage = Properties.Resources.button_round22;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_confirm.ForeColor = SystemColors.Window;
            btn_confirm.Location = new Point(409, 273);
            btn_confirm.Margin = new Padding(3, 2, 3, 2);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(80, 28);
            btn_confirm.TabIndex = 254;
            btn_confirm.Text = "Đăng ký";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click; 
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(299, 273);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(80, 28);
            btn_Back.TabIndex = 253;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_email.Location = new Point(25, 225);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(48, 21);
            lb_email.TabIndex = 252;
            lb_email.Text = "Email";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(270, 7);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(206, 25);
            lb_Info.TabIndex = 249;
            lb_Info.Text = "Đăng ký doanh nghiệp";
            // 
            // tb_tax
            // 
            tb_tax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_tax.Location = new Point(172, 109);
            tb_tax.Margin = new Padding(3, 2, 3, 2);
            tb_tax.Name = "tb_tax";
            tb_tax.Size = new Size(223, 29);
            tb_tax.TabIndex = 260;
            tb_tax.TabStop = false;
            // 
            // P_AddCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(lb_tax);
            Controls.Add(tb_email);
            Controls.Add(lb_manager);
            Controls.Add(tb_tax);
            Controls.Add(tb_manager);
            Controls.Add(tb_address);
            Controls.Add(tb_name);
            Controls.Add(lb_jobName);
            Controls.Add(lb_name);
            Controls.Add(btn_confirm);
            Controls.Add(btn_Back);
            Controls.Add(lb_email);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "P_AddCompany";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_AddCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_tax;
        private TextBox tb_email;
        private TextBox tb_criteria;
        private Label lb_manager;
        private TextBox tb_state;
        private TextBox tb_manager;
        private TextBox tb_amount;
        private TextBox tb_address;
        private TextBox tb_name;
        private Label lb_jobName;
        private Label lb_name;
        private Button btn_confirm;
        private Button btn_Back;
        private Label lb_email;
        private Label lb_amount;
        private Label lb_state;
        private Label lb_Info;
        private TextBox tb_tax;
    }
}