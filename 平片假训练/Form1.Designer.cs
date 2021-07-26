
namespace 平片假训练
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.hunhe = new System.Windows.Forms.Button();
            this.pianj = new System.Windows.Forms.Button();
            this.pinj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.ans);
            this.panel1.Controls.Add(this.view);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 326);
            this.panel1.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(741, 0);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "提交答案";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(634, 3);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(100, 21);
            this.ans.TabIndex = 1;
            this.ans.Text = "答案在这";
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.Font = new System.Drawing.Font("SoukouMincho", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.view.Location = new System.Drawing.Point(248, 119);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(288, 74);
            this.view.TabIndex = 0;
            this.view.Text = "何もない";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tB1);
            this.panel2.Controls.Add(this.hunhe);
            this.panel2.Controls.Add(this.pianj);
            this.panel2.Controls.Add(this.pinj);
            this.panel2.Location = new System.Drawing.Point(13, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 101);
            this.panel2.TabIndex = 1;
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(28, 4);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(117, 21);
            this.tB1.TabIndex = 3;
            this.tB1.Text = "0";
            // 
            // hunhe
            // 
            this.hunhe.Location = new System.Drawing.Point(593, 39);
            this.hunhe.Name = "hunhe";
            this.hunhe.Size = new System.Drawing.Size(89, 23);
            this.hunhe.TabIndex = 2;
            this.hunhe.Text = "模式3-混合";
            this.hunhe.UseVisualStyleBackColor = true;
            this.hunhe.Click += new System.EventHandler(this.button2_Click);
            // 
            // pianj
            // 
            this.pianj.Location = new System.Drawing.Point(319, 39);
            this.pianj.Name = "pianj";
            this.pianj.Size = new System.Drawing.Size(89, 23);
            this.pianj.TabIndex = 1;
            this.pianj.Text = "模式2-片假名";
            this.pianj.UseVisualStyleBackColor = true;
            this.pianj.Click += new System.EventHandler(this.pianj_Click);
            // 
            // pinj
            // 
            this.pinj.Location = new System.Drawing.Point(56, 39);
            this.pinj.Name = "pinj";
            this.pinj.Size = new System.Drawing.Size(89, 23);
            this.pinj.TabIndex = 0;
            this.pinj.Text = "模式1-平假名";
            this.pinj.UseVisualStyleBackColor = true;
            this.pinj.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.ClientSize = new System.Drawing.Size(871, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Panel quizpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label view;
        private System.Windows.Forms.Button pinj;
        private System.Windows.Forms.Button hunhe;
        private System.Windows.Forms.Button pianj;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Label label1;
    }
}

