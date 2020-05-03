namespace MiniParduotuve
{
    partial class ShopForm
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
            this.PrekesList = new System.Windows.Forms.ListBox();
            this.SpecsRichText = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeText = new System.Windows.Forms.TextBox();
            this.ShapeText = new System.Windows.Forms.TextBox();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SpecsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToCartButton = new System.Windows.Forms.Button();
            this.SnowboardLabel = new System.Windows.Forms.Label();
            this.MyCartListBox = new System.Windows.Forms.ListBox();
            this.MyCartLabel = new System.Windows.Forms.Label();
            this.PriceCartText = new System.Windows.Forms.TextBox();
            this.PriceCartLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrekesList
            // 
            this.PrekesList.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrekesList.FormattingEnabled = true;
            this.PrekesList.ItemHeight = 24;
            this.PrekesList.Location = new System.Drawing.Point(12, 50);
            this.PrekesList.Name = "PrekesList";
            this.PrekesList.Size = new System.Drawing.Size(255, 484);
            this.PrekesList.TabIndex = 0;
            this.PrekesList.SelectedIndexChanged += new System.EventHandler(this.PrekesList_SelectedIndexChanged);
            // 
            // SpecsRichText
            // 
            this.SpecsRichText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecsRichText.Location = new System.Drawing.Point(147, 204);
            this.SpecsRichText.Name = "SpecsRichText";
            this.SpecsRichText.ReadOnly = true;
            this.SpecsRichText.Size = new System.Drawing.Size(567, 137);
            this.SpecsRichText.TabIndex = 31;
            this.SpecsRichText.Text = "";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(147, 0);
            this.NameText.Name = "NameText";
            this.NameText.ReadOnly = true;
            this.NameText.Size = new System.Drawing.Size(567, 32);
            this.NameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // SizeText
            // 
            this.SizeText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeText.Location = new System.Drawing.Point(147, 38);
            this.SizeText.Name = "SizeText";
            this.SizeText.ReadOnly = true;
            this.SizeText.Size = new System.Drawing.Size(567, 32);
            this.SizeText.TabIndex = 25;
            // 
            // ShapeText
            // 
            this.ShapeText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeText.Location = new System.Drawing.Point(147, 76);
            this.ShapeText.Name = "ShapeText";
            this.ShapeText.ReadOnly = true;
            this.ShapeText.Size = new System.Drawing.Size(567, 32);
            this.ShapeText.TabIndex = 26;
            // 
            // WeightText
            // 
            this.WeightText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightText.Location = new System.Drawing.Point(147, 114);
            this.WeightText.Name = "WeightText";
            this.WeightText.ReadOnly = true;
            this.WeightText.Size = new System.Drawing.Size(567, 32);
            this.WeightText.TabIndex = 27;
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(147, 152);
            this.PriceText.Name = "PriceText";
            this.PriceText.ReadOnly = true;
            this.PriceText.Size = new System.Drawing.Size(567, 32);
            this.PriceText.TabIndex = 28;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(90, 38);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(51, 25);
            this.SizeLabel.TabIndex = 32;
            this.SizeLabel.Text = "Size";
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeLabel.Location = new System.Drawing.Point(71, 76);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(70, 25);
            this.ShapeLabel.TabIndex = 33;
            this.ShapeLabel.Text = "Shape";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(67, 117);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(74, 25);
            this.WeightLabel.TabIndex = 34;
            this.WeightLabel.Text = "Weight";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(85, 155);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 25);
            this.PriceLabel.TabIndex = 35;
            this.PriceLabel.Text = "Price";
            // 
            // SpecsLabel
            // 
            this.SpecsLabel.AutoSize = true;
            this.SpecsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecsLabel.Location = new System.Drawing.Point(3, 204);
            this.SpecsLabel.Name = "SpecsLabel";
            this.SpecsLabel.Size = new System.Drawing.Size(133, 25);
            this.SpecsLabel.TabIndex = 36;
            this.SpecsLabel.Text = "Specifications";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpecsLabel);
            this.panel1.Controls.Add(this.PriceLabel);
            this.panel1.Controls.Add(this.WeightLabel);
            this.panel1.Controls.Add(this.ShapeLabel);
            this.panel1.Controls.Add(this.SizeLabel);
            this.panel1.Controls.Add(this.SpecsRichText);
            this.panel1.Controls.Add(this.PriceText);
            this.panel1.Controls.Add(this.WeightText);
            this.panel1.Controls.Add(this.ShapeText);
            this.panel1.Controls.Add(this.SizeText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Location = new System.Drawing.Point(300, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 368);
            this.panel1.TabIndex = 37;
            // 
            // ToCartButton
            // 
            this.ToCartButton.Location = new System.Drawing.Point(300, 407);
            this.ToCartButton.Name = "ToCartButton";
            this.ToCartButton.Size = new System.Drawing.Size(136, 84);
            this.ToCartButton.TabIndex = 38;
            this.ToCartButton.Text = "Add To Cart";
            this.ToCartButton.UseVisualStyleBackColor = true;
            this.ToCartButton.Click += new System.EventHandler(this.ToCartButton_Click);
            // 
            // SnowboardLabel
            // 
            this.SnowboardLabel.AutoSize = true;
            this.SnowboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnowboardLabel.Location = new System.Drawing.Point(12, 9);
            this.SnowboardLabel.Name = "SnowboardLabel";
            this.SnowboardLabel.Size = new System.Drawing.Size(122, 25);
            this.SnowboardLabel.TabIndex = 40;
            this.SnowboardLabel.Text = "Snowboards";
            // 
            // MyCartListBox
            // 
            this.MyCartListBox.FormattingEnabled = true;
            this.MyCartListBox.ItemHeight = 16;
            this.MyCartListBox.Location = new System.Drawing.Point(1075, 47);
            this.MyCartListBox.Name = "MyCartListBox";
            this.MyCartListBox.Size = new System.Drawing.Size(193, 292);
            this.MyCartListBox.TabIndex = 41;
            this.MyCartListBox.SelectedIndexChanged += new System.EventHandler(this.MyCartListBox_SelectedIndexChanged);
            // 
            // MyCartLabel
            // 
            this.MyCartLabel.AutoSize = true;
            this.MyCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCartLabel.Location = new System.Drawing.Point(1070, 9);
            this.MyCartLabel.Name = "MyCartLabel";
            this.MyCartLabel.Size = new System.Drawing.Size(81, 25);
            this.MyCartLabel.TabIndex = 42;
            this.MyCartLabel.Text = "My Cart";
            // 
            // PriceCartText
            // 
            this.PriceCartText.Location = new System.Drawing.Point(1140, 358);
            this.PriceCartText.Name = "PriceCartText";
            this.PriceCartText.Size = new System.Drawing.Size(100, 22);
            this.PriceCartText.TabIndex = 44;
            // 
            // PriceCartLabel
            // 
            this.PriceCartLabel.AutoSize = true;
            this.PriceCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCartLabel.Location = new System.Drawing.Point(1078, 358);
            this.PriceCartLabel.Name = "PriceCartLabel";
            this.PriceCartLabel.Size = new System.Drawing.Size(56, 25);
            this.PriceCartLabel.TabIndex = 45;
            this.PriceCartLabel.Text = "Price";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 758);
            this.Controls.Add(this.PriceCartLabel);
            this.Controls.Add(this.PriceCartText);
            this.Controls.Add(this.MyCartLabel);
            this.Controls.Add(this.MyCartListBox);
            this.Controls.Add(this.SnowboardLabel);
            this.Controls.Add(this.ToCartButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrekesList);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PrekesList;
        private System.Windows.Forms.RichTextBox SpecsRichText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SizeText;
        private System.Windows.Forms.TextBox ShapeText;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SpecsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToCartButton;
        private System.Windows.Forms.Label SnowboardLabel;
        private System.Windows.Forms.ListBox MyCartListBox;
        private System.Windows.Forms.Label MyCartLabel;
        private System.Windows.Forms.TextBox PriceCartText;
        private System.Windows.Forms.Label PriceCartLabel;
    }
}

