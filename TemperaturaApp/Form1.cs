using Domain;
using Domain.Enums;
using Infraestructura.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturaApp
{
    public partial class Form1 : Form
    {
        public RegistroRepository obj;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                obj = Select();

                decimal valorInicial = nudGrados.Value;
                decimal valorFinal = obj.Conversion(valorInicial, cmbEFinal.SelectedIndex);

                Registro reg = new Registro()
                {
                    EscalaInicial = (EscalaTemperatura)cmbEInicial.SelectedIndex,
                    EscalaFinal = (EscalaTemperatura) GetElementIndex(string.Format($"{cmbEFinal.SelectedItem}")),
                    GradosIniciales = Math.Round(valorInicial, 2),
                    GradosFinales = Math.Round(valorFinal, 2)
                };

                obj.Create(reg);

                MessageBox.Show($"La conversion de {reg.GradosIniciales}° {reg.EscalaInicial} resulta a {reg.GradosFinales}° {reg.EscalaFinal}",
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CLS();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepcion: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = new List<string>();
            items.Add("Celcius");
            items.Add("Fahrenheit");
            items.Add("Kelvin");

            string aux = (string)cmbEInicial.SelectedItem;

            items.Remove(aux);

            cmbEFinal.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Registro> arr = obj.GetAll(a => a.GetType == obj.);
            MessageBox.Show($"{cmbEFinal.SelectedIndex}");
        }

        private RegistroRepository Select()
        {
            if (cmbEInicial.SelectedIndex == 0)
            {
                return new Celcius();
            }
            else if (cmbEInicial.SelectedIndex == 1)
            {
                return new Fahrenheit();
            }
            else if (cmbEInicial.SelectedIndex == 2)
            {
                return new Kelvin();
            }
            else
            {
                throw new ArgumentException("Las escalas no pueden tener un valor nulo.");
            }
        }
        private int GetElementIndex(string aux)
        {
            if (aux == "Celcius")
            {
                return 0;
            }
            else if (aux == "Fahrenheit")
            {
                return 1;
            }
            else if (aux == "Kelvin")
            {
                return 2;
            }
            else
            {
                throw new ArgumentException("Este valor no puede ser nulo.");
            }
        }

        private void CLS()
        {
            nudGrados.Value = 0;
        }
    }
}
