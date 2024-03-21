namespace Phonebook
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
            label1 = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            btnInserisci = new Button();
            btnCerca = new Button();
            btnCancella = new Button();
            lvAgenda = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(94, 91);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(185, 23);
            txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Cognome";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(94, 147);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(185, 23);
            txtTelefono.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // btnInserisci
            // 
            btnInserisci.Location = new Point(12, 205);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(83, 41);
            btnInserisci.TabIndex = 6;
            btnInserisci.Text = "INSERISCI";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(105, 205);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(83, 41);
            btnCerca.TabIndex = 7;
            btnCerca.Text = "CERCA";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(196, 205);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(83, 41);
            btnCancella.TabIndex = 8;
            btnCancella.Text = "CANCELLA";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // lvAgenda
            // 
            lvAgenda.Location = new Point(298, 12);
            lvAgenda.Name = "lvAgenda";
            lvAgenda.Size = new Size(374, 386);
            lvAgenda.TabIndex = 9;
            lvAgenda.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 410);
            Controls.Add(lvAgenda);
            Controls.Add(btnCancella);
            Controls.Add(btnCerca);
            Controls.Add(btnInserisci);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtCognome);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private Button btnInserisci;
        private Button btnCerca;
        private Button btnCancella;
        private ListView lvAgenda;
    }
}
