
namespace OssKeyWordAlarm.Forms
{
    partial class Notice
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(17, 16);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(483, 45);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "글 공지 테스트";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);

            // 
            // Notice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.lbltitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Notice";
            this.Size = new System.Drawing.Size(500, 70);
            this.Load += new System.EventHandler(this.Notice_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notice_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
    }
}
