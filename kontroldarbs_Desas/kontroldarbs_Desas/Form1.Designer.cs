
namespace kontroldarbs_Desas
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
            this.labelVirsraksts = new System.Windows.Forms.Label();
            this.SaktPoga = new System.Windows.Forms.Button();
            this.InformacijaPoga = new System.Windows.Forms.Button();
            this.AizvertPoga = new System.Windows.Forms.Button();
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
            this.labelVirsraksts.Location = new System.Drawing.Point(92, 89);
            this.labelVirsraksts.Name = "labelVirsraksts";
            this.labelVirsraksts.Size = new System.Drawing.Size(394, 182);
            this.labelVirsraksts.TabIndex = 0;
            this.labelVirsraksts.Text = "Spēle \"Desas\"";
            this.labelVirsraksts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaktPoga
            // 
            this.SaktPoga.BackColor = System.Drawing.Color.YellowGreen;
            this.SaktPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SaktPoga.Location = new System.Drawing.Point(197, 359);
            this.SaktPoga.Name = "SaktPoga";
            this.SaktPoga.Size = new System.Drawing.Size(166, 123);
            this.SaktPoga.TabIndex = 1;
            this.SaktPoga.Text = "Sākt";
            this.SaktPoga.UseVisualStyleBackColor = false;
            // 
            // InformacijaPoga
            // 
            this.InformacijaPoga.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InformacijaPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InformacijaPoga.Location = new System.Drawing.Point(424, 411);
            this.InformacijaPoga.Name = "InformacijaPoga";
            this.InformacijaPoga.Size = new System.Drawing.Size(111, 71);
            this.InformacijaPoga.TabIndex = 2;
            this.InformacijaPoga.Text = "Info";
            this.InformacijaPoga.UseVisualStyleBackColor = false;
            // 
            // AizvertPoga
            // 
            this.AizvertPoga.BackColor = System.Drawing.Color.Brown;
            this.AizvertPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AizvertPoga.Location = new System.Drawing.Point(25, 411);
            this.AizvertPoga.Name = "AizvertPoga";
            this.AizvertPoga.Size = new System.Drawing.Size(111, 71);
            this.AizvertPoga.TabIndex = 3;
            this.AizvertPoga.Text = "Aizvērt";
            this.AizvertPoga.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 635);
            this.Controls.Add(this.AizvertPoga);
            this.Controls.Add(this.InformacijaPoga);
            this.Controls.Add(this.SaktPoga);
            this.Controls.Add(this.labelVirsraksts);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Desas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVirsraksts;
        private System.Windows.Forms.Button SaktPoga;
        private System.Windows.Forms.Button InformacijaPoga;
        private System.Windows.Forms.Button AizvertPoga;
    }
}

