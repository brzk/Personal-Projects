namespace WaitressingWindowsFormsApplication
{
    partial class Table
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableNumberlabel = new System.Windows.Forms.Label();
            this.appetizerButton = new System.Windows.Forms.Button();
            this.hamburgersButton = new System.Windows.Forms.Button();
            this.dessertsButton = new System.Windows.Forms.Button();
            this.mainDishesButton = new System.Windows.Forms.Button();
            this.drinksButton = new System.Windows.Forms.Button();
            this.sideDishesButton = new System.Windows.Forms.Button();
            this.saladsButton = new System.Windows.Forms.Button();
            this.tableListBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return to Tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableNumberlabel
            // 
            this.tableNumberlabel.AutoSize = true;
            this.tableNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tableNumberlabel.Location = new System.Drawing.Point(444, 39);
            this.tableNumberlabel.Name = "tableNumberlabel";
            this.tableNumberlabel.Size = new System.Drawing.Size(104, 29);
            this.tableNumberlabel.TabIndex = 2;
            this.tableNumberlabel.Text = "Table 1";
            this.tableNumberlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // appetizerButton
            // 
            this.appetizerButton.Location = new System.Drawing.Point(31, 113);
            this.appetizerButton.Name = "appetizerButton";
            this.appetizerButton.Size = new System.Drawing.Size(100, 75);
            this.appetizerButton.TabIndex = 3;
            this.appetizerButton.Text = "Appetizers";
            this.appetizerButton.UseVisualStyleBackColor = true;
            this.appetizerButton.Click += new System.EventHandler(this.appetizerButton_Click);
            // 
            // hamburgersButton
            // 
            this.hamburgersButton.Location = new System.Drawing.Point(165, 212);
            this.hamburgersButton.Name = "hamburgersButton";
            this.hamburgersButton.Size = new System.Drawing.Size(100, 75);
            this.hamburgersButton.TabIndex = 4;
            this.hamburgersButton.Text = "Hamburgers";
            this.hamburgersButton.UseVisualStyleBackColor = true;
            this.hamburgersButton.Click += new System.EventHandler(this.hamburgersButton_Click);
            // 
            // dessertsButton
            // 
            this.dessertsButton.Location = new System.Drawing.Point(165, 307);
            this.dessertsButton.Name = "dessertsButton";
            this.dessertsButton.Size = new System.Drawing.Size(100, 75);
            this.dessertsButton.TabIndex = 5;
            this.dessertsButton.Text = "Desserts";
            this.dessertsButton.UseVisualStyleBackColor = true;
            this.dessertsButton.Click += new System.EventHandler(this.dessertsButton_Click);
            // 
            // mainDishesButton
            // 
            this.mainDishesButton.Location = new System.Drawing.Point(31, 212);
            this.mainDishesButton.Name = "mainDishesButton";
            this.mainDishesButton.Size = new System.Drawing.Size(100, 75);
            this.mainDishesButton.TabIndex = 6;
            this.mainDishesButton.Text = "MainDishes";
            this.mainDishesButton.UseVisualStyleBackColor = true;
            this.mainDishesButton.Click += new System.EventHandler(this.mainDishesButton_Click);
            // 
            // drinksButton
            // 
            this.drinksButton.Location = new System.Drawing.Point(165, 113);
            this.drinksButton.Name = "drinksButton";
            this.drinksButton.Size = new System.Drawing.Size(100, 75);
            this.drinksButton.TabIndex = 7;
            this.drinksButton.Text = "Drinks";
            this.drinksButton.UseVisualStyleBackColor = true;
            this.drinksButton.Click += new System.EventHandler(this.drinksButton_Click);
            // 
            // sideDishesButton
            // 
            this.sideDishesButton.Location = new System.Drawing.Point(304, 212);
            this.sideDishesButton.Name = "sideDishesButton";
            this.sideDishesButton.Size = new System.Drawing.Size(100, 75);
            this.sideDishesButton.TabIndex = 8;
            this.sideDishesButton.Text = "SideDishes";
            this.sideDishesButton.UseVisualStyleBackColor = true;
            this.sideDishesButton.Click += new System.EventHandler(this.sideDishesButton_Click);
            // 
            // saladsButton
            // 
            this.saladsButton.Location = new System.Drawing.Point(304, 113);
            this.saladsButton.Name = "saladsButton";
            this.saladsButton.Size = new System.Drawing.Size(100, 75);
            this.saladsButton.TabIndex = 9;
            this.saladsButton.Text = "Salads";
            this.saladsButton.UseVisualStyleBackColor = true;
            this.saladsButton.Click += new System.EventHandler(this.saladsButton_Click);
            // 
            // tableListBox
            // 
            this.tableListBox.FormattingEnabled = true;
            this.tableListBox.HorizontalScrollbar = true;
            this.tableListBox.ItemHeight = 16;
            this.tableListBox.Location = new System.Drawing.Point(449, 113);
            this.tableListBox.Name = "tableListBox";
            this.tableListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tableListBox.Size = new System.Drawing.Size(214, 324);
            this.tableListBox.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(708, 113);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(220, 324);
            this.listBox2.TabIndex = 11;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(484, 459);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(117, 59);
            this.sortButton.TabIndex = 15;
            this.sortButton.Text = "sort order";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.tableListBox);
            this.Controls.Add(this.saladsButton);
            this.Controls.Add(this.sideDishesButton);
            this.Controls.Add(this.drinksButton);
            this.Controls.Add(this.mainDishesButton);
            this.Controls.Add(this.dessertsButton);
            this.Controls.Add(this.hamburgersButton);
            this.Controls.Add(this.appetizerButton);
            this.Controls.Add(this.tableNumberlabel);
            this.Controls.Add(this.button1);
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tableNumberlabel;
        private System.Windows.Forms.Button appetizerButton;
        private System.Windows.Forms.Button hamburgersButton;
        private System.Windows.Forms.Button dessertsButton;
        private System.Windows.Forms.Button mainDishesButton;
        private System.Windows.Forms.Button drinksButton;
        private System.Windows.Forms.Button sideDishesButton;
        private System.Windows.Forms.Button saladsButton;
        public System.Windows.Forms.ListBox tableListBox;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button sortButton;
    }
}