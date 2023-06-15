
namespace CapaVista
{
    partial class Mant_examen
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.tbl_examenes = new System.Windows.Forms.DataGridView();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id_tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_examenes)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(109, 22);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 14;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(161, 244);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(118, 21);
            this.cbxCodigo.TabIndex = 45;
            this.cbxCodigo.SelectedIndexChanged += new System.EventHandler(this.cbxCodigo_SelectedIndexChanged);
            // 
            // tbl_examenes
            // 
            this.tbl_examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_examenes.Location = new System.Drawing.Point(285, 204);
            this.tbl_examenes.Name = "tbl_examenes";
            this.tbl_examenes.Size = new System.Drawing.Size(488, 212);
            this.tbl_examenes.TabIndex = 44;
            this.tbl_examenes.Tag = "tbl_examen";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(86, 331);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 43;
            this.txt_precio.Tag = "precio";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(161, 288);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre.TabIndex = 42;
            this.txt_nombre.Tag = "nombreExam";
            // 
            // txt_id_tipo
            // 
            this.txt_id_tipo.Location = new System.Drawing.Point(161, 246);
            this.txt_id_tipo.Name = "txt_id_tipo";
            this.txt_id_tipo.Size = new System.Drawing.Size(118, 20);
            this.txt_id_tipo.TabIndex = 41;
            this.txt_id_tipo.Tag = "fk_codtipoExam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "NOMBRE DE EXAMEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "CODIGO TIPO EXAMEN";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(105, 204);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(40, 20);
            this.txt_id.TabIndex = 37;
            this.txt_id.Tag = "pk_idExamen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID EXAMEN:";
            // 
            // cbxNombre
            // 
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(161, 288);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(118, 21);
            this.cbxNombre.TabIndex = 46;
            this.cbxNombre.SelectedIndexChanged += new System.EventHandler(this.cbxNombre_SelectedIndexChanged);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Location = new System.Drawing.Point(697, 138);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(75, 23);
            this.btn_Reporte.TabIndex = 47;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // Mant_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.cbxCodigo);
            this.Controls.Add(this.tbl_examenes);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNombre);
            this.Controls.Add(this.navegador1);
            this.Name = "Mant_examen";
            this.Text = "Mant_examen";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_examenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.DataGridView tbl_examenes;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.Button btn_Reporte;
    }
}