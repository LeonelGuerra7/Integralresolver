using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace.Models;


namespace IntegralesSolucion
{
    public partial class FormIntegral : Form
    {
        private IntegralCalculator _calculator; // Cambiado a IntegralCalculator

        public FormIntegral()
        {
            InitializeComponent();
            _calculator = new IntegralCalculator(); // Aquí inicializas la calculadora
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío o agregar lógica de inicialización si es necesario
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string expresion = textBoxIntegral.Text;
            string resultado = _calculator.CalcularIntegral(expresion);
            labelResultado.Text = resultado;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Clear();
            labelResultado.Text = string.Empty;
        }
    }
}
