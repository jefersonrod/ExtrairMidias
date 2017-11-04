namespace ExtrairMidias
{
    partial class Form1
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
            this.tbCaminho = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.rtConteudo = new System.Windows.Forms.RichTextBox();
            this.cbPDF = new System.Windows.Forms.CheckBox();
            this.cbRAR = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbCaminho
            // 
            this.tbCaminho.Location = new System.Drawing.Point(94, 13);
            this.tbCaminho.Name = "tbCaminho";
            this.tbCaminho.Size = new System.Drawing.Size(569, 20);
            this.tbCaminho.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(13, 9);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(669, 9);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "GO";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // rtConteudo
            // 
            this.rtConteudo.Location = new System.Drawing.Point(13, 75);
            this.rtConteudo.Name = "rtConteudo";
            this.rtConteudo.Size = new System.Drawing.Size(731, 250);
            this.rtConteudo.TabIndex = 3;
            this.rtConteudo.Text = "";
            // 
            // cbPDF
            // 
            this.cbPDF.AutoSize = true;
            this.cbPDF.Location = new System.Drawing.Point(13, 52);
            this.cbPDF.Name = "cbPDF";
            this.cbPDF.Size = new System.Drawing.Size(50, 17);
            this.cbPDF.TabIndex = 4;
            this.cbPDF.Text = ".PDF";
            this.cbPDF.UseVisualStyleBackColor = true;
            // 
            // cbRAR
            // 
            this.cbRAR.AutoSize = true;
            this.cbRAR.Location = new System.Drawing.Point(94, 52);
            this.cbRAR.Name = "cbRAR";
            this.cbRAR.Size = new System.Drawing.Size(52, 17);
            this.cbRAR.TabIndex = 5;
            this.cbRAR.Text = ".RAR";
            this.cbRAR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 337);
            this.Controls.Add(this.cbRAR);
            this.Controls.Add(this.cbPDF);
            this.Controls.Add(this.rtConteudo);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbCaminho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCaminho;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.RichTextBox rtConteudo;
        private System.Windows.Forms.CheckBox cbPDF;
        private System.Windows.Forms.CheckBox cbRAR;
    }
}

