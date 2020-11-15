namespace GDI3
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
            this.funcControl1 = new GDI3.FuncControl();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // funcControl1
            // 
            this.funcControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.funcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcControl1.Location = new System.Drawing.Point(0, 0);
            this.funcControl1.Name = "funcControl1";
            this.funcControl1.Size = new System.Drawing.Size(800, 450);
            this.funcControl1.TabIndex = 0;
            this.funcControl1.Text = "funcControl1";
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(100, 13);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(75, 23);
            this.btnSin.TabIndex = 1;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(211, 13);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(75, 23);
            this.btnCos.TabIndex = 2;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(323, 13);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(75, 23);
            this.btnTan.TabIndex = 3;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.Location = new System.Drawing.Point(554, 35);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(75, 23);
            this.btnParabola.TabIndex = 4;
            this.btnParabola.Text = "parabola";
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(507, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(41, 20);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(507, 38);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(41, 20);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(507, 64);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(41, 20);
            this.txtC.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnParabola);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.funcControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FuncControl funcControl1;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
    }
}

