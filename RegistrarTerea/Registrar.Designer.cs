namespace RegistrarTerea
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdmostrar = new System.Windows.Forms.Button();
            this.mrcTareas.SuspendLayout();
            this.mrcReunion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(77, 554);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(80, 27);
            this.cmdCancelar.TabIndex = 8;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(160, 554);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(92, 28);
            this.cmdGrabar.TabIndex = 6;
            this.cmdGrabar.Text = "Registrar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Location = new System.Drawing.Point(14, 427);
            this.mrcTareas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mrcTareas.Size = new System.Drawing.Size(324, 107);
            this.mrcTareas.TabIndex = 5;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotasReunion.Location = new System.Drawing.Point(190, 66);
            this.chkNotasReunion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(97, 17);
            this.chkNotasReunion.TabIndex = 3;
            this.chkNotasReunion.Text = "Notas Reunión";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvestigacion.Location = new System.Drawing.Point(39, 66);
            this.chkInvestigacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 2;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebate.Location = new System.Drawing.Point(190, 38);
            this.chkDebate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 1;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepositorio.Location = new System.Drawing.Point(39, 38);
            this.chkRepositorio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.Location = new System.Drawing.Point(14, 306);
            this.mrcReunion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mrcReunion.Size = new System.Drawing.Size(324, 100);
            this.mrcReunion.TabIndex = 4;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunión";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(201, 49);
            this.optNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(46, 21);
            this.optNo.TabIndex = 1;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Checked = true;
            this.optSi.Location = new System.Drawing.Point(63, 49);
            this.optSi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(40, 21);
            this.optSi.TabIndex = 0;
            this.optSi.TabStop = true;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "Tarea 1",
            "Tarea 2",
            "Tarea 3",
            "Tarea 4",
            "Tarea 5",
            "Tarea 6"});
            this.lstTipo.Location = new System.Drawing.Point(14, 112);
            this.lstTipo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(322, 21);
            this.lstTipo.TabIndex = 2;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(14, 189);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(322, 86);
            this.txtDetalle.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(14, 38);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(322, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(14, 169);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(59, 17);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(14, 92);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(14, 18);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 17);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // cmdmostrar
            // 
            this.cmdmostrar.Location = new System.Drawing.Point(254, 554);
            this.cmdmostrar.Name = "cmdmostrar";
            this.cmdmostrar.Size = new System.Drawing.Size(84, 28);
            this.cmdmostrar.TabIndex = 7;
            this.cmdmostrar.Text = "Mostrar";
            this.cmdmostrar.UseVisualStyleBackColor = true;
            this.cmdmostrar.Click += new System.EventHandler(this.cmdmostrar_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 591);
            this.Controls.Add(this.cmdmostrar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lstTipo);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button cmdmostrar;
    }
}