namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_UpdateCompany
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
            tb_tax = new TextBox();
            tb_manager = new TextBox();
            tb_address = new TextBox();
            tb_name = new TextBox();
            lb_jobName = new Label();
            lb_name = new Label();
            btn_confirm = new Button();
            btn_Back = new Button();
            lb_email = new Label();
            lb_Info = new Label();
            lb_compID = new Label();
            tb_compID = new TextBox();
            SuspendLayout();
            // 
            // lb_tax
            // 
            lb_tax.AutoSize = true;
            lb_tax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_tax.Location = new Point(434, 50);
            lb_tax.Name = "lb_tax";
            lb_tax.Size = new Size(87, 21);
            lb_tax.TabIndex = 278;
            lb_tax.Text = "Mã số thuế";
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(172, 228);
            tb_email.Margin = new Padding(3, 2, 3, 2);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(585, 29);
            tb_email.TabIndex = 277;
            tb_email.TabStop = false;
            // 
            // lb_manager
            // 
            lb_manager.AutoSize = true;
            lb_manager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_manager.Location = new Point(25, 136);
            lb_manager.Name = "lb_manager";
            lb_manager.Size = new Size(113, 21);
            lb_manager.TabIndex = 276;
            lb_manager.Text = "Người đại diện";
            // 
            // tb_tax
            // 
            tb_tax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_tax.Location = new Point(535, 47);
            tb_tax.Margin = new Padding(3, 2, 3, 2);
            tb_tax.Name = "tb_tax";
            tb_tax.ReadOnly = true;
            tb_tax.Size = new Size(223, 29);
            tb_tax.TabIndex = 274;
            tb_tax.TabStop = false;
            // 
            // tb_manager
            // 
            tb_manager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_manager.Location = new Point(172, 134);
            tb_manager.Margin = new Padding(3, 2, 3, 2);
            tb_manager.Name = "tb_manager";
            tb_manager.Size = new Size(585, 29);
            tb_manager.TabIndex = 275;
            tb_manager.TabStop = false;
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_address.Location = new Point(172, 181);
            tb_address.Margin = new Padding(3, 2, 3, 2);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(585, 29);
            tb_address.TabIndex = 273;
            tb_address.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(172, 90);
            tb_name.Margin = new Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(585, 29);
            tb_name.TabIndex = 272;
            tb_name.TabStop = false;
            // 
            // lb_jobName
            // 
            lb_jobName.AutoSize = true;
            lb_jobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_jobName.Location = new Point(25, 183);
            lb_jobName.Name = "lb_jobName";
            lb_jobName.Size = new Size(57, 21);
            lb_jobName.TabIndex = 271;
            lb_jobName.Text = "Địa chỉ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(25, 92);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(133, 21);
            lb_name.TabIndex = 270;
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
            btn_confirm.Location = new Point(409, 278);
            btn_confirm.Margin = new Padding(3, 2, 3, 2);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(80, 28);
            btn_confirm.TabIndex = 269;
            btn_confirm.Text = "Cập nhật";
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
            btn_Back.Location = new Point(299, 278);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(80, 28);
            btn_Back.TabIndex = 268;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_email.Location = new Point(25, 230);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(48, 21);
            lb_email.TabIndex = 267;
            lb_email.Text = "Email";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(229, 15);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(296, 25);
            lb_Info.TabIndex = 266;
            lb_Info.Text = "Cập nhật thông tin doanh nghiệp";
            // 
            // lb_compID
            // 
            lb_compID.AutoSize = true;
            lb_compID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_compID.Location = new Point(25, 50);
            lb_compID.Name = "lb_compID";
            lb_compID.Size = new Size(132, 21);
            lb_compID.TabIndex = 280;
            lb_compID.Text = "Mã doanh nghiệp";
            // 
            // tb_compID
            // 
            tb_compID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compID.Location = new Point(172, 47);
            tb_compID.Margin = new Padding(3, 2, 3, 2);
            tb_compID.Name = "tb_compID";
            tb_compID.ReadOnly = true;
            tb_compID.Size = new Size(223, 29);
            tb_compID.TabIndex = 279;
            tb_compID.TabStop = false;
            // 
            // P_UpdateCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(lb_compID);
            Controls.Add(tb_compID);
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
            Name = "P_UpdateCompany";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_UpdateCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_tax;
        private TextBox tb_email;
        private Label lb_manager;
        private TextBox tb_tax;
        private TextBox tb_manager;
        private TextBox tb_address;
        private TextBox tb_name;
        private Label lb_jobName;
        private Label lb_name;
        private Button btn_confirm;
        private Button btn_Back;
        private Label lb_email;
        private Label lb_Info;
        private Label lb_compID;
        private TextBox tb_compID;
    }
}