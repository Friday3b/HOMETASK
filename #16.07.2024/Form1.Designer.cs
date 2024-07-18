namespace _16._07._2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            nametextBox = new TextBox();
            desctextBox = new TextBox();
            pricetextBox = new TextBox();
            categorycomboBox = new ComboBox();
            clickbutton = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 144);
            listView1.Name = "listView1";
            listView1.Size = new Size(530, 294);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(571, 145);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(195, 27);
            nametextBox.TabIndex = 1;
            nametextBox.Text = "Name";
            // 
            // desctextBox
            // 
            desctextBox.Location = new Point(571, 203);
            desctextBox.Name = "desctextBox";
            desctextBox.Size = new Size(195, 27);
            desctextBox.TabIndex = 2;
            desctextBox.Text = "Description";
            // 
            // pricetextBox
            // 
            pricetextBox.Location = new Point(571, 329);
            pricetextBox.Name = "pricetextBox";
            pricetextBox.Size = new Size(195, 27);
            pricetextBox.TabIndex = 3;
            pricetextBox.Text = "Price";
            // 
            // categorycomboBox
            // 
            categorycomboBox.FormattingEnabled = true;
            categorycomboBox.Items.AddRange(new object[] { "coca-cola", "fanta", "sprite", "pepsi" });
            categorycomboBox.Location = new Point(573, 263);
            categorycomboBox.Name = "categorycomboBox";
            categorycomboBox.Size = new Size(193, 28);
            categorycomboBox.TabIndex = 4;
            categorycomboBox.Text = "Category";
            // 
            // clickbutton
            // 
            clickbutton.Location = new Point(588, 391);
            clickbutton.Name = "clickbutton";
            clickbutton.Size = new Size(151, 37);
            clickbutton.TabIndex = 5;
            clickbutton.Text = "Click ";
            clickbutton.UseVisualStyleBackColor = true;
            clickbutton.Click += clickbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(clickbutton);
            Controls.Add(categorycomboBox);
            Controls.Add(pricetextBox);
            Controls.Add(desctextBox);
            Controls.Add(nametextBox);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox nametextBox;
        private TextBox desctextBox;
        private TextBox pricetextBox;
        private ComboBox categorycomboBox;
        private Button clickbutton;
    }
}
