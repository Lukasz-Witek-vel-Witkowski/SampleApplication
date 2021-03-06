﻿using SampleApplication.Controller;
using SampleApplication.SQL;
using SampleApplication.View;
using System;

namespace SampleApplication
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Other_products = new System.Windows.Forms.Button();
            this.bt_Add_quantity = new System.Windows.Forms.Button();
            this.bt_buy = new System.Windows.Forms.Button();
            this.bt_help = new System.Windows.Forms.Button();
            this.LV_Option = new System.Windows.Forms.ListView();
            this.Heading_main = new System.Windows.Forms.TextBox();
            this.Heading_option = new System.Windows.Forms.TextBox();
            this.LV_Main = new System.Windows.Forms.ListView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.09045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.90955F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Heading_main, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Heading_option, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LV_Main, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.558558F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.44144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LV_Option, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(544, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.53465F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.46535F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 400);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_Other_products);
            this.flowLayoutPanel1.Controls.Add(this.bt_Add_quantity);
            this.flowLayoutPanel1.Controls.Add(this.bt_buy);
            this.flowLayoutPanel1.Controls.Add(this.bt_help);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 108);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bt_Other_products
            // 
            this.bt_Other_products.Location = new System.Drawing.Point(3, 3);
            this.bt_Other_products.Name = "bt_Other_products";
            this.bt_Other_products.Size = new System.Drawing.Size(120, 34);
            this.bt_Other_products.TabIndex = 4;
            this.bt_Other_products.Text = "Dodaj produkt";
            this.bt_Other_products.UseVisualStyleBackColor = true;
            this.bt_Other_products.Click += new System.EventHandler(this.bt_Other_products_Click);
            // 
            // bt_Add_quantity
            // 
            this.bt_Add_quantity.Location = new System.Drawing.Point(129, 3);
            this.bt_Add_quantity.Name = "bt_Add_quantity";
            this.bt_Add_quantity.Size = new System.Drawing.Size(110, 34);
            this.bt_Add_quantity.TabIndex = 3;
            this.bt_Add_quantity.Text = "Podaj ilość ";
            this.bt_Add_quantity.UseVisualStyleBackColor = true;
            this.bt_Add_quantity.Click += new System.EventHandler(this.bt_Add_quantity_Click);
            // 
            // bt_buy
            // 
            this.bt_buy.Location = new System.Drawing.Point(3, 43);
            this.bt_buy.Name = "bt_buy";
            this.bt_buy.Size = new System.Drawing.Size(236, 30);
            this.bt_buy.TabIndex = 0;
            this.bt_buy.Text = "Zakończ i zapłać";
            this.bt_buy.UseVisualStyleBackColor = true;
            this.bt_buy.Click += new System.EventHandler(this.bt_buy_Click);
            // 
            // bt_help
            // 
            this.bt_help.Location = new System.Drawing.Point(3, 79);
            this.bt_help.Name = "bt_help";
            this.bt_help.Size = new System.Drawing.Size(236, 29);
            this.bt_help.TabIndex = 2;
            this.bt_help.Text = "Pomoc";
            this.bt_help.UseVisualStyleBackColor = true;
            this.bt_help.Click += new System.EventHandler(this.bt_help_Click);
            // 
            // LV_Option
            // 
            this.LV_Option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Option.HideSelection = false;
            this.LV_Option.Location = new System.Drawing.Point(3, 3);
            this.LV_Option.Name = "LV_Option";
            this.LV_Option.Size = new System.Drawing.Size(243, 280);
            this.LV_Option.TabIndex = 0;
            this.LV_Option.UseCompatibleStateImageBehavior = false;
            this.LV_Option.View = System.Windows.Forms.View.Details;
            // 
            // Heading_main
            // 
            this.Heading_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Heading_main.BackColor = System.Drawing.Color.Red;
            this.Heading_main.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Heading_main.ForeColor = System.Drawing.SystemColors.Window;
            this.Heading_main.Location = new System.Drawing.Point(3, 3);
            this.Heading_main.Name = "Heading_main";
            this.Heading_main.ReadOnly = true;
            this.Heading_main.ShortcutsEnabled = false;
            this.Heading_main.Size = new System.Drawing.Size(535, 30);
            this.Heading_main.TabIndex = 2;
            this.Heading_main.Text = "Lista zakupów";
            this.Heading_main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Heading_option
            // 
            this.Heading_option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Heading_option.BackColor = System.Drawing.Color.Red;
            this.Heading_option.CausesValidation = false;
            this.Heading_option.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Heading_option.ForeColor = System.Drawing.SystemColors.Window;
            this.Heading_option.Location = new System.Drawing.Point(544, 3);
            this.Heading_option.Name = "Heading_option";
            this.Heading_option.ReadOnly = true;
            this.Heading_option.Size = new System.Drawing.Size(249, 30);
            this.Heading_option.TabIndex = 3;
            this.Heading_option.Text = "Informacja o produkcie";
            this.Heading_option.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LV_Main
            // 
            this.LV_Main.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LV_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Main.FullRowSelect = true;
            this.LV_Main.HideSelection = false;
            this.LV_Main.HotTracking = true;
            this.LV_Main.HoverSelection = true;
            this.LV_Main.Location = new System.Drawing.Point(3, 41);
            this.LV_Main.MultiSelect = false;
            this.LV_Main.Name = "LV_Main";
            this.LV_Main.Size = new System.Drawing.Size(535, 400);
            this.LV_Main.TabIndex = 0;
            this.LV_Main.UseCompatibleStateImageBehavior = false;
            this.LV_Main.View = System.Windows.Forms.View.Details;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Trick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shopping";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.ListView LV_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.ListView LV_Option;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_buy;
        private System.Windows.Forms.Button bt_help;
        private System.Windows.Forms.Button bt_Add_quantity;
        private System.Windows.Forms.Button bt_Other_products;
        private System.Windows.Forms.TextBox Heading_main;
        private System.Windows.Forms.TextBox Heading_option;
        private System.Windows.Forms.Timer timer;
        private Client client;
        private ListProductsView listProductsView;
        private ProductView productView;
        private Manager manager;
    }
}

