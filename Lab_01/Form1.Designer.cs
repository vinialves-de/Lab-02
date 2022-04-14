
namespace Lab_01
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Swis721 BlkEx BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(108, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(546, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visualizar Dados Na Caixa De Texto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(129, 161);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.Location = new System.Drawing.Point(129, 215);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(57, 21);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(196, 159);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(337, 23);
            this.tbNome.TabIndex = 3;
            this.tbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "PHP",
            "JAVA",
            "JavaScript",
            "Python",
            "Object-C",
            "CSharp",
            "C++",
            "C"});
            this.cbCurso.Location = new System.Drawing.Point(196, 213);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(121, 23);
            this.cbCurso.TabIndex = 4;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.Lime;
            this.lblMensagem.Location = new System.Drawing.Point(129, 323);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(441, 92);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // btExibir
            // 
            this.btExibir.BackColor = System.Drawing.Color.Blue;
            this.btExibir.Font = new System.Drawing.Font("Swis721 BlkEx BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btExibir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btExibir.Location = new System.Drawing.Point(108, 271);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(480, 37);
            this.btExibir.TabIndex = 6;
            this.btExibir.Text = "EXIBIR";
            this.btExibir.UseVisualStyleBackColor = false;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório¨_- 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btExibir;
    }
}

