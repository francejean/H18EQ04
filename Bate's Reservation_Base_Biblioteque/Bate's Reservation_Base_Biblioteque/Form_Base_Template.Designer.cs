namespace Bate_s_Reservation_Base_Biblioteque
{
    partial class Form_Base_Template
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
            this.TextBox_Info_S = new System.Windows.Forms.TextBox();
            this.BR_DTP_G = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BR_CB_S = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextBox_Info_S
            // 
            this.TextBox_Info_S.Location = new System.Drawing.Point(95, 42);
            this.TextBox_Info_S.Name = "TextBox_Info_S";
            this.TextBox_Info_S.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Info_S.TabIndex = 46;
            // 
            // BR_DTP_G
            // 
            this.BR_DTP_G.CustomFormat = "yyyy/mm/dd";
            this.BR_DTP_G.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_G.Location = new System.Drawing.Point(12, 12);
            this.BR_DTP_G.Name = "BR_DTP_G";
            this.BR_DTP_G.Size = new System.Drawing.Size(99, 20);
            this.BR_DTP_G.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Label_Info_S";
            // 
            // BR_CB_S
            // 
            this.BR_CB_S.BackColor = System.Drawing.SystemColors.Control;
            this.BR_CB_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BR_CB_S.FormattingEnabled = true;
            this.BR_CB_S.Location = new System.Drawing.Point(12, 68);
            this.BR_CB_S.Name = "BR_CB_S";
            this.BR_CB_S.Size = new System.Drawing.Size(121, 21);
            this.BR_CB_S.TabIndex = 49;
            // 
            // Form_Base_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 861);
            this.Controls.Add(this.BR_CB_S);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BR_DTP_G);
            this.Controls.Add(this.TextBox_Info_S);
            this.Name = "Form_Base_Template";
            this.Text = "Form_Base_Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_Info_S;
        private System.Windows.Forms.DateTimePicker BR_DTP_G;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BR_CB_S;
    }
}