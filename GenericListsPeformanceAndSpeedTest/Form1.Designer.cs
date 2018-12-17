namespace GenericListsPeformanceAndSpeedTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudElemanSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnTestEt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSQLGrafik = new System.Windows.Forms.Button();
            this.btnSQLTestEt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnArraySpeedTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudElemanSayisi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Elements";
            // 
            // nudElemanSayisi
            // 
            this.nudElemanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudElemanSayisi.Location = new System.Drawing.Point(226, 9);
            this.nudElemanSayisi.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudElemanSayisi.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudElemanSayisi.Name = "nudElemanSayisi";
            this.nudElemanSayisi.Size = new System.Drawing.Size(130, 32);
            this.nudElemanSayisi.TabIndex = 2;
            this.nudElemanSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudElemanSayisi.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // btnTestEt
            // 
            this.btnTestEt.AutoSize = true;
            this.btnTestEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestEt.Location = new System.Drawing.Point(362, 7);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(224, 36);
            this.btnTestEt.TabIndex = 3;
            this.btnTestEt.Text = "Array Memory Test";
            this.btnTestEt.UseVisualStyleBackColor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudElemanSayisi);
            this.panel1.Controls.Add(this.btnSQLGrafik);
            this.panel1.Controls.Add(this.btnSQLTestEt);
            this.panel1.Controls.Add(this.btnArraySpeedTest);
            this.panel1.Controls.Add(this.btnTestEt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 54);
            this.panel1.TabIndex = 4;
            // 
            // btnSQLGrafik
            // 
            this.btnSQLGrafik.AutoSize = true;
            this.btnSQLGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLGrafik.Location = new System.Drawing.Point(976, 7);
            this.btnSQLGrafik.Name = "btnSQLGrafik";
            this.btnSQLGrafik.Size = new System.Drawing.Size(148, 36);
            this.btnSQLGrafik.TabIndex = 3;
            this.btnSQLGrafik.Text = "SQL Graphic";
            this.btnSQLGrafik.UseVisualStyleBackColor = true;
            this.btnSQLGrafik.Click += new System.EventHandler(this.btnSQLGrafik_Click);
            // 
            // btnSQLTestEt
            // 
            this.btnSQLTestEt.AutoSize = true;
            this.btnSQLTestEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLTestEt.Location = new System.Drawing.Point(788, 7);
            this.btnSQLTestEt.Name = "btnSQLTestEt";
            this.btnSQLTestEt.Size = new System.Drawing.Size(182, 36);
            this.btnSQLTestEt.TabIndex = 3;
            this.btnSQLTestEt.Text = "SQL Speed Test";
            this.btnSQLTestEt.UseVisualStyleBackColor = true;
            this.btnSQLTestEt.Click += new System.EventHandler(this.btnSQLTestEt_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1163, 400);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnArraySpeedTest
            // 
            this.btnArraySpeedTest.AutoSize = true;
            this.btnArraySpeedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArraySpeedTest.Location = new System.Drawing.Point(592, 7);
            this.btnArraySpeedTest.Name = "btnArraySpeedTest";
            this.btnArraySpeedTest.Size = new System.Drawing.Size(190, 36);
            this.btnArraySpeedTest.TabIndex = 3;
            this.btnArraySpeedTest.Text = "Array Speed Test";
            this.btnArraySpeedTest.UseVisualStyleBackColor = true;
            this.btnArraySpeedTest.Click += new System.EventHandler(this.btnArraySpeedTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 454);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Lists Performance And Speed Test";
            ((System.ComponentModel.ISupportInitialize)(this.nudElemanSayisi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudElemanSayisi;
        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSQLTestEt;
        private System.Windows.Forms.Button btnSQLGrafik;
        private System.Windows.Forms.Button btnArraySpeedTest;
    }
}

