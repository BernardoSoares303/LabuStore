namespace Trabalho_MS
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            Cadastrar_Labubu = new Button();
            Editar_Labubu = new Button();
            Ver_Labubu = new Button();
            SuspendLayout();
            // 
            // Cadastrar_Labubu
            // 
            Cadastrar_Labubu.BackColor = Color.MediumPurple;
            Cadastrar_Labubu.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            Cadastrar_Labubu.Location = new Point(27, 44);
            Cadastrar_Labubu.Name = "Cadastrar_Labubu";
            Cadastrar_Labubu.Size = new Size(134, 111);
            Cadastrar_Labubu.TabIndex = 0;
            Cadastrar_Labubu.Text = "Cadastrar Labubu";
            Cadastrar_Labubu.UseVisualStyleBackColor = false;
            // 
            // Editar_Labubu
            // 
            Editar_Labubu.BackColor = Color.MediumPurple;
            Editar_Labubu.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            Editar_Labubu.Location = new Point(27, 165);
            Editar_Labubu.Name = "Editar_Labubu";
            Editar_Labubu.Size = new Size(134, 111);
            Editar_Labubu.TabIndex = 1;
            Editar_Labubu.Text = "Editar Labubu";
            Editar_Labubu.UseVisualStyleBackColor = false;
            // 
            // Ver_Labubu
            // 
            Ver_Labubu.BackColor = Color.MediumPurple;
            Ver_Labubu.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            Ver_Labubu.Location = new Point(27, 288);
            Ver_Labubu.Name = "Ver_Labubu";
            Ver_Labubu.Size = new Size(134, 111);
            Ver_Labubu.TabIndex = 2;
            Ver_Labubu.Text = "Ver Labubus";
            Ver_Labubu.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 85, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(Ver_Labubu);
            Controls.Add(Editar_Labubu);
            Controls.Add(Cadastrar_Labubu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaPrincipal";
            Text = " Pagina Principal";
            FormClosing += TelaPrincipal_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button Cadastrar_Labubu;
        private Button Editar_Labubu;
        private Button Ver_Labubu;
    }
}