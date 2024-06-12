namespace Evaluacion1_Jenifer
{
    partial class Login
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
            this.Usuario = new MaterialSkin.Controls.MaterialTextBox();
            this.IngresarGestion = new MaterialSkin.Controls.MaterialButton();
            this.txtContrasennia = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AnimateReadOnly = false;
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Depth = 0;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Usuario.Hint = "Ingrese su usuario";
            this.Usuario.LeadingIcon = null;
            this.Usuario.Location = new System.Drawing.Point(189, 250);
            this.Usuario.MaxLength = 50;
            this.Usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.Usuario.Multiline = false;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(328, 50);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "";
            this.Usuario.TrailingIcon = null;
            // 
            // IngresarGestion
            // 
            this.IngresarGestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IngresarGestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.IngresarGestion.Depth = 0;
            this.IngresarGestion.HighEmphasis = true;
            this.IngresarGestion.Icon = null;
            this.IngresarGestion.Location = new System.Drawing.Point(302, 398);
            this.IngresarGestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IngresarGestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.IngresarGestion.Name = "IngresarGestion";
            this.IngresarGestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.IngresarGestion.Size = new System.Drawing.Size(91, 36);
            this.IngresarGestion.TabIndex = 2;
            this.IngresarGestion.Text = "Ingresar";
            this.IngresarGestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.IngresarGestion.UseAccentColor = false;
            this.IngresarGestion.UseVisualStyleBackColor = true;
            this.IngresarGestion.Click += new System.EventHandler(this.IngresarGestion_Click);
            // 
            // txtContrasennia
            // 
            this.txtContrasennia.AllowPromptAsInput = true;
            this.txtContrasennia.AnimateReadOnly = false;
            this.txtContrasennia.AsciiOnly = false;
            this.txtContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasennia.BeepOnError = false;
            this.txtContrasennia.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasennia.Depth = 0;
            this.txtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasennia.HidePromptOnLeave = false;
            this.txtContrasennia.HideSelection = true;
            this.txtContrasennia.Hint = "Contraseña";
            this.txtContrasennia.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtContrasennia.LeadingIcon = null;
            this.txtContrasennia.Location = new System.Drawing.Point(189, 321);
            this.txtContrasennia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContrasennia.Mask = "";
            this.txtContrasennia.MaxLength = 32767;
            this.txtContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasennia.Name = "txtContrasennia";
            this.txtContrasennia.PasswordChar = '*';
            this.txtContrasennia.PrefixSuffixText = null;
            this.txtContrasennia.PromptChar = '_';
            this.txtContrasennia.ReadOnly = false;
            this.txtContrasennia.RejectInputOnFirstFailure = false;
            this.txtContrasennia.ResetOnPrompt = true;
            this.txtContrasennia.ResetOnSpace = true;
            this.txtContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasennia.SelectedText = "";
            this.txtContrasennia.SelectionLength = 0;
            this.txtContrasennia.SelectionStart = 0;
            this.txtContrasennia.ShortcutsEnabled = true;
            this.txtContrasennia.Size = new System.Drawing.Size(328, 48);
            this.txtContrasennia.SkipLiterals = true;
            this.txtContrasennia.TabIndex = 4;
            this.txtContrasennia.TabStop = false;
            this.txtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasennia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasennia.TrailingIcon = null;
            this.txtContrasennia.UseSystemPasswordChar = false;
            this.txtContrasennia.ValidatingType = null;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Evaluacion1_Jenifer.Properties.Resources.icons8_grupo_de_usuario_100;
            this.panel1.Location = new System.Drawing.Point(302, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 97);
            this.panel1.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 487);
            this.Controls.Add(this.txtContrasennia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IngresarGestion);
            this.Controls.Add(this.Usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox Usuario;
        private MaterialSkin.Controls.MaterialButton IngresarGestion;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContrasennia;
    }
}

