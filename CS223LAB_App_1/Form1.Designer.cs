using System;
using System.Windows.Forms;

namespace CS223LAB_App_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txt_sku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.dataview1 = new System.Windows.Forms.DataGridView();
            this.priceerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.is_checked = new System.Windows.Forms.CheckBox();
            this.check_list = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceerror)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(21, 75);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(188, 26);
            this.txt_number.TabIndex = 2;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(21, 170);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(271, 26);
            this.dtp.TabIndex = 14;
            // 
            // txt_sku
            // 
            this.txt_sku.Location = new System.Drawing.Point(687, 34);
            this.txt_sku.Name = "txt_sku";
            this.txt_sku.Size = new System.Drawing.Size(188, 26);
            this.txt_sku.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "NUMBER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "SKU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Item name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(21, 247);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(420, 26);
            this.txt_name.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Price";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(21, 329);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(151, 26);
            this.txt_quant.TabIndex = 23;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(315, 329);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(96, 26);
            this.txt_price.TabIndex = 24;
            // 
            // dataview1
            // 
            this.dataview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview1.Location = new System.Drawing.Point(491, 170);
            this.dataview1.Name = "dataview1";
            this.dataview1.RowHeadersWidth = 62;
            this.dataview1.RowTemplate.Height = 28;
            this.dataview1.Size = new System.Drawing.Size(632, 249);
            this.dataview1.TabIndex = 25;
            // 
            // priceerror
            // 
            this.priceerror.ContainerControl = this;
            // 
            // is_checked
            // 
            this.is_checked.AutoSize = true;
            this.is_checked.Location = new System.Drawing.Point(344, 174);
            this.is_checked.Name = "is_checked";
            this.is_checked.Size = new System.Drawing.Size(81, 24);
            this.is_checked.TabIndex = 26;
            this.is_checked.Text = "is avail";
            this.is_checked.UseVisualStyleBackColor = true;
            // 
            // check_list
            // 
            this.check_list.FormattingEnabled = true;
            this.check_list.Items.AddRange(new object[] {
            "bisrat",
            "asiya",
            "salahadin"});
            this.check_list.Location = new System.Drawing.Point(321, 34);
            this.check_list.Name = "check_list";
            this.check_list.Size = new System.Drawing.Size(120, 96);
            this.check_list.TabIndex = 28;
            this.check_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(491, 445);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 467);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.check_list);
            this.Controls.Add(this.is_checked);
            this.Controls.Add(this.dataview1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sku);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "q";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txt_sku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DataGridView dataview1;
        private System.Windows.Forms.ErrorProvider priceerror;
        private EventHandler txt_name_TextChanged;
        private EventHandler txt_sku_TextChanged;
        private EventHandler label2_Click;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick;
        private CheckBox is_checked;
        private CheckedListBox check_list;
        private EventHandler checkBox1_CheckedChanged;
        private RadioButton radioButton1;
    }
}

