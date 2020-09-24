namespace Evaluacion_IM.View
{
    partial class PorcentajePuestosView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshPorcentajePuestos = new System.Windows.Forms.Button();
            this.dataPorcentajePuestos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPorcentajePuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.refreshPorcentajePuestos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataPorcentajePuestos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // refreshPorcentajePuestos
            // 
            this.refreshPorcentajePuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshPorcentajePuestos.Location = new System.Drawing.Point(362, 101);
            this.refreshPorcentajePuestos.Name = "refreshPorcentajePuestos";
            this.refreshPorcentajePuestos.Size = new System.Drawing.Size(75, 23);
            this.refreshPorcentajePuestos.TabIndex = 0;
            this.refreshPorcentajePuestos.Text = "Refrescar";
            this.refreshPorcentajePuestos.UseVisualStyleBackColor = true;
            this.refreshPorcentajePuestos.Click += new System.EventHandler(this.onRefresh);
            // 
            // dataPorcentajePuestos
            // 
            this.dataPorcentajePuestos.AllowUserToAddRows = false;
            this.dataPorcentajePuestos.AllowUserToDeleteRows = false;
            this.dataPorcentajePuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPorcentajePuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPorcentajePuestos.Location = new System.Drawing.Point(3, 228);
            this.dataPorcentajePuestos.Name = "dataPorcentajePuestos";
            this.dataPorcentajePuestos.ReadOnly = true;
            this.dataPorcentajePuestos.Size = new System.Drawing.Size(794, 219);
            this.dataPorcentajePuestos.TabIndex = 1;
            // 
            // PorcentajePuestosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PorcentajePuestosView";
            this.Text = "PorcentajePuestos";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPorcentajePuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button refreshPorcentajePuestos;
        private System.Windows.Forms.DataGridView dataPorcentajePuestos;
    }
}