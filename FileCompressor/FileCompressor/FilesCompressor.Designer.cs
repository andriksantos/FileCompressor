namespace FileCompressor
{
    partial class FIleCompressor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIleCompressor));
            this.MoverFileCompressor = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.RedondearFIleCompressor = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Maximized = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Minimized = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ShadowFIleCompressor = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PanelTitulo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MoverTitulo = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Extraction = new System.Windows.Forms.TabPage();
            this.Compression = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTitulo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Extraction.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoverFileCompressor
            // 
            this.MoverFileCompressor.TargetControl = this;
            // 
            // RedondearFIleCompressor
            // 
            this.RedondearFIleCompressor.TargetControl = this;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(454, 0);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(45, 29);
            this.Exit.TabIndex = 0;
            // 
            // Maximized
            // 
            this.Maximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximized.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.Maximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximized.Enabled = false;
            this.Maximized.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Maximized.HoverState.Parent = this.Maximized;
            this.Maximized.IconColor = System.Drawing.Color.White;
            this.Maximized.Location = new System.Drawing.Point(409, 0);
            this.Maximized.Name = "Maximized";
            this.Maximized.ShadowDecoration.Parent = this.Maximized;
            this.Maximized.Size = new System.Drawing.Size(45, 29);
            this.Maximized.TabIndex = 1;
            // 
            // Minimized
            // 
            this.Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimized.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Minimized.HoverState.Parent = this.Minimized;
            this.Minimized.IconColor = System.Drawing.Color.White;
            this.Minimized.Location = new System.Drawing.Point(364, 0);
            this.Minimized.Name = "Minimized";
            this.Minimized.ShadowDecoration.Parent = this.Minimized;
            this.Minimized.Size = new System.Drawing.Size(45, 29);
            this.Minimized.TabIndex = 2;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.PanelTitulo.Controls.Add(this.guna2HtmlLabel1);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.FillColor = System.Drawing.Color.White;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.ShadowColor = System.Drawing.Color.Black;
            this.PanelTitulo.ShadowShift = 2;
            this.PanelTitulo.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.PanelTitulo.Size = new System.Drawing.Size(500, 50);
            this.PanelTitulo.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Enabled = false;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(133, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "File Compressor";
            // 
            // MoverTitulo
            // 
            this.MoverTitulo.TargetControl = this.PanelTitulo;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Extraction);
            this.tabControl1.Controls.Add(this.Compression);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(247, 28);
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 250);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // Extraction
            // 
            this.Extraction.Controls.Add(this.guna2GroupBox1);
            this.Extraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Extraction.Location = new System.Drawing.Point(4, 32);
            this.Extraction.Name = "Extraction";
            this.Extraction.Padding = new System.Windows.Forms.Padding(3);
            this.Extraction.Size = new System.Drawing.Size(492, 214);
            this.Extraction.TabIndex = 0;
            this.Extraction.Text = "Extraction";
            this.Extraction.UseVisualStyleBackColor = true;
            // 
            // Compression
            // 
            this.Compression.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Compression.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Compression.Location = new System.Drawing.Point(4, 32);
            this.Compression.Name = "Compression";
            this.Compression.Padding = new System.Windows.Forms.Padding(3);
            this.Compression.Size = new System.Drawing.Size(492, 214);
            this.Compression.TabIndex = 1;
            this.Compression.Text = "Compression";
            this.Compression.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2Button3);
            this.guna2GroupBox1.Controls.Add(this.guna2Button2);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox2);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(8, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(478, 205);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Extraction";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Enabled = false;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 65);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(94, 16);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Output directory";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Enabled = false;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Raleway", 9F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 112);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 16);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Archive file name";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(122, 60);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(310, 25);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 6;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(122, 107);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(310, 25);
            this.guna2TextBox2.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(438, 60);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(25, 25);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(438, 107);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(25, 25);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 6;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2Button3.Font = new System.Drawing.Font("Raleway", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(175, 158);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(115, 32);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "Extraction";
            // 
            // FIleCompressor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.Maximized);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FIleCompressor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIleCompressor";
            this.Load += new System.EventHandler(this.FIleCompressor_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Extraction.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl MoverFileCompressor;
        private Guna.UI2.WinForms.Guna2Elipse RedondearFIleCompressor;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2ControlBox Minimized;
        private Guna.UI2.WinForms.Guna2ControlBox Maximized;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowFIleCompressor;
        private Guna.UI2.WinForms.Guna2ShadowPanel PanelTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DragControl MoverTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Extraction;
        private System.Windows.Forms.TabPage Compression;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}

