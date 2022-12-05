namespace Hlidac_Winforms {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnHlidej = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbCheckCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbInterval = new System.Windows.Forms.Label();
            this.nudMinuty = new System.Windows.Forms.NumericUpDown();
            this.lbMinuty = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuty)).BeginInit();
            this.SuspendLayout();
            // 
            // casovac
            // 
            this.casovac.Interval = 10000;
            this.casovac.Tick += new System.EventHandler(this.casovac_Tick);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(83, 33);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(145, 23);
            this.tbAdresa.TabIndex = 0;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(33, 36);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(44, 15);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "E-mail:";
            // 
            // btnHlidej
            // 
            this.btnHlidej.Location = new System.Drawing.Point(33, 109);
            this.btnHlidej.Name = "btnHlidej";
            this.btnHlidej.Size = new System.Drawing.Size(260, 23);
            this.btnHlidej.TabIndex = 2;
            this.btnHlidej.Text = "Hlídej a minimalizuj do oznamovací oblasti";
            this.btnHlidej.UseVisualStyleBackColor = true;
            this.btnHlidej.Click += new System.EventHandler(this.btnHlidej_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCheckCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 153);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(453, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbCheckCount
            // 
            this.lbCheckCount.Name = "lbCheckCount";
            this.lbCheckCount.Size = new System.Drawing.Size(125, 17);
            this.lbCheckCount.Text = "Zatím nekontrolováno";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Schováno, hlídám";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(33, 73);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(46, 15);
            this.lbInterval.TabIndex = 4;
            this.lbInterval.Text = "Interval";
            // 
            // nudMinuty
            // 
            this.nudMinuty.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinuty.Location = new System.Drawing.Point(83, 71);
            this.nudMinuty.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudMinuty.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinuty.Name = "nudMinuty";
            this.nudMinuty.Size = new System.Drawing.Size(59, 23);
            this.nudMinuty.TabIndex = 5;
            this.nudMinuty.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbMinuty
            // 
            this.lbMinuty.AutoSize = true;
            this.lbMinuty.Location = new System.Drawing.Point(148, 73);
            this.lbMinuty.Name = "lbMinuty";
            this.lbMinuty.Size = new System.Drawing.Size(39, 15);
            this.lbMinuty.TabIndex = 6;
            this.lbMinuty.Text = "minut";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 175);
            this.Controls.Add(this.lbMinuty);
            this.Controls.Add(this.nudMinuty);
            this.Controls.Add(this.lbInterval);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnHlidej);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbAdresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hlídací zub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer casovac;
        private TextBox tbAdresa;
        private Label lbEmail;
        private Button btnHlidej;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lbCheckCount;
        private NotifyIcon notifyIcon;
        private Label lbInterval;
        private NumericUpDown nudMinuty;
        private Label lbMinuty;
    }
}