namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categories = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fermer = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.AutoSize = true;
            this.categories.Location = new System.Drawing.Point(40, 37);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(147, 32);
            this.categories.TabIndex = 2;
            this.categories.Text = "categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(711, 790);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 928);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "statut :";
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fermer.Location = new System.Drawing.Point(862, 714);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(243, 70);
            this.fermer.TabIndex = 7;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ajouter.Location = new System.Drawing.Point(862, 424);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(243, 72);
            this.ajouter.TabIndex = 4;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(862, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modifier.Location = new System.Drawing.Point(862, 567);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(243, 70);
            this.modifier.TabIndex = 9;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 977);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.categories);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label categories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button modifier;
    }
}

