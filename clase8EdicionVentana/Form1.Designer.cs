namespace clase8EdicionVentana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btcancelar = new ToolStripButton();
            btguardar = new ToolStripButton();
            bteditar = new ToolStripButton();
            listBox1 = new ListBox();
            txbombre = new TextBox();
            lbnombre = new Label();
            button1 = new Button();
            lberror = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btcancelar, btguardar, bteditar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1009, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btcancelar
            // 
            btcancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btcancelar.Image = (Image)resources.GetObject("btcancelar.Image");
            btcancelar.ImageTransparentColor = Color.Magenta;
            btcancelar.Name = "btcancelar";
            btcancelar.Size = new Size(29, 24);
            btcancelar.Text = "toolStripButton1";
            btcancelar.Click += btcancelar_Click;
            // 
            // btguardar
            // 
            btguardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btguardar.Image = (Image)resources.GetObject("btguardar.Image");
            btguardar.ImageTransparentColor = Color.Magenta;
            btguardar.Name = "btguardar";
            btguardar.Size = new Size(29, 24);
            btguardar.Text = "toolStripButton2";
            btguardar.Click += btguardar_Click;
            // 
            // bteditar
            // 
            bteditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bteditar.Image = (Image)resources.GetObject("bteditar.Image");
            bteditar.ImageTransparentColor = Color.Magenta;
            bteditar.Name = "bteditar";
            bteditar.Size = new Size(29, 24);
            bteditar.Text = "toolStripButton3";
            bteditar.Click += bteditar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 424);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txbombre
            // 
            txbombre.Location = new Point(399, 49);
            txbombre.Name = "txbombre";
            txbombre.Size = new Size(297, 27);
            txbombre.TabIndex = 2;
            txbombre.KeyUp += txbombre_KeyUp;
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnombre.Location = new Point(280, 52);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(107, 25);
            lbnombre.TabIndex = 3;
            lbnombre.Text = "Nombre";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(903, 464);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lberror
            // 
            lberror.AutoSize = true;
            lberror.ForeColor = Color.Red;
            lberror.Location = new Point(729, 53);
            lberror.Name = "lberror";
            lberror.Size = new Size(0, 20);
            lberror.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1009, 535);
            Controls.Add(lberror);
            Controls.Add(button1);
            Controls.Add(lbnombre);
            Controls.Add(txbombre);
            Controls.Add(listBox1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Ventana de participantes";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btcancelar;
        private ToolStripButton btguardar;
        private ToolStripButton bteditar;
        private ListBox listBox1;
        private TextBox txbombre;
        private Label lbnombre;
        private Button button1;
        private Label lberror;
    }
}
