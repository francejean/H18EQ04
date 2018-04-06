namespace Bates_Reservation_Transactions
{
    partial class BR_LS_Transaction
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
            this.BR_LS_DGW_arrive = new System.Windows.Forms.DataGridView();
            this.BR_LS_Button_Annuler = new System.Windows.Forms.Button();
            this.BR_LS_Button_Ok_ = new System.Windows.Forms.Button();
            this.BR_BS_Transaction_Arrive = new System.Windows.Forms.BindingSource(this.components);
            this.BR_BS_Transaction_Trx = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGW_arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Trx)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_LS_DGW_arrive
            // 
            this.BR_LS_DGW_arrive.AllowUserToOrderColumns = true;
            this.BR_LS_DGW_arrive.AutoGenerateColumns = false;
            this.BR_LS_DGW_arrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_LS_DGW_arrive.DataSource = this.BR_BS_Transaction_Arrive;
            this.BR_LS_DGW_arrive.Location = new System.Drawing.Point(12, 5);
            this.BR_LS_DGW_arrive.Name = "BR_LS_DGW_arrive";
            this.BR_LS_DGW_arrive.Size = new System.Drawing.Size(1079, 447);
            this.BR_LS_DGW_arrive.TabIndex = 3;
            // 
            // BR_LS_Button_Annuler
            // 
            this.BR_LS_Button_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_LS_Button_Annuler.Location = new System.Drawing.Point(678, 458);
            this.BR_LS_Button_Annuler.Name = "BR_LS_Button_Annuler";
            this.BR_LS_Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Button_Annuler.TabIndex = 5;
            this.BR_LS_Button_Annuler.Text = "ANNULER";
            this.BR_LS_Button_Annuler.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Button_Ok_
            // 
            this.BR_LS_Button_Ok_.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Button_Ok_.Location = new System.Drawing.Point(71, 458);
            this.BR_LS_Button_Ok_.Name = "BR_LS_Button_Ok_";
            this.BR_LS_Button_Ok_.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Button_Ok_.TabIndex = 4;
            this.BR_LS_Button_Ok_.Text = "OK";
            this.BR_LS_Button_Ok_.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 495);
            this.Controls.Add(this.BR_LS_DGW_arrive);
            this.Controls.Add(this.BR_LS_Button_Annuler);
            this.Controls.Add(this.BR_LS_Button_Ok_);
            this.Name = "BR_LS_Transaction";
            this.Text = "BR_LS_Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGW_arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Trx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BR_LS_DGW_arrive;
        private System.Windows.Forms.BindingSource BR_BS_Transaction_Arrive;
        private System.Windows.Forms.BindingSource BR_BS_Transaction_Trx;
        private System.Windows.Forms.Button BR_LS_Button_Annuler;
        private System.Windows.Forms.Button BR_LS_Button_Ok_;
    }
}