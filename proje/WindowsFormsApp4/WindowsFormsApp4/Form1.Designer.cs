
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.sayfa = new System.Windows.Forms.Label();
            this.paragraf = new System.Windows.Forms.Label();
            this.psize = new System.Windows.Forms.Label();
            this.hsize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 287);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(54, 438);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(422, 318);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(596, 603);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(493, 183);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(596, 240);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(493, 287);
            this.dataGridView4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlık Kontrolü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Url Kontrolü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paragraf Kontrolü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genel Sayfa Bilgisi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "İncelemeyi başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1357, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hatalar";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(1200, 67);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(369, 91);
            this.url.TabIndex = 14;
            this.url.Text = "Url";
            // 
            // baslik
            // 
            this.baslik.Location = new System.Drawing.Point(1200, 201);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(332, 86);
            this.baslik.TabIndex = 15;
            this.baslik.Text = "Başlık";
            // 
            // sayfa
            // 
            this.sayfa.Location = new System.Drawing.Point(1200, 302);
            this.sayfa.Name = "sayfa";
            this.sayfa.Size = new System.Drawing.Size(341, 66);
            this.sayfa.TabIndex = 16;
            this.sayfa.Text = "Sayfa";
            // 
            // paragraf
            // 
            this.paragraf.Location = new System.Drawing.Point(1200, 403);
            this.paragraf.Name = "paragraf";
            this.paragraf.Size = new System.Drawing.Size(341, 56);
            this.paragraf.TabIndex = 17;
            this.paragraf.Text = "Paragraf";
            // 
            // psize
            // 
            this.psize.Location = new System.Drawing.Point(1200, 513);
            this.psize.Name = "psize";
            this.psize.Size = new System.Drawing.Size(341, 62);
            this.psize.TabIndex = 18;
            this.psize.Text = "Paragraf Boyutu";
            // 
            // hsize
            // 
            this.hsize.Location = new System.Drawing.Point(1200, 631);
            this.hsize.Name = "hsize";
            this.hsize.Size = new System.Drawing.Size(341, 62);
            this.hsize.TabIndex = 19;
            this.hsize.Text = "Başlık Boyutu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "örnek yol ---> C:\\Users\\Cenkk\\Desktop\\cenk.docx \r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 822);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hsize);
            this.Controls.Add(this.psize);
            this.Controls.Add(this.paragraf);
            this.Controls.Add(this.sayfa);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Label sayfa;
        private System.Windows.Forms.Label paragraf;
        private System.Windows.Forms.Label psize;
        private System.Windows.Forms.Label hsize;
        private System.Windows.Forms.Label label7;
    }
}

