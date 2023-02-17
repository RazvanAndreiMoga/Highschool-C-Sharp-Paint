namespace MiniPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_fillPie = new System.Windows.Forms.Button();
            this.btn_fillSquare = new System.Windows.Forms.Button();
            this.btn_fillCircle = new System.Windows.Forms.Button();
            this.btn_fillRect = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox_sweep = new System.Windows.Forms.TextBox();
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.btn_Arc = new System.Windows.Forms.Button();
            this.btn_Polygon = new System.Windows.Forms.Button();
            this.btn_Pie = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_CanvasColor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.cmb_PenSize = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 178);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txt_ShapeSize);
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Controls.Add(this.textBox2);
            this.panel9.Controls.Add(this.btn_fillPie);
            this.panel9.Controls.Add(this.btn_fillSquare);
            this.panel9.Controls.Add(this.btn_fillCircle);
            this.panel9.Controls.Add(this.btn_fillRect);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(142, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 169);
            this.panel9.TabIndex = 4;
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(135, 32);
            this.txt_ShapeSize.Multiline = true;
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(109, 61);
            this.txt_ShapeSize.TabIndex = 18;
            this.txt_ShapeSize.Text = "10";
            this.txt_ShapeSize.TextChanged += new System.EventHandler(this.txt_ShapeSize_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Sweep Angle";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Start Angle";
            // 
            // btn_fillPie
            // 
            this.btn_fillPie.Location = new System.Drawing.Point(3, 136);
            this.btn_fillPie.Name = "btn_fillPie";
            this.btn_fillPie.Size = new System.Drawing.Size(122, 23);
            this.btn_fillPie.TabIndex = 10;
            this.btn_fillPie.Text = "Pie";
            this.btn_fillPie.UseVisualStyleBackColor = true;
            this.btn_fillPie.Click += new System.EventHandler(this.btn_fillPie_Click);
            // 
            // btn_fillSquare
            // 
            this.btn_fillSquare.BackColor = System.Drawing.SystemColors.Control;
            this.btn_fillSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fillSquare.Location = new System.Drawing.Point(3, 32);
            this.btn_fillSquare.Name = "btn_fillSquare";
            this.btn_fillSquare.Size = new System.Drawing.Size(122, 28);
            this.btn_fillSquare.TabIndex = 4;
            this.btn_fillSquare.Text = "Square";
            this.btn_fillSquare.UseVisualStyleBackColor = false;
            this.btn_fillSquare.Click += new System.EventHandler(this.btn_fillSquare_Click);
            // 
            // btn_fillCircle
            // 
            this.btn_fillCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_fillCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fillCircle.Location = new System.Drawing.Point(3, 100);
            this.btn_fillCircle.Name = "btn_fillCircle";
            this.btn_fillCircle.Size = new System.Drawing.Size(122, 28);
            this.btn_fillCircle.TabIndex = 7;
            this.btn_fillCircle.Text = "Circle";
            this.btn_fillCircle.UseVisualStyleBackColor = false;
            this.btn_fillCircle.Click += new System.EventHandler(this.btn_fillCircle_Click);
            // 
            // btn_fillRect
            // 
            this.btn_fillRect.BackColor = System.Drawing.SystemColors.Control;
            this.btn_fillRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fillRect.Location = new System.Drawing.Point(3, 66);
            this.btn_fillRect.Name = "btn_fillRect";
            this.btn_fillRect.Size = new System.Drawing.Size(122, 28);
            this.btn_fillRect.TabIndex = 6;
            this.btn_fillRect.Text = "Rectangle";
            this.btn_fillRect.UseVisualStyleBackColor = false;
            this.btn_fillRect.Click += new System.EventHandler(this.btn_fillRect_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(-1, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(324, 27);
            this.panel10.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fill Shapes";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.textBox_sweep);
            this.panel7.Controls.Add(this.textBox_Start);
            this.panel7.Controls.Add(this.btn_Arc);
            this.panel7.Controls.Add(this.btn_Polygon);
            this.panel7.Controls.Add(this.btn_Pie);
            this.panel7.Controls.Add(this.btn_Line);
            this.panel7.Controls.Add(this.btn_Circle);
            this.panel7.Controls.Add(this.btn_Rectangle);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(401, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 169);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // textBox_sweep
            // 
            this.textBox_sweep.Location = new System.Drawing.Point(135, 136);
            this.textBox_sweep.Name = "textBox_sweep";
            this.textBox_sweep.Size = new System.Drawing.Size(109, 20);
            this.textBox_sweep.TabIndex = 17;
            this.textBox_sweep.Text = "Sweep Angle";
            // 
            // textBox_Start
            // 
            this.textBox_Start.Location = new System.Drawing.Point(135, 105);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(109, 20);
            this.textBox_Start.TabIndex = 17;
            this.textBox_Start.Text = "Start Angle";
            this.textBox_Start.TextChanged += new System.EventHandler(this.textBox_Start_TextChanged);
            // 
            // btn_Arc
            // 
            this.btn_Arc.Location = new System.Drawing.Point(135, 65);
            this.btn_Arc.Name = "btn_Arc";
            this.btn_Arc.Size = new System.Drawing.Size(109, 28);
            this.btn_Arc.TabIndex = 15;
            this.btn_Arc.Text = "Arc";
            this.btn_Arc.UseVisualStyleBackColor = true;
            this.btn_Arc.Click += new System.EventHandler(this.btn_Arc_Click);
            // 
            // btn_Polygon
            // 
            this.btn_Polygon.Location = new System.Drawing.Point(135, 32);
            this.btn_Polygon.Name = "btn_Polygon";
            this.btn_Polygon.Size = new System.Drawing.Size(109, 27);
            this.btn_Polygon.TabIndex = 13;
            this.btn_Polygon.Text = "Polygon";
            this.btn_Polygon.UseVisualStyleBackColor = true;
            this.btn_Polygon.Click += new System.EventHandler(this.btn_Polygon_Click);
            // 
            // btn_Pie
            // 
            this.btn_Pie.Location = new System.Drawing.Point(3, 136);
            this.btn_Pie.Name = "btn_Pie";
            this.btn_Pie.Size = new System.Drawing.Size(122, 23);
            this.btn_Pie.TabIndex = 10;
            this.btn_Pie.Text = "Pie";
            this.btn_Pie.UseVisualStyleBackColor = true;
            this.btn_Pie.Click += new System.EventHandler(this.btn_Pie_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Line.Location = new System.Drawing.Point(3, 32);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(122, 28);
            this.btn_Line.TabIndex = 4;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = false;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.Location = new System.Drawing.Point(3, 100);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(122, 28);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(3, 66);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(122, 28);
            this.btn_Rectangle.TabIndex = 6;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(-1, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(324, 27);
            this.panel8.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Draw Shapes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(660, 6);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(80, 168);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_CanvasColor);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(5, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 70);
            this.panel4.TabIndex = 2;
            // 
            // btn_CanvasColor
            // 
            this.btn_CanvasColor.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CanvasColor.Location = new System.Drawing.Point(3, 34);
            this.btn_CanvasColor.Name = "btn_CanvasColor";
            this.btn_CanvasColor.Size = new System.Drawing.Size(122, 28);
            this.btn_CanvasColor.TabIndex = 4;
            this.btn_CanvasColor.UseVisualStyleBackColor = false;
            this.btn_CanvasColor.Click += new System.EventHandler(this.btn_CanvasColor_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 27);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canvas Color";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_PenColor);
            this.panel2.Controls.Add(this.cmb_PenSize);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(130, 27);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pen Tool";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-1, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 100);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(4, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "1";
            // 
            // button2
            // 
            this.button2.Image = global::MiniPaint.Properties.Resources.pencil;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pen Tool";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.Location = new System.Drawing.Point(3, 65);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(122, 28);
            this.btn_PenColor.TabIndex = 2;
            this.btn_PenColor.UseVisualStyleBackColor = false;
            this.btn_PenColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_PenSize
            // 
            this.cmb_PenSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmb_PenSize.FormattingEnabled = true;
            this.cmb_PenSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_PenSize.Location = new System.Drawing.Point(4, 38);
            this.cmb_PenSize.MaxDropDownItems = 12;
            this.cmb_PenSize.Name = "cmb_PenSize";
            this.cmb_PenSize.Size = new System.Drawing.Size(122, 21);
            this.cmb_PenSize.TabIndex = 1;
            this.cmb_PenSize.Text = "1";
            this.cmb_PenSize.SelectedIndexChanged += new System.EventHandler(this.cmb_PenSize_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Draw.Location = new System.Drawing.Point(0, 205);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(743, 423);
            this.pnl_Draw.TabIndex = 2;
            this.pnl_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Draw_Paint);
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 680);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint-ul lui Răzvan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CanvasColor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Pie;
        private System.Windows.Forms.TextBox textBox_sweep;
        private System.Windows.Forms.TextBox textBox_Start;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Arc;
        private System.Windows.Forms.Button btn_Polygon;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_fillPie;
        private System.Windows.Forms.Button btn_fillSquare;
        private System.Windows.Forms.Button btn_fillCircle;
        private System.Windows.Forms.Button btn_fillRect;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ShapeSize;
    }
}

