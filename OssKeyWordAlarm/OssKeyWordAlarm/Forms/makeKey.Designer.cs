
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
            this.keyWord_listBox = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Keyword_TextBox
            // 
            this.Keyword_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Keyword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keyword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Keyword_TextBox.Location = new System.Drawing.Point(521, 116);
            this.Keyword_TextBox.Name = "Keyword_TextBox";
            this.Keyword_TextBox.Size = new System.Drawing.Size(200, 19);
            this.Keyword_TextBox.TabIndex = 1;
            this.Keyword_TextBox.Text = "키워드를 입력하세요.";
            this.Keyword_TextBox.TextChanged += new System.EventHandler(this.Keyword_TextBox_TextChanged);
            this.Keyword_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKeyword_KeyDown);
            // 
            // keyWord_listBox
            // 
            this.keyWord_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyWord_listBox.FormattingEnabled = true;
            this.keyWord_listBox.ItemHeight = 12;
            this.keyWord_listBox.Location = new System.Drawing.Point(66, 94);
            this.keyWord_listBox.Name = "keyWord_listBox";
            this.keyWord_listBox.Size = new System.Drawing.Size(330, 252);
            this.keyWord_listBox.TabIndex = 2;
            this.keyWord_listBox.SelectedIndexChanged += new System.EventHandler(this.keyWord_listBox_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Location = new System.Drawing.Point(618, 318);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // makeKey
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.keyWord_listBox);
            this.Controls.Add(this.Keyword_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "makeKey";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.makeKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Keyword_TextBox;
        private System.Windows.Forms.ListBox keyWord_listBox;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDelete;
    }
}