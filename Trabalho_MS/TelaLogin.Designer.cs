namespace Trabalho_MS
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            textUsuario = new TextBox();
            textSenha = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.MediumPurple;
            textUsuario.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUsuario.Location = new Point(163, 120);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(485, 46);
            textUsuario.TabIndex = 0;
            textUsuario.Text = "Usuario:";
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.MediumPurple;
            textSenha.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSenha.Location = new Point(163, 224);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(485, 46);
            textSenha.TabIndex = 1;
            textSenha.Text = "Senha:";
            textSenha.TextChanged += textSenha_TextChanged;
            // 
            // Login
            // 
            Login.BackColor = Color.MediumPurple;
            Login.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold);
            Login.Location = new Point(285, 303);
            Login.Margin = new Padding(8);
            Login.Name = "Login";
            Login.Size = new Size(229, 75);
            Login.TabIndex = 2;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 85, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(textSenha);
            Controls.Add(textUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private TextBox textSenha;
        private Button Login;
    }
}