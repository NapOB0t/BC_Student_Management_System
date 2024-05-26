namespace PRGProject.PresentationLayer
{
    partial class Modules
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
            this.dataGridViewModule = new System.Windows.Forms.DataGridView();
            this.mdlldisplaybtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mcodeBox = new System.Windows.Forms.TextBox();
            this.mDescriptionbox = new System.Windows.Forms.TextBox();
            this.mLinksbox = new System.Windows.Forms.TextBox();
            this.mNamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModuleAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewModule
            // 
            this.dataGridViewModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModule.Location = new System.Drawing.Point(8, 98);
            this.dataGridViewModule.Name = "dataGridViewModule";
            this.dataGridViewModule.RowHeadersWidth = 51;
            this.dataGridViewModule.RowTemplate.Height = 24;
            this.dataGridViewModule.Size = new System.Drawing.Size(462, 241);
            this.dataGridViewModule.TabIndex = 0;
            this.dataGridViewModule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModule_CellContentClick);
            // 
            // mdlldisplaybtn
            // 
            this.mdlldisplaybtn.Location = new System.Drawing.Point(6, 363);
            this.mdlldisplaybtn.Name = "mdlldisplaybtn";
            this.mdlldisplaybtn.Size = new System.Drawing.Size(139, 23);
            this.mdlldisplaybtn.TabIndex = 1;
            this.mdlldisplaybtn.Text = "Display Modules";
            this.mdlldisplaybtn.UseVisualStyleBackColor = true;
            this.mdlldisplaybtn.Click += new System.EventHandler(this.mdlldisplaybtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(658, 363);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(525, 46);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Module Code:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(174, 47);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(331, 22);
            this.searchtxt.TabIndex = 5;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRGProject.Properties.Resources.BCLogo;
            this.pictureBox1.Location = new System.Drawing.Point(681, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mcodeBox
            // 
            this.mcodeBox.Location = new System.Drawing.Point(621, 114);
            this.mcodeBox.Name = "mcodeBox";
            this.mcodeBox.Size = new System.Drawing.Size(167, 22);
            this.mcodeBox.TabIndex = 8;
            // 
            // mDescriptionbox
            // 
            this.mDescriptionbox.Location = new System.Drawing.Point(621, 218);
            this.mDescriptionbox.Name = "mDescriptionbox";
            this.mDescriptionbox.Size = new System.Drawing.Size(167, 22);
            this.mDescriptionbox.TabIndex = 9;
            // 
            // mLinksbox
            // 
            this.mLinksbox.Location = new System.Drawing.Point(621, 271);
            this.mLinksbox.Name = "mLinksbox";
            this.mLinksbox.Size = new System.Drawing.Size(167, 22);
            this.mLinksbox.TabIndex = 10;
            // 
            // mNamebox
            // 
            this.mNamebox.Location = new System.Drawing.Point(621, 164);
            this.mNamebox.Name = "mNamebox";
            this.mNamebox.Size = new System.Drawing.Size(167, 22);
            this.mNamebox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Module Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Module Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Module  Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Module Study Links :";
            // 
            // ModuleAdd
            // 
            this.ModuleAdd.Location = new System.Drawing.Point(174, 363);
            this.ModuleAdd.Name = "ModuleAdd";
            this.ModuleAdd.Size = new System.Drawing.Size(104, 23);
            this.ModuleAdd.TabIndex = 16;
            this.ModuleAdd.Text = "Add Module";
            this.ModuleAdd.UseVisualStyleBackColor = true;
            this.ModuleAdd.Click += new System.EventHandler(this.ModuleAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete Module";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update Module";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModuleAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mNamebox);
            this.Controls.Add(this.mLinksbox);
            this.Controls.Add(this.mDescriptionbox);
            this.Controls.Add(this.mcodeBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.mdlldisplaybtn);
            this.Controls.Add(this.dataGridViewModule);
            this.Name = "Modules";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.Modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModule;
        private System.Windows.Forms.Button mdlldisplaybtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mcodeBox;
        private System.Windows.Forms.TextBox mDescriptionbox;
        private System.Windows.Forms.TextBox mLinksbox;
        private System.Windows.Forms.TextBox mNamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ModuleAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}