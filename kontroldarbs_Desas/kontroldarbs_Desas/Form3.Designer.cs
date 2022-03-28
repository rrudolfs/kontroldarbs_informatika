
namespace kontroldarbs_Desas
{
    partial class Form3
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
            this.ApsveikumaUzraksts = new System.Windows.Forms.Label();
            this.AizvertPoga2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(141, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apsveicam !!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApsveikumaUzraksts
            // 
            this.ApsveikumaUzraksts.BackColor = System.Drawing.Color.Khaki;
            this.ApsveikumaUzraksts.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ApsveikumaUzraksts.Location = new System.Drawing.Point(44, 261);
            this.ApsveikumaUzraksts.Name = "ApsveikumaUzraksts";
            this.ApsveikumaUzraksts.Size = new System.Drawing.Size(492, 118);
            this.ApsveikumaUzraksts.TabIndex = 1;
            this.ApsveikumaUzraksts.Text = "Uzvarējis 2. spēlētājs !!";
            this.ApsveikumaUzraksts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApsveikumaUzraksts.Click += new System.EventHandler(this.ApsveikumaUzraksts_Click);
            // 
            // AizvertPoga2
            // 
            this.AizvertPoga2.BackColor = System.Drawing.Color.Brown;
            this.AizvertPoga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AizvertPoga2.Location = new System.Drawing.Point(203, 451);
            this.AizvertPoga2.Name = "AizvertPoga2";
            this.AizvertPoga2.Size = new System.Drawing.Size(154, 82);
            this.AizvertPoga2.TabIndex = 12;
            this.AizvertPoga2.Text = "Atgriezties";
            this.AizvertPoga2.UseVisualStyleBackColor = false;
            this.AizvertPoga2.Click += new System.EventHandler(this.AizvertPoga2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(581, 635);
            this.Controls.Add(this.AizvertPoga2);
            this.Controls.Add(this.ApsveikumaUzraksts);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Desas";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApsveikumaUzraksts;
        private System.Windows.Forms.Button AizvertPoga2;
    }
}