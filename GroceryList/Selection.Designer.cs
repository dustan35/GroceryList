namespace GroceryList
{
    partial class Selection
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
            this.Breakfast = new System.Windows.Forms.Button();
            this.Lunch = new System.Windows.Forms.Button();
            this.Dinner = new System.Windows.Forms.Button();
            this.Snacks = new System.Windows.Forms.Button();
            this.BathItems = new System.Windows.Forms.Button();
            this.AnimalStuff = new System.Windows.Forms.Button();
            this.CarStuff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Breakfast
            // 
            this.Breakfast.Location = new System.Drawing.Point(29, 66);
            this.Breakfast.Name = "Breakfast";
            this.Breakfast.Size = new System.Drawing.Size(75, 23);
            this.Breakfast.TabIndex = 0;
            this.Breakfast.Text = "Breakfast";
            this.Breakfast.UseVisualStyleBackColor = true;
            this.Breakfast.Click += new System.EventHandler(this.Breakfast_Click);
            // 
            // Lunch
            // 
            this.Lunch.Location = new System.Drawing.Point(29, 113);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(75, 23);
            this.Lunch.TabIndex = 1;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = true;
            this.Lunch.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // Dinner
            // 
            this.Dinner.Location = new System.Drawing.Point(29, 162);
            this.Dinner.Name = "Dinner";
            this.Dinner.Size = new System.Drawing.Size(75, 23);
            this.Dinner.TabIndex = 2;
            this.Dinner.Text = "Dinner";
            this.Dinner.UseVisualStyleBackColor = true;
            this.Dinner.Click += new System.EventHandler(this.Dinner_Click);
            // 
            // Snacks
            // 
            this.Snacks.Location = new System.Drawing.Point(29, 210);
            this.Snacks.Name = "Snacks";
            this.Snacks.Size = new System.Drawing.Size(75, 23);
            this.Snacks.TabIndex = 3;
            this.Snacks.Text = "Snacks";
            this.Snacks.UseVisualStyleBackColor = true;
            // 
            // BathItems
            // 
            this.BathItems.Location = new System.Drawing.Point(153, 66);
            this.BathItems.Name = "BathItems";
            this.BathItems.Size = new System.Drawing.Size(75, 23);
            this.BathItems.TabIndex = 4;
            this.BathItems.Text = "Bath Items";
            this.BathItems.UseVisualStyleBackColor = true;
            // 
            // AnimalStuff
            // 
            this.AnimalStuff.Location = new System.Drawing.Point(153, 113);
            this.AnimalStuff.Name = "AnimalStuff";
            this.AnimalStuff.Size = new System.Drawing.Size(75, 23);
            this.AnimalStuff.TabIndex = 5;
            this.AnimalStuff.Text = "Animal Stuff";
            this.AnimalStuff.UseVisualStyleBackColor = true;
            // 
            // CarStuff
            // 
            this.CarStuff.Location = new System.Drawing.Point(153, 162);
            this.CarStuff.Name = "CarStuff";
            this.CarStuff.Size = new System.Drawing.Size(75, 23);
            this.CarStuff.TabIndex = 6;
            this.CarStuff.Text = "Car stuff";
            this.CarStuff.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarStuff);
            this.Controls.Add(this.AnimalStuff);
            this.Controls.Add(this.BathItems);
            this.Controls.Add(this.Snacks);
            this.Controls.Add(this.Dinner);
            this.Controls.Add(this.Lunch);
            this.Controls.Add(this.Breakfast);
            this.Name = "Selection";
            this.Text = "Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Breakfast;
        private System.Windows.Forms.Button Lunch;
        private System.Windows.Forms.Button Dinner;
        private System.Windows.Forms.Button Snacks;
        private System.Windows.Forms.Button BathItems;
        private System.Windows.Forms.Button AnimalStuff;
        private System.Windows.Forms.Button CarStuff;
    }
}