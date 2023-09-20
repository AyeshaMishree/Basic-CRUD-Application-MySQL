namespace MySQL_conn
{
    partial class form_initial
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
            this.cont_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cont_btn
            // 
            this.cont_btn.BackColor = System.Drawing.Color.Transparent;
            this.cont_btn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_btn.ForeColor = System.Drawing.Color.Black;
            this.cont_btn.Location = new System.Drawing.Point(450, 241);
            this.cont_btn.Name = "cont_btn";
            this.cont_btn.Size = new System.Drawing.Size(97, 33);
            this.cont_btn.TabIndex = 0;
            this.cont_btn.Text = "Continue";
            this.cont_btn.UseVisualStyleBackColor = false;
            this.cont_btn.Click += new System.EventHandler(this.cont_btn_Click);
            // 
            // form_initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySQL_conn.Properties.Resources.This_is_CRUD_Application__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.cont_btn);
            this.DoubleBuffered = true;
            this.Name = "form_initial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Application";
            this.Load += new System.EventHandler(this.form_initial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cont_btn;
    }
}