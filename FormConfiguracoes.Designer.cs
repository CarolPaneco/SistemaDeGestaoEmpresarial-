namespace SistemaFazenda2
{
    partial class FormConfiguracoes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnPermissoes = new System.Windows.Forms.Button();
            this.btnPreferencias = new System.Windows.Forms.Button();

            // btnGerenciarUsuarios
            this.btnGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuarios.Location = new System.Drawing.Point(30, 30);

            // btnPermissoes
            this.btnPermissoes.Text = "Permissões";
            this.btnPermissoes.Location = new System.Drawing.Point(30, 80);

            // btnPreferencias
            this.btnPreferencias.Text = "Preferências";
            this.btnPreferencias.Location = new System.Drawing.Point(30, 130);

            // FormConfiguracoes
            this.Controls.Add(this.btnGerenciarUsuarios);
            this.Controls.Add(this.btnPermissoes);
            this.Controls.Add(this.btnPreferencias);
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Text = "Configurações";
        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarUsuarios;
        private System.Windows.Forms.Button btnPermissoes;
        private System.Windows.Forms.Button btnPreferencias;
    }
}
