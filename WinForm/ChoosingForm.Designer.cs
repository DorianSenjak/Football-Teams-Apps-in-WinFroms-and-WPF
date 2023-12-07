namespace WinForm
{
    partial class ChoosingForm
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
            lblLang = new Label();
            lblChampionship = new Label();
            cbLang = new ComboBox();
            cbChampionship = new ComboBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Location = new Point(32, 35);
            lblLang.Margin = new Padding(1, 0, 1, 0);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(34, 15);
            lblLang.TabIndex = 0;
            lblLang.Text = "Jezik ";
            // 
            // lblChampionship
            // 
            lblChampionship.AutoSize = true;
            lblChampionship.Location = new Point(32, 110);
            lblChampionship.Margin = new Padding(1, 0, 1, 0);
            lblChampionship.Name = "lblChampionship";
            lblChampionship.Size = new Size(59, 15);
            lblChampionship.TabIndex = 1;
            lblChampionship.Text = "Prvenstvo";
            // 
            // cbLang
            // 
            cbLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLang.FormattingEnabled = true;
            cbLang.Location = new Point(155, 35);
            cbLang.Margin = new Padding(1, 1, 1, 1);
            cbLang.Name = "cbLang";
            cbLang.Size = new Size(130, 23);
            cbLang.TabIndex = 2;
            // 
            // cbChampionship
            // 
            cbChampionship.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChampionship.FormattingEnabled = true;
            cbChampionship.Location = new Point(155, 110);
            cbChampionship.Margin = new Padding(1, 1, 1, 1);
            cbChampionship.Name = "cbChampionship";
            cbChampionship.Size = new Size(130, 23);
            cbChampionship.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(140, 166);
            btnOk.Margin = new Padding(1, 1, 1, 1);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(79, 22);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ChoosingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 223);
            Controls.Add(btnOk);
            Controls.Add(cbChampionship);
            Controls.Add(cbLang);
            Controls.Add(lblChampionship);
            Controls.Add(lblLang);
            Margin = new Padding(1, 1, 1, 1);
            Name = "ChoosingForm";
            Text = "ChoosingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLang;
        private Label lblChampionship;
        private ComboBox cbLang;
        private ComboBox cbChampionship;
        private Button btnOk;
    }
}