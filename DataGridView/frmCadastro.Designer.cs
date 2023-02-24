
namespace DataGridView
{
    partial class frmCadastro
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btngravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Enabled = false;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblcodigo.Location = new System.Drawing.Point(170, 35);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(87, 26);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblcpf.Location = new System.Drawing.Point(170, 281);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(62, 26);
            this.lblcpf.TabIndex = 1;
            this.lblcpf.Text = "CPF:";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblrg.Location = new System.Drawing.Point(170, 222);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(51, 26);
            this.lblrg.TabIndex = 2;
            this.lblrg.Text = "RG:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblend.Location = new System.Drawing.Point(170, 160);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(111, 26);
            this.lblend.TabIndex = 3;
            this.lblend.Text = "Endereço:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblname.Location = new System.Drawing.Point(170, 99);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(77, 26);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Nome:";
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtcod.Location = new System.Drawing.Point(305, 32);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(294, 32);
            this.txtcod.TabIndex = 5;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtcpf.Location = new System.Drawing.Point(305, 278);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(294, 32);
            this.txtcpf.TabIndex = 7;
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtrg.Location = new System.Drawing.Point(305, 219);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(294, 32);
            this.txtrg.TabIndex = 8;
            // 
            // txtend
            // 
            this.txtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtend.Location = new System.Drawing.Point(305, 154);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(294, 32);
            this.txtend.TabIndex = 9;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtnome.Location = new System.Drawing.Point(305, 93);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(294, 32);
            this.txtnome.TabIndex = 10;
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btngravar.Location = new System.Drawing.Point(338, 360);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(123, 52);
            this.btngravar.TabIndex = 11;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btngravar;
    }
}