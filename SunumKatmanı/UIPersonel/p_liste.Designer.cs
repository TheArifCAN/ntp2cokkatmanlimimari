namespace SunumKatmanı.UIPersonel
{
    partial class p_liste
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
            this.dt_pslist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_pslist)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_pslist
            // 
            this.dt_pslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_pslist.Location = new System.Drawing.Point(12, 12);
            this.dt_pslist.Name = "dt_pslist";
            this.dt_pslist.Size = new System.Drawing.Size(556, 360);
            this.dt_pslist.TabIndex = 0;
            // 
            // p_liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_pslist);
            this.Name = "p_liste";
            this.Text = "p_liste";
            this.Load += new System.EventHandler(this.p_liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_pslist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_pslist;
    }
}