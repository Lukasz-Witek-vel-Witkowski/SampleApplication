using SampleApplication.SQL;

namespace SampleApplication
{
    partial class FormInputNumber
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
            this.TB_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Number
            // 
            this.TB_Number.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Number.Location = new System.Drawing.Point(23, 45);
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.ReadOnly = true;
            this.TB_Number.Size = new System.Drawing.Size(190, 22);
            this.TB_Number.TabIndex = 0;
            this.TB_Number.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_Number_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadz kod artykułu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zatwierdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormInputNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(222, 109);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 141);
            this.Name = "FormInputNumber";
            this.Text = "Wprowadzanie kodu produktu";
            this.Activated += new System.EventHandler(this.FormInputNumber_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal void setManager(Manager _manager)
        {
            manager = _manager;
        }

        private System.Windows.Forms.TextBox TB_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Manager manager;
    }
}