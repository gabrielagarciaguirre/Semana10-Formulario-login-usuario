
namespace Semana8_Formulario_login_usuario
{
    partial class Fusuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fusuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.ComboBox();
            this.usernameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._sistema_mdbDataSet = new Semana8_Formulario_login_usuario._sistema_mdbDataSet();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.ComboBox();
            this.bprimero = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.usernameTableAdapter = new Semana8_Formulario_login_usuario._sistema_mdbDataSetTableAdapters.UsernameTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agendaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet1 = new Semana8_Formulario_login_usuario.agendaDataSet();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Semana8_Formulario_login_usuario.agendaDataSet();
            this.contactosTableAdapter = new Semana8_Formulario_login_usuario.agendaDataSetTableAdapters.contactosTableAdapter();
            this.contactosDataSet = new Semana8_Formulario_login_usuario.contactosDataSet();
            this.contactosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sistema_mdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usernameBindingSource, "Nombre", true));
            this.txtusuario.DataSource = this.usernameBindingSource;
            this.txtusuario.FormattingEnabled = true;
            this.txtusuario.Location = new System.Drawing.Point(226, 93);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(121, 21);
            this.txtusuario.TabIndex = 10;
            // 
            // usernameBindingSource
            // 
            this.usernameBindingSource.DataMember = "Username";
            this.usernameBindingSource.DataSource = this._sistema_mdbDataSet;
            // 
            // _sistema_mdbDataSet
            // 
            this._sistema_mdbDataSet.DataSetName = "_sistema_mdbDataSet";
            this._sistema_mdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstnivel
            // 
            this.lstnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usernameBindingSource, "Nivel", true));
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstnivel.Location = new System.Drawing.Point(226, 172);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(121, 21);
            this.lstnivel.TabIndex = 11;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usernameBindingSource, "Clave", true));
            this.txtclave.FormattingEnabled = true;
            this.txtclave.Location = new System.Drawing.Point(226, 135);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(121, 21);
            this.txtclave.TabIndex = 12;
            // 
            // bprimero
            // 
            this.bprimero.Location = new System.Drawing.Point(21, 235);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(86, 48);
            this.bprimero.TabIndex = 13;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // banterior
            // 
            this.banterior.Location = new System.Drawing.Point(125, 235);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(86, 48);
            this.banterior.TabIndex = 14;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.Location = new System.Drawing.Point(226, 235);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(86, 48);
            this.bsiguiente.TabIndex = 15;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // bultimo
            // 
            this.bultimo.Location = new System.Drawing.Point(329, 235);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(86, 48);
            this.bultimo.TabIndex = 16;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            this.bultimo.Click += new System.EventHandler(this.bultimo_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.Location = new System.Drawing.Point(21, 360);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(86, 48);
            this.bnuevo.TabIndex = 17;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(125, 306);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(86, 48);
            this.beliminar.TabIndex = 18;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Location = new System.Drawing.Point(226, 360);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(86, 48);
            this.bmodificar.TabIndex = 19;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(329, 306);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(86, 48);
            this.bsalir.TabIndex = 20;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(21, 306);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(86, 48);
            this.bguardar.TabIndex = 21;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(226, 306);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(86, 48);
            this.bactualizar.TabIndex = 22;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // usernameTableAdapter
            // 
            this.usernameTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(468, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(696, 93);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(90, 48);
            this.btbuscar.TabIndex = 29;
            this.btbuscar.Text = "Buscar ";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.agendaDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(450, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 235);
            this.dataGridView1.TabIndex = 28;
            // 
            // agendaDataSet1BindingSource
            // 
            this.agendaDataSet1BindingSource.DataSource = this.agendaDataSet1;
            this.agendaDataSet1BindingSource.Position = 0;
            // 
            // agendaDataSet1
            // 
            this.agendaDataSet1.DataSetName = "agendaDataSet";
            this.agendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "contactos";
            this.contactosBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
            // 
            // contactosDataSet
            // 
            this.contactosDataSet.DataSetName = "contactosDataSet";
            this.contactosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosDataSetBindingSource
            // 
            this.contactosDataSetBindingSource.DataSource = this.contactosDataSet;
            this.contactosDataSetBindingSource.Position = 0;
            // 
            // contactosBindingSource1
            // 
            this.contactosBindingSource1.DataMember = "contactos";
            this.contactosBindingSource1.DataSource = this.agendaDataSet1BindingSource;
            // 
            // Fusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bactualizar);
            this.Name = "Fusuarios";
            this.Text = "Ferreteria/AgregarUsuario";
            this.Load += new System.EventHandler(this.Fusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sistema_mdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtusuario;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.ComboBox txtclave;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bactualizar;
        private _sistema_mdbDataSet _sistema_mdbDataSet;
        private System.Windows.Forms.BindingSource usernameBindingSource;
        private _sistema_mdbDataSetTableAdapters.UsernameTableAdapter usernameTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private agendaDataSetTableAdapters.contactosTableAdapter contactosTableAdapter;
        private System.Windows.Forms.BindingSource contactosDataSetBindingSource;
        private contactosDataSet contactosDataSet;
        private System.Windows.Forms.BindingSource agendaDataSet1BindingSource;
        private agendaDataSet agendaDataSet1;
        private System.Windows.Forms.BindingSource contactosBindingSource1;
    }
}