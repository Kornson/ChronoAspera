namespace ChronoAspera
{
    partial class Form2
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
            this.actionCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.delActionButtonForm2 = new System.Windows.Forms.Button();
            this.cancelButtonForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionCheckedListBox1
            // 
            this.actionCheckedListBox1.FormattingEnabled = true;
            this.actionCheckedListBox1.Location = new System.Drawing.Point(233, 41);
            this.actionCheckedListBox1.Name = "actionCheckedListBox1";
            this.actionCheckedListBox1.Size = new System.Drawing.Size(324, 208);
            this.actionCheckedListBox1.TabIndex = 0;
            // 
            // delActionButtonForm2
            // 
            this.delActionButtonForm2.Location = new System.Drawing.Point(249, 266);
            this.delActionButtonForm2.Name = "delActionButtonForm2";
            this.delActionButtonForm2.Size = new System.Drawing.Size(120, 40);
            this.delActionButtonForm2.TabIndex = 1;
            this.delActionButtonForm2.Text = "Supprimer";
            this.delActionButtonForm2.UseVisualStyleBackColor = true;
            this.delActionButtonForm2.Click += new System.EventHandler(this.delActionButtonForm2_Click);
            // 
            // cancelButtonForm2
            // 
            this.cancelButtonForm2.Location = new System.Drawing.Point(419, 266);
            this.cancelButtonForm2.Name = "cancelButtonForm2";
            this.cancelButtonForm2.Size = new System.Drawing.Size(120, 40);
            this.cancelButtonForm2.TabIndex = 2;
            this.cancelButtonForm2.Text = "Annuler";
            this.cancelButtonForm2.UseVisualStyleBackColor = true;
            this.cancelButtonForm2.Click += new System.EventHandler(this.cancelButtonForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButtonForm2);
            this.Controls.Add(this.delActionButtonForm2);
            this.Controls.Add(this.actionCheckedListBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox actionCheckedListBox1;
        private System.Windows.Forms.Button delActionButtonForm2;
        private System.Windows.Forms.Button cancelButtonForm2;
    }
}