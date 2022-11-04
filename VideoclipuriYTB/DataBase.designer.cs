
namespace VideoclipuriYTB
{
    partial class DataBase
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
            System.Windows.Forms.Label categorieLabel;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label linkLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.categorieTextBox = new System.Windows.Forms.TextBox();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            categorieLabel = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categorieLabel
            // 
            categorieLabel.AutoSize = true;
            categorieLabel.Font = new System.Drawing.Font("Georgia", 15.25F, System.Drawing.FontStyle.Bold);
            categorieLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            categorieLabel.Location = new System.Drawing.Point(9, 162);
            categorieLabel.Name = "categorieLabel";
            categorieLabel.Size = new System.Drawing.Size(123, 25);
            categorieLabel.TabIndex = 16;
            categorieLabel.Text = "Categorie:";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Font = new System.Drawing.Font("Georgia", 15.25F, System.Drawing.FontStyle.Bold);
            tagLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tagLabel.Location = new System.Drawing.Point(9, 111);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(59, 25);
            tagLabel.TabIndex = 17;
            tagLabel.Text = "Tag:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            linkLabel.Location = new System.Drawing.Point(9, 58);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(69, 25);
            linkLabel.TabIndex = 18;
            linkLabel.Text = "Link:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.button1.Location = new System.Drawing.Point(340, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.button2.Location = new System.Drawing.Point(145, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Adauga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(linkLabel);
            this.panel1.Controls.Add(tagLabel);
            this.panel1.Controls.Add(categorieLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 311);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "        exit      ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // categorieTextBox
            // 
            this.categorieTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.categorieTextBox.Location = new System.Drawing.Point(145, 161);
            this.categorieTextBox.Name = "categorieTextBox";
            this.categorieTextBox.Size = new System.Drawing.Size(378, 31);
            this.categorieTextBox.TabIndex = 17;
            // 
            // tagTextBox
            // 
            this.tagTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.tagTextBox.Location = new System.Drawing.Point(145, 104);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(378, 31);
            this.tagTextBox.TabIndex = 18;
            // 
            // linkTextBox
            // 
            this.linkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.linkTextBox.Location = new System.Drawing.Point(145, 57);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(378, 31);
            this.linkTextBox.TabIndex = 19;
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 310);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.categorieTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 15.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "DataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase";
            this.Load += new System.EventHandler(this.DataBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox categorieTextBox;

        private System.Windows.Forms.TextBox tagTextBox;

        private System.Windows.Forms.TextBox linkTextBox;
    }
}