namespace GestAcaGUI
{
    partial class GestAcaAPP
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
            Bienvenido = new Label();
            btnUser = new Button();
            btnAdmin = new Button();
            labelEntrar = new Label();
            pictureBoxImage = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Bienvenido
            // 
            Bienvenido.AutoSize = true;
            Bienvenido.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Bienvenido.ForeColor = Color.Brown;
            Bienvenido.Location = new Point(43, 61);
            Bienvenido.Name = "Bienvenido";
            Bienvenido.Size = new Size(338, 63);
            Bienvenido.TabIndex = 0;
            Bienvenido.Text = "BIENVENIDO";
            Bienvenido.Click += label1_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.Brown;
            btnUser.Location = new Point(349, 194);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(110, 50);
            btnUser.TabIndex = 7;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            btnUser.MouseEnter += btnUser_MouseEnter;
            btnUser.MouseLeave += btnUser_MouseLeave;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Brown;
            btnAdmin.Location = new Point(349, 273);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(110, 50);
            btnAdmin.TabIndex = 8;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            btnAdmin.MouseEnter += btnAdmin_MouseEnter;
            btnAdmin.MouseLeave += btnAdmin_MouseLeave;
            // 
            // labelEntrar
            // 
            labelEntrar.AutoSize = true;
            labelEntrar.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEntrar.ForeColor = Color.Brown;
            labelEntrar.Location = new Point(180, 161);
            labelEntrar.Name = "labelEntrar";
            labelEntrar.Size = new Size(152, 32);
            labelEntrar.TabIndex = 9;
            labelEntrar.Text = "Entrar como:";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(500, 50);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(500, 300);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 10;
            pictureBoxImage.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(692, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 227);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GestAcaAPP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1087, 571);
            Controls.Add(pictureBox1);
            Controls.Add(labelEntrar);
            Controls.Add(btnAdmin);
            Controls.Add(btnUser);
            Controls.Add(Bienvenido);
            Name = "GestAcaAPP";
            Text = "Gestión de academias";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Bienvenido;
        private Button btnUser;
        private Button btnAdmin;
        private Label labelEntrar;
        private PictureBox pictureBoxImage;
        private PictureBox pictureBox1;
    }
}
