namespace Trabalho_MS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logo = new PictureBox();
            Login = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(251, 27);
            logo.Name = "logo";
            logo.Size = new Size(300, 300);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // Login
            // 
            Login.BackColor = Color.MediumPurple;
            Login.FlatAppearance.BorderSize = 0;
            Login.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold);
            Login.ForeColor = SystemColors.ControlText;
            Login.Location = new Point(251, 340);
            Login.Margin = new Padding(0);
            Login.Name = "Login";
            Login.Size = new Size(300, 56);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 85, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "LabuStore";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logo;
        private Button Login;
    }
}
