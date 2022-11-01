namespace WindowsFormsApp1
{
    partial class InfoForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SymbolLabel = new System.Windows.Forms.Label();
            this.AtomicNumberLabel = new System.Windows.Forms.Label();
            this.AtomicMassLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DiscoverHolderLabel = new System.Windows.Forms.Label();
            this.DiscoverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(283, 47);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "fasdfasdfasdfa";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SymbolLabel
            // 
            this.SymbolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolLabel.Location = new System.Drawing.Point(301, 36);
            this.SymbolLabel.Name = "SymbolLabel";
            this.SymbolLabel.Size = new System.Drawing.Size(84, 47);
            this.SymbolLabel.TabIndex = 1;
            this.SymbolLabel.Text = "H";
            this.SymbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AtomicNumberLabel
            // 
            this.AtomicNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AtomicNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AtomicNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtomicNumberLabel.Location = new System.Drawing.Point(12, 132);
            this.AtomicNumberLabel.Name = "AtomicNumberLabel";
            this.AtomicNumberLabel.Size = new System.Drawing.Size(373, 47);
            this.AtomicNumberLabel.TabIndex = 2;
            this.AtomicNumberLabel.Text = "Atomic Number: ";
            this.AtomicNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtomicNumberLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // AtomicMassLabel
            // 
            this.AtomicMassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AtomicMassLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AtomicMassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtomicMassLabel.Location = new System.Drawing.Point(12, 179);
            this.AtomicMassLabel.Name = "AtomicMassLabel";
            this.AtomicMassLabel.Size = new System.Drawing.Size(373, 47);
            this.AtomicMassLabel.TabIndex = 3;
            this.AtomicMassLabel.Text = "Atomic Mass:";
            this.AtomicMassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(12, 226);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(373, 47);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category: ";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiscoverHolderLabel
            // 
            this.DiscoverHolderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscoverHolderLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DiscoverHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscoverHolderLabel.Location = new System.Drawing.Point(12, 273);
            this.DiscoverHolderLabel.Name = "DiscoverHolderLabel";
            this.DiscoverHolderLabel.Size = new System.Drawing.Size(373, 79);
            this.DiscoverHolderLabel.TabIndex = 5;
            this.DiscoverHolderLabel.Text = "Discovered by:";
            this.DiscoverHolderLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // DiscoverLabel
            // 
            this.DiscoverLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DiscoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscoverLabel.Location = new System.Drawing.Point(23, 313);
            this.DiscoverLabel.Name = "DiscoverLabel";
            this.DiscoverLabel.Size = new System.Drawing.Size(350, 31);
            this.DiscoverLabel.TabIndex = 6;
            this.DiscoverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiscoverLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 369);
            this.Controls.Add(this.DiscoverLabel);
            this.Controls.Add(this.DiscoverHolderLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.AtomicMassLabel);
            this.Controls.Add(this.AtomicNumberLabel);
            this.Controls.Add(this.SymbolLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SymbolLabel;
        private System.Windows.Forms.Label AtomicNumberLabel;
        private System.Windows.Forms.Label AtomicMassLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label DiscoverHolderLabel;
        private System.Windows.Forms.Label DiscoverLabel;
    }
}