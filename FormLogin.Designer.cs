using System.Windows.Forms;

namespace SistemaFazenda2
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblUsuario;
        private Label lblSenha;

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
            this.txtUsuario = new TextBox();
            this.txtSenha = new TextBox();
            this.btnLogin = new Button();
            this.lblUsuario = new Label();
            this.lblSenha = new Label();
            this.SuspendLayout();

            // txtUsuario
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 14F);
            this.txtUsuario.Location = new System.Drawing.Point(550, 300);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 29);
            this.txtUsuario.TabIndex = 0;

            // txtSenha
            this.txtSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.txtSenha.Location = new System.Drawing.Point(550, 380);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(300, 29);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(615, 450);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 14F);
            this.lblUsuario.Location = new System.Drawing.Point(450, 300);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 22);
            this.lblUsuario.Text = "Usuário";

            // lblSenha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSenha.Location = new System.Drawing.Point(450, 380);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 22);
            this.lblSenha.Text = "Senha";

            // FormLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSenha);
            this.Name = "FormLogin";
            this.Text = "Tela de Login";
            this.WindowState = FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
