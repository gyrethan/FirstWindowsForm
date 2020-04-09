namespace firstprogram
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.didHeGetYou = new System.Windows.Forms.Panel();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.didHeGetYouText = new System.Windows.Forms.PictureBox();
            this.browRaise = new System.Windows.Forms.PictureBox();
            this.contactInfo = new System.Windows.Forms.Panel();
            this.doesBirthdays = new System.Windows.Forms.PictureBox();
            this.leaves = new System.Windows.Forms.PictureBox();
            this.youveBeenSpooked = new System.Windows.Forms.PictureBox();
            this.spagettScare = new System.Windows.Forms.Panel();
            this.spagettScareGif = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.didHeGetYou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.didHeGetYouText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browRaise)).BeginInit();
            this.contactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doesBirthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youveBeenSpooked)).BeginInit();
            this.spagettScare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spagettScareGif)).BeginInit();
            this.SuspendLayout();
            // 
            // didHeGetYou
            // 
            this.didHeGetYou.Controls.Add(this.yesButton);
            this.didHeGetYou.Controls.Add(this.noButton);
            this.didHeGetYou.Controls.Add(this.didHeGetYouText);
            this.didHeGetYou.Controls.Add(this.browRaise);
            this.didHeGetYou.Location = new System.Drawing.Point(0, 0);
            this.didHeGetYou.Name = "didHeGetYou";
            this.didHeGetYou.Size = new System.Drawing.Size(879, 674);
            this.didHeGetYou.TabIndex = 2;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(87, 425);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(217, 425);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // didHeGetYouText
            // 
            this.didHeGetYouText.BackColor = System.Drawing.Color.Transparent;
            this.didHeGetYouText.Image = global::firstprogram.Properties.Resources.didhegetyou;
            this.didHeGetYouText.Location = new System.Drawing.Point(12, 93);
            this.didHeGetYouText.Name = "didHeGetYouText";
            this.didHeGetYouText.Size = new System.Drawing.Size(359, 497);
            this.didHeGetYouText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.didHeGetYouText.TabIndex = 1;
            this.didHeGetYouText.TabStop = false;
            // 
            // browRaise
            // 
            this.browRaise.BackColor = System.Drawing.Color.Transparent;
            this.browRaise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.browRaise.Image = global::firstprogram.Properties.Resources.browraiser;
            this.browRaise.Location = new System.Drawing.Point(241, -3);
            this.browRaise.Name = "browRaise";
            this.browRaise.Size = new System.Drawing.Size(690, 674);
            this.browRaise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.browRaise.TabIndex = 0;
            this.browRaise.TabStop = false;
            // 
            // contactInfo
            // 
            this.contactInfo.Controls.Add(this.doesBirthdays);
            this.contactInfo.Controls.Add(this.leaves);
            this.contactInfo.Controls.Add(this.youveBeenSpooked);
            this.contactInfo.Location = new System.Drawing.Point(0, 0);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Size = new System.Drawing.Size(879, 674);
            this.contactInfo.TabIndex = 3;
            // 
            // doesBirthdays
            // 
            this.doesBirthdays.Image = global::firstprogram.Properties.Resources.LEAF2;
            this.doesBirthdays.Location = new System.Drawing.Point(217, 271);
            this.doesBirthdays.Name = "doesBirthdays";
            this.doesBirthdays.Size = new System.Drawing.Size(454, 202);
            this.doesBirthdays.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doesBirthdays.TabIndex = 2;
            this.doesBirthdays.TabStop = false;
            // 
            // leaves
            // 
            this.leaves.Image = global::firstprogram.Properties.Resources.leafspook;
            this.leaves.Location = new System.Drawing.Point(697, 43);
            this.leaves.Name = "leaves";
            this.leaves.Size = new System.Drawing.Size(668, 496);
            this.leaves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leaves.TabIndex = 1;
            this.leaves.TabStop = false;
            // 
            // youveBeenSpooked
            // 
            this.youveBeenSpooked.Image = global::firstprogram.Properties.Resources.spooked;
            this.youveBeenSpooked.Location = new System.Drawing.Point(-21, -3);
            this.youveBeenSpooked.Name = "youveBeenSpooked";
            this.youveBeenSpooked.Size = new System.Drawing.Size(897, 715);
            this.youveBeenSpooked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.youveBeenSpooked.TabIndex = 0;
            this.youveBeenSpooked.TabStop = false;
            // 
            // spagettScare
            // 
            this.spagettScare.Controls.Add(this.spagettScareGif);
            this.spagettScare.Location = new System.Drawing.Point(0, 0);
            this.spagettScare.Name = "spagettScare";
            this.spagettScare.Size = new System.Drawing.Size(879, 674);
            this.spagettScare.TabIndex = 1;
            // 
            // spagettScareGif
            // 
            this.spagettScareGif.Image = global::firstprogram.Properties.Resources.scare1;
            this.spagettScareGif.Location = new System.Drawing.Point(-11, -3);
            this.spagettScareGif.Name = "spagettScareGif";
            this.spagettScareGif.Size = new System.Drawing.Size(876, 674);
            this.spagettScareGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spagettScareGif.TabIndex = 0;
            this.spagettScareGif.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(859, 661);
            this.Controls.Add(this.spagettScare);
            this.Controls.Add(this.didHeGetYou);
            this.Controls.Add(this.contactInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(875, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(875, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mysterious Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.didHeGetYou.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.didHeGetYouText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browRaise)).EndInit();
            this.contactInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doesBirthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youveBeenSpooked)).EndInit();
            this.spagettScare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spagettScareGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel didHeGetYou;
        private System.Windows.Forms.Panel spagettScare;
        private System.Windows.Forms.PictureBox spagettScareGif;
        private System.Windows.Forms.PictureBox browRaise;
        private System.Windows.Forms.PictureBox didHeGetYouText;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Panel contactInfo;
        private System.Windows.Forms.PictureBox youveBeenSpooked;
        private System.Windows.Forms.PictureBox leaves;
        private System.Windows.Forms.PictureBox doesBirthdays;
        private System.Windows.Forms.Timer timer1;
    }

}

