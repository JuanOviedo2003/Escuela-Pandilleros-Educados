using System;
using System.Collections;
using System.Windows.Forms;

namespace Practica33
{
    public partial class Form1 : Form
    {
        ArrayList lista_materias;
        Materia materia;
        public Form1()
        {
            InitializeComponent();
            lista_materias = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                materia = new Materia();
                materia.NombreMateria = txtMateria.Text;
                materia.Nota1 = int.Parse(txtNota1.Text);
                materia.Nota2 = int.Parse(txtNota2.Text);
                materia.Nota3 = int.Parse(txtNota3.Text);
                lista_materias.Add(materia);
                limpiar();
                MessageBox.Show("Guardado con Exito", "SAVE");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Exeption" + ex, "ERROR");
            }

            
        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtMateria.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            area.Text = "Materias ";
            foreach(Materia mate in lista_materias){
                area.AppendText("\nNombre: "+mate.NombreMateria);
                area.AppendText("\nNota 1: " + mate.Nota1);
                area.AppendText("\nNota 2: " + mate.Nota2);
                area.AppendText("\nNota 3: " + mate.Nota3);
                area.AppendText("\nDefinitiva: "+( mate.Nota1 * 0.3 + mate.Nota2 * 0.3 + mate.Nota3 * 0.3));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // lista_materias.Remove // asi no mas
            // lista_materias.RemoveAt // por index
        }
    }
}
