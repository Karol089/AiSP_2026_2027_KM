namespace Zajecia_09_10_2026
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
            tbLiczby = new TextBox();
            lbLiczby = new Label();
            cbMetodaSortowania = new ComboBox();
            btSortuj = new Button();
            tbWynik = new TextBox();
            lbWynik = new Label();
            lbRodzajSortowania = new Label();
            SuspendLayout();
            // 
            // tbLiczby
            // 
            tbLiczby.Location = new Point(239, 56);
            tbLiczby.Name = "tbLiczby";
            tbLiczby.Size = new Size(207, 23);
            tbLiczby.TabIndex = 0;
            tbLiczby.Tag = "tdLiczby";
            // 
            // lbLiczby
            // 
            lbLiczby.AutoSize = true;
            lbLiczby.Location = new Point(183, 61);
            lbLiczby.Name = "lbLiczby";
            lbLiczby.Size = new Size(40, 15);
            lbLiczby.TabIndex = 1;
            lbLiczby.Tag = "lbLiczby";
            lbLiczby.Text = "Liczby";
            // 
            // cbMetodaSortowania
            // 
            cbMetodaSortowania.FormattingEnabled = true;
            cbMetodaSortowania.Location = new Point(531, 56);
            cbMetodaSortowania.Name = "cbMetodaSortowania";
            cbMetodaSortowania.Size = new Size(194, 23);
            cbMetodaSortowania.TabIndex = 2;
            cbMetodaSortowania.Tag = "cbMetodaSortowania";
            cbMetodaSortowania.SelectedIndexChanged += cbMetodaSortowania_SelectedIndexChanged;
            // 
            // btSortuj
            // 
            btSortuj.ForeColor = SystemColors.InfoText;
            btSortuj.Location = new Point(576, 182);
            btSortuj.Name = "btSortuj";
            btSortuj.Size = new Size(75, 23);
            btSortuj.TabIndex = 3;
            btSortuj.Tag = "btSortuj";
            btSortuj.Text = "Sortuj";
            btSortuj.UseVisualStyleBackColor = true;
            btSortuj.Click += button1_Click;
            // 
            // tbWynik
            // 
            tbWynik.Location = new Point(239, 182);
            tbWynik.Name = "tbWynik";
            tbWynik.Size = new Size(207, 23);
            tbWynik.TabIndex = 4;
            tbWynik.Tag = "tdWynik";
            // 
            // lbWynik
            // 
            lbWynik.AutoSize = true;
            lbWynik.Location = new Point(183, 186);
            lbWynik.Name = "lbWynik";
            lbWynik.Size = new Size(40, 15);
            lbWynik.TabIndex = 5;
            lbWynik.Tag = "lbWynik";
            lbWynik.Text = "Wynik";
            // 
            // lbRodzajSortowania
            // 
            lbRodzajSortowania.AutoSize = true;
            lbRodzajSortowania.Location = new Point(576, 26);
            lbRodzajSortowania.Name = "lbRodzajSortowania";
            lbRodzajSortowania.Size = new Size(104, 15);
            lbRodzajSortowania.TabIndex = 6;
            lbRodzajSortowania.Text = "Rodzaj Sortowania";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRodzajSortowania);
            Controls.Add(lbWynik);
            Controls.Add(tbWynik);
            Controls.Add(btSortuj);
            Controls.Add(cbMetodaSortowania);
            Controls.Add(lbLiczby);
            Controls.Add(tbLiczby);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLiczby;
        private Label lbLiczby;
        private ComboBox cbMetodaSortowania;
        private Button btSortuj;
        private TextBox tbWynik;
        private Label lbWynik;
        private Label lbRodzajSortowania;
    }
}
