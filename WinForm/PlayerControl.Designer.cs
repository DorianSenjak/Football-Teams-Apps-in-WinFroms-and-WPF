namespace WinForm
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerControl));
            pictureBox1 = new PictureBox();
            lblPlayerName = new Label();
            lblPosition = new Label();
            lblNumber = new Label();
            lblCaptain = new Label();
            lblFavourite = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(lblPlayerName, "lblPlayerName");
            lblPlayerName.Name = "lblPlayerName";
            // 
            // lblPosition
            // 
            resources.ApplyResources(lblPosition, "lblPosition");
            lblPosition.Name = "lblPosition";
            // 
            // lblNumber
            // 
            resources.ApplyResources(lblNumber, "lblNumber");
            lblNumber.Name = "lblNumber";
            // 
            // lblCaptain
            // 
            resources.ApplyResources(lblCaptain, "lblCaptain");
            lblCaptain.Name = "lblCaptain";
            // 
            // lblFavourite
            // 
            resources.ApplyResources(lblFavourite, "lblFavourite");
            lblFavourite.Name = "lblFavourite";
            // 
            // PlayerControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblFavourite);
            Controls.Add(lblCaptain);
            Controls.Add(lblNumber);
            Controls.Add(lblPosition);
            Controls.Add(lblPlayerName);
            Controls.Add(pictureBox1);
            Name = "PlayerControl";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label lblPlayerName;
        public Label lblPosition;
        public Label lblNumber;
        public Label lblCaptain;
        public Label lblFavourite;
    }
}
