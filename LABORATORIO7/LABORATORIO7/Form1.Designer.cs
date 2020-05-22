namespace LABORATORIO7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncleanall = new System.Windows.Forms.Button();
            this.btnlastresult = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnmultiplication = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 27);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(352, 36);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0                                                                                " +
    "                 ";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btndelete.Location = new System.Drawing.Point(12, 81);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(80, 65);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "DEL";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncleanall
            // 
            this.btncleanall.BackColor = System.Drawing.Color.DarkCyan;
            this.btncleanall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncleanall.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncleanall.Location = new System.Drawing.Point(98, 81);
            this.btncleanall.Name = "btncleanall";
            this.btncleanall.Size = new System.Drawing.Size(80, 65);
            this.btncleanall.TabIndex = 2;
            this.btncleanall.Text = "AC";
            this.btncleanall.UseVisualStyleBackColor = false;
            this.btncleanall.Click += new System.EventHandler(this.btncleanall_Click);
            // 
            // btnlastresult
            // 
            this.btnlastresult.BackColor = System.Drawing.Color.DarkCyan;
            this.btnlastresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlastresult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlastresult.Location = new System.Drawing.Point(184, 81);
            this.btnlastresult.Name = "btnlastresult";
            this.btnlastresult.Size = new System.Drawing.Size(86, 65);
            this.btnlastresult.TabIndex = 3;
            this.btnlastresult.Text = "ANS";
            this.btnlastresult.UseVisualStyleBackColor = false;
            this.btnlastresult.Click += new System.EventHandler(this.btnlastresult_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(284, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "L";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.DarkCyan;
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnplus.Location = new System.Drawing.Point(284, 152);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(80, 65);
            this.btnplus.TabIndex = 8;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkCyan;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Location = new System.Drawing.Point(184, 152);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 65);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkCyan;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Location = new System.Drawing.Point(98, 152);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 65);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkCyan;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Location = new System.Drawing.Point(12, 152);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 65);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.DarkCyan;
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnminus.Location = new System.Drawing.Point(284, 223);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(80, 65);
            this.btnminus.TabIndex = 12;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkCyan;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Location = new System.Drawing.Point(184, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 65);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkCyan;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Location = new System.Drawing.Point(98, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 65);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkCyan;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Location = new System.Drawing.Point(12, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 65);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btnmultiplication
            // 
            this.btnmultiplication.BackColor = System.Drawing.Color.DarkCyan;
            this.btnmultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplication.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnmultiplication.Location = new System.Drawing.Point(284, 294);
            this.btnmultiplication.Name = "btnmultiplication";
            this.btnmultiplication.Size = new System.Drawing.Size(80, 65);
            this.btnmultiplication.TabIndex = 16;
            this.btnmultiplication.Text = "*";
            this.btnmultiplication.UseVisualStyleBackColor = false;
            this.btnmultiplication.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkCyan;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Location = new System.Drawing.Point(184, 294);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 65);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkCyan;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(98, 294);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 65);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkCyan;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(12, 294);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 65);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.Color.DarkCyan;
            this.btndivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btndivision.Location = new System.Drawing.Point(284, 365);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(80, 65);
            this.btndivision.TabIndex = 20;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.DarkCyan;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnequal.Location = new System.Drawing.Point(184, 365);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(86, 65);
            this.btnequal.TabIndex = 19;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.DarkCyan;
            this.btnpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnpoint.Location = new System.Drawing.Point(98, 365);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(80, 65);
            this.btnpoint.TabIndex = 18;
            this.btnpoint.Text = ",";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.Numericvalue);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkCyan;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Location = new System.Drawing.Point(12, 365);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 65);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Numericvalue);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 449);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnmultiplication);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnlastresult);
            this.Controls.Add(this.btncleanall);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncleanall;
        private System.Windows.Forms.Button btnlastresult;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnmultiplication;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn0;
    }
}

