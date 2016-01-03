namespace Fujiy.DiminuirFotos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.chkIncluirSubPastas = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ptbVisualizacao = new System.Windows.Forms.PictureBox();
            this.ckbVisualizar = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTamanhoMaximo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisualizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // chkIncluirSubPastas
            // 
            this.chkIncluirSubPastas.AutoSize = true;
            this.chkIncluirSubPastas.Location = new System.Drawing.Point(94, 16);
            this.chkIncluirSubPastas.Name = "chkIncluirSubPastas";
            this.chkIncluirSubPastas.Size = new System.Drawing.Size(105, 17);
            this.chkIncluirSubPastas.TabIndex = 1;
            this.chkIncluirSubPastas.Text = "Incluir subpastas";
            this.chkIncluirSubPastas.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 83);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // ptbVisualizacao
            // 
            this.ptbVisualizacao.Location = new System.Drawing.Point(12, 112);
            this.ptbVisualizacao.Name = "ptbVisualizacao";
            this.ptbVisualizacao.Size = new System.Drawing.Size(270, 270);
            this.ptbVisualizacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbVisualizacao.TabIndex = 3;
            this.ptbVisualizacao.TabStop = false;
            // 
            // ckbVisualizar
            // 
            this.ckbVisualizar.AutoSize = true;
            this.ckbVisualizar.Location = new System.Drawing.Point(13, 53);
            this.ckbVisualizar.Name = "ckbVisualizar";
            this.ckbVisualizar.Size = new System.Drawing.Size(70, 17);
            this.ckbVisualizar.TabIndex = 4;
            this.ckbVisualizar.Text = "Visualizar";
            this.ckbVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(13, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTamanhoMaximo
            // 
            this.txtTamanhoMaximo.Location = new System.Drawing.Point(214, 50);
            this.txtTamanhoMaximo.MaxLength = 6;
            this.txtTamanhoMaximo.Name = "txtTamanhoMaximo";
            this.txtTamanhoMaximo.Size = new System.Drawing.Size(55, 20);
            this.txtTamanhoMaximo.TabIndex = 6;
            this.txtTamanhoMaximo.Text = "640";
            this.txtTamanhoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tamanho máximo:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamanhoMaximo);
            this.Controls.Add(this.ckbVisualizar);
            this.Controls.Add(this.ptbVisualizacao);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkIncluirSubPastas);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCancelar);
            this.Name = "Principal";
            this.Text = "Thumbnail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisualizacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.CheckBox chkIncluirSubPastas;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox ptbVisualizacao;
        private System.Windows.Forms.CheckBox ckbVisualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTamanhoMaximo;
        private System.Windows.Forms.Label label1;
    }
}

