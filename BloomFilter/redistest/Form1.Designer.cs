namespace redistest
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
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.bloomfilter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIsExist = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBoxContent.Location = new System.Drawing.Point(151, 46);
            this.textBoxContent.Name = "textBox1";
            this.textBoxContent.Size = new System.Drawing.Size(100, 25);
            this.textBoxContent.TabIndex = 0;
            // 
            // bloomfilter
            // 
            this.bloomfilter.AutoSize = true;
            this.bloomfilter.Location = new System.Drawing.Point(41, 49);
            this.bloomfilter.Name = "bloomfilter";
            this.bloomfilter.Size = new System.Drawing.Size(82, 15);
            this.bloomfilter.TabIndex = 1;
            this.bloomfilter.Text = "布隆过滤器";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBoxIsExist.Location = new System.Drawing.Point(151, 106);
            this.textBoxIsExist.Name = "textBox2";
            this.textBoxIsExist.Size = new System.Drawing.Size(100, 25);
            this.textBoxIsExist.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "初始化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "占用内存（M）";
            // 
            // textBox3
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(395, 106);
            this.textBoxMemory.Name = "textBox3";
            this.textBoxMemory.Size = new System.Drawing.Size(100, 25);
            this.textBoxMemory.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "元素个数";
            // 
            // textBox4
            // 
            this.textBoxCount.Location = new System.Drawing.Point(537, 106);
            this.textBoxCount.Name = "textBox4";
            this.textBoxCount.Size = new System.Drawing.Size(100, 25);
            this.textBoxCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxIsExist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bloomfilter);
            this.Controls.Add(this.textBoxContent);
            this.Name = "Form1";
            this.Text = "redisTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label bloomfilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIsExist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}

