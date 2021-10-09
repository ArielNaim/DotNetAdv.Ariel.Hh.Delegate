
namespace Delegate4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.TxtBoxNum2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(47, 110);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(112, 34);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "Sub";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(231, 45);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(150, 31);
            this.txtBoxNum1.TabIndex = 2;
            this.txtBoxNum1.TextChanged += new System.EventHandler(this.txtBoxNum1_TextChanged);
            // 
            // TxtBoxNum2
            // 
            this.TxtBoxNum2.Location = new System.Drawing.Point(231, 113);
            this.TxtBoxNum2.Name = "TxtBoxNum2";
            this.TxtBoxNum2.Size = new System.Drawing.Size(150, 31);
            this.TxtBoxNum2.TabIndex = 3;
            this.TxtBoxNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(231, 192);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(150, 31);
            this.textResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.TxtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.TextBox TxtBoxNum2;
        private System.Windows.Forms.TextBox textResult;
    }
}

