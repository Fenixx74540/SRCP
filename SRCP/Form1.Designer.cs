
namespace SRCP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.btnPreviousWeek = new System.Windows.Forms.Button();
            this.weekFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weekTo = new System.Windows.Forms.Label();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(36, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Week:";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPreviousWeek
            // 
            this.btnPreviousWeek.Location = new System.Drawing.Point(81, 31);
            this.btnPreviousWeek.Name = "btnPreviousWeek";
            this.btnPreviousWeek.Size = new System.Drawing.Size(39, 23);
            this.btnPreviousWeek.TabIndex = 1;
            this.btnPreviousWeek.Text = "<--";
            this.btnPreviousWeek.UseVisualStyleBackColor = true;
            this.btnPreviousWeek.Click += new System.EventHandler(this.button1_Click);
            // 
            // weekFrom
            // 
            this.weekFrom.AutoSize = true;
            this.weekFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekFrom.Location = new System.Drawing.Point(126, 36);
            this.weekFrom.Name = "weekFrom";
            this.weekFrom.Size = new System.Drawing.Size(64, 13);
            this.weekFrom.TabIndex = 2;
            this.weekFrom.Text = "weekFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // weekTo
            // 
            this.weekTo.AutoSize = true;
            this.weekTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekTo.Location = new System.Drawing.Point(265, 36);
            this.weekTo.Name = "weekTo";
            this.weekTo.Size = new System.Drawing.Size(52, 13);
            this.weekTo.TabIndex = 4;
            this.weekTo.Text = "weekTo";
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(355, 31);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(39, 23);
            this.btnNextWeek.TabIndex = 5;
            this.btnNextWeek.Text = "-->";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.weekTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weekFrom);
            this.Controls.Add(this.btnPreviousWeek);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Working time registration system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnPreviousWeek;
        private System.Windows.Forms.Label weekFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label weekTo;
        private System.Windows.Forms.Button btnNextWeek;
    }
}

