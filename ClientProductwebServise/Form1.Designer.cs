
namespace ClientProductwebServise
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetUrun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetUrun
            // 
            this.btnGetUrun.Location = new System.Drawing.Point(274, 12);
            this.btnGetUrun.Name = "btnGetUrun";
            this.btnGetUrun.Size = new System.Drawing.Size(209, 89);
            this.btnGetUrun.TabIndex = 1;
            this.btnGetUrun.Text = "Urunleri Getir";
            this.btnGetUrun.UseVisualStyleBackColor = true;
            this.btnGetUrun.Click += new System.EventHandler(this.btnGetUrun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 306);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(489, 12);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(209, 89);
            this.btnMusteriGetir.TabIndex = 1;
            this.btnMusteriGetir.Text = "Musteri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMusteriGetir);
            this.Controls.Add(this.btnGetUrun);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetUrun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMusteriGetir;
    }
}

