﻿namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_AddRecruitmentDetail
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
            btn_confirm = new Button();
            btn_Back = new Button();
            lb_Info = new Label();
            tb_content = new TextBox();
            lb_content = new Label();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.White;
            btn_confirm.BackgroundImage = Properties.Resources.button_round22;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_confirm.ForeColor = SystemColors.Window;
            btn_confirm.Location = new Point(467, 375);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(91, 37);
            btn_confirm.TabIndex = 295;
            btn_confirm.Text = "Đăng ký";
            btn_confirm.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 375);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 294;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(276, 13);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(324, 31);
            lb_Info.TabIndex = 292;
            lb_Info.Text = "Nội dung bài đăng quảng cáo";
            // 
            // tb_content
            // 
            tb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_content.Location = new Point(34, 85);
            tb_content.Multiline = true;
            tb_content.Name = "tb_content";
            tb_content.Size = new Size(825, 270);
            tb_content.TabIndex = 300;
            tb_content.TabStop = false;
            // 
            // lb_content
            // 
            lb_content.AutoSize = true;
            lb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_content.Location = new Point(34, 53);
            lb_content.Name = "lb_content";
            lb_content.Size = new Size(95, 28);
            lb_content.TabIndex = 299;
            lb_content.Text = "Nội dung";
            // 
            // P_AddRecruitmentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_content);
            Controls.Add(lb_content);
            Controls.Add(btn_confirm);
            Controls.Add(btn_Back);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_AddRecruitmentDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_AddRecruitmentDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_confirm;
        private Button btn_Back;
        private Label lb_Info;
        private TextBox tb_content;
        private Label lb_content;
    }
}