namespace LabuStore
{
    partial class Cadastrar_Labubus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Labubus));
            label1 = new Label();
            nome_text = new TextBox();
            label2 = new Label();
            valor_text = new TextBox();
            label3 = new Label();
            quantidade_text = new TextBox();
            label4 = new Label();
            link_text = new TextBox();
            pictureBox1 = new PictureBox();
            Cadastrar_Labubu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // nome_text
            // 
            nome_text.BackColor = Color.MediumPurple;
            nome_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nome_text.Location = new Point(98, 42);
            nome_text.Name = "nome_text";
            nome_text.Size = new Size(212, 23);
            nome_text.TabIndex = 1;
            nome_text.TextChanged += nome_text_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // valor_text
            // 
            valor_text.BackColor = Color.MediumPurple;
            valor_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            valor_text.Location = new Point(98, 93);
            valor_text.Name = "valor_text";
            valor_text.Size = new Size(212, 23);
            valor_text.TabIndex = 3;
            valor_text.TextChanged += valor_text_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // quantidade_text
            // 
            quantidade_text.BackColor = Color.MediumPurple;
            quantidade_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quantidade_text.Location = new Point(162, 138);
            quantidade_text.Name = "quantidade_text";
            quantidade_text.Size = new Size(212, 23);
            quantidade_text.TabIndex = 5;
            quantidade_text.TextChanged += quantidade_text_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(317, 31);
            label4.TabIndex = 6;
            label4.Text = "Link Da Imagem(Opicional): ";
            // 
            // link_text
            // 
            link_text.BackColor = Color.MediumPurple;
            link_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            link_text.Location = new Point(319, 182);
            link_text.Name = "link_text";
            link_text.Size = new Size(431, 23);
            link_text.TabIndex = 7;
            link_text.TextChanged += link_text_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Cadastrar_Labubu
            // 
            Cadastrar_Labubu.BackColor = Color.MediumPurple;
            Cadastrar_Labubu.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            Cadastrar_Labubu.Location = new Point(414, 314);
            Cadastrar_Labubu.Name = "Cadastrar_Labubu";
            Cadastrar_Labubu.Size = new Size(278, 50);
            Cadastrar_Labubu.TabIndex = 9;
            Cadastrar_Labubu.Text = "Cadastrar Labubu";
            Cadastrar_Labubu.UseVisualStyleBackColor = false;
            Cadastrar_Labubu.Click += Cadastrar_Labubu_Click;
            // 
            // Cadastrar_Labubus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 85, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastrar_Labubu);
            Controls.Add(pictureBox1);
            Controls.Add(link_text);
            Controls.Add(label4);
            Controls.Add(quantidade_text);
            Controls.Add(label3);
            Controls.Add(valor_text);
            Controls.Add(label2);
            Controls.Add(nome_text);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cadastrar_Labubus";
            Text = "Cadastrar Labubu";
            FormClosing += Cadastrar_Labubus_FormClosing;
            Load += Cadastrar_Labubus_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nome_text;
        private Label label2;
        private TextBox valor_text;
        private Label label3;
        private TextBox quantidade_text;
        private Label label4;
        private TextBox link_text;
        private PictureBox pictureBox1;
        private Button Cadastrar_Labubu;
    }
}