namespace System
{
    partial class Dashoboard
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
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.lblDateIN = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblTimeIN = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOfficial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tClear = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpID
            // 
            this.txtEmpID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpID.BackColor = System.Drawing.Color.Honeydew;
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpID.CausesValidation = false;
            this.txtEmpID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(507, 271);
            this.txtEmpID.MaxLength = 7;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(301, 42);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // lblFullname
            // 
            this.lblFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(2)))));
            this.lblFullname.CausesValidation = false;
            this.lblFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.White;
            this.lblFullname.Location = new System.Drawing.Point(426, 340);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(489, 35);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullname.TextChanged += new System.EventHandler(this.fullname_TextChanged);
            // 
            // imgImage
            // 
            this.imgImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgImage.Location = new System.Drawing.Point(1007, 271);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(246, 268);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 2;
            this.imgImage.TabStop = false;
            // 
            // lblDateIN
            // 
            this.lblDateIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(2)))));
            this.lblDateIN.CausesValidation = false;
            this.lblDateIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIN.ForeColor = System.Drawing.Color.White;
            this.lblDateIN.Location = new System.Drawing.Point(426, 406);
            this.lblDateIN.Name = "lblDateIN";
            this.lblDateIN.Size = new System.Drawing.Size(489, 35);
            this.lblDateIN.TabIndex = 3;
            this.lblDateIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDept
            // 
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(2)))));
            this.lblDept.CausesValidation = false;
            this.lblDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.White;
            this.lblDept.Location = new System.Drawing.Point(426, 546);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(489, 35);
            this.lblDept.TabIndex = 5;
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeIN
            // 
            this.lblTimeIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(2)))));
            this.lblTimeIN.CausesValidation = false;
            this.lblTimeIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeIN.Location = new System.Drawing.Point(426, 477);
            this.lblTimeIN.Name = "lblTimeIN";
            this.lblTimeIN.Size = new System.Drawing.Size(489, 35);
            this.lblTimeIN.TabIndex = 4;
            this.lblTimeIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmessage
            // 
            this.lblmessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblmessage.CausesValidation = false;
            this.lblmessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(426, 606);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(489, 97);
            this.lblmessage.TabIndex = 6;
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblmessage.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.CausesValidation = false;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(140, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "FULLNAME:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.CausesValidation = false;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(140, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "DATE:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.CausesValidation = false;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(140, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "TIME:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.CausesValidation = false;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(119, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "DEPARTMENT:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOfficial
            // 
            this.btnOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficial.Location = new System.Drawing.Point(1217, 32);
            this.btnOfficial.Name = "btnOfficial";
            this.btnOfficial.Size = new System.Drawing.Size(122, 56);
            this.btnOfficial.TabIndex = 7;
            this.btnOfficial.Text = "OFFICIAL USE";
            this.btnOfficial.UseVisualStyleBackColor = true;
            this.btnOfficial.Click += new System.EventHandler(this.btnOfficial_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(2)))));
            this.label2.CausesValidation = false;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(577, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 35);
            this.label2.TabIndex = 8;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(2)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(373, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "DIGNITY DTRT ATTENDANCE SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 879);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Designed and Developed by Abeikugeorge IT Department";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fin_system.Properties.Resources.dtrt_logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 128);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Dashoboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1317, 906);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOfficial);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblTimeIN);
            this.Controls.Add(this.lblDateIN);
            this.Controls.Add(this.imgImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.txtEmpID);
            this.Name = "Dashoboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashoboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TextBox txtEmpID;
        private Windows.Forms.Label lblFullname;
        private Windows.Forms.PictureBox imgImage;
        private Windows.Forms.Label lblDateIN;
        private Windows.Forms.Label lblDept;
        private Windows.Forms.Label lblTimeIN;
        private Windows.Forms.Label lblmessage;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label label6;
        private Windows.Forms.Label label7;
        private Windows.Forms.Label label8;
        private Windows.Forms.Button btnOfficial;
        private Windows.Forms.Label label2;
        private Windows.Forms.Timer tClear;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label label3;
        private Windows.Forms.PictureBox pictureBox1;
    }
}