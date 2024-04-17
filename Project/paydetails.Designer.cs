namespace Project
{
    partial class paydetails
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
            this.paydetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paydetailsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paydetailsdataGridView
            // 
            this.paydetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paydetailsdataGridView.Location = new System.Drawing.Point(-2, 1);
            this.paydetailsdataGridView.Name = "paydetailsdataGridView";
            this.paydetailsdataGridView.Size = new System.Drawing.Size(544, 427);
            this.paydetailsdataGridView.TabIndex = 0;
            this.paydetailsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paydetailsdataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-2, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(544, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paydetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(544, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paydetailsdataGridView);
            this.Name = "paydetails";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.paydetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paydetailsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paydetailsdataGridView;
        private System.Windows.Forms.Button button1;
    }
}