using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Fujiy.DiminuirFotos
{
    public partial class Principal : Form
    {
        private bool cancelar;

        public Principal()
        {
            InitializeComponent();
        }

        private void GravarThumb(FileInfo arquivo, string pastaThumbnails, int tamanhoMaximo)
        {
            using (Bitmap bm = (Bitmap)Image.FromFile(arquivo.FullName))
            {
                int altura = bm.Height;
                int largura = bm.Width;

                if (bm.Width > tamanhoMaximo || bm.Height > tamanhoMaximo)
                {
                    altura = (int) ((decimal)tamanhoMaximo/bm.Width*bm.Height);
                    if (altura > tamanhoMaximo)
                    {
                        altura = tamanhoMaximo;
                        largura = (int) ((decimal)tamanhoMaximo/bm.Height*bm.Width);
                    }
                    else
                    {
                        largura = tamanhoMaximo;
                    }
                }

                using (Bitmap thumb = new Bitmap(bm, new Size(largura, altura)))
                {
                    thumb.Save(Path.Combine(pastaThumbnails, arquivo.Name), System.Drawing.Imaging.ImageFormat.Jpeg);
                    if (ckbVisualizar.Checked)
                    {
                        ptbVisualizacao.Image = thumb;
                        Application.DoEvents();
                    }
                }
            }
        }

        private readonly List<string> pastasEuCriei = new List<string>();
        private string CriarPastaThumbnails(string caminhoBase)
        {
            int tentativas = 2;
            string caminhoThumbnails = Path.Combine(caminhoBase, "thumbnails");

            while (Directory.Exists(caminhoThumbnails))
            {
                if (pastasEuCriei.Contains(caminhoThumbnails))
                {
                    return caminhoThumbnails;
                }

                caminhoThumbnails = Path.Combine(caminhoBase, "thumbnails" + tentativas);
                tentativas++;
            }

            Directory.CreateDirectory(caminhoThumbnails);
            pastasEuCriei.Add(caminhoThumbnails);
            return caminhoThumbnails;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            pastasEuCriei.Clear();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                cancelar = false;
                btnAbrir.Visible = false;

                DirectoryInfo d = new DirectoryInfo(folderBrowser.SelectedPath);

                FileInfo[] arquivos = d.GetFiles("*.jpg", chkIncluirSubPastas.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                progressBar1.Maximum = arquivos.Length;
                
                int tamanhoMaximo;
                if (!int.TryParse(txtTamanhoMaximo.Text, out tamanhoMaximo))
                {
                    tamanhoMaximo = 640;
                    txtTamanhoMaximo.Text = "640";
                }

                for (int index = 0; index < arquivos.Length && !cancelar; index++)
                {
                    FileInfo arquivo = arquivos[index];
                    string pastaThumbnails = CriarPastaThumbnails(arquivo.DirectoryName);
                    GravarThumb(arquivo, pastaThumbnails, tamanhoMaximo);
                    progressBar1.Value++;
                    Application.DoEvents();
                }

                progressBar1.Value = 0;
                ptbVisualizacao.Image = null;
                btnAbrir.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            ptbVisualizacao.Image = null;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelar = true;
        }
    }
}