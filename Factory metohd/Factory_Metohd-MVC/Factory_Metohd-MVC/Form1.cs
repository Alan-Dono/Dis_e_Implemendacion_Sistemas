using System;
using System.Windows.Forms;
using Factory_Metohd_MVC.Controladora;
using Factory_Metohd_MVC.Interfaces;

namespace Factory_Metohd_MVC
{
    public partial class Form1 : Form
    {
        FigurasController controller = new FigurasController(); // esto deberia ser por patron singleton para tener una sola instancia de la controladora pero bueno...
        public Form1()
        {
            InitializeComponent();
        }
        // estamos en la vista
        private void btnCreate_Click(object sender, EventArgs e)
        {
            controller.crearFiguras(cboxFiguras.Text); // pasa un string como parametro al metodo de la controlador que luego se lo pasa a la fabricaDeFiguras
            lboxFiguras.Items.Clear(); // Limpiamos la lisa antes de mostrarla asi no vuelve a cargar los objetos repetidos
            mostrarLista(); // llamamos al metodo de abajo para llenar el ListBox
        }
        private void mostrarLista()
        {
            foreach(IFiguras figura in controller.getLista()) // <-- para cada figura que implementa IFigura en la lista que devuelve la Controladora de tipo IFigura
            {
                lboxFiguras.Items.Add(figura.getName()); // al listBox. a cada item. le agregamos . figura.getName(). esto se puede hacer gracias a que por la interfaz
                // podemos aceder a los metodos de la clase concreta y esa es una ventaja muy poderosa.
            }
        }
    }
}
