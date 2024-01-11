using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace UpdateTrucks
{
    public partial class TrucksUpdate : Form
    {
        public TrucksUpdate()
        {
            InitializeComponent();

            // Establecer el estilo del borde para que la ventana no sea redimensionable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            // Establecer la ruta predeterminada en el TextBox y deshabilitarlo
            textBox1.Text = @"\\192.168.40.5\ti\Trucks\TRUCKS ZIP\Versiones";
            textBox1.Enabled = false;

            txtboxOrigen.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string selectedFolderPath = txtboxOrigen.Text;

            // Filtrar y obtener archivos .pbd y .exe en la carpeta seleccionada
            string[] filesToCompress = Directory.GetFiles(selectedFolderPath, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".pbd") || file.EndsWith(".exe"))
                .ToArray();

            if (filesToCompress.Length > 0)
            {
                // Definir la ruta remota del directorio de archivos
                string rutaRemota = @"\\192.168.40.5\ti\Trucks\TRUCKS ZIP\Versiones";
                string nameArchivo = @"Trucks Version - " + txtboxVersion.Text + "-" + txtboxVersionFinal.Text + ".zip";

                // Definir el nombre del archivo ZIP
                string zipFileName = Path.Combine(rutaRemota, nameArchivo);

                try
                {
                    // Utilizar un ProgressBar para mostrar el progreso de la compresión
                    pbEstatus.Maximum = filesToCompress.Length;
                    pbEstatus.Value = 0;

                    await Task.Run(() =>
                    {
                        using (FileStream zipToCreate = new FileStream(zipFileName, FileMode.Create))
                        {
                            using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                            {
                                foreach (var file in filesToCompress)
                                {
                                    string entryName = GetRelativePath(selectedFolderPath, file);
                                    archive.CreateEntryFromFile(file, entryName);

                                    // Actualizar el ProgressBar
                                    pbEstatus.Invoke((MethodInvoker)delegate { pbEstatus.Value++; });
                                }
                            }
                        }
                    });

                    MessageBox.Show($"Archivos comprimidos en: {zipFileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("¿Desea realizar acciones adicionales?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        // Acciones adicionales después de hacer clic en "OK"
                        txtboxOrigen.Text = "";
                        txtboxOrigen.Enabled = true;

                        txtboxVersion.Text = "";
                        txtboxVersionFinal.Text = "";
                    }

                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error al comprimir archivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Restablecer el valor del ProgressBar
                    pbEstatus.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron archivos .pbd o .exe en la carpeta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetRelativePath(string basePath, string fullPath)
        {
            Uri baseUri = new Uri(basePath.EndsWith("\\") ? basePath : basePath + "\\");
            Uri fullUri = new Uri(fullPath);
            return Uri.UnescapeDataString(baseUri.MakeRelativeUri(fullUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        private void explorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecciona la carpeta que contiene los archivos";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                txtboxOrigen.Text = selectedFolderPath; // AQUI REMPLAZAMOS EL TEXTBOX donde ira la ruta
                txtboxOrigen.Enabled = false;
            }
        }

    }
}
