﻿
namespace Capa_Vista_Nominas
{
    partial class frm_principal_nominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal_nominas));
            this.Pnl_contenedor = new System.Windows.Forms.Panel();
            this.panelIdentificacion = new System.Windows.Forms.Panel();
            this.Pnl_formularios = new System.Windows.Forms.Panel();
            this.Pic_logoformularios = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Pnl_mantenimientos = new System.Windows.Forms.Panel();
            this.Btn_percepdeduc = new System.Windows.Forms.Button();
            this.Btn_empleado = new System.Windows.Forms.Button();
            this.Btn_departamento = new System.Windows.Forms.Button();
            this.Btn_puesto = new System.Windows.Forms.Button();
            this.Btn_mantenimientos = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Pnl_superior = new System.Windows.Forms.Panel();
            this.Pic_icono = new System.Windows.Forms.PictureBox();
            this.Btn_restaurar = new System.Windows.Forms.PictureBox();
            this.Btn_minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_maximizar = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar = new System.Windows.Forms.PictureBox();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_usuario2 = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Lbl_fechaHora = new System.Windows.Forms.Label();
            this.Pnl_contenedor.SuspendLayout();
            this.panelIdentificacion.SuspendLayout();
            this.Pnl_formularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logoformularios)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.Pnl_mantenimientos.SuspendLayout();
            this.Pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_contenedor
            // 
            this.Pnl_contenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_contenedor.Controls.Add(this.panelIdentificacion);
            this.Pnl_contenedor.Controls.Add(this.Pnl_formularios);
            this.Pnl_contenedor.Controls.Add(this.panelMenu);
            this.Pnl_contenedor.Controls.Add(this.Pnl_superior);
            this.Pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenedor.Location = new System.Drawing.Point(0, 0);
            this.Pnl_contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_contenedor.Name = "Pnl_contenedor";
            this.Pnl_contenedor.Size = new System.Drawing.Size(1363, 661);
            this.Pnl_contenedor.TabIndex = 1;
            // 
            // panelIdentificacion
            // 
            this.panelIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(214)))));
            this.panelIdentificacion.Controls.Add(this.Lbl_hora);
            this.panelIdentificacion.Controls.Add(this.Lbl_usuario);
            this.panelIdentificacion.Controls.Add(this.Lbl_usuario2);
            this.panelIdentificacion.Controls.Add(this.Lbl_fechaHora);
            this.panelIdentificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIdentificacion.Location = new System.Drawing.Point(206, 638);
            this.panelIdentificacion.Name = "panelIdentificacion";
            this.panelIdentificacion.Size = new System.Drawing.Size(1157, 23);
            this.panelIdentificacion.TabIndex = 3;
            // 
            // Pnl_formularios
            // 
            this.Pnl_formularios.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_formularios.Controls.Add(this.Pic_logoformularios);
            this.Pnl_formularios.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pnl_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_formularios.Location = new System.Drawing.Point(206, 39);
            this.Pnl_formularios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_formularios.Name = "Pnl_formularios";
            this.Pnl_formularios.Size = new System.Drawing.Size(1157, 622);
            this.Pnl_formularios.TabIndex = 2;
            // 
            // Pic_logoformularios
            // 
            this.Pic_logoformularios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic_logoformularios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pic_logoformularios.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logoformularios.Image")));
            this.Pic_logoformularios.Location = new System.Drawing.Point(298, 163);
            this.Pic_logoformularios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_logoformularios.Name = "Pic_logoformularios";
            this.Pic_logoformularios.Size = new System.Drawing.Size(225, 225);
            this.Pic_logoformularios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic_logoformularios.TabIndex = 0;
            this.Pic_logoformularios.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panelMenu.Controls.Add(this.Btn_salir);
            this.panelMenu.Controls.Add(this.Pnl_mantenimientos);
            this.panelMenu.Controls.Add(this.Btn_mantenimientos);
            this.panelMenu.Controls.Add(this.Btn_inicio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 622);
            this.panelMenu.TabIndex = 1;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_salir.Image = global::Capa_Vista_Nominas.Properties.Resources.cerrar_sesion;
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salir.Location = new System.Drawing.Point(0, 290);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(206, 60);
            this.Btn_salir.TabIndex = 7;
            this.Btn_salir.Text = "     Salir";
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Pnl_mantenimientos
            // 
            this.Pnl_mantenimientos.Controls.Add(this.Btn_percepdeduc);
            this.Pnl_mantenimientos.Controls.Add(this.Btn_empleado);
            this.Pnl_mantenimientos.Controls.Add(this.Btn_departamento);
            this.Pnl_mantenimientos.Controls.Add(this.Btn_puesto);
            this.Pnl_mantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_mantenimientos.Location = new System.Drawing.Point(0, 120);
            this.Pnl_mantenimientos.Name = "Pnl_mantenimientos";
            this.Pnl_mantenimientos.Size = new System.Drawing.Size(206, 170);
            this.Pnl_mantenimientos.TabIndex = 9;
            this.Pnl_mantenimientos.Visible = false;
            // 
            // Btn_percepdeduc
            // 
            this.Btn_percepdeduc.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_percepdeduc.FlatAppearance.BorderSize = 0;
            this.Btn_percepdeduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_percepdeduc.ForeColor = System.Drawing.Color.Silver;
            this.Btn_percepdeduc.Location = new System.Drawing.Point(0, 120);
            this.Btn_percepdeduc.Name = "Btn_percepdeduc";
            this.Btn_percepdeduc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_percepdeduc.Size = new System.Drawing.Size(206, 43);
            this.Btn_percepdeduc.TabIndex = 6;
            this.Btn_percepdeduc.Text = "Percepciones\r\nDeducciones";
            this.Btn_percepdeduc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_percepdeduc.UseVisualStyleBackColor = true;
            this.Btn_percepdeduc.Click += new System.EventHandler(this.Btn_percepdeduc_Click);
            // 
            // Btn_empleado
            // 
            this.Btn_empleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_empleado.FlatAppearance.BorderSize = 0;
            this.Btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_empleado.ForeColor = System.Drawing.Color.Silver;
            this.Btn_empleado.Location = new System.Drawing.Point(0, 79);
            this.Btn_empleado.Name = "Btn_empleado";
            this.Btn_empleado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_empleado.Size = new System.Drawing.Size(206, 41);
            this.Btn_empleado.TabIndex = 5;
            this.Btn_empleado.Text = "Empleado";
            this.Btn_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_empleado.UseVisualStyleBackColor = true;
            this.Btn_empleado.Click += new System.EventHandler(this.Btn_empleado_Click);
            // 
            // Btn_departamento
            // 
            this.Btn_departamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_departamento.FlatAppearance.BorderSize = 0;
            this.Btn_departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_departamento.ForeColor = System.Drawing.Color.Silver;
            this.Btn_departamento.Location = new System.Drawing.Point(0, 38);
            this.Btn_departamento.Name = "Btn_departamento";
            this.Btn_departamento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_departamento.Size = new System.Drawing.Size(206, 41);
            this.Btn_departamento.TabIndex = 4;
            this.Btn_departamento.Text = "Departamento";
            this.Btn_departamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_departamento.UseVisualStyleBackColor = true;
            this.Btn_departamento.Click += new System.EventHandler(this.Btn_departamento_Click);
            // 
            // Btn_puesto
            // 
            this.Btn_puesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_puesto.FlatAppearance.BorderSize = 0;
            this.Btn_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_puesto.ForeColor = System.Drawing.Color.Silver;
            this.Btn_puesto.Location = new System.Drawing.Point(0, 0);
            this.Btn_puesto.Name = "Btn_puesto";
            this.Btn_puesto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_puesto.Size = new System.Drawing.Size(206, 38);
            this.Btn_puesto.TabIndex = 3;
            this.Btn_puesto.Text = "Puesto";
            this.Btn_puesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_puesto.UseVisualStyleBackColor = true;
            this.Btn_puesto.Click += new System.EventHandler(this.Btn_puesto_Click);
            // 
            // Btn_mantenimientos
            // 
            this.Btn_mantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_mantenimientos.FlatAppearance.BorderSize = 0;
            this.Btn_mantenimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Btn_mantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Btn_mantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mantenimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mantenimientos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_mantenimientos.Image = global::Capa_Vista_Nominas.Properties.Resources.mantenimiento_web;
            this.Btn_mantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_mantenimientos.Location = new System.Drawing.Point(0, 60);
            this.Btn_mantenimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_mantenimientos.Name = "Btn_mantenimientos";
            this.Btn_mantenimientos.Size = new System.Drawing.Size(206, 60);
            this.Btn_mantenimientos.TabIndex = 2;
            this.Btn_mantenimientos.Text = "     Mantenimientos";
            this.Btn_mantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_mantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_mantenimientos.UseVisualStyleBackColor = true;
            this.Btn_mantenimientos.Click += new System.EventHandler(this.Btn_mantenimientos_Click);
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_inicio.FlatAppearance.BorderSize = 0;
            this.Btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_inicio.Image = global::Capa_Vista_Nominas.Properties.Resources.pagina_de_inicio;
            this.Btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_inicio.Location = new System.Drawing.Point(0, 0);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(206, 60);
            this.Btn_inicio.TabIndex = 1;
            this.Btn_inicio.Text = "     Inicio";
            this.Btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            this.Btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // Pnl_superior
            // 
            this.Pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(1)))), ((int)(((byte)(111)))));
            this.Pnl_superior.Controls.Add(this.Pic_icono);
            this.Pnl_superior.Controls.Add(this.Btn_restaurar);
            this.Pnl_superior.Controls.Add(this.Btn_minimizar);
            this.Pnl_superior.Controls.Add(this.Btn_maximizar);
            this.Pnl_superior.Controls.Add(this.Btn_cerrar);
            this.Pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_superior.Name = "Pnl_superior";
            this.Pnl_superior.Size = new System.Drawing.Size(1363, 39);
            this.Pnl_superior.TabIndex = 0;
            // 
            // Pic_icono
            // 
            this.Pic_icono.Image = global::Capa_Vista_Nominas.Properties.Resources.seguridad;
            this.Pic_icono.Location = new System.Drawing.Point(12, 4);
            this.Pic_icono.Name = "Pic_icono";
            this.Pic_icono.Size = new System.Drawing.Size(39, 32);
            this.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_icono.TabIndex = 4;
            this.Pic_icono.TabStop = false;
            // 
            // Btn_restaurar
            // 
            this.Btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_restaurar.Image")));
            this.Btn_restaurar.Location = new System.Drawing.Point(1311, 11);
            this.Btn_restaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_restaurar.Name = "Btn_restaurar";
            this.Btn_restaurar.Size = new System.Drawing.Size(16, 16);
            this.Btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_restaurar.TabIndex = 3;
            this.Btn_restaurar.TabStop = false;
            this.Btn_restaurar.Visible = false;
            this.Btn_restaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1289, 11);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(16, 16);
            this.Btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_minimizar.TabIndex = 2;
            this.Btn_minimizar.TabStop = false;
            this.Btn_minimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Btn_maximizar
            // 
            this.Btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_maximizar.Image")));
            this.Btn_maximizar.Location = new System.Drawing.Point(1312, 11);
            this.Btn_maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_maximizar.Name = "Btn_maximizar";
            this.Btn_maximizar.Size = new System.Drawing.Size(16, 16);
            this.Btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_maximizar.TabIndex = 1;
            this.Btn_maximizar.TabStop = false;
            this.Btn_maximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1333, 11);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(16, 16);
            this.Btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_cerrar.TabIndex = 0;
            this.Btn_cerrar.TabStop = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(757, 0);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(77, 20);
            this.Lbl_usuario.TabIndex = 0;
            this.Lbl_usuario.Text = "Usuario: ";
            // 
            // Lbl_usuario2
            // 
            this.Lbl_usuario2.AutoSize = true;
            this.Lbl_usuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario2.Location = new System.Drawing.Point(840, 0);
            this.Lbl_usuario2.Name = "Lbl_usuario2";
            this.Lbl_usuario2.Size = new System.Drawing.Size(21, 20);
            this.Lbl_usuario2.TabIndex = 1;
            this.Lbl_usuario2.Text = "--";
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(1020, 1);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(21, 20);
            this.Lbl_hora.TabIndex = 3;
            this.Lbl_hora.Text = "--";
            // 
            // Lbl_fechaHora
            // 
            this.Lbl_fechaHora.AutoSize = true;
            this.Lbl_fechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaHora.Location = new System.Drawing.Point(940, 0);
            this.Lbl_fechaHora.Name = "Lbl_fechaHora";
            this.Lbl_fechaHora.Size = new System.Drawing.Size(60, 20);
            this.Lbl_fechaHora.TabIndex = 2;
            this.Lbl_fechaHora.Text = "Fecha:";
            // 
            // frm_principal_nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 661);
            this.Controls.Add(this.Pnl_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(651, 400);
            this.Name = "frm_principal_nominas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_principal_nominas";
            this.Pnl_contenedor.ResumeLayout(false);
            this.panelIdentificacion.ResumeLayout(false);
            this.panelIdentificacion.PerformLayout();
            this.Pnl_formularios.ResumeLayout(false);
            this.Pnl_formularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logoformularios)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.Pnl_mantenimientos.ResumeLayout(false);
            this.Pnl_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_contenedor;
        private System.Windows.Forms.Panel panelIdentificacion;
        private System.Windows.Forms.Panel Pnl_formularios;
        private System.Windows.Forms.PictureBox Pic_logoformularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Panel Pnl_superior;
        private System.Windows.Forms.PictureBox Pic_icono;
        private System.Windows.Forms.PictureBox Btn_restaurar;
        private System.Windows.Forms.PictureBox Btn_minimizar;
        private System.Windows.Forms.PictureBox Btn_maximizar;
        private System.Windows.Forms.PictureBox Btn_cerrar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Panel Pnl_mantenimientos;
        private System.Windows.Forms.Button Btn_departamento;
        private System.Windows.Forms.Button Btn_puesto;
        private System.Windows.Forms.Button Btn_mantenimientos;
        private System.Windows.Forms.Button Btn_percepdeduc;
        private System.Windows.Forms.Button Btn_empleado;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Label Lbl_fechaHora;
        private System.Windows.Forms.Label Lbl_usuario2;
        private System.Windows.Forms.Label Lbl_usuario;
    }
}