using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrearAnimales.Controller;
using CrearAnimales.Interfaces;
using CrearAnimales.Model;

namespace CrearAnimales.UI
{
    public partial class AnimalCreated : Form
    {
        AnimalController animalController = AnimalController.getInstance();
        public AnimalCreated()
        {
            InitializeComponent();
            desHabilitarComponentes();
        }
        private void habilitarComponentes()
        {
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
            btnCrearAnimal.Enabled = true;
            btnCrearAnimal.Visible = true;
            btnCancelCreate.Enabled = true;
            btnCancelCreate.Visible = true;
            txtEspecie.Enabled = true;
            txtPeso.Enabled = true;
            txtEdad.Enabled = true;
            cboxTiposAnimales.Enabled = true;
            rbCarnivoro.Enabled = true;
            rbHerviboro.Enabled = true;
            rbOmnivoro.Enabled = true;
        }
        private void desHabilitarComponentes()
        {
            btnNuevo.Enabled = true;
            btnNuevo.Visible = true;
            btnCrearAnimal.Enabled = false;
            btnCrearAnimal.Visible = false;
            btnCancelCreate.Enabled = false;
            btnCancelCreate.Visible = false;
            txtEspecie.Enabled = false;
            txtPeso.Enabled = false;
            txtEdad.Enabled = false;
            cboxTiposAnimales.Enabled=false;
            rbCarnivoro.Enabled = false;
            rbHerviboro.Enabled = false;
            rbOmnivoro.Enabled = false;
        }
        private void limpiarComponentes()
        {
            txtEdad.Clear();
            txtEspecie.Clear();
            txtPeso.Clear();
            // ver el tema de los checbox y comboBox para restaurar los valores
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarComponentes();
        }

        private void newAnimal() // Reveer
        {
            string especie = txtEspecie.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            int peso = Convert.ToInt32(txtPeso.Text);
            string tipoAnimal = cboxTiposAnimales.SelectedItem.ToString();
            string diet = cboxTiposAnimales.SelectedItem.ToString();
            animalController.animalCreated(especie, edad, peso, tipoAnimal, diet);
        }
    }
}
