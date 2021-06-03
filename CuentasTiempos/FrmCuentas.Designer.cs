
namespace CuentasTiempos
{
    partial class FrmCuentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSorteo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBanca = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbxValesxDia = new System.Windows.Forms.MaskedTextBox();
            this.mtbxValesDiaAnterior = new System.Windows.Forms.MaskedTextBox();
            this.mtbxGananciaDiaAnterior = new System.Windows.Forms.MaskedTextBox();
            this.mtbxBancaDiaAnterior = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValesSemana = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGananciaSemana = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBancaSemana = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGananciaxDia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBancaxDia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPorcentajeGanancia = new System.Windows.Forms.Label();
            this.mtxbVenta = new System.Windows.Forms.MaskedTextBox();
            this.mtxbPremio = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuentas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sorteo";
            // 
            // cbxSorteo
            // 
            this.cbxSorteo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSorteo.FormattingEnabled = true;
            this.cbxSorteo.Items.AddRange(new object[] {
            "Nica 11:00 a.m",
            "Nica 3:00 p.m",
            "Nica 6:00 p.m",
            "Nica 9:00 p.m",
            "Digital Dia - Numero",
            "Digital Dia - Reventado",
            "Digital Noche - Numero",
            "Digital Noche - Reventado"});
            this.cbxSorteo.Location = new System.Drawing.Point(101, 244);
            this.cbxSorteo.Name = "cbxSorteo";
            this.cbxSorteo.Size = new System.Drawing.Size(173, 24);
            this.cbxSorteo.TabIndex = 2;
            this.cbxSorteo.SelectedIndexChanged += new System.EventHandler(this.cbxSorteo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ganancia";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.Location = new System.Drawing.Point(101, 327);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.ReadOnly = true;
            this.txtGanancia.Size = new System.Drawing.Size(173, 23);
            this.txtGanancia.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Premio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Banca";
            // 
            // txtBanca
            // 
            this.txtBanca.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanca.Location = new System.Drawing.Point(426, 291);
            this.txtBanca.Name = "txtBanca";
            this.txtBanca.ReadOnly = true;
            this.txtBanca.Size = new System.Drawing.Size(173, 23);
            this.txtBanca.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(145, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(17, 461);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(582, 163);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sorteo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ventas";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ganancia";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Premio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Banca";
            this.Column5.Name = "Column5";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(335, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 44);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbxValesxDia);
            this.groupBox1.Controls.Add(this.mtbxValesDiaAnterior);
            this.groupBox1.Controls.Add(this.mtbxGananciaDiaAnterior);
            this.groupBox1.Controls.Add(this.mtbxBancaDiaAnterior);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtValesSemana);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtGananciaSemana);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBancaSemana);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGananciaxDia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBancaxDia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(24, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // mtbxValesxDia
            // 
            this.mtbxValesxDia.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxValesxDia.Location = new System.Drawing.Point(157, 102);
            this.mtbxValesxDia.Mask = "99999999999";
            this.mtbxValesxDia.Name = "mtbxValesxDia";
            this.mtbxValesxDia.Size = new System.Drawing.Size(101, 23);
            this.mtbxValesxDia.TabIndex = 24;
            this.mtbxValesxDia.ValidatingType = typeof(int);
            this.mtbxValesxDia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtbxValesxDia_MouseClick);
            // 
            // mtbxValesDiaAnterior
            // 
            this.mtbxValesDiaAnterior.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxValesDiaAnterior.Location = new System.Drawing.Point(410, 103);
            this.mtbxValesDiaAnterior.Mask = "99999999999";
            this.mtbxValesDiaAnterior.Name = "mtbxValesDiaAnterior";
            this.mtbxValesDiaAnterior.Size = new System.Drawing.Size(101, 23);
            this.mtbxValesDiaAnterior.TabIndex = 23;
            this.mtbxValesDiaAnterior.ValidatingType = typeof(int);
            this.mtbxValesDiaAnterior.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtbxValesDiaAnterior_MouseClick);
            // 
            // mtbxGananciaDiaAnterior
            // 
            this.mtbxGananciaDiaAnterior.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxGananciaDiaAnterior.Location = new System.Drawing.Point(157, 62);
            this.mtbxGananciaDiaAnterior.Mask = "99999999999";
            this.mtbxGananciaDiaAnterior.Name = "mtbxGananciaDiaAnterior";
            this.mtbxGananciaDiaAnterior.Size = new System.Drawing.Size(101, 23);
            this.mtbxGananciaDiaAnterior.TabIndex = 22;
            this.mtbxGananciaDiaAnterior.ValidatingType = typeof(int);
            this.mtbxGananciaDiaAnterior.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtbxGananciaDiaAnterior_MouseClick);
            // 
            // mtbxBancaDiaAnterior
            // 
            this.mtbxBancaDiaAnterior.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxBancaDiaAnterior.Location = new System.Drawing.Point(157, 19);
            this.mtbxBancaDiaAnterior.Mask = "99999999999";
            this.mtbxBancaDiaAnterior.Name = "mtbxBancaDiaAnterior";
            this.mtbxBancaDiaAnterior.Size = new System.Drawing.Size(101, 23);
            this.mtbxBancaDiaAnterior.TabIndex = 21;
            this.mtbxBancaDiaAnterior.ValidatingType = typeof(int);
            this.mtbxBancaDiaAnterior.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtbxBancaDiaAnterior_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(282, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Vales Anterior";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ganancia Anterior";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "Banca Anterior";
            // 
            // txtValesSemana
            // 
            this.txtValesSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValesSemana.Location = new System.Drawing.Point(681, 106);
            this.txtValesSemana.Name = "txtValesSemana";
            this.txtValesSemana.ReadOnly = true;
            this.txtValesSemana.Size = new System.Drawing.Size(101, 23);
            this.txtValesSemana.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(537, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Vales Semanal";
            // 
            // txtGananciaSemana
            // 
            this.txtGananciaSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGananciaSemana.Location = new System.Drawing.Point(681, 67);
            this.txtGananciaSemana.Name = "txtGananciaSemana";
            this.txtGananciaSemana.ReadOnly = true;
            this.txtGananciaSemana.Size = new System.Drawing.Size(101, 23);
            this.txtGananciaSemana.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(537, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ganancia Semanal";
            // 
            // txtBancaSemana
            // 
            this.txtBancaSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancaSemana.Location = new System.Drawing.Point(681, 20);
            this.txtBancaSemana.Name = "txtBancaSemana";
            this.txtBancaSemana.ReadOnly = true;
            this.txtBancaSemana.Size = new System.Drawing.Size(101, 23);
            this.txtBancaSemana.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Banca Semanal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Vales";
            // 
            // txtGananciaxDia
            // 
            this.txtGananciaxDia.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGananciaxDia.Location = new System.Drawing.Point(410, 66);
            this.txtGananciaxDia.Name = "txtGananciaxDia";
            this.txtGananciaxDia.ReadOnly = true;
            this.txtGananciaxDia.Size = new System.Drawing.Size(101, 23);
            this.txtGananciaxDia.TabIndex = 9;
            this.txtGananciaxDia.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ganancia Dia";
            // 
            // txtBancaxDia
            // 
            this.txtBancaxDia.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancaxDia.Location = new System.Drawing.Point(410, 19);
            this.txtBancaxDia.Name = "txtBancaxDia";
            this.txtBancaxDia.ReadOnly = true;
            this.txtBancaxDia.Size = new System.Drawing.Size(101, 23);
            this.txtBancaxDia.TabIndex = 7;
            this.txtBancaxDia.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Banca Dia";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Location = new System.Drawing.Point(651, 483);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(155, 44);
            this.btnDescargar.TabIndex = 15;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(651, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 44);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPorcentajeGanancia
            // 
            this.lblPorcentajeGanancia.AutoSize = true;
            this.lblPorcentajeGanancia.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeGanancia.Location = new System.Drawing.Point(280, 336);
            this.lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            this.lblPorcentajeGanancia.Size = new System.Drawing.Size(25, 14);
            this.lblPorcentajeGanancia.TabIndex = 18;
            this.lblPorcentajeGanancia.Text = "0 %";
            // 
            // mtxbVenta
            // 
            this.mtxbVenta.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbVenta.Location = new System.Drawing.Point(101, 286);
            this.mtxbVenta.Mask = "99999999999";
            this.mtxbVenta.Name = "mtxbVenta";
            this.mtxbVenta.Size = new System.Drawing.Size(173, 23);
            this.mtxbVenta.TabIndex = 19;
            this.mtxbVenta.ValidatingType = typeof(int);
            this.mtxbVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxbVenta_MouseClick);
            this.mtxbVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxbVenta_KeyDown);
            // 
            // mtxbPremio
            // 
            this.mtxbPremio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbPremio.Location = new System.Drawing.Point(426, 245);
            this.mtxbPremio.Mask = "99999999999";
            this.mtxbPremio.Name = "mtxbPremio";
            this.mtxbPremio.Size = new System.Drawing.Size(173, 23);
            this.mtxbPremio.TabIndex = 20;
            this.mtxbPremio.ValidatingType = typeof(int);
            this.mtxbPremio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxbPremio_MouseClick);
            this.mtxbPremio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxbPremio_KeyDown);
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 643);
            this.Controls.Add(this.mtxbPremio);
            this.Controls.Add(this.mtxbVenta);
            this.Controls.Add(this.lblPorcentajeGanancia);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBanca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSorteo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSorteo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBanca;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtValesSemana;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGananciaSemana;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBancaSemana;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGananciaxDia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBancaxDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPorcentajeGanancia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtxbVenta;
        private System.Windows.Forms.MaskedTextBox mtxbPremio;
        private System.Windows.Forms.MaskedTextBox mtbxBancaDiaAnterior;
        private System.Windows.Forms.MaskedTextBox mtbxGananciaDiaAnterior;
        private System.Windows.Forms.MaskedTextBox mtbxValesDiaAnterior;
        private System.Windows.Forms.MaskedTextBox mtbxValesxDia;
    }
}