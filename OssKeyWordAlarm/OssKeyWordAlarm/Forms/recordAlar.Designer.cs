
namespace OssKeyWordAlarm.Forms
{
    partial class recordAlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "알림을 클릭시 웹 사이트로 이동합니다.";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(644, 12);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(114, 97);
            this.btnRemoveAll.TabIndex = 1;
            this.btnRemoveAll.Text = "모두 지우기";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(626, 465);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // recordAlar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recordAlar";
            this.Text = "recordAlar";
            this.Load += new System.EventHandler(this.recordAlar_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1; // 부모 폼 삭제 위해 임시로 편집
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveAll;

    }
}