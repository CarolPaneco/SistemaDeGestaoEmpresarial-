namespace SistemaFazenda2
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewUsuarios;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Label lblTitulo;
        


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 26);
            this.lblTitulo.Text = "Administração";

            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Location = new System.Drawing.Point(10, 50);
            this.listViewUsuarios.Size = new System.Drawing.Size(400, 200);
            this.listViewUsuarios.View = System.Windows.Forms.View.Details;
            this.listViewUsuarios.FullRowSelect = true;
            this.listViewUsuarios.Columns.Add("ID", 50);
            this.listViewUsuarios.Columns.Add("Usuário", 150);
            this.listViewUsuarios.Columns.Add("Tipo", 100);

            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(420, 50);
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionarUsuario.Text = "Adicionar";
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);

            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(420, 90);
            this.btnEditarUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);

            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(420, 130);
            this.btnExcluirUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);

            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(540, 270);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listViewUsuarios);
            this.Controls.Add(this.btnAdicionarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Text = "Administração de Usuários";
        }
    }
}
