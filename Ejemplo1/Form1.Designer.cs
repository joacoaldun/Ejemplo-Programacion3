namespace Ejemplo1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.numNumerosFavoritos = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerosFavoritos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(188, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgregar.Location = new System.Drawing.Point(119, 618);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvElementos
            // 
            this.lvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(119, 497);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(220, 97);
            this.lvElementos.TabIndex = 8;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            this.lvElementos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(89, 182);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(93, 13);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(188, 176);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(188, 203);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(135, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(99, 45);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(184, 31);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Perfil Persona";
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Checked = true;
            this.rbtWizard.Location = new System.Drawing.Point(8, 35);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizard.TabIndex = 1;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            this.rbtWizard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(146, 35);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 2;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(267, 35);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 2;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxTipo.Controls.Add(this.rbtMuggle);
            this.gbxTipo.Controls.Add(this.rbtSquibs);
            this.gbxTipo.Controls.Add(this.rbtWizard);
            this.gbxTipo.Location = new System.Drawing.Point(92, 245);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(367, 61);
            this.gbxTipo.TabIndex = 3;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(116, 347);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color Favorito:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(202, 344);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(214, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // numNumerosFavoritos
            // 
            this.numNumerosFavoritos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumerosFavoritos.Location = new System.Drawing.Point(217, 389);
            this.numNumerosFavoritos.Name = "numNumerosFavoritos";
            this.numNumerosFavoritos.Size = new System.Drawing.Size(199, 20);
            this.numNumerosFavoritos.TabIndex = 5;
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(116, 391);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroFavorito.TabIndex = 15;
            this.lblNumeroFavorito.Text = "Numero favorito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerPerfil.FlatAppearance.BorderSize = 2;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(132, 441);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(106, 28);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver &Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 676);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.numNumerosFavoritos);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 719);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(548, 715);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerosFavoritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.NumericUpDown numNumerosFavoritos;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

