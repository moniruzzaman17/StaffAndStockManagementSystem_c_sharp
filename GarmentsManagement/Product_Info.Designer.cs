namespace GarmentsManagement
{
    partial class Product_Info
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_total_type_name = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_xl_long_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_l_long_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_m_long_total = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_long_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_xl_short_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_l_short_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_m_short_total = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_sort_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_available = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(12, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1040, 53);
            this.panel5.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(912, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Polo",
            "Round Neck",
            "V Neck"});
            this.comboBox1.Location = new System.Drawing.Point(542, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 26);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(310, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Search By T-Shirt Type";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_available);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label_total_type_name);
            this.panel1.Controls.Add(this.textBox_total);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 242);
            this.panel1.TabIndex = 45;
            // 
            // label_total_type_name
            // 
            this.label_total_type_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_total_type_name.AutoSize = true;
            this.label_total_type_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_type_name.Location = new System.Drawing.Point(324, 95);
            this.label_total_type_name.Name = "label_total_type_name";
            this.label_total_type_name.Size = new System.Drawing.Size(169, 20);
            this.label_total_type_name.TabIndex = 52;
            this.label_total_type_name.Text = "Total ____ T-Shirt :-";
            // 
            // textBox_total
            // 
            this.textBox_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(542, 93);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(115, 24);
            this.textBox_total.TabIndex = 53;
            this.textBox_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox_xl_long_total);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox_l_long_total);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_m_long_total);
            this.panel4.Location = new System.Drawing.Point(799, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 164);
            this.panel4.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "XL Size :-";
            // 
            // textBox_xl_long_total
            // 
            this.textBox_xl_long_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_xl_long_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_xl_long_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_xl_long_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xl_long_total.Location = new System.Drawing.Point(97, 112);
            this.textBox_xl_long_total.Name = "textBox_xl_long_total";
            this.textBox_xl_long_total.ReadOnly = true;
            this.textBox_xl_long_total.Size = new System.Drawing.Size(107, 24);
            this.textBox_xl_long_total.TabIndex = 50;
            this.textBox_xl_long_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "L Size :-";
            // 
            // textBox_l_long_total
            // 
            this.textBox_l_long_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_l_long_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_l_long_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_l_long_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_l_long_total.Location = new System.Drawing.Point(97, 67);
            this.textBox_l_long_total.Name = "textBox_l_long_total";
            this.textBox_l_long_total.ReadOnly = true;
            this.textBox_l_long_total.Size = new System.Drawing.Size(107, 24);
            this.textBox_l_long_total.TabIndex = 48;
            this.textBox_l_long_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "M Size :-";
            // 
            // textBox_m_long_total
            // 
            this.textBox_m_long_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_m_long_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_m_long_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_m_long_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_m_long_total.Location = new System.Drawing.Point(97, 24);
            this.textBox_m_long_total.Name = "textBox_m_long_total";
            this.textBox_m_long_total.ReadOnly = true;
            this.textBox_m_long_total.Size = new System.Drawing.Size(107, 24);
            this.textBox_m_long_total.TabIndex = 46;
            this.textBox_m_long_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label_long_total);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(799, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 53);
            this.panel6.TabIndex = 50;
            // 
            // label_long_total
            // 
            this.label_long_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_long_total.AutoSize = true;
            this.label_long_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_long_total.Location = new System.Drawing.Point(184, 9);
            this.label_long_total.Name = "label_long_total";
            this.label_long_total.Size = new System.Drawing.Size(20, 29);
            this.label_long_total.TabIndex = 49;
            this.label_long_total.Text = " ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Long Sleeves";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox_xl_short_total);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_l_short_total);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_m_short_total);
            this.panel3.Location = new System.Drawing.Point(19, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 164);
            this.panel3.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "XL Size :-";
            // 
            // textBox_xl_short_total
            // 
            this.textBox_xl_short_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_xl_short_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_xl_short_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_xl_short_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xl_short_total.Location = new System.Drawing.Point(100, 112);
            this.textBox_xl_short_total.Name = "textBox_xl_short_total";
            this.textBox_xl_short_total.ReadOnly = true;
            this.textBox_xl_short_total.Size = new System.Drawing.Size(107, 24);
            this.textBox_xl_short_total.TabIndex = 50;
            this.textBox_xl_short_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "L Size :-";
            // 
            // textBox_l_short_total
            // 
            this.textBox_l_short_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_l_short_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_l_short_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_l_short_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_l_short_total.Location = new System.Drawing.Point(100, 67);
            this.textBox_l_short_total.Name = "textBox_l_short_total";
            this.textBox_l_short_total.ReadOnly = true;
            this.textBox_l_short_total.Size = new System.Drawing.Size(107, 24);
            this.textBox_l_short_total.TabIndex = 48;
            this.textBox_l_short_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "M Size :-";
            // 
            // textBox_m_short_total
            // 
            this.textBox_m_short_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_m_short_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_m_short_total.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_m_short_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_m_short_total.Location = new System.Drawing.Point(100, 24);
            this.textBox_m_short_total.Name = "textBox_m_short_total";
            this.textBox_m_short_total.ReadOnly = true;
            this.textBox_m_short_total.Size = new System.Drawing.Size(107, 24);
            this.textBox_m_short_total.TabIndex = 46;
            this.textBox_m_short_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label_sort_total);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 53);
            this.panel2.TabIndex = 48;
            // 
            // label_sort_total
            // 
            this.label_sort_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sort_total.AutoSize = true;
            this.label_sort_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sort_total.Location = new System.Drawing.Point(187, 9);
            this.label_sort_total.Name = "label_sort_total";
            this.label_sort_total.Size = new System.Drawing.Size(20, 29);
            this.label_sort_total.TabIndex = 48;
            this.label_sort_total.Text = " ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Short Sleeves";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.AutoSize = true;
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(12, 358);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1040, 312);
            this.panel7.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_available
            // 
            this.label_available.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_available.AutoSize = true;
            this.label_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_available.Location = new System.Drawing.Point(570, 1);
            this.label_available.Name = "label_available";
            this.label_available.Size = new System.Drawing.Size(20, 29);
            this.label_available.TabIndex = 55;
            this.label_available.Text = " ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Total Available T-Shirt:-";
            // 
            // Product_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 682);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Product_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product_Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Product_Info_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_total_type_name;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_xl_long_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_l_long_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_m_long_total;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_xl_short_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_l_short_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_m_short_total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_sort_total;
        private System.Windows.Forms.Label label_long_total;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_available;
        private System.Windows.Forms.Label label10;
    }
}