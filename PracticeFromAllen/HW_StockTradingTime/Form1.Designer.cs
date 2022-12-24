
namespace Q02_StockTradingTime
{
    partial class frmStockOpen
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDay = new System.Windows.Forms.Label();
            this.btnChk = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDay.Location = new System.Drawing.Point(109, 150);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(70, 29);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "日期: ";
            // 
            // btnChk
            // 
            this.btnChk.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChk.Location = new System.Drawing.Point(344, 292);
            this.btnChk.Name = "btnChk";
            this.btnChk.Size = new System.Drawing.Size(162, 67);
            this.btnChk.TabIndex = 4;
            this.btnChk.Text = "驗證";
            this.btnChk.UseVisualStyleBackColor = true;
            this.btnChk.Click += new System.EventHandler(this.btnChk_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(230, 143);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(302, 43);
            this.txtTime.TabIndex = 5;
            // 
            // frmStockOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnChk);
            this.Controls.Add(this.lblDay);
            this.Name = "frmStockOpen";
            this.Text = "股票營業時間";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnChk;
        private System.Windows.Forms.TextBox txtTime;
    }
}

