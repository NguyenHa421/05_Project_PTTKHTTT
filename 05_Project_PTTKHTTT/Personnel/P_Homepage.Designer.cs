namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_Homepage
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
            panel1 = new Panel();
            pn_Enterprise = new Panel();
            btn_Enterprise = new Button();
            pic_Enterprise = new PictureBox();
            pn_recruit = new Panel();
            btn_recruit = new Button();
            pic_recruit = new PictureBox();
            pn_cv = new Panel();
            btn_cv = new Button();
            pic_cv = new PictureBox();
            pn_contract = new Panel();
            btn_contract = new Button();
            pic_contract = new PictureBox();
            panel1.SuspendLayout();
            pn_Enterprise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Enterprise).BeginInit();
            pn_recruit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_recruit).BeginInit();
            pn_cv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_cv).BeginInit();
            pn_contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_contract).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pn_Enterprise);
            panel1.Controls.Add(pn_recruit);
            panel1.Controls.Add(pn_cv);
            panel1.Controls.Add(pn_contract);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 425);
            panel1.TabIndex = 0;
            // 
            // pn_Enterprise
            // 
            pn_Enterprise.BackColor = Color.White;
            pn_Enterprise.BackgroundImage = Properties.Resources.Bg_icon;
            pn_Enterprise.BackgroundImageLayout = ImageLayout.Zoom;
            pn_Enterprise.Controls.Add(btn_Enterprise);
            pn_Enterprise.Controls.Add(pic_Enterprise);
            pn_Enterprise.Location = new Point(36, 35);
            pn_Enterprise.Name = "pn_Enterprise";
            pn_Enterprise.Size = new Size(170, 170);
            pn_Enterprise.TabIndex = 4;
            // 
            // btn_Enterprise
            // 
            btn_Enterprise.BackgroundImage = Properties.Resources.button_2;
            btn_Enterprise.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Enterprise.FlatStyle = FlatStyle.Flat;
            btn_Enterprise.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Enterprise.ForeColor = Color.White;
            btn_Enterprise.Location = new Point(13, 119);
            btn_Enterprise.Name = "btn_Enterprise";
            btn_Enterprise.Size = new Size(144, 38);
            btn_Enterprise.TabIndex = 1;
            btn_Enterprise.Text = "Doanh nghiệp";
            btn_Enterprise.UseVisualStyleBackColor = true;
            // 
            // pic_Enterprise
            // 
            pic_Enterprise.Image = Properties.Resources.enterprise;
            pic_Enterprise.Location = new Point(41, 22);
            pic_Enterprise.Name = "pic_Enterprise";
            pic_Enterprise.Size = new Size(91, 82);
            pic_Enterprise.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Enterprise.TabIndex = 1;
            pic_Enterprise.TabStop = false;
            // 
            // pn_recruit
            // 
            pn_recruit.BackColor = Color.White;
            pn_recruit.BackgroundImage = Properties.Resources.Bg_icon;
            pn_recruit.BackgroundImageLayout = ImageLayout.Zoom;
            pn_recruit.Controls.Add(btn_recruit);
            pn_recruit.Controls.Add(pic_recruit);
            pn_recruit.Location = new Point(466, 35);
            pn_recruit.Name = "pn_recruit";
            pn_recruit.Size = new Size(170, 170);
            pn_recruit.TabIndex = 6;
            // 
            // btn_recruit
            // 
            btn_recruit.BackgroundImage = Properties.Resources.button_2;
            btn_recruit.BackgroundImageLayout = ImageLayout.Zoom;
            btn_recruit.FlatStyle = FlatStyle.Flat;
            btn_recruit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_recruit.ForeColor = Color.White;
            btn_recruit.Location = new Point(13, 119);
            btn_recruit.Name = "btn_recruit";
            btn_recruit.Size = new Size(144, 38);
            btn_recruit.TabIndex = 1;
            btn_recruit.Text = "Đăng tuyển";
            btn_recruit.UseVisualStyleBackColor = true;
            // 
            // pic_recruit
            // 
            pic_recruit.Image = Properties.Resources.recruit;
            pic_recruit.Location = new Point(41, 22);
            pic_recruit.Name = "pic_recruit";
            pic_recruit.Size = new Size(91, 82);
            pic_recruit.SizeMode = PictureBoxSizeMode.Zoom;
            pic_recruit.TabIndex = 1;
            pic_recruit.TabStop = false;
            // 
            // pn_cv
            // 
            pn_cv.BackColor = Color.White;
            pn_cv.BackgroundImage = Properties.Resources.Bg_icon;
            pn_cv.BackgroundImageLayout = ImageLayout.Zoom;
            pn_cv.Controls.Add(btn_cv);
            pn_cv.Controls.Add(pic_cv);
            pn_cv.Location = new Point(683, 35);
            pn_cv.Name = "pn_cv";
            pn_cv.Size = new Size(170, 170);
            pn_cv.TabIndex = 7;
            // 
            // btn_cv
            // 
            btn_cv.BackgroundImage = Properties.Resources.button_2;
            btn_cv.BackgroundImageLayout = ImageLayout.Zoom;
            btn_cv.FlatStyle = FlatStyle.Flat;
            btn_cv.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cv.ForeColor = Color.White;
            btn_cv.Location = new Point(13, 119);
            btn_cv.Name = "btn_cv";
            btn_cv.Size = new Size(144, 38);
            btn_cv.TabIndex = 1;
            btn_cv.Text = "CV ứng viên";
            btn_cv.UseVisualStyleBackColor = true;
            // 
            // pic_cv
            // 
            pic_cv.Image = Properties.Resources.cv;
            pic_cv.Location = new Point(41, 22);
            pic_cv.Name = "pic_cv";
            pic_cv.Size = new Size(91, 82);
            pic_cv.SizeMode = PictureBoxSizeMode.Zoom;
            pic_cv.TabIndex = 1;
            pic_cv.TabStop = false;
            // 
            // pn_contract
            // 
            pn_contract.BackColor = Color.White;
            pn_contract.BackgroundImage = Properties.Resources.Bg_icon;
            pn_contract.BackgroundImageLayout = ImageLayout.Zoom;
            pn_contract.Controls.Add(btn_contract);
            pn_contract.Controls.Add(pic_contract);
            pn_contract.Location = new Point(250, 35);
            pn_contract.Name = "pn_contract";
            pn_contract.Size = new Size(170, 170);
            pn_contract.TabIndex = 8;
            // 
            // btn_contract
            // 
            btn_contract.BackgroundImage = Properties.Resources.button_2;
            btn_contract.BackgroundImageLayout = ImageLayout.Zoom;
            btn_contract.FlatStyle = FlatStyle.Flat;
            btn_contract.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_contract.ForeColor = Color.White;
            btn_contract.Location = new Point(13, 119);
            btn_contract.Name = "btn_contract";
            btn_contract.Size = new Size(144, 38);
            btn_contract.TabIndex = 1;
            btn_contract.Text = "Hợp đồng";
            btn_contract.UseVisualStyleBackColor = true;
            // 
            // pic_contract
            // 
            pic_contract.Image = Properties.Resources.contract;
            pic_contract.Location = new Point(41, 22);
            pic_contract.Name = "pic_contract";
            pic_contract.Size = new Size(91, 82);
            pic_contract.SizeMode = PictureBoxSizeMode.Zoom;
            pic_contract.TabIndex = 1;
            pic_contract.TabStop = false;
            // 
            // P_Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_Homepage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_Homepage";
            panel1.ResumeLayout(false);
            pn_Enterprise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Enterprise).EndInit();
            pn_recruit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_recruit).EndInit();
            pn_cv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_cv).EndInit();
            pn_contract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_contract).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pn_Enterprise;
        private Button btn_Enterprise;
        private PictureBox pic_Enterprise;
        private Panel pn_recruit;
        private Button btn_recruit;
        private PictureBox pic_recruit;
        private Panel pn_cv;
        private Button btn_cv;
        private PictureBox pic_cv;
        private Panel pn_contract;
        private Button btn_contract;
        private PictureBox pic_contract;
    }
}