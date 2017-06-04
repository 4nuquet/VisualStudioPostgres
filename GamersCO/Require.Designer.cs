namespace GamersCO
{
    partial class Require
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
            this.dgv_Require = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Require)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Require
            // 
            this.dgv_Require.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Require.Location = new System.Drawing.Point(12, 12);
            this.dgv_Require.Name = "dgv_Require";
            this.dgv_Require.RowTemplate.Height = 24;
            this.dgv_Require.Size = new System.Drawing.Size(822, 377);
            this.dgv_Require.TabIndex = 0;
            // 
            // Require
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 401);
            this.Controls.Add(this.dgv_Require);
            this.Name = "Require";
            this.Text = "Require";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Require)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Require;
    }
}