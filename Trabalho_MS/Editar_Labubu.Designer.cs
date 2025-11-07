namespace LabuStore
{
    partial class Editar_Labubu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Labubu));
            Labubu_Editar = new Button();
            pictureBox1 = new PictureBox();
            link_text = new TextBox();
            label4 = new Label();
            quantidade_text = new TextBox();
            label3 = new Label();
            valor_text = new TextBox();
            label2 = new Label();
            nome_text = new TextBox();
            label1 = new Label();
            label5 = new Label();
            id_text = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Labubu_Editar
            // 
            Labubu_Editar.BackColor = Color.MediumPurple;
            Labubu_Editar.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            Labubu_Editar.Location = new Point(433, 377);
            Labubu_Editar.Name = "Labubu_Editar";
            Labubu_Editar.Size = new Size(278, 50);
            Labubu_Editar.TabIndex = 19;
            Labubu_Editar.Text = "Editar Labubu";
            Labubu_Editar.UseVisualStyleBackColor = false;
            Labubu_Editar.Click += Labubu_Editar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // link_text
            // 
            link_text.BackColor = Color.MediumPurple;
            link_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            link_text.Location = new Point(339, 191);
            link_text.Name = "link_text";
            link_text.Size = new Size(431, 23);
            link_text.TabIndex = 17;
            link_text.TextChanged += link_text_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label4.Location = new Point(32, 183);
            label4.Name = "label4";
            label4.Size = new Size(317, 31);
            label4.TabIndex = 16;
            label4.Text = "Link Da Imagem(Opicional): ";
            // 
            // quantidade_text
            // 
            quantidade_text.BackColor = Color.MediumPurple;
            quantidade_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quantidade_text.Location = new Point(182, 147);
            quantidade_text.Name = "quantidade_text";
            quantidade_text.Size = new Size(212, 23);
            quantidade_text.TabIndex = 15;
            quantidade_text.TextChanged += quantidade_text_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label3.Location = new Point(32, 139);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 14;
            label3.Text = "Quantidade:";
            // 
            // valor_text
            // 
            valor_text.BackColor = Color.MediumPurple;
            valor_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            valor_text.Location = new Point(118, 102);
            valor_text.Name = "valor_text";
            valor_text.Size = new Size(212, 23);
            valor_text.TabIndex = 13;
            valor_text.TextChanged += valor_text_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label2.Location = new Point(32, 94);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 12;
            label2.Text = "Valor:";
            // 
            // nome_text
            // 
            nome_text.BackColor = Color.MediumPurple;
            nome_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nome_text.Location = new Point(118, 51);
            nome_text.Name = "nome_text";
            nome_text.Size = new Size(212, 23);
            nome_text.TabIndex = 11;
            nome_text.TextChanged += nome_text_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label1.Location = new Point(32, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            label5.Location = new Point(32, 9);
            label5.Name = "label5";
            label5.Size = new Size(49, 31);
            label5.TabIndex = 20;
            label5.Text = "Id:";
            // 
            // id_text
            // 
            id_text.BackColor = Color.MediumPurple;
            id_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            id_text.Location = new Point(87, 12);
            id_text.Name = "id_text";
            id_text.Size = new Size(47, 23);
            id_text.TabIndex = 21;
            id_text.TextChanged += id_text_TextChanged;
            // 
            // Editar_Labubu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 85, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(id_text);
            Controls.Add(label5);
            Controls.Add(Labubu_Editar);
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
            Name = "Editar_Labubu";
            Text = "Editar Labubu";
            FormClosing += Editar_Labubu_FormClosing;
            Load += Editar_Labubu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Labubu_Editar;
        private PictureBox pictureBox1;
        private TextBox link_text;
        private Label label4;
        private TextBox quantidade_text;
        private Label label3;
        private TextBox valor_text;
        private Label label2;
        private TextBox nome_text;
        private Label label1;
        private Label label5;
        private TextBox id_text;
    }
}