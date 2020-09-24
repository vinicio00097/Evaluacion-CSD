namespace Evaluacion_IM.View
{
    partial class PuestosActivosView
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
            this.refreshPuestosActivos = new System.Windows.Forms.Button();
            this.dataPuestosActivos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPuestosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.refreshPuestosActivos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataPuestosActivos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // refreshPuestosActivos
            // 
            this.refreshPuestosActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshPuestosActivos.Location = new System.Drawing.Point(362, 33);
            this.refreshPuestosActivos.Name = "refreshPuestosActivos";
            this.refreshPuestosActivos.Size = new System.Drawing.Size(75, 23);
            this.refreshPuestosActivos.TabIndex = 0;
            this.refreshPuestosActivos.Text = "Refrescar";
            this.refreshPuestosActivos.UseVisualStyleBackColor = true;
            this.refreshPuestosActivos.Click += new System.EventHandler(this.onRefresh);
            // 
            // dataPuestosActivos
            // 
            this.dataPuestosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPuestosActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPuestosActivos.Location = new System.Drawing.Point(3, 93);
            this.dataPuestosActivos.Name = "dataPuestosActivos";
            this.dataPuestosActivos.Size = new System.Drawing.Size(794, 354);
            this.dataPuestosActivos.TabIndex = 1;
            // 
            // PuestosActivosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PuestosActivosView";
            this.Text = "PuestosActivos";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPuestosActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button refreshPuestosActivos;
        private System.Windows.Forms.DataGridView dataPuestosActivos;
    }
}