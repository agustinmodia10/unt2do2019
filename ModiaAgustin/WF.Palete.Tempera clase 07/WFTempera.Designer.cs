namespace WF.Palete.Tempera_clase_07
{
    partial class WFTempera
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
            this.TBMARCA = new System.Windows.Forms.TextBox();
            this.TBCANT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.CBCOLOR = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBMARCA
            // 
            this.TBMARCA.Location = new System.Drawing.Point(84, 50);
            this.TBMARCA.Name = "TBMARCA";
            this.TBMARCA.Size = new System.Drawing.Size(121, 20);
            this.TBMARCA.TabIndex = 0;
            this.TBMARCA.TextChanged += new System.EventHandler(this.TBMARCA_TextChanged);
            // 
            // TBCANT
            // 
            this.TBCANT.Location = new System.Drawing.Point(84, 139);
            this.TBCANT.Name = "TBCANT";
            this.TBCANT.Size = new System.Drawing.Size(121, 20);
            this.TBCANT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MARCA :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "COLOR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CANTIDAD :";
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(52, 201);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 6;
            this.BAceptar.Text = "ACEPTAR";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(133, 201);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "CANCELAR";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // CBCOLOR
            // 
            this.CBCOLOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCOLOR.FormattingEnabled = true;
            this.CBCOLOR.Location = new System.Drawing.Point(84, 95);
            this.CBCOLOR.Name = "CBCOLOR";
            this.CBCOLOR.Size = new System.Drawing.Size(121, 21);
            this.CBCOLOR.TabIndex = 8;
            this.CBCOLOR.SelectedIndexChanged += new System.EventHandler(this.CBCOLOR_SelectedIndexChanged);
            // 
            // WFTempera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 286);
            this.Controls.Add(this.CBCOLOR);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCANT);
            this.Controls.Add(this.TBMARCA);
            this.Name = "WFTempera";
            this.Text = "WFTempera";
            this.Load += new System.EventHandler(this.WFTempera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBMARCA;
        private System.Windows.Forms.TextBox TBCANT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.ComboBox CBCOLOR;
    }
}