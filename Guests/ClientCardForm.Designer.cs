namespace Guests
{
    partial class ClientCardForm
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
            this.guestCardLabel = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.withAnimalscheckBox = new System.Windows.Forms.CheckBox();
            this.buttonCloseCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guestCardLabel
            // 
            this.guestCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestCardLabel.Location = new System.Drawing.Point(88, 22);
            this.guestCardLabel.Name = "guestCardLabel";
            this.guestCardLabel.Size = new System.Drawing.Size(206, 43);
            this.guestCardLabel.TabIndex = 0;
            this.guestCardLabel.Text = "Карточка гостя";
            this.guestCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFullName
            // 
            this.labelFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(12, 85);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(364, 43);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "ФИО";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFullName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelBirth
            // 
            this.labelBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth.Location = new System.Drawing.Point(12, 148);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(364, 43);
            this.labelBirth.TabIndex = 2;
            this.labelBirth.Text = "Дата рождения";
            this.labelBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPayment
            // 
            this.labelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPayment.Location = new System.Drawing.Point(12, 208);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(364, 43);
            this.labelPayment.TabIndex = 3;
            this.labelPayment.Text = "Оплата";
            this.labelPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(194, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество дней";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDays
            // 
            this.labelDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDays.Location = new System.Drawing.Point(33, 282);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(48, 43);
            this.labelDays.TabIndex = 5;
            this.labelDays.Text = "00";
            this.labelDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // withAnimalscheckBox
            // 
            this.withAnimalscheckBox.AutoCheck = false;
            this.withAnimalscheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.withAnimalscheckBox.Location = new System.Drawing.Point(33, 362);
            this.withAnimalscheckBox.Name = "withAnimalscheckBox";
            this.withAnimalscheckBox.Size = new System.Drawing.Size(177, 35);
            this.withAnimalscheckBox.TabIndex = 6;
            this.withAnimalscheckBox.Text = "Путешествую с животными";
            this.withAnimalscheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonCloseCard
            // 
            this.buttonCloseCard.BackColor = System.Drawing.Color.Red;
            this.buttonCloseCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseCard.Location = new System.Drawing.Point(368, -2);
            this.buttonCloseCard.Name = "buttonCloseCard";
            this.buttonCloseCard.Size = new System.Drawing.Size(44, 40);
            this.buttonCloseCard.TabIndex = 7;
            this.buttonCloseCard.Text = "X";
            this.buttonCloseCard.UseVisualStyleBackColor = false;
            this.buttonCloseCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 500);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCloseCard);
            this.Controls.Add(this.withAnimalscheckBox);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.guestCardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCardForm";
            this.Text = "ClientCardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label guestCardLabel;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.CheckBox withAnimalscheckBox;
        private System.Windows.Forms.Button buttonCloseCard;
    }
}