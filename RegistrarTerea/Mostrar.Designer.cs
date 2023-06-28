namespace RegistrarTerea
{
    partial class Mostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar));
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AllowUserToAddRows = false;
            this.dtgvRegistro.AllowUserToDeleteRows = false;
            this.dtgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tipo_de_Tarea,
            this.Detalles,
            this.Reunion,
            this.Tareas});
            this.dtgvRegistro.Location = new System.Drawing.Point(12, 12);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.RowHeadersWidth = 10;
            this.dtgvRegistro.Size = new System.Drawing.Size(776, 426);
            this.dtgvRegistro.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Tipo_de_Tarea
            // 
            this.Tipo_de_Tarea.HeaderText = "Tipo de Tarea";
            this.Tipo_de_Tarea.Name = "Tipo_de_Tarea";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            // 
            // Reunion
            // 
            this.Reunion.HeaderText = "Reunión";
            this.Reunion.Name = "Reunion";
            // 
            // Tareas
            // 
            this.Tareas.HeaderText = "Tareas";
            this.Tareas.Name = "Tareas";
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tareas;
    }
}