using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasTiempos
{
    public partial class FrmCuentas : Form
    {
        private double ganancia;

        private double ventas;

        private double premios;

        private double banca;

        double montoBancaElimiar;

        double montoGananciaEliminar;

        double porcentajeGanancia;

        public FrmCuentas()
        {
            InitializeComponent();

        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            this.mtbxBancaDiaAnterior.Focus();
        }

        private void cbxSorteo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxSorteo.SelectedIndex == 0 || this.cbxSorteo.SelectedIndex == 1 || this.cbxSorteo.SelectedIndex == 2 || this.cbxSorteo.SelectedIndex == 3)
            {
                porcentajeGanancia = 0.10;
                this.lblPorcentajeGanancia.Text = "10 %";
            }
            else
            {

                if (this.cbxSorteo.SelectedIndex == 4 || this.cbxSorteo.SelectedIndex == 6)
                {
                    porcentajeGanancia = 0.13;
                    this.lblPorcentajeGanancia.Text = "13 %";
                }
                else
                {
                    porcentajeGanancia = 0.05;
                    this.lblPorcentajeGanancia.Text = "5 %";
                }
            }
            this.mtxbVenta.Focus();
        }


        private void mtxbVenta_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.Enter)
            {
                ganancia = Convert.ToDouble(this.mtxbVenta.Text) * porcentajeGanancia;

                this.txtGanancia.Text = ganancia.ToString();

                this.mtxbPremio.Focus();

            }

        }

        private void mtxbPremio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                ventas = Convert.ToDouble(this.mtxbVenta.Text);

                premios = Convert.ToDouble(this.mtxbPremio.Text);

                this.txtBanca.Text = Convert.ToString(ventas - ganancia - premios);

            }
        }

        private void mtbxBancaDiaAnterior_KeyDown(object sender, KeyEventArgs e)
        {
            this.mtbxGananciaDiaAnterior.Focus();
        }

        private void mtbxGananciaDiaAnterior_KeyDown(object sender, KeyEventArgs e)
        {
            this.mtbxValesDiaAnterior.Focus();
        }

        private void mtbxValesDiaAnterior_KeyDown(object sender, KeyEventArgs e)
        {
            this.mtbxValesxDia.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (this.validFields())
            {
                return;
            }

            //Update Totals
            this.updateTotals();
           
            //Add elements to the GridView
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = this.cbxSorteo.GetItemText(this.cbxSorteo.SelectedItem);
            fila.Cells[1].Value = this.mtxbVenta.Text;
            fila.Cells[2].Value = this.txtGanancia.Text;
            fila.Cells[3].Value = this.mtxbPremio.Text;
            fila.Cells[4].Value = this.txtBanca.Text;

            this.dataGridView1.Rows.Add(fila);

            this.cleanFields();

        }

        public bool validFields()
        {
            if (this.mtxbVenta.Text == "")
            {
                MessageBox.Show("Debe digitar el monto de las ventas");
                this.mtxbVenta.Focus();
                return true;
            }

            if (this.mtxbPremio.Text == "")
            {
                MessageBox.Show("Debe digitar el monto de los premios pagados");
                this.mtxbPremio.Focus();
                return true;
            }

            if (this.mtbxBancaDiaAnterior.Text == "")
            {
                MessageBox.Show("Debe digitar el monto de la banca del dia anterior");
                this.mtbxBancaDiaAnterior.Focus();
                return true;
            }

            if (this.mtbxGananciaDiaAnterior.Text == "")
            {
                MessageBox.Show("Debe digitar el monto de la ganancia del dia anterior");
                this.mtbxGananciaDiaAnterior.Focus();
                return true;
            }

            if (this.mtbxValesxDia.Text == "")
            {
                MessageBox.Show("Debe digitar el monto de la vales para hoy");
                this.mtbxValesxDia.Focus();
                return true;
            }

            if (this.mtbxValesDiaAnterior.Text == "")
            {
                MessageBox.Show("Debe digitar el monto de los vales del dia anterior");
                this.mtbxValesDiaAnterior.Focus();
                return true;
            }

            return false;
        }

        public void updateTotals()
        {
            //Variables 
            double totalBanca;
            double totalGanancia;


            //Banca per Day
            banca = Convert.ToDouble(this.txtBanca.Text);
            totalBanca = Convert.ToDouble(this.txtBancaxDia.Text) + banca;
            this.txtBancaxDia.Text = Convert.ToString(totalBanca);

            //Ganancia per Day
            ganancia = Convert.ToDouble(this.txtGanancia.Text);
            totalGanancia = Convert.ToDouble(this.txtGananciaxDia.Text) + ganancia;
            this.txtGananciaxDia.Text = Convert.ToString(totalGanancia);

            //Banca per Week
            this.txtBancaSemana.Text = Convert.ToString(Convert.ToDouble(this.txtBancaxDia.Text) + Convert.ToDouble(this.mtbxBancaDiaAnterior.Text));


            //Ganancia per Week
            this.txtGananciaSemana.Text = Convert.ToString(Convert.ToDouble(this.txtGananciaxDia.Text) + Convert.ToDouble(this.mtbxGananciaDiaAnterior.Text));


            //Vales per week
            this.txtValesSemana.Text = Convert.ToString(Convert.ToDouble(this.mtbxValesxDia.Text) + Convert.ToDouble(this.mtbxValesDiaAnterior.Text));


        }

        public void cleanFields()
        {
            this.cbxSorteo.SelectedIndex = -1;
            this.mtxbVenta.Text = "";
            this.txtGanancia.Text = "";
            this.mtxbPremio.Text = "";
            this.txtBanca.Text = "";
            this.lblPorcentajeGanancia.Text = "0 %";
            this.cbxSorteo.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            var filaSelected = this.dataGridView1.CurrentRow;
            
            if (filaSelected != null)
            {

                montoBancaElimiar = Convert.ToDouble(filaSelected.Cells[4].Value);
                montoGananciaEliminar = Convert.ToDouble(filaSelected.Cells[2].Value);
                


            }

            //Restar montos
            this.txtBancaxDia.Text = Convert.ToString(Convert.ToDouble(this.txtBancaxDia.Text) - montoBancaElimiar);
            this.txtGananciaxDia.Text = Convert.ToString(Convert.ToDouble(this.txtGananciaxDia.Text) - montoGananciaEliminar);

            //Semanal
            this.txtBancaSemana.Text = Convert.ToString(Convert.ToDouble(this.txtBancaSemana.Text) - montoBancaElimiar);
            this.txtGananciaSemana.Text = Convert.ToString(Convert.ToDouble(this.txtGananciaSemana.Text) - montoGananciaEliminar);
           

            this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);

            MessageBox.Show("Fila Eliminada exitosamente");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMenu m = new FrmMenu();
            this.Hide();
            m.ShowDialog();

        }

        //Position first caracter on TextBox Venta
        private void mtxbVenta_MouseClick(object sender, MouseEventArgs e)
        {
            this.mtxbVenta.Select(0, 0);
        }

        private void mtxbPremio_MouseClick(object sender, MouseEventArgs e)
        {
            this.mtxbPremio.Select(0, 0);
        }

        private void mtbxBancaDiaAnterior_MouseClick(object sender, MouseEventArgs e)
        {
            this.mtbxBancaDiaAnterior.Select(0, 0);
        }

        private void mtbxGananciaDiaAnterior_MouseClick(object sender, MouseEventArgs e)
        {
            this.mtbxGananciaDiaAnterior.Select(0, 0);
        }

        private void mtbxValesDiaAnterior_MouseClick(object sender, MouseEventArgs e)
        {
            this.mtbxValesDiaAnterior.Select(0, 0);
        }

        private void mtbxValesxDia_MouseClick(object sender, MouseEventArgs e)
        {
            this.mtbxValesxDia.Select(0, 0);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0 )
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Cuentas.pdf";
                bool errorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {

                            errorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }

                    if (!errorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(this.dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in this.dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell c in viewRow.Cells)
                                {
                                    pTable.AddCell(c.Value.ToString());
                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document doc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(doc, fileStream);
                                doc.Open();
                                doc.Add(new iTextSharp.text.Paragraph("Monto banca del dia anterior: " + this.mtbxBancaDiaAnterior.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto banca del dia de hoy: " + this.txtBancaxDia.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto banca semanal: " + this.txtBancaSemana.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto ganancia del dia anterior: " + this.mtbxGananciaDiaAnterior.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto ganancia del dia de hoy: " + this.txtGananciaxDia.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto ganancia semanal: " + this.txtGananciaSemana.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto vales del dia anterior: " + this.mtbxValesDiaAnterior.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto vales del dia de hoy: " + this.mtbxValesxDia.Text));
                                doc.Add(new iTextSharp.text.Paragraph("Monto vales semanal: " + this.txtValesSemana.Text));

                                var spacer = new Paragraph("")
                                {
                                    SpacingBefore = 10f,
                                    SpacingAfter = 10f,
                                };
                                doc.Add(spacer);
                                doc.Add(pTable);
                                doc.Close();
                                fileStream.Close();
                            }

                            MessageBox.Show("File saved successfully", "info");



                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error while saving the file" + ex.Message);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("No existe informacion para descargar");
            }
        }
    }
}
