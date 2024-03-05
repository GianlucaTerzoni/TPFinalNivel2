namespace Presentacion
{
    partial class FormEliminarCategoria
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
            this.lbxCategoria = new System.Windows.Forms.ListBox();
            this.btnCancelarEliminarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCategoria
            // 
            this.lbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lbxCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategoria.ForeColor = System.Drawing.Color.White;
            this.lbxCategoria.FormattingEnabled = true;
            this.lbxCategoria.ItemHeight = 21;
            this.lbxCategoria.Location = new System.Drawing.Point(40, 81);
            this.lbxCategoria.Name = "lbxCategoria";
            this.lbxCategoria.Size = new System.Drawing.Size(189, 172);
            this.lbxCategoria.TabIndex = 10;
            // 
            // btnCancelarEliminarCategoria
            // 
            this.btnCancelarEliminarCategoria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCancelarEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEliminarCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEliminarCategoria.Location = new System.Drawing.Point(143, 268);
            this.btnCancelarEliminarCategoria.Name = "btnCancelarEliminarCategoria";
            this.btnCancelarEliminarCategoria.Size = new System.Drawing.Size(75, 31);
            this.btnCancelarEliminarCategoria.TabIndex = 9;
            this.btnCancelarEliminarCategoria.Text = "Cancelar";
            this.btnCancelarEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarEliminarCategoria.Click += new System.EventHandler(this.btnCancelarEliminarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(44, 268);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarCategoria.TabIndex = 8;
            this.btnEliminarCategoria.Text = "Aceptar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = " desea eliminar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione la categoría que";
            // 
            // FormEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(306, 344);
            this.Controls.Add(this.lbxCategoria);
            this.Controls.Add(this.btnCancelarEliminarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Categoría";
            this.Load += new System.EventHandler(this.FormEliminarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCategoria;
        private System.Windows.Forms.Button btnCancelarEliminarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}