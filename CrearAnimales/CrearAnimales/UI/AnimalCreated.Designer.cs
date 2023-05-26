using System;

namespace CrearAnimales.UI
{
    partial class AnimalCreated
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
            this.lvlTitle = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxTiposAnimales = new System.Windows.Forms.ComboBox();
            this.btnCancelCreate = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCrearAnimal = new System.Windows.Forms.Button();
            this.rbOmnivoro = new System.Windows.Forms.RadioButton();
            this.rbHerviboro = new System.Windows.Forms.RadioButton();
            this.rbCarnivoro = new System.Windows.Forms.RadioButton();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataPanel.SuspendLayout();
            this.showPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlTitle
            // 
            this.lvlTitle.AutoSize = true;
            this.lvlTitle.Font = new System.Drawing.Font("Bodoni MT Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTitle.Location = new System.Drawing.Point(191, 9);
            this.lvlTitle.Name = "lvlTitle";
            this.lvlTitle.Size = new System.Drawing.Size(738, 70);
            this.lvlTitle.TabIndex = 0;
            this.lvlTitle.Text = "Creacion de Animales";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.label5);
            this.dataPanel.Controls.Add(this.cboxTiposAnimales);
            this.dataPanel.Controls.Add(this.btnCancelCreate);
            this.dataPanel.Controls.Add(this.btnNuevo);
            this.dataPanel.Controls.Add(this.btnCrearAnimal);
            this.dataPanel.Controls.Add(this.rbOmnivoro);
            this.dataPanel.Controls.Add(this.rbHerviboro);
            this.dataPanel.Controls.Add(this.rbCarnivoro);
            this.dataPanel.Controls.Add(this.txtEdad);
            this.dataPanel.Controls.Add(this.txtPeso);
            this.dataPanel.Controls.Add(this.label3);
            this.dataPanel.Controls.Add(this.label2);
            this.dataPanel.Controls.Add(this.txtEspecie);
            this.dataPanel.Controls.Add(this.label1);
            this.dataPanel.Controls.Add(this.lblComplete);
            this.dataPanel.Location = new System.Drawing.Point(13, 97);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(388, 444);
            this.dataPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo";
            // 
            // cboxTiposAnimales
            // 
            this.cboxTiposAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTiposAnimales.FormattingEnabled = true;
            this.cboxTiposAnimales.Items.AddRange(new object[] {
            "Terrestre",
            "Acuatico",
            "AeroTerrestre"});
            this.cboxTiposAnimales.Location = new System.Drawing.Point(125, 200);
            this.cboxTiposAnimales.Name = "cboxTiposAnimales";
            this.cboxTiposAnimales.Size = new System.Drawing.Size(236, 33);
            this.cboxTiposAnimales.TabIndex = 13;
            // 
            // btnCancelCreate
            // 
            this.btnCancelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCreate.Location = new System.Drawing.Point(261, 318);
            this.btnCancelCreate.Name = "btnCancelCreate";
            this.btnCancelCreate.Size = new System.Drawing.Size(100, 40);
            this.btnCancelCreate.TabIndex = 12;
            this.btnCancelCreate.Text = "Cancelar";
            this.btnCancelCreate.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(261, 373);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCrearAnimal
            // 
            this.btnCrearAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAnimal.Location = new System.Drawing.Point(261, 375);
            this.btnCrearAnimal.Name = "btnCrearAnimal";
            this.btnCrearAnimal.Size = new System.Drawing.Size(100, 40);
            this.btnCrearAnimal.TabIndex = 10;
            this.btnCrearAnimal.Text = "Crear";
            this.btnCrearAnimal.UseVisualStyleBackColor = true;
            // 
            // rbOmnivoro
            // 
            this.rbOmnivoro.AutoSize = true;
            this.rbOmnivoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOmnivoro.Location = new System.Drawing.Point(29, 375);
            this.rbOmnivoro.Name = "rbOmnivoro";
            this.rbOmnivoro.Size = new System.Drawing.Size(147, 33);
            this.rbOmnivoro.TabIndex = 9;
            this.rbOmnivoro.TabStop = true;
            this.rbOmnivoro.Text = "Omnivoro";
            this.rbOmnivoro.UseVisualStyleBackColor = true;
            // 
            // rbHerviboro
            // 
            this.rbHerviboro.AutoSize = true;
            this.rbHerviboro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHerviboro.Location = new System.Drawing.Point(29, 325);
            this.rbHerviboro.Name = "rbHerviboro";
            this.rbHerviboro.Size = new System.Drawing.Size(149, 33);
            this.rbHerviboro.TabIndex = 8;
            this.rbHerviboro.TabStop = true;
            this.rbHerviboro.Text = "Herviboro";
            this.rbHerviboro.UseVisualStyleBackColor = true;
            // 
            // rbCarnivoro
            // 
            this.rbCarnivoro.AutoSize = true;
            this.rbCarnivoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCarnivoro.Location = new System.Drawing.Point(29, 271);
            this.rbCarnivoro.Name = "rbCarnivoro";
            this.rbCarnivoro.Size = new System.Drawing.Size(147, 33);
            this.rbCarnivoro.TabIndex = 7;
            this.rbCarnivoro.TabStop = true;
            this.rbCarnivoro.Text = "Carnivoro";
            this.rbCarnivoro.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(125, 116);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(236, 30);
            this.txtEdad.TabIndex = 6;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(125, 157);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(236, 30);
            this.txtPeso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso (Kg)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(125, 77);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(236, 30);
            this.txtEspecie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especie";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Bodoni MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(57, 1);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(272, 40);
            this.lblComplete.TabIndex = 0;
            this.lblComplete.Text = "Informacion Requerida";
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.listView1);
            this.showPanel.Controls.Add(this.label4);
            this.showPanel.Location = new System.Drawing.Point(407, 98);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(663, 443);
            this.showPanel.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 400);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Animales Creados";
            // 
            // AnimalCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.lvlTitle);
            this.Name = "AnimalCreated";
            this.Text = "AnimalCreated";
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lvlTitle;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHerviboro;
        private System.Windows.Forms.RadioButton rbCarnivoro;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbOmnivoro;
        private System.Windows.Forms.Button btnCrearAnimal;
        private System.Windows.Forms.Button btnCancelCreate;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxTiposAnimales;
    }
}