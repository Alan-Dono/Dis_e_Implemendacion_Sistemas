using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntitiesLayer.ConcretClass;
using EntitiesLayer.ConcretClass.atmosphere;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace CrearAnimales
{
    public partial class FrmAnimalCreated : Form
    {
        public FrmAnimalCreated()
        {
            InitializeComponent();
        }

        private void FrmAnimalCreated_Load(object sender, EventArgs e)
        {
            CargarCmBox();
        }
        private void CargarCmBox()
        {
            // Dietas
            cmDieta.Items.Clear();
            cmDieta.Text = "Seleccione una opción";
            cmDieta.Items.Add(new Carnivoro());
            cmDieta.Items.Add(new Herbivoro());
            cmDieta.Items.Add(new Omnivoro());
            // Habitats
            cmHabitat.Items.Clear();
            cmHabitat.Text = "Seleccione una opción";
            cmHabitat.Items.Add(new Aerial());
            cmHabitat.Items.Add(new City());
            cmHabitat.Items.Add(new Desert());
            cmHabitat.Items.Add(new Forest());
            cmHabitat.Items.Add(new Mountain());
            cmHabitat.Items.Add(new Ocean());
            cmHabitat.Items.Add(new Sheet());
            cmHabitat.Items.Add(new Underground());
        }

        private void CrearAnimal()
        {
            Animal animal = new Animal();
            animal.Especie = txtEspecie.Text;
            animal.Age = Convert.ToInt32(txtEdad.Text);
            animal.Weight = Convert.ToInt32(txtPeso.Text);
            animal.Diet = cmDieta.SelectedItem as IDiet;
            animal.Enviroment = cmHabitat.SelectedItem as IEnviroment;
            // Validar el modelo
            ValidarAnimal(animal);
        }

        private void ValidarAnimal(Animal animal)
        {
            var errores = ValidadorAnimalModel.ValidarObjeto(animal);
            foreach(var error in errores)
            {
                MessageBox.Show(error.ErrorMessage);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CrearAnimal();
            this.Close();
            LimpiarComponentes();
        }

        public void FrmAnimalCreated_FormClosed(object sender, FormClosedEventArgs e){ }

        #region VisualComponents
        private void LimpiarComponentes()
        {
            txtEdad.Clear();
            txtEspecie.Clear();
            txtPeso.Clear();
            CargarCmBox();
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
    }
}
