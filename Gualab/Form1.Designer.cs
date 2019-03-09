namespace Gualab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hw_tb = new System.Windows.Forms.TrackBar();
            this.hw_nud = new System.Windows.Forms.NumericUpDown();
            this.al_nud = new System.Windows.Forms.NumericUpDown();
            this.al_tb = new System.Windows.Forms.TrackBar();
            this.bc_nud = new System.Windows.Forms.NumericUpDown();
            this.bc_tb = new System.Windows.Forms.TrackBar();
            this.fac_nud = new System.Windows.Forms.NumericUpDown();
            this.fac_tb = new System.Windows.Forms.TrackBar();
            this.HandWidth_lbl = new System.Windows.Forms.Label();
            this.ArmLength_lbl = new System.Windows.Forms.Label();
            this.ForeArmCircumference_lbl = new System.Windows.Forms.Label();
            this.BicepCircumference_lbl = new System.Windows.Forms.Label();
            this.LeftRight_lbl = new System.Windows.Forms.Label();
            this.crear_btn = new System.Windows.Forms.Button();
            this.lr_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pd_lbl = new System.Windows.Forms.Label();
            this.pd_nud = new System.Windows.Forms.NumericUpDown();
            this.pd_tb = new System.Windows.Forms.TrackBar();
            this.iniciales_txt = new System.Windows.Forms.TextBox();
            this.iniciales_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hw_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hw_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bc_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bc_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fac_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fac_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pd_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pd_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // hw_tb
            // 
            this.hw_tb.LargeChange = 50;
            this.hw_tb.Location = new System.Drawing.Point(173, 144);
            this.hw_tb.Maximum = 186;
            this.hw_tb.Minimum = 50;
            this.hw_tb.Name = "hw_tb";
            this.hw_tb.Size = new System.Drawing.Size(391, 45);
            this.hw_tb.SmallChange = 100;
            this.hw_tb.TabIndex = 0;
            this.hw_tb.TickFrequency = 14;
            this.hw_tb.Value = 50;
            this.hw_tb.ValueChanged += new System.EventHandler(this.hw_tb_ValueChanged);
            // 
            // hw_nud
            // 
            this.hw_nud.Location = new System.Drawing.Point(587, 144);
            this.hw_nud.Maximum = new decimal(new int[] {
            186,
            0,
            0,
            0});
            this.hw_nud.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.hw_nud.Name = "hw_nud";
            this.hw_nud.Size = new System.Drawing.Size(45, 20);
            this.hw_nud.TabIndex = 126;
            this.hw_nud.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.hw_nud.ValueChanged += new System.EventHandler(this.hw_nud_ValueChanged);
            // 
            // al_nud
            // 
            this.al_nud.Location = new System.Drawing.Point(587, 195);
            this.al_nud.Maximum = new decimal(new int[] {
            564,
            0,
            0,
            0});
            this.al_nud.Minimum = new decimal(new int[] {
            141,
            0,
            0,
            0});
            this.al_nud.Name = "al_nud";
            this.al_nud.Size = new System.Drawing.Size(45, 20);
            this.al_nud.TabIndex = 128;
            this.al_nud.Value = new decimal(new int[] {
            141,
            0,
            0,
            0});
            this.al_nud.ValueChanged += new System.EventHandler(this.al_nud_ValueChanged);
            // 
            // al_tb
            // 
            this.al_tb.LargeChange = 50;
            this.al_tb.Location = new System.Drawing.Point(173, 195);
            this.al_tb.Maximum = 564;
            this.al_tb.Minimum = 141;
            this.al_tb.Name = "al_tb";
            this.al_tb.Size = new System.Drawing.Size(391, 45);
            this.al_tb.SmallChange = 100;
            this.al_tb.TabIndex = 127;
            this.al_tb.TickFrequency = 43;
            this.al_tb.Value = 141;
            this.al_tb.ValueChanged += new System.EventHandler(this.al_tb_ValueChanged);
            // 
            // bc_nud
            // 
            this.bc_nud.Location = new System.Drawing.Point(587, 298);
            this.bc_nud.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.bc_nud.Minimum = new decimal(new int[] {
            147,
            0,
            0,
            0});
            this.bc_nud.Name = "bc_nud";
            this.bc_nud.Size = new System.Drawing.Size(45, 20);
            this.bc_nud.TabIndex = 132;
            this.bc_nud.Value = new decimal(new int[] {
            147,
            0,
            0,
            0});
            this.bc_nud.ValueChanged += new System.EventHandler(this.bc_nud_ValueChanged);
            // 
            // bc_tb
            // 
            this.bc_tb.LargeChange = 50;
            this.bc_tb.Location = new System.Drawing.Point(173, 298);
            this.bc_tb.Maximum = 600;
            this.bc_tb.Minimum = 147;
            this.bc_tb.Name = "bc_tb";
            this.bc_tb.Size = new System.Drawing.Size(391, 45);
            this.bc_tb.SmallChange = 100;
            this.bc_tb.TabIndex = 131;
            this.bc_tb.TickFrequency = 46;
            this.bc_tb.Value = 147;
            this.bc_tb.ValueChanged += new System.EventHandler(this.bc_tb_ValueChanged);
            // 
            // fac_nud
            // 
            this.fac_nud.Location = new System.Drawing.Point(587, 245);
            this.fac_nud.Maximum = new decimal(new int[] {
            542,
            0,
            0,
            0});
            this.fac_nud.Minimum = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.fac_nud.Name = "fac_nud";
            this.fac_nud.Size = new System.Drawing.Size(45, 20);
            this.fac_nud.TabIndex = 130;
            this.fac_nud.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.fac_nud.ValueChanged += new System.EventHandler(this.fac_nud_ValueChanged);
            // 
            // fac_tb
            // 
            this.fac_tb.LargeChange = 50;
            this.fac_tb.Location = new System.Drawing.Point(173, 245);
            this.fac_tb.Maximum = 542;
            this.fac_tb.Minimum = 135;
            this.fac_tb.Name = "fac_tb";
            this.fac_tb.Size = new System.Drawing.Size(391, 45);
            this.fac_tb.SmallChange = 100;
            this.fac_tb.TabIndex = 129;
            this.fac_tb.TickFrequency = 41;
            this.fac_tb.Value = 135;
            this.fac_tb.ValueChanged += new System.EventHandler(this.fac_tb_ValueChanged);
            // 
            // HandWidth_lbl
            // 
            this.HandWidth_lbl.AutoSize = true;
            this.HandWidth_lbl.Location = new System.Drawing.Point(14, 146);
            this.HandWidth_lbl.Name = "HandWidth_lbl";
            this.HandWidth_lbl.Size = new System.Drawing.Size(96, 13);
            this.HandWidth_lbl.TabIndex = 133;
            this.HandWidth_lbl.Text = "Ancho de la mano:";
            // 
            // ArmLength_lbl
            // 
            this.ArmLength_lbl.AutoSize = true;
            this.ArmLength_lbl.Location = new System.Drawing.Point(12, 197);
            this.ArmLength_lbl.Name = "ArmLength_lbl";
            this.ArmLength_lbl.Size = new System.Drawing.Size(84, 13);
            this.ArmLength_lbl.TabIndex = 134;
            this.ArmLength_lbl.Text = "Largo del Brazo:";
            // 
            // ForeArmCircumference_lbl
            // 
            this.ForeArmCircumference_lbl.AutoSize = true;
            this.ForeArmCircumference_lbl.Location = new System.Drawing.Point(12, 247);
            this.ForeArmCircumference_lbl.Name = "ForeArmCircumference_lbl";
            this.ForeArmCircumference_lbl.Size = new System.Drawing.Size(151, 13);
            this.ForeArmCircumference_lbl.TabIndex = 135;
            this.ForeArmCircumference_lbl.Text = "Circumferencia del Antebrazo: ";
            // 
            // BicepCircumference_lbl
            // 
            this.BicepCircumference_lbl.AutoSize = true;
            this.BicepCircumference_lbl.Location = new System.Drawing.Point(14, 300);
            this.BicepCircumference_lbl.Name = "BicepCircumference_lbl";
            this.BicepCircumference_lbl.Size = new System.Drawing.Size(121, 13);
            this.BicepCircumference_lbl.TabIndex = 136;
            this.BicepCircumference_lbl.Text = "Circumfrencia del Bicep:";
            // 
            // LeftRight_lbl
            // 
            this.LeftRight_lbl.AutoSize = true;
            this.LeftRight_lbl.Location = new System.Drawing.Point(12, 86);
            this.LeftRight_lbl.Name = "LeftRight_lbl";
            this.LeftRight_lbl.Size = new System.Drawing.Size(96, 13);
            this.LeftRight_lbl.TabIndex = 137;
            this.LeftRight_lbl.Text = "Izquierda/Derecha";
            // 
            // crear_btn
            // 
            this.crear_btn.Location = new System.Drawing.Point(236, 420);
            this.crear_btn.Name = "crear_btn";
            this.crear_btn.Size = new System.Drawing.Size(75, 35);
            this.crear_btn.TabIndex = 139;
            this.crear_btn.Text = "Generar";
            this.crear_btn.UseVisualStyleBackColor = true;
            this.crear_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lr_cb
            // 
            this.lr_cb.FormattingEnabled = true;
            this.lr_cb.Location = new System.Drawing.Point(173, 83);
            this.lr_cb.Name = "lr_cb";
            this.lr_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lr_cb.Size = new System.Drawing.Size(70, 21);
            this.lr_cb.TabIndex = 140;
            this.lr_cb.Text = "Izquierda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 141;
            this.button1.Text = "Redenderizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pd_lbl
            // 
            this.pd_lbl.AutoSize = true;
            this.pd_lbl.Location = new System.Drawing.Point(14, 355);
            this.pd_lbl.Name = "pd_lbl";
            this.pd_lbl.Size = new System.Drawing.Size(115, 13);
            this.pd_lbl.TabIndex = 144;
            this.pd_lbl.Text = "Relleno de Antebrazo: ";
            // 
            // pd_nud
            // 
            this.pd_nud.Location = new System.Drawing.Point(587, 353);
            this.pd_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pd_nud.Name = "pd_nud";
            this.pd_nud.Size = new System.Drawing.Size(45, 20);
            this.pd_nud.TabIndex = 143;
            this.pd_nud.ValueChanged += new System.EventHandler(this.pd_nud_ValueChanged);
            // 
            // pd_tb
            // 
            this.pd_tb.LargeChange = 50;
            this.pd_tb.Location = new System.Drawing.Point(173, 353);
            this.pd_tb.Name = "pd_tb";
            this.pd_tb.Size = new System.Drawing.Size(391, 45);
            this.pd_tb.SmallChange = 100;
            this.pd_tb.TabIndex = 142;
            this.pd_tb.ValueChanged += new System.EventHandler(this.pd_tb_ValueChanged);
            // 
            // iniciales_txt
            // 
            this.iniciales_txt.Location = new System.Drawing.Point(173, 28);
            this.iniciales_txt.Name = "iniciales_txt";
            this.iniciales_txt.Size = new System.Drawing.Size(41, 20);
            this.iniciales_txt.TabIndex = 145;
            // 
            // iniciales_lbl
            // 
            this.iniciales_lbl.AutoSize = true;
            this.iniciales_lbl.Location = new System.Drawing.Point(14, 31);
            this.iniciales_lbl.Name = "iniciales_lbl";
            this.iniciales_lbl.Size = new System.Drawing.Size(107, 13);
            this.iniciales_lbl.TabIndex = 146;
            this.iniciales_lbl.Text = "Iniciales del Usuario: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 496);
            this.Controls.Add(this.iniciales_lbl);
            this.Controls.Add(this.iniciales_txt);
            this.Controls.Add(this.pd_lbl);
            this.Controls.Add(this.pd_nud);
            this.Controls.Add(this.pd_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lr_cb);
            this.Controls.Add(this.crear_btn);
            this.Controls.Add(this.LeftRight_lbl);
            this.Controls.Add(this.BicepCircumference_lbl);
            this.Controls.Add(this.ForeArmCircumference_lbl);
            this.Controls.Add(this.ArmLength_lbl);
            this.Controls.Add(this.HandWidth_lbl);
            this.Controls.Add(this.bc_nud);
            this.Controls.Add(this.bc_tb);
            this.Controls.Add(this.fac_nud);
            this.Controls.Add(this.fac_tb);
            this.Controls.Add(this.al_nud);
            this.Controls.Add(this.al_tb);
            this.Controls.Add(this.hw_nud);
            this.Controls.Add(this.hw_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gualab";
            ((System.ComponentModel.ISupportInitialize)(this.hw_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hw_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.al_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.al_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bc_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bc_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fac_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fac_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pd_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pd_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar hw_tb;
        private System.Windows.Forms.NumericUpDown hw_nud;
        private System.Windows.Forms.NumericUpDown al_nud;
        private System.Windows.Forms.TrackBar al_tb;
        private System.Windows.Forms.NumericUpDown bc_nud;
        private System.Windows.Forms.TrackBar bc_tb;
        private System.Windows.Forms.NumericUpDown fac_nud;
        private System.Windows.Forms.TrackBar fac_tb;
        private System.Windows.Forms.Label HandWidth_lbl;
        private System.Windows.Forms.Label ArmLength_lbl;
        private System.Windows.Forms.Label ForeArmCircumference_lbl;
        private System.Windows.Forms.Label BicepCircumference_lbl;
        private System.Windows.Forms.Label LeftRight_lbl;
        private System.Windows.Forms.Button crear_btn;
        private System.Windows.Forms.ComboBox lr_cb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pd_lbl;
        private System.Windows.Forms.NumericUpDown pd_nud;
        private System.Windows.Forms.TrackBar pd_tb;
        private System.Windows.Forms.TextBox iniciales_txt;
        private System.Windows.Forms.Label iniciales_lbl;
    }
}

