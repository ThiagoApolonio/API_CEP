
namespace Api
{
    partial class CEP
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
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtIBGE = new System.Windows.Forms.TextBox();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblGIA = new System.Windows.Forms.Label();
            this.lblIBGE = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(106, 17);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(127, 20);
            this.txtCEP.TabIndex = 0;
            this.txtCEP.Leave += new System.EventHandler(this.CEP_Leave);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(106, 147);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(127, 20);
            this.txtUF.TabIndex = 5;
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(106, 121);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(382, 20);
            this.txtLocalidade.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(106, 95);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(382, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(106, 69);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(382, 20);
            this.txtComplemento.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(106, 43);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(382, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(106, 173);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(127, 20);
            this.txtUnidade.TabIndex = 6;
            // 
            // txtIBGE
            // 
            this.txtIBGE.Location = new System.Drawing.Point(106, 199);
            this.txtIBGE.Name = "txtIBGE";
            this.txtIBGE.Size = new System.Drawing.Size(127, 20);
            this.txtIBGE.TabIndex = 7;
            // 
            // txtGIA
            // 
            this.txtGIA.Location = new System.Drawing.Point(106, 225);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.Size = new System.Drawing.Size(127, 20);
            this.txtGIA.TabIndex = 8;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(56, 154);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(40, 13);
            this.lblUF.TabIndex = 9;
            this.lblUF.Text = "Estado";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(34, 128);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidade.TabIndex = 10;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(56, 102);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro: ";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(22, 76);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 12;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(32, 50);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 13;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(65, 24);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 14;
            this.lblCEP.Text = "CEP:";
            // 
            // lblGIA
            // 
            this.lblGIA.AutoSize = true;
            this.lblGIA.Location = new System.Drawing.Point(65, 232);
            this.lblGIA.Name = "lblGIA";
            this.lblGIA.Size = new System.Drawing.Size(31, 13);
            this.lblGIA.TabIndex = 15;
            this.lblGIA.Text = "GIA: ";
            // 
            // lblIBGE
            // 
            this.lblIBGE.AutoSize = true;
            this.lblIBGE.Location = new System.Drawing.Point(61, 206);
            this.lblIBGE.Name = "lblIBGE";
            this.lblIBGE.Size = new System.Drawing.Size(35, 13);
            this.lblIBGE.TabIndex = 16;
            this.lblIBGE.Text = "IBGE:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(49, 180);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 17;
            this.lblUnidade.Text = "Unidade";
            // 
            // frmCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 282);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblIBGE);
            this.Controls.Add(this.lblGIA);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblLocalidade);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtGIA);
            this.Controls.Add(this.txtIBGE);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCEP);
            this.Name = "frmCEP";
            this.Text = "Busca CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtIBGE;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblGIA;
        private System.Windows.Forms.Label lblIBGE;
        private System.Windows.Forms.Label lblUnidade;
    }
}
