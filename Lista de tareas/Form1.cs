using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Lista_de_tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            string nuevaTarea = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(nuevaTarea))
            {
                listBox1.Items.Add(nuevaTarea);
                textBox1.Clear();
            }
        }

        private void Completarbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int indiceSeleccionado = listBox1.SelectedIndex;
                string tarea = listBox1.Items[indiceSeleccionado].ToString();
                listBox1.Items[indiceSeleccionado] = "✔️ " + tarea;
            }
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int indiceSeleccionado = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(indiceSeleccionado);
            }
        }


        private void CambiarColorFondoBtn_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.BackColor = colorDialog.Color;
            }
        }

        private void CambiarTamañoLetraBtn_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Font = fontDialog.Font;
            }
        }
    }
}

