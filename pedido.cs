using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProyectoGina
{
    public partial class pedido : Form
    {

        public pedido()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
        }
        private double totalPedido = 0;

        // Método para agregar un pedido al RichTextBox
        public void AgregarPedido(string detallePedido, double subtotal)
        {
            if (pedido_richtxt != null)
            {
                pedido_richtxt.AppendText(detallePedido + Environment.NewLine);
                totalPedido += subtotal; // Suma el subtotal al total acumulado
                total.Text = $"${totalPedido:F2}"; // Actualiza la etiqueta total
            }
            else
            {
                MessageBox.Show("Error al mostrar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private pantalla_productos pantallaProductos;

        public pedido(pantalla_productos pantalla)
        {
            InitializeComponent();
            pantallaProductos = pantalla;
        }
        private void button_atras_Click(object sender, EventArgs e)
        {
            if (pantallaProductos != null)
            {
                this.Hide();
                pantallaProductos.Show();
            }
            else
            {
                MessageBox.Show("Error: La referencia a pantalla_productos no se inicializó.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (pantallaProductos != null)
            {
                FormPagos formPagos = new FormPagos(totalPedido, pantallaProductos);
                this.Hide();
                formPagos.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: No se pudo regresar a la pantalla de productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GenerarPDF(string detalles, double total, string rutaArchivo)
        {
            // Configurar explícitamente la licencia
            QuestPDF.Settings.License = LicenseType.Community;

            // Calcular el impuesto del 6%
            double impuesto = total * 0.06;
            double totalConImpuesto = total + impuesto;

            // Crear el documento PDF
            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);

                    page.Header().Padding(10).Row(row =>
                    {
                        // Logotipo y nombre de la tienda
                        string rutaLogo = @"C:\\Users\\Admin\\source\\repos\\ProyectoFinalFINAL\\ProyectoFinal (2)\\ProyectoFinal\\Resources\\logo_fuby.png";
                        row.RelativeItem().Height(50).Image(rutaLogo, ImageScaling.FitHeight);
                        row.RelativeItem().Column(column =>
                        {
                            column.Item().Text("FutureByte").FontSize(20).Bold();
                            column.Item().Text("Innovación que conecta contigo").FontSize(12).Italic();
                        });
                    });

                    page.Content().Padding(10).Column(column =>
                    {
                        // Fecha y hora
                        column.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy}").FontSize(12).Italic();
                        column.Item().Text($"Hora: {DateTime.Now:HH:mm:ss}").FontSize(12).Italic();

                        // Detalles del pedido
                        column.Item().PaddingVertical(10).Text("Detalles del Pedido:").FontSize(14).Bold();

                        column.Item().Table(table =>
                        {
                            // Configurar las columnas
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1); // Cantidad
                                columns.RelativeColumn(4); // Descripción
                                columns.RelativeColumn(2); // Precio
                            });

                            // Encabezado de la tabla
                            table.Header(header =>
                            {
                                header.Cell().Text("Cantidad").Bold();
                                header.Cell().Text("Descripción").Bold();
                                header.Cell().Text("Precio").Bold();
                            });

                            // Agregar filas (una por cada línea del pedido)
                            var lineas = detalles.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var linea in lineas)
                            {
                                var partes = linea.Split(new[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
  
                                if (partes.Length == 3)
                                {
                                    table.Cell().Text(partes[0]); // Cantidad
                                    table.Cell().Text(partes[1]); // Descripción
                                    table.Cell().Text(partes[2]); // Precio
                                }
                            }
                        });

                        // Total e impuesto
                        column.Item().PaddingVertical(10).Text($"Subtotal: ${total:F2}").FontSize(12);
                        column.Item().Text($"Impuesto (6%): ${impuesto:F2}").FontSize(12);
                        column.Item().Text($"Total con impuesto: ${totalConImpuesto:F2}").FontSize(14).Bold();
                    });
                });
            });

            // Guardar el archivo PDF
            documento.GeneratePdf(rutaArchivo);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los detalles del pedido y el total
                string detallesPedido = pedido_richtxt.Text; // Detalles en el RichTextBox
                double total = totalPedido; // Total acumulado

                // Validar que haya datos en el pedido
                if (string.IsNullOrWhiteSpace(detallesPedido))
                {
                    MessageBox.Show("No hay detalles en el pedido para generar una nota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generar el PDF
                string rutaArchivo = "NotaPedido.pdf"; // Ruta de salida del PDF
                GenerarPDF(detallesPedido, total, rutaArchivo);

                // Confirmación al usuario
                MessageBox.Show($"Nota generada exitosamente en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


    
