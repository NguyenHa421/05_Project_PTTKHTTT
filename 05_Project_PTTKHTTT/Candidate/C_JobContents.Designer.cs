namespace _05_Project_PTTKHTTT.Candidate
{
    partial class C_JobContents
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
            pn_parents = new Panel();
            tb_content = new TextBox();
            btn_next = new Button();
            btn_Back = new Button();
            lb_content = new Label();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(tb_content);
            pn_parents.Controls.Add(btn_next);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(lb_content);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 249;
            // 
            // tb_content
            // 
            tb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_content.Location = new Point(43, 96);
            tb_content.Multiline = true;
            tb_content.Name = "tb_content";
            tb_content.ReadOnly = true;
            tb_content.Size = new Size(804, 263);
            tb_content.TabIndex = 264;
            tb_content.TabStop = false;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.White;
            btn_next.BackgroundImage = Properties.Resources.button_round22;
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_next.ForeColor = SystemColors.Window;
            btn_next.Location = new Point(467, 376);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(91, 37);
            btn_next.TabIndex = 254;
            btn_next.Text = "Tiếp";
            btn_next.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 376);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 253;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // lb_content
            // 
            lb_content.AutoSize = true;
            lb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_content.Location = new Point(43, 55);
            lb_content.Name = "lb_content";
            lb_content.Size = new Size(95, 28);
            lb_content.TabIndex = 252;
            lb_content.Text = "Nội dung";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(293, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(333, 31);
            lb_Info.TabIndex = 249;
            lb_Info.Text = "Nội dung bài đăng tuyển dụng";
            // 
            // C_JobDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "C_JobDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C_JobDetail";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lb_criteia;
        private Panel pn_parents;
        private Label lb_criteria;
        private TextBox tb_content;
        private TextBox tb_criteria;
        private Label lb_postdate;
        private TextBox tb_state;
        private TextBox tb_postdate;
        private TextBox tb_amount;
        private TextBox tb_jobName;
        private TextBox tb_compName;
        private Label lb_jobName;
        private Label lb_compName;
        private Button btn_next;
        private Button btn_Back;
        private Label lb_content;
        private Label lb_amount;
        private Label lb_state;
        private Label lb_Info;
    }
}