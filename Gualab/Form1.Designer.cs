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
            this.lr_dud = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hw_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hw_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bc_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bc_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fac_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fac_tb)).BeginInit();
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
            this.al_nud.Location = new System.Drawing.Point(587, 210);
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
            this.al_tb.Location = new System.Drawing.Point(173, 210);
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
            this.bc_nud.Location = new System.Drawing.Point(587, 336);
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
            this.bc_tb.Location = new System.Drawing.Point(173, 336);
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
            this.fac_nud.Location = new System.Drawing.Point(587, 270);
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
            this.fac_tb.Location = new System.Drawing.Point(173, 270);
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
            this.ArmLength_lbl.Location = new System.Drawing.Point(12, 212);
            this.ArmLength_lbl.Name = "ArmLength_lbl";
            this.ArmLength_lbl.Size = new System.Drawing.Size(84, 13);
            this.ArmLength_lbl.TabIndex = 134;
            this.ArmLength_lbl.Text = "Largo del Brazo:";
            // 
            // ForeArmCircumference_lbl
            // 
            this.ForeArmCircumference_lbl.AutoSize = true;
            this.ForeArmCircumference_lbl.Location = new System.Drawing.Point(12, 272);
            this.ForeArmCircumference_lbl.Name = "ForeArmCircumference_lbl";
            this.ForeArmCircumference_lbl.Size = new System.Drawing.Size(151, 13);
            this.ForeArmCircumference_lbl.TabIndex = 135;
            this.ForeArmCircumference_lbl.Text = "Circumferencia del Antebrazo: ";
            // 
            // BicepCircumference_lbl
            // 
            this.BicepCircumference_lbl.AutoSize = true;
            this.BicepCircumference_lbl.Location = new System.Drawing.Point(14, 338);
            this.BicepCircumference_lbl.Name = "BicepCircumference_lbl";
            this.BicepCircumference_lbl.Size = new System.Drawing.Size(121, 13);
            this.BicepCircumference_lbl.TabIndex = 136;
            this.BicepCircumference_lbl.Text = "Circumfrencia del Bicep:";
            // 
            // LeftRight_lbl
            // 
            this.LeftRight_lbl.AutoSize = true;
            this.LeftRight_lbl.Location = new System.Drawing.Point(17, 86);
            this.LeftRight_lbl.Name = "LeftRight_lbl";
            this.LeftRight_lbl.Size = new System.Drawing.Size(96, 13);
            this.LeftRight_lbl.TabIndex = 137;
            this.LeftRight_lbl.Text = "Izquierda/Derecha";
            // 
            // lr_dud
            // 
            this.lr_dud.BackColor = System.Drawing.SystemColors.Window;
            this.lr_dud.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lr_dud.Location = new System.Drawing.Point(173, 86);
            this.lr_dud.Name = "lr_dud";
            this.lr_dud.Size = new System.Drawing.Size(93, 20);
            this.lr_dud.TabIndex = 138;
            this.lr_dud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lr_dud);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DomainUpDown lr_dud;
    }
}

