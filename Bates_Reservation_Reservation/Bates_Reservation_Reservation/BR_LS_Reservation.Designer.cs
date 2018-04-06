namespace Bates_Reservation_Reservation
{
    partial class BR_LS_Reservation
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
            this.BR_LA_Button_Annuler = new System.Windows.Forms.Button();
            this.BR_LA_Button_Ok = new System.Windows.Forms.Button();
            this.BR_LS_DGW_Reser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGW_Reser)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_LA_Button_Annuler
            // 
            this.BR_LA_Button_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_LA_Button_Annuler.Location = new System.Drawing.Point(526, 388);
            this.BR_LA_Button_Annuler.Name = "BR_LA_Button_Annuler";
            this.BR_LA_Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BR_LA_Button_Annuler.TabIndex = 8;
            this.BR_LA_Button_Annuler.Text = "Annuler";
            this.BR_LA_Button_Annuler.UseVisualStyleBackColor = true;
            // 
            // BR_LA_Button_Ok
            // 
            this.BR_LA_Button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LA_Button_Ok.Location = new System.Drawing.Point(200, 388);
            this.BR_LA_Button_Ok.Name = "BR_LA_Button_Ok";
            this.BR_LA_Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.BR_LA_Button_Ok.TabIndex = 7;
            this.BR_LA_Button_Ok.Text = "OK";
            this.BR_LA_Button_Ok.UseVisualStyleBackColor = true;
            // 
            // BR_LS_DGW_Reser
            // 
            this.BR_LS_DGW_Reser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_LS_DGW_Reser.Location = new System.Drawing.Point(12, 12);
            this.BR_LS_DGW_Reser.Name = "BR_LS_DGW_Reser";
            this.BR_LS_DGW_Reser.Size = new System.Drawing.Size(816, 324);
            this.BR_LS_DGW_Reser.TabIndex = 6;
            // 
            // BR_LS_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 452);
            this.Controls.Add(this.BR_LA_Button_Annuler);
            this.Controls.Add(this.BR_LA_Button_Ok);
            this.Controls.Add(this.BR_LS_DGW_Reser);
            this.Name = "BR_LS_Reservation";
            this.Text = "BR_LS_Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGW_Reser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BR_LA_Button_Annuler;
        private System.Windows.Forms.Button BR_LA_Button_Ok;
        private System.Windows.Forms.DataGridView BR_LS_DGW_Reser;
    }
}