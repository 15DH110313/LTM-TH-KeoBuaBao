namespace LTM_TH_KeoBuaBao
{
    partial class Form1
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
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_bua = new System.Windows.Forms.Button();
            this.btn_bao = new System.Windows.Forms.Button();
            this.btn_keo = new System.Windows.Forms.Button();
            this.tb_select = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(148, 259);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(135, 20);
            this.tb_result.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your result:";
            // 
            // btn_bua
            // 
            this.btn_bua.Location = new System.Drawing.Point(377, 119);
            this.btn_bua.Name = "btn_bua";
            this.btn_bua.Size = new System.Drawing.Size(90, 77);
            this.btn_bua.TabIndex = 11;
            this.btn_bua.Text = "Búa";
            this.btn_bua.UseVisualStyleBackColor = true;
            this.btn_bua.Click += new System.EventHandler(this.btn_bua_Click);
            // 
            // btn_bao
            // 
            this.btn_bao.Location = new System.Drawing.Point(244, 119);
            this.btn_bao.Name = "btn_bao";
            this.btn_bao.Size = new System.Drawing.Size(90, 77);
            this.btn_bao.TabIndex = 10;
            this.btn_bao.Text = "Bao";
            this.btn_bao.UseVisualStyleBackColor = true;
            this.btn_bao.Click += new System.EventHandler(this.btn_bao_Click);
            // 
            // btn_keo
            // 
            this.btn_keo.Location = new System.Drawing.Point(112, 119);
            this.btn_keo.Name = "btn_keo";
            this.btn_keo.Size = new System.Drawing.Size(90, 77);
            this.btn_keo.TabIndex = 9;
            this.btn_keo.Text = "Kéo";
            this.btn_keo.UseVisualStyleBackColor = true;
            this.btn_keo.Click += new System.EventHandler(this.btn_keo_Click);
            // 
            // tb_select
            // 
            this.tb_select.Location = new System.Drawing.Point(163, 34);
            this.tb_select.Name = "tb_select";
            this.tb_select.Size = new System.Drawing.Size(261, 20);
            this.tb_select.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your selection:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 313);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bua);
            this.Controls.Add(this.btn_bao);
            this.Controls.Add(this.btn_keo);
            this.Controls.Add(this.tb_select);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_bua;
        private System.Windows.Forms.Button btn_bao;
        private System.Windows.Forms.Button btn_keo;
        private System.Windows.Forms.TextBox tb_select;
        private System.Windows.Forms.Label label1;
    }
}

