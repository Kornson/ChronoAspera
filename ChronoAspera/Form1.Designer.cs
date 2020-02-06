namespace ChronoAspera
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
            this.components = new System.ComponentModel.Container();
            this.cStart = new System.Windows.Forms.Button();
            this.sChrono = new System.Windows.Forms.Button();
            this.labelChrono = new System.Windows.Forms.Label();
            this.chronoTimer = new System.Windows.Forms.Timer(this.components);
            this.rChono = new System.Windows.Forms.Button();
            this.labelAction = new System.Windows.Forms.Label();
            this.comboBoxActions = new System.Windows.Forms.ComboBox();
            this.labelAddAction = new System.Windows.Forms.Label();
            this.textBoxAddAction = new System.Windows.Forms.TextBox();
            this.buttonAddAction = new System.Windows.Forms.Button();
            this.SaveAction = new System.Windows.Forms.Button();
            this.saveFileDialogAction = new System.Windows.Forms.SaveFileDialog();
            this.saveActionTextbox = new System.Windows.Forms.TextBox();
            this.updateAction = new System.Windows.Forms.Button();
            this.labelListAction = new System.Windows.Forms.Label();
            this.textBoxListAction = new System.Windows.Forms.TextBox();
            this.importSaveAction = new System.Windows.Forms.Button();
            this.openFileDialogImportAction = new System.Windows.Forms.OpenFileDialog();
            this.delAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cStart
            // 
            this.cStart.Location = new System.Drawing.Point(77, 287);
            this.cStart.Name = "cStart";
            this.cStart.Size = new System.Drawing.Size(75, 37);
            this.cStart.TabIndex = 1;
            this.cStart.Text = "Start";
            this.cStart.UseVisualStyleBackColor = true;
            this.cStart.Click += new System.EventHandler(this.cStart_Click);
            // 
            // sChrono
            // 
            this.sChrono.Location = new System.Drawing.Point(241, 287);
            this.sChrono.Name = "sChrono";
            this.sChrono.Size = new System.Drawing.Size(75, 37);
            this.sChrono.TabIndex = 2;
            this.sChrono.Text = "Stop";
            this.sChrono.UseVisualStyleBackColor = true;
            this.sChrono.Click += new System.EventHandler(this.sChrono_Click);
            // 
            // labelChrono
            // 
            this.labelChrono.AutoSize = true;
            this.labelChrono.Location = new System.Drawing.Point(152, 195);
            this.labelChrono.Name = "labelChrono";
            this.labelChrono.Size = new System.Drawing.Size(90, 17);
            this.labelChrono.TabIndex = 3;
            this.labelChrono.Text = "Chronométre";
            // 
            // rChono
            // 
            this.rChono.Location = new System.Drawing.Point(155, 345);
            this.rChono.Name = "rChono";
            this.rChono.Size = new System.Drawing.Size(87, 30);
            this.rChono.TabIndex = 4;
            this.rChono.Text = "Reset";
            this.rChono.UseVisualStyleBackColor = true;
            this.rChono.Click += new System.EventHandler(this.rChono_Click);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(56, 39);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(55, 17);
            this.labelAction.TabIndex = 5;
            this.labelAction.Text = "Action :";
            // 
            // comboBoxActions
            // 
            this.comboBoxActions.FormattingEnabled = true;
            this.comboBoxActions.Location = new System.Drawing.Point(137, 39);
            this.comboBoxActions.Name = "comboBoxActions";
            this.comboBoxActions.Size = new System.Drawing.Size(121, 24);
            this.comboBoxActions.TabIndex = 6;
            // 
            // labelAddAction
            // 
            this.labelAddAction.AutoSize = true;
            this.labelAddAction.Location = new System.Drawing.Point(322, 39);
            this.labelAddAction.Name = "labelAddAction";
            this.labelAddAction.Size = new System.Drawing.Size(131, 17);
            this.labelAddAction.TabIndex = 7;
            this.labelAddAction.Text = "Ajouter une action :";
            // 
            // textBoxAddAction
            // 
            this.textBoxAddAction.Location = new System.Drawing.Point(460, 39);
            this.textBoxAddAction.Name = "textBoxAddAction";
            this.textBoxAddAction.Size = new System.Drawing.Size(131, 22);
            this.textBoxAddAction.TabIndex = 8;
            // 
            // buttonAddAction
            // 
            this.buttonAddAction.Location = new System.Drawing.Point(598, 37);
            this.buttonAddAction.Name = "buttonAddAction";
            this.buttonAddAction.Size = new System.Drawing.Size(75, 26);
            this.buttonAddAction.TabIndex = 9;
            this.buttonAddAction.Text = "Ajouter";
            this.buttonAddAction.UseVisualStyleBackColor = true;
            this.buttonAddAction.Click += new System.EventHandler(this.buttonAddAction_Click);
            // 
            // SaveAction
            // 
            this.SaveAction.Location = new System.Drawing.Point(419, 232);
            this.SaveAction.Name = "SaveAction";
            this.SaveAction.Size = new System.Drawing.Size(110, 59);
            this.SaveAction.TabIndex = 10;
            this.SaveAction.Text = "Creer Sauvegarde";
            this.SaveAction.UseVisualStyleBackColor = true;
            this.SaveAction.Click += new System.EventHandler(this.SaveAction_Click);
            // 
            // saveActionTextbox
            // 
            this.saveActionTextbox.Location = new System.Drawing.Point(419, 138);
            this.saveActionTextbox.Name = "saveActionTextbox";
            this.saveActionTextbox.Size = new System.Drawing.Size(254, 22);
            this.saveActionTextbox.TabIndex = 11;
            // 
            // updateAction
            // 
            this.updateAction.Location = new System.Drawing.Point(550, 232);
            this.updateAction.Name = "updateAction";
            this.updateAction.Size = new System.Drawing.Size(123, 59);
            this.updateAction.TabIndex = 12;
            this.updateAction.Text = "Mettre à jour";
            this.updateAction.UseVisualStyleBackColor = true;
            this.updateAction.Click += new System.EventHandler(this.updateAction_Click);
            // 
            // labelListAction
            // 
            this.labelListAction.AutoSize = true;
            this.labelListAction.Location = new System.Drawing.Point(419, 345);
            this.labelListAction.Name = "labelListAction";
            this.labelListAction.Size = new System.Drawing.Size(0, 17);
            this.labelListAction.TabIndex = 13;
            // 
            // textBoxListAction
            // 
            this.textBoxListAction.AcceptsReturn = true;
            this.textBoxListAction.Location = new System.Drawing.Point(419, 349);
            this.textBoxListAction.Multiline = true;
            this.textBoxListAction.Name = "textBoxListAction";
            this.textBoxListAction.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxListAction.Size = new System.Drawing.Size(251, 188);
            this.textBoxListAction.TabIndex = 14;
            this.textBoxListAction.WordWrap = false;
            // 
            // importSaveAction
            // 
            this.importSaveAction.Location = new System.Drawing.Point(419, 166);
            this.importSaveAction.Name = "importSaveAction";
            this.importSaveAction.Size = new System.Drawing.Size(110, 48);
            this.importSaveAction.TabIndex = 15;
            this.importSaveAction.Text = "Importer actions client";
            this.importSaveAction.UseVisualStyleBackColor = true;
            this.importSaveAction.Click += new System.EventHandler(this.importSaveAction_Click);
            // 
            // openFileDialogImportAction
            // 
            this.openFileDialogImportAction.FileName = "openFileDialog1";
            // 
            // delAction
            // 
            this.delAction.Location = new System.Drawing.Point(490, 559);
            this.delAction.Name = "delAction";
            this.delAction.Size = new System.Drawing.Size(110, 42);
            this.delAction.TabIndex = 16;
            this.delAction.Text = "Supprimer Action";
            this.delAction.UseVisualStyleBackColor = true;
            this.delAction.Click += new System.EventHandler(this.delAction_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1119, 783);
            this.Controls.Add(this.delAction);
            this.Controls.Add(this.importSaveAction);
            this.Controls.Add(this.textBoxListAction);
            this.Controls.Add(this.labelListAction);
            this.Controls.Add(this.updateAction);
            this.Controls.Add(this.saveActionTextbox);
            this.Controls.Add(this.SaveAction);
            this.Controls.Add(this.buttonAddAction);
            this.Controls.Add(this.textBoxAddAction);
            this.Controls.Add(this.labelAddAction);
            this.Controls.Add(this.comboBoxActions);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.rChono);
            this.Controls.Add(this.labelChrono);
            this.Controls.Add(this.sChrono);
            this.Controls.Add(this.cStart);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cStart;
        private System.Windows.Forms.Button sChrono;
        private System.Windows.Forms.Label labelChrono;
        private System.Windows.Forms.Timer chronoTimer;
        private System.Windows.Forms.Button rChono;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.ComboBox comboBoxActions;
        private System.Windows.Forms.Label labelAddAction;
        private System.Windows.Forms.TextBox textBoxAddAction;
        private System.Windows.Forms.Button buttonAddAction;
        private System.Windows.Forms.Button SaveAction;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAction;
        private System.Windows.Forms.TextBox saveActionTextbox;
        private System.Windows.Forms.Button updateAction;
        private System.Windows.Forms.Label labelListAction;
        private System.Windows.Forms.TextBox textBoxListAction;
        private System.Windows.Forms.Button importSaveAction;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportAction;
        private System.Windows.Forms.Button delAction;
    }
}

