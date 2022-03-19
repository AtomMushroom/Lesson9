
namespace lab1
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
            this.pct = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.txt = new System.Windows.Forms.TextBox();
            this.file2 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(237, 12);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(291, 191);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(237, 232);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(291, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "выбери картинку";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(237, 210);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(291, 23);
            this.txt.TabIndex = 2;
            // 
            // file2
            // 
            this.file2.DefaultExt = "jpg";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(291, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Нажми меня";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.SaveFileDialog file2;
        private System.Windows.Forms.Button btnSave;
    }
}

