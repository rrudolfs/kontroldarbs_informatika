
namespace kontroldarbs_Desas
{
    partial class Form5
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
            this.labelVirsraksts = new System.Windows.Forms.Label();
            this.AizvertPoga2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVirsraksts
            // 
            this.labelVirsraksts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVirsraksts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelVirsraksts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVirsraksts.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelVirsraksts.Location = new System.Drawing.Point(44, 173);
            this.labelVirsraksts.Name = "labelVirsraksts";
            this.labelVirsraksts.Size = new System.Drawing.Size(488, 120);
            this.labelVirsraksts.TabIndex = 1;
            this.labelVirsraksts.Text = "Diemžēl neizšķirts :(";
            this.labelVirsraksts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AizvertPoga2
            // 
            this.AizvertPoga2.BackColor = System.Drawing.Color.Brown;
            this.AizvertPoga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AizvertPoga2.Location = new System.Drawing.Point(199, 360);
            this.AizvertPoga2.Name = "AizvertPoga2";
            this.AizvertPoga2.Size = new System.Drawing.Size(154, 82);
            this.AizvertPoga2.TabIndex = 14;
            this.AizvertPoga2.Text = "Atgriezties";
            this.AizvertPoga2.UseVisualStyleBackColor = false;
            this.AizvertPoga2.Click += new System.EventHandler(this.AizvertPoga2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 635);
            this.Controls.Add(this.AizvertPoga2);
            this.Controls.Add(this.labelVirsraksts);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVirsraksts;
        private System.Windows.Forms.Button AizvertPoga2;
    }
}