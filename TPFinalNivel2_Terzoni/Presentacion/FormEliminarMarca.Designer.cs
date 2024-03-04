namespace Presentacion
{
    partial class FormEliminarMarca
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
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnCancelarEliminarMarca = new System.Windows.Forms.Button();
            this.lbxMarcas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el nombre de la marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "que desea eliminar:";
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMarca.Location = new System.Drawing.Point(26, 270);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Aceptar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnCancelarEliminarMarca
            // 
            this.btnCancelarEliminarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEliminarMarca.Location = new System.Drawing.Point(125, 270);
            this.btnCancelarEliminarMarca.Name = "btnCancelarEliminarMarca";
            this.btnCancelarEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEliminarMarca.TabIndex = 4;
            this.btnCancelarEliminarMarca.Text = "Cancelar";
            this.btnCancelarEliminarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarEliminarMarca.Click += new System.EventHandler(this.btnCancelarEliminarMarca_Click);
            // 
            // lbxMarcas
            // 
            this.lbxMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMarcas.FormattingEnabled = true;
            this.lbxMarcas.ItemHeight = 16;
            this.lbxMarcas.Location = new System.Drawing.Point(26, 72);
            this.lbxMarcas.Name = "lbxMarcas";
            this.lbxMarcas.Size = new System.Drawing.Size(189, 180);
            this.lbxMarcas.TabIndex = 5;
            // 
            // FormEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 343);
            this.Controls.Add(this.lbxMarcas);
            this.Controls.Add(this.btnCancelarEliminarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarMarca";
            this.Load += new System.EventHandler(this.FormEliminarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnCancelarEliminarMarca;
        private System.Windows.Forms.ListBox lbxMarcas;
    }
}