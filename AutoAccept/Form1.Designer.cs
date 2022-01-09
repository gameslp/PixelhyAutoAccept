
namespace AutoAccept
{
    partial class PixelhyAutoAccept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelhyAutoAccept));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneCheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox2 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox3 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox4 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pixelhy Auto Accept";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(284, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "by Maciek";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderRadius = 14;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.Gray;
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(29, 152);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(335, 30);
            this.siticoneButton1.TabIndex = 13;
            this.siticoneButton1.Text = "enable";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.Location = new System.Drawing.Point(43, 76);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(79, 17);
            this.siticoneCheckBox1.TabIndex = 14;
            this.siticoneCheckBox1.Text = "1920x1080";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.CheckedChanged += new System.EventHandler(this.siticoneCheckBox1_CheckedChanged);
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.Location = new System.Drawing.Point(43, 118);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(79, 17);
            this.siticoneCheckBox2.TabIndex = 15;
            this.siticoneCheckBox2.Text = "1920x1080";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.CheckedChanged += new System.EventHandler(this.siticoneCheckBox2_CheckedChanged);
            // 
            // siticoneCheckBox3
            // 
            this.siticoneCheckBox3.AutoSize = true;
            this.siticoneCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox3.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.Location = new System.Drawing.Point(235, 76);
            this.siticoneCheckBox3.Name = "siticoneCheckBox3";
            this.siticoneCheckBox3.Size = new System.Drawing.Size(79, 17);
            this.siticoneCheckBox3.TabIndex = 16;
            this.siticoneCheckBox3.Text = "1920x1080";
            this.siticoneCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox3.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.CheckedChanged += new System.EventHandler(this.siticoneCheckBox3_CheckedChanged);
            // 
            // siticoneCheckBox4
            // 
            this.siticoneCheckBox4.AutoSize = true;
            this.siticoneCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox4.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.Location = new System.Drawing.Point(235, 118);
            this.siticoneCheckBox4.Name = "siticoneCheckBox4";
            this.siticoneCheckBox4.Size = new System.Drawing.Size(79, 17);
            this.siticoneCheckBox4.TabIndex = 17;
            this.siticoneCheckBox4.Text = "1920x1080";
            this.siticoneCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox4.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox4.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox4.CheckedChanged += new System.EventHandler(this.siticoneCheckBox4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(68, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "1920x1080";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(68, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "1600x900";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(259, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "1280x720";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(259, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "1024x576";
            // 
            // PixelhyAutoAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(388, 222);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneCheckBox4);
            this.Controls.Add(this.siticoneCheckBox3);
            this.Controls.Add(this.siticoneCheckBox2);
            this.Controls.Add(this.siticoneCheckBox1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PixelhyAutoAccept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PixelhyAutoAccept_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

