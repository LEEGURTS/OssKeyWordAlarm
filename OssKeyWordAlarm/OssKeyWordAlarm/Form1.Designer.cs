namespace OssKeyWordAlarm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.testbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.makeKeyword = new System.Windows.Forms.Button();
            this.changeAlarm = new System.Windows.Forms.Button();
            this.recordAlarm = new System.Windows.Forms.Button();
            this.addLink = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // testbutton
            // 
            this.testbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.testbutton.Location = new System.Drawing.Point(495, 170);
            this.testbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(250, 250);
            this.testbutton.TabIndex = 0;
            this.testbutton.Text = "누르면 url 연결돼서 콘솔열림";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.makeKeyword);
            this.panel1.Controls.Add(this.changeAlarm);
            this.panel1.Controls.Add(this.recordAlarm);
            this.panel1.Controls.Add(this.addLink);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 550);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("나눔고딕", 8F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(28, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 13);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "광운대학교 공지사항 알리미";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(60, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "KW ALARM";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Location = new System.Drawing.Point(282, 41);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 60);
            this.pnlNav.TabIndex = 2;
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Image = global::OssKeyWordAlarm.Properties.Resources.power_off_button_25px;
            this.Exit_Button.Location = new System.Drawing.Point(911, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(27, 28);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // makeKeyword
            // 
            this.makeKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.makeKeyword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.makeKeyword.FlatAppearance.BorderSize = 0;
            this.makeKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeKeyword.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.makeKeyword.ForeColor = System.Drawing.Color.White;
            this.makeKeyword.Image = global::OssKeyWordAlarm.Properties.Resources.pencil_24px;
            this.makeKeyword.Location = new System.Drawing.Point(0, 188);
            this.makeKeyword.Margin = new System.Windows.Forms.Padding(0);
            this.makeKeyword.Name = "makeKeyword";
            this.makeKeyword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.makeKeyword.Size = new System.Drawing.Size(180, 60);
            this.makeKeyword.TabIndex = 14;
            this.makeKeyword.Text = "키워드 등록";
            this.makeKeyword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.makeKeyword.UseVisualStyleBackColor = false;
            this.makeKeyword.Leave += new System.EventHandler(this.makeKeyword_Leave);
            this.makeKeyword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.makeKeyword_MouseDown);
            // 
            // changeAlarm
            // 
            this.changeAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.changeAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeAlarm.FlatAppearance.BorderSize = 0;
            this.changeAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeAlarm.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeAlarm.ForeColor = System.Drawing.Color.White;
            this.changeAlarm.Image = ((System.Drawing.Image)(resources.GetObject("changeAlarm.Image")));
            this.changeAlarm.Location = new System.Drawing.Point(0, 368);
            this.changeAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.changeAlarm.Name = "changeAlarm";
            this.changeAlarm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changeAlarm.Size = new System.Drawing.Size(180, 60);
            this.changeAlarm.TabIndex = 12;
            this.changeAlarm.Text = "알림음 변경";
            this.changeAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.changeAlarm.UseVisualStyleBackColor = false;
            this.changeAlarm.Leave += new System.EventHandler(this.changeAlarm_Leave);
            this.changeAlarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeAlarm_MouseDown);
            // 
            // recordAlarm
            // 
            this.recordAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.recordAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recordAlarm.FlatAppearance.BorderSize = 0;
            this.recordAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordAlarm.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recordAlarm.ForeColor = System.Drawing.Color.White;
            this.recordAlarm.Image = global::OssKeyWordAlarm.Properties.Resources.alarm_30px;
            this.recordAlarm.Location = new System.Drawing.Point(0, 248);
            this.recordAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.recordAlarm.Name = "recordAlarm";
            this.recordAlarm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recordAlarm.Size = new System.Drawing.Size(180, 60);
            this.recordAlarm.TabIndex = 11;
            this.recordAlarm.Text = "알림 기록";
            this.recordAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.recordAlarm.UseVisualStyleBackColor = false;
            this.recordAlarm.Leave += new System.EventHandler(this.recordAlarm_Leave);
            this.recordAlarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recordAlarm_MouseDown);
            // 
            // addLink
            // 
            this.addLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addLink.FlatAppearance.BorderSize = 0;
            this.addLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLink.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addLink.ForeColor = System.Drawing.Color.White;
            this.addLink.Image = global::OssKeyWordAlarm.Properties.Resources.link_30px;
            this.addLink.Location = new System.Drawing.Point(0, 308);
            this.addLink.Margin = new System.Windows.Forms.Padding(0);
            this.addLink.Name = "addLink";
            this.addLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addLink.Size = new System.Drawing.Size(180, 60);
            this.addLink.TabIndex = 9;
            this.addLink.Text = "링크 등록";
            this.addLink.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addLink.UseVisualStyleBackColor = false;
            this.addLink.Leave += new System.EventHandler(this.addLink_Leave);
            this.addLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addLink_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Maximize
            // 
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Image = global::OssKeyWordAlarm.Properties.Resources.icons8_application_window_24px;
            this.Maximize.Location = new System.Drawing.Point(877, 15);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(28, 23);
            this.Maximize.TabIndex = 4;
            this.Maximize.UseVisualStyleBackColor = true;
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::OssKeyWordAlarm.Properties.Resources.minus_24px;
            this.Minimize.Location = new System.Drawing.Point(844, 15);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 23);
            this.Minimize.TabIndex = 5;
            this.Minimize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.testbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button addLink;
        private System.Windows.Forms.Button changeAlarm;
        private System.Windows.Forms.Button recordAlarm;
        private System.Windows.Forms.Button makeKeyword;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Minimize;
    }
}

