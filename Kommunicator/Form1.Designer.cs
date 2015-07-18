namespace Kommunicator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.frenchText = new System.Windows.Forms.TextBox();
            this.strangeText = new System.Windows.Forms.TextBox();
            this.frenchLabel = new System.Windows.Forms.Label();
            this.strangeLabel = new System.Windows.Forms.Label();
            this.toStrange = new System.Windows.Forms.Button();
            this.toFrench = new System.Windows.Forms.Button();
            this.copyAuto = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // frenchText
            // 
            this.frenchText.Location = new System.Drawing.Point(13, 39);
            this.frenchText.Multiline = true;
            this.frenchText.Name = "frenchText";
            this.frenchText.Size = new System.Drawing.Size(697, 115);
            this.frenchText.TabIndex = 0;
            // 
            // strangeText
            // 
            this.strangeText.Location = new System.Drawing.Point(14, 230);
            this.strangeText.Multiline = true;
            this.strangeText.Name = "strangeText";
            this.strangeText.Size = new System.Drawing.Size(696, 117);
            this.strangeText.TabIndex = 1;
            // 
            // frenchLabel
            // 
            this.frenchLabel.AutoSize = true;
            this.frenchLabel.Location = new System.Drawing.Point(14, 23);
            this.frenchLabel.Name = "frenchLabel";
            this.frenchLabel.Size = new System.Drawing.Size(89, 13);
            this.frenchLabel.TabIndex = 2;
            this.frenchLabel.Text = "Texte en français";
            // 
            // strangeLabel
            // 
            this.strangeLabel.AutoSize = true;
            this.strangeLabel.Location = new System.Drawing.Point(14, 211);
            this.strangeLabel.Name = "strangeLabel";
            this.strangeLabel.Size = new System.Drawing.Size(99, 13);
            this.strangeLabel.TabIndex = 3;
            this.strangeLabel.Text = "Texte en DeguiTon";
            // 
            // toStrange
            // 
            this.toStrange.Location = new System.Drawing.Point(189, 177);
            this.toStrange.Name = "toStrange";
            this.toStrange.Size = new System.Drawing.Size(166, 25);
            this.toStrange.TabIndex = 4;
            this.toStrange.Text = "Traduire en DeguiTon";
            this.toStrange.UseVisualStyleBackColor = true;
            this.toStrange.Click += new System.EventHandler(this.toStrange_Click);
            // 
            // toFrench
            // 
            this.toFrench.Location = new System.Drawing.Point(377, 177);
            this.toFrench.Name = "toFrench";
            this.toFrench.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toFrench.Size = new System.Drawing.Size(144, 25);
            this.toFrench.TabIndex = 5;
            this.toFrench.Text = "Traduire en Français";
            this.toFrench.UseVisualStyleBackColor = true;
            this.toFrench.Click += new System.EventHandler(this.toFrench_Click);
            // 
            // copyAuto
            // 
            this.copyAuto.AutoSize = true;
            this.copyAuto.Location = new System.Drawing.Point(204, 207);
            this.copyAuto.Name = "copyAuto";
            this.copyAuto.Size = new System.Drawing.Size(304, 17);
            this.copyAuto.TabIndex = 6;
            this.copyAuto.Text = "Copier la traduction dans le presse-papier automatiquement";
            this.copyAuto.UseVisualStyleBackColor = true;
            this.copyAuto.CheckedChanged += new System.EventHandler(this.copyAuto_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Traduction hard";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 359);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.copyAuto);
            this.Controls.Add(this.toFrench);
            this.Controls.Add(this.toStrange);
            this.Controls.Add(this.strangeLabel);
            this.Controls.Add(this.frenchLabel);
            this.Controls.Add(this.strangeText);
            this.Controls.Add(this.frenchText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kommunicator V1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frenchText;
        private System.Windows.Forms.TextBox strangeText;
        private System.Windows.Forms.Label frenchLabel;
        private System.Windows.Forms.Label strangeLabel;
        private System.Windows.Forms.Button toStrange;
        private System.Windows.Forms.Button toFrench;
        private System.Windows.Forms.CheckBox copyAuto;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

