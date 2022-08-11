namespace ArtigoPOO
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
            this.btnAtribuirValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtribuirValores
            // 
            this.btnAtribuirValores.Location = new System.Drawing.Point(97, 27);
            this.btnAtribuirValores.Name = "btnAtribuirValores";
            this.btnAtribuirValores.Size = new System.Drawing.Size(75, 23);
            this.btnAtribuirValores.TabIndex = 0;
            this.btnAtribuirValores.Text = "Executar";
            this.btnAtribuirValores.UseVisualStyleBackColor = true;
            this.btnAtribuirValores.Click += new System.EventHandler(this.btnAtribuirValores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.btnAtribuirValores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtribuirValores;
    }
}

