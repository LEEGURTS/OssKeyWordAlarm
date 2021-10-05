
namespace OssKeyWordAlarm
{
    partial class makeKey
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
            this.Keyword_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Keyword_TextBox
            // 
            this.Keyword_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Keyword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keyword_TextBox.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Keyword_TextBox.Location = new System.Drawing.Point(388, 269);
            this.Keyword_TextBox.Name = "Keyword_TextBox";
            this.Keyword_TextBox.Size = new System.Drawing.Size(200, 19);
            this.Keyword_TextBox.TabIndex = 1;
            this.Keyword_TextBox.Text = "키워드를 입력하세요.";
            this.Keyword_TextBox.TextChanged += new System.EventHandler(this.Keyword_TextBox_TextChanged);
            // 
            // makeKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.Keyword_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "makeKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.makeKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Keyword_TextBox;
    }
}