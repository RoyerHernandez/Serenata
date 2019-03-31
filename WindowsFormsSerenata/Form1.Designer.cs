namespace WindowsFormsSerenata
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSerenata = new System.Windows.Forms.GroupBox();
            this.pedirSerenata = new System.Windows.Forms.Button();
            this.serenata = new System.Windows.Forms.Label();
            this.dataGridViewSerenata = new System.Windows.Forms.DataGridView();
            this.groupBoxSerenata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerenata)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSerenata
            // 
            this.groupBoxSerenata.Controls.Add(this.dataGridViewSerenata);
            this.groupBoxSerenata.Controls.Add(this.serenata);
            this.groupBoxSerenata.Controls.Add(this.pedirSerenata);
            this.groupBoxSerenata.Location = new System.Drawing.Point(30, 26);
            this.groupBoxSerenata.Name = "groupBoxSerenata";
            this.groupBoxSerenata.Size = new System.Drawing.Size(457, 280);
            this.groupBoxSerenata.TabIndex = 0;
            this.groupBoxSerenata.TabStop = false;
            this.groupBoxSerenata.Text = "Serenata";
            this.groupBoxSerenata.Enter += new System.EventHandler(this.groupBoxSerenata_Enter);
            // 
            // pedirSerenata
            // 
            this.pedirSerenata.Location = new System.Drawing.Point(42, 75);
            this.pedirSerenata.Name = "pedirSerenata";
            this.pedirSerenata.Size = new System.Drawing.Size(128, 38);
            this.pedirSerenata.TabIndex = 0;
            this.pedirSerenata.Text = "Pedir Serenata";
            this.pedirSerenata.UseVisualStyleBackColor = true;
            this.pedirSerenata.Click += new System.EventHandler(this.button1_Click);
            // 
            // serenata
            // 
            this.serenata.AutoSize = true;
            this.serenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serenata.Location = new System.Drawing.Point(222, 16);
            this.serenata.Name = "serenata";
            this.serenata.Size = new System.Drawing.Size(59, 13);
            this.serenata.TabIndex = 1;
            this.serenata.Text = "Vocalista";
            // 
            // dataGridViewSerenata
            // 
            this.dataGridViewSerenata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridViewSerenata.Location = new System.Drawing.Point(225, 32);
            this.dataGridViewSerenata.Name = "dataGridViewSerenata";
            this.dataGridViewSerenata.Size = new System.Drawing.Size(226, 242);
            this.dataGridViewSerenata.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 324);
            this.Controls.Add(this.groupBoxSerenata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSerenata.ResumeLayout(false);
            this.groupBoxSerenata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerenata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSerenata;
        private System.Windows.Forms.Button pedirSerenata;
        private System.Windows.Forms.Label serenata;
        private System.Windows.Forms.DataGridView dataGridViewSerenata;
    }
}

