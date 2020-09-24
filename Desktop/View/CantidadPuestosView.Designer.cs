namespace Evaluacion_IM.View
{
    partial class CantidadPuestosView
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
            this.dataCantidadPuestos = new System.Windows.Forms.DataGridView();
            this.refreshCantidadPuestos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCantidadPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataCantidadPuestos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.refreshCantidadPuestos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataCantidadPuestos
            // 
            this.dataCantidadPuestos.AllowUserToAddRows = false;
            this.dataCantidadPuestos.AllowUserToDeleteRows = false;
            this.dataCantidadPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCantidadPuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCantidadPuestos.Location = new System.Drawing.Point(3, 93);
            this.dataCantidadPuestos.Name = "dataCantidadPuestos";
            this.dataCantidadPuestos.ReadOnly = true;
            this.dataCantidadPuestos.Size = new System.Drawing.Size(794, 354);
            this.dataCantidadPuestos.TabIndex = 0;
            // 
            // refreshCantidadPuestos
            // 
            this.refreshCantidadPuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshCantidadPuestos.Location = new System.Drawing.Point(362, 33);
            this.refreshCantidadPuestos.Name = "refreshCantidadPuestos";
            this.refreshCantidadPuestos.Size = new System.Drawing.Size(75, 23);
            this.refreshCantidadPuestos.TabIndex = 1;
            this.refreshCantidadPuestos.Text = "Refrescar";
            this.refreshCantidadPuestos.UseVisualStyleBackColor = true;
            this.refreshCantidadPuestos.Click += new System.EventHandler(this.onRefresh);
            // 
            // CantidadPuestosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CantidadPuestosView";
            this.Text = "CantidadPuestosView";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCantidadPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataCantidadPuestos;
        private System.Windows.Forms.Button refreshCantidadPuestos;
    }
}