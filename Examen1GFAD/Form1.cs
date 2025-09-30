using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1GFAD
{
    public partial class FrmAfiliados : Form
    {
        List<string> columnas;
        private List<object[]> allFilas = new List<object[]>();
        public FrmAfiliados()
        {
            InitializeComponent();
            columnas = new List<string>();

            CbMunicipio.SelectedIndexChanged += CbMunicipio_SelectedIndexChanged;
        }

        private void CbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OfdAbrir.ShowDialog() == DialogResult.OK)
            {
                string archivo = OfdAbrir.FileName;
                CargarExcel(archivo);
            }
        }

        private async void CargarExcel(string path)
        {
            try
            {
                ExcelPackage.License.SetNonCommercialPersonal("Jose Franscisco Garcia Lopez");

                // Lista temporal
                List<object[]> filas = new List<object[]>();
                HashSet<string> municipios = new HashSet<string>();
                string entidaduno = "";

                //usamos un hilo secundario
                await Task.Run(() =>
                {
                    using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
                    {
                        if (package.Workbook.Worksheets.Count == 0)
                        {
                            MessageBox.Show("El archivo no contiene hojas de trabajo.");//por si no hay hojas
                            return;
                        }

                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.End.Row;

                        // lee un rango completo
                        object[,] values = worksheet.Cells[2, 1, rowCount, 6].Value as object[,];

                        int rows = values.GetLength(0); // cantidad filas

                        for (int i = 0; i < rows; i++)
                        {
                            string id = values[i, 0]?.ToString() ?? "";
                            if (!string.IsNullOrWhiteSpace(id))
                            {
                                //evitamos llamadas innescesarias del .text()
                                string entidad = values[i, 1]?.ToString() ?? "";
                                string municipio = values[i, 2]?.ToString() ?? "";
                                string nombre = values[i, 3]?.ToString() ?? "";
                                string fecha_af = values[i, 4]?.ToString() ?? "";
                                string estatus = values[i, 5]?.ToString() ?? "";

                                filas.Add(new object[] { id, entidad, municipio, nombre, fecha_af, estatus });

                                //agregamos el estado solo la primera vuelta
                                if (string.IsNullOrWhiteSpace(entidaduno) && !string.IsNullOrWhiteSpace(entidad))
                                {
                                    entidaduno = entidad;
                                }

                                //leemos los municipios del excel; con el hashset ignora los elementos repetidos
                                if (!string.IsNullOrWhiteSpace(municipio))
                                {
                                    municipios.Add(municipio);
                                }
                            }
                        }
                    }
                });

                allFilas = filas;

                //aqui cargamos el combo box (ya en el primer hilo)
                CbMunicipio.Items.Clear();
                CbMunicipio.Items.Add("TODOS");
                CbMunicipio.Items.Add("NINGUNO");
                foreach (var m in municipios.OrderBy(x => x))
                {
                    CbMunicipio.Items.Add(m);
                }
                CbMunicipio.SelectedIndex = 0; //forzamos a que se muestren todos la primera vez

                //suspend cancela que se actualize cada vez
                DgvAfiliados.SuspendLayout();
                DgvAfiliados.Rows.Clear();
                foreach (var fila in filas)
                {
                    DgvAfiliados.Rows.Add(fila);
                }
                DgvAfiliados.ResumeLayout(); //actualiza una sola vez

                TxtAfiliados.Text = filas.Count.ToString();

                //agregamos el estado (una vez)
                if (!string.IsNullOrWhiteSpace(entidaduno))
                {
                    txtEstado.Text = entidaduno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de carga: " + ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbMunicipio.SelectedItem == null)
                return;

            string municipio = CbMunicipio.SelectedItem.ToString();

            IEnumerable<object[]> filtradas;

            if (municipio == "TODOS")
            {
                filtradas = allFilas;
            }
            else if (municipio == "NINGUNO")
            {
                // los que no tienen municipio
                filtradas = allFilas.Where(f => string.IsNullOrWhiteSpace(f[2]?.ToString()));
            }
            else
                filtradas = allFilas.Where(f => (f[2]?.ToString() ?? "") == municipio);

            CargarFilas(filtradas.ToList());
            TxtAfiliados.Text = filtradas.Count().ToString();
        }
        private void CargarFilas(List<object[]> filtradas)
        {
            DgvAfiliados.SuspendLayout();
            DgvAfiliados.Rows.Clear();
            foreach (var fila in filtradas)
            {
                DgvAfiliados.Rows.Add(fila);
            }
            DgvAfiliados.ResumeLayout();
        }

    }
}
