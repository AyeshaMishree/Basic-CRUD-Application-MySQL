namespace MySQL_conn
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agetxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.adddresstxt = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crudtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Enabled = false;
            this.nametxt.Location = new System.Drawing.Point(78, 107);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(82, 20);
            this.nametxt.TabIndex = 0;
            this.nametxt.Text = "Name: ";
            this.nametxt.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // agetxt
            // 
            this.agetxt.Enabled = false;
            this.agetxt.Location = new System.Drawing.Point(78, 147);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(82, 20);
            this.agetxt.TabIndex = 2;
            this.agetxt.Text = "Age: ";
            this.agetxt.Visible = false;
            // 
            // emailtxt
            // 
            this.emailtxt.Enabled = false;
            this.emailtxt.Location = new System.Drawing.Point(78, 190);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(82, 20);
            this.emailtxt.TabIndex = 3;
            this.emailtxt.Text = "Email: ";
            this.emailtxt.Visible = false;
            // 
            // adddresstxt
            // 
            this.adddresstxt.Enabled = false;
            this.adddresstxt.Location = new System.Drawing.Point(78, 235);
            this.adddresstxt.Name = "adddresstxt";
            this.adddresstxt.Size = new System.Drawing.Size(82, 20);
            this.adddresstxt.TabIndex = 4;
            this.adddresstxt.Text = "Address: ";
            this.adddresstxt.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(188, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(192, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(192, 150);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(188, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(192, 115);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(188, 20);
            this.textBox8.TabIndex = 5;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(108, 379);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(232, 379);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 10;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(490, 379);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 23);
            this.viewbtn.TabIndex = 11;
            this.viewbtn.Text = "VIEW";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(358, 379);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(86, 23);
            this.updatebtn.TabIndex = 13;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(618, 379);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.MaximumSize = new System.Drawing.Size(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 287);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // crudtxt
            // 
            this.crudtxt.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crudtxt.Location = new System.Drawing.Point(42, 57);
            this.crudtxt.Name = "crudtxt";
            this.crudtxt.Size = new System.Drawing.Size(384, 27);
            this.crudtxt.TabIndex = 15;
            this.crudtxt.Text = " CRUD: CREATE-READ-UPDATE-DELETE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySQL_conn.Properties.Resources.This_is_CRUD_Application__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crudtxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.adddresstxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.nametxt);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox adddresstxt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox crudtxt;
        private System.Windows.Forms.Button button1;
    }
}

