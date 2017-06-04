namespace GamersCO
{
    partial class Stock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Insert2 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cbx_Filter = new System.Windows.Forms.ComboBox();
            this.dgview_Result = new System.Windows.Forms.DataGridView();
            this.cbx_Search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(176, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtrar";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(17, 245);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(142, 48);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Consultar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(17, 185);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(192, 37);
            this.txt_Search.TabIndex = 5;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.Location = new System.Drawing.Point(17, 458);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(142, 48);
            this.btn_Filter.TabIndex = 7;
            this.btn_Filter.Text = "Consultar";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Insert2
            // 
            this.btn_Insert2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert2.Location = new System.Drawing.Point(265, 568);
            this.btn_Insert2.Name = "btn_Insert2";
            this.btn_Insert2.Size = new System.Drawing.Size(137, 48);
            this.btn_Insert2.TabIndex = 8;
            this.btn_Insert2.Text = "Insertar";
            this.btn_Insert2.UseVisualStyleBackColor = true;
            this.btn_Insert2.Click += new System.EventHandler(this.btn_Insert2_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(783, 568);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 48);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cbx_Filter
            // 
            this.cbx_Filter.FormattingEnabled = true;
            this.cbx_Filter.Items.AddRange(new object[] {
            "accion",
            "aventura",
            "conduccion",
            "indie",
            "mmo",
            "moba",
            "sport",
            "estrategia",
            "terror"});
            this.cbx_Filter.Location = new System.Drawing.Point(17, 390);
            this.cbx_Filter.Name = "cbx_Filter";
            this.cbx_Filter.Size = new System.Drawing.Size(192, 24);
            this.cbx_Filter.TabIndex = 10;
            // 
            // dgview_Result
            // 
            this.dgview_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_Result.Location = new System.Drawing.Point(265, 137);
            this.dgview_Result.Name = "dgview_Result";
            this.dgview_Result.RowTemplate.Height = 24;
            this.dgview_Result.Size = new System.Drawing.Size(638, 412);
            this.dgview_Result.TabIndex = 11;
            // 
            // cbx_Search
            // 
            this.cbx_Search.FormattingEnabled = true;
            this.cbx_Search.Items.AddRange(new object[] {
            "nombre",
            "plataforma",
            "estreno",
            "calificacion"});
            this.cbx_Search.Location = new System.Drawing.Point(17, 137);
            this.cbx_Search.Name = "cbx_Search";
            this.cbx_Search.Size = new System.Drawing.Size(192, 24);
            this.cbx_Search.TabIndex = 12;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 628);
            this.Controls.Add(this.cbx_Search);
            this.Controls.Add(this.dgview_Result);
            this.Controls.Add(this.cbx_Filter);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Insert2);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Insert2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox cbx_Filter;
        private System.Windows.Forms.DataGridView dgview_Result;
        private System.Windows.Forms.ComboBox cbx_Search;
    }
}