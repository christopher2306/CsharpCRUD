namespace Funcionarios
{
    partial class Funcionarios
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
            lblNome = new Label();
            lblEmail = new Label();
            lblCPF = new Label();
            lblEndereco = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(14, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(13, 117);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 19);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPF.Location = new Point(14, 160);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(48, 19);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.Location = new Point(14, 203);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(89, 19);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(109, 70);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(206, 22);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(109, 117);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 22);
            txtEmail.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(109, 160);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(206, 22);
            txtCPF.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(109, 203);
            txtEndereco.MaxLength = 200;
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(206, 23);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(96, 270);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(147, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 460);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblEndereco);
            Controls.Add(lblCPF);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "Funcionarios";
            Text = "Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblCPF;
        private Label lblEndereco;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btnCadastrar;
    }
}