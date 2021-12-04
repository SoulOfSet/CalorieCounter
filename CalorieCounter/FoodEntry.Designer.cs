
namespace CalorieCounter
{
    partial class FoodEntry
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
            this.Type = new System.Windows.Forms.Label();
            this.labelServings = new System.Windows.Forms.Label();
            this.carbs = new System.Windows.Forms.Label();
            this.protein = new System.Windows.Forms.Label();
            this.fat = new System.Windows.Forms.Label();
            this.textBoxServings = new System.Windows.Forms.TextBox();
            this.textBoxCarbs = new System.Windows.Forms.TextBox();
            this.textBoxProtein = new System.Windows.Forms.TextBox();
            this.textBoxFat = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.comboBoxFoodTypes = new System.Windows.Forms.ComboBox();
            this.labelNewMealHeader = new System.Windows.Forms.Label();
            this.labelFoodName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(113, 111);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 16);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type";
            // 
            // labelServings
            // 
            this.labelServings.AutoSize = true;
            this.labelServings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServings.Location = new System.Drawing.Point(113, 139);
            this.labelServings.Name = "labelServings";
            this.labelServings.Size = new System.Drawing.Size(61, 16);
            this.labelServings.TabIndex = 2;
            this.labelServings.Text = "Servings";
            // 
            // carbs
            // 
            this.carbs.AutoSize = true;
            this.carbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbs.Location = new System.Drawing.Point(113, 167);
            this.carbs.Name = "carbs";
            this.carbs.Size = new System.Drawing.Size(44, 16);
            this.carbs.TabIndex = 4;
            this.carbs.Text = "Carbs";
            // 
            // protein
            // 
            this.protein.AutoSize = true;
            this.protein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protein.Location = new System.Drawing.Point(113, 195);
            this.protein.Name = "protein";
            this.protein.Size = new System.Drawing.Size(50, 16);
            this.protein.TabIndex = 5;
            this.protein.Text = "Protein";
            // 
            // fat
            // 
            this.fat.AutoSize = true;
            this.fat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fat.Location = new System.Drawing.Point(113, 223);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(27, 16);
            this.fat.TabIndex = 6;
            this.fat.Text = "Fat";
            // 
            // textBoxServings
            // 
            this.textBoxServings.Location = new System.Drawing.Point(211, 139);
            this.textBoxServings.Name = "textBoxServings";
            this.textBoxServings.Size = new System.Drawing.Size(100, 20);
            this.textBoxServings.TabIndex = 8;
            // 
            // textBoxCarbs
            // 
            this.textBoxCarbs.Location = new System.Drawing.Point(211, 167);
            this.textBoxCarbs.Name = "textBoxCarbs";
            this.textBoxCarbs.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarbs.TabIndex = 10;
            // 
            // textBoxProtein
            // 
            this.textBoxProtein.Location = new System.Drawing.Point(211, 195);
            this.textBoxProtein.Name = "textBoxProtein";
            this.textBoxProtein.Size = new System.Drawing.Size(100, 20);
            this.textBoxProtein.TabIndex = 11;
            // 
            // textBoxFat
            // 
            this.textBoxFat.Location = new System.Drawing.Point(211, 223);
            this.textBoxFat.Name = "textBoxFat";
            this.textBoxFat.Size = new System.Drawing.Size(100, 20);
            this.textBoxFat.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(93, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 45);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(231, 275);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(125, 45);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // comboBoxFoodTypes
            // 
            this.comboBoxFoodTypes.FormattingEnabled = true;
            this.comboBoxFoodTypes.Location = new System.Drawing.Point(211, 111);
            this.comboBoxFoodTypes.Name = "comboBoxFoodTypes";
            this.comboBoxFoodTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFoodTypes.TabIndex = 17;
            // 
            // labelNewMealHeader
            // 
            this.labelNewMealHeader.AutoSize = true;
            this.labelNewMealHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMealHeader.Location = new System.Drawing.Point(86, 27);
            this.labelNewMealHeader.Name = "labelNewMealHeader";
            this.labelNewMealHeader.Size = new System.Drawing.Size(270, 39);
            this.labelNewMealHeader.TabIndex = 18;
            this.labelNewMealHeader.Text = "Add a Food Item";
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodName.Location = new System.Drawing.Point(113, 85);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(45, 16);
            this.labelFoodName.TabIndex = 2;
            this.labelFoodName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(211, 85);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // FoodEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.labelNewMealHeader);
            this.Controls.Add(this.comboBoxFoodTypes);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBoxFat);
            this.Controls.Add(this.textBoxProtein);
            this.Controls.Add(this.textBoxCarbs);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxServings);
            this.Controls.Add(this.fat);
            this.Controls.Add(this.protein);
            this.Controls.Add(this.carbs);
            this.Controls.Add(this.labelFoodName);
            this.Controls.Add(this.labelServings);
            this.Controls.Add(this.Type);
            this.Name = "FoodEntry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodEntry_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label labelServings;
        private System.Windows.Forms.Label carbs;
        private System.Windows.Forms.Label protein;
        private System.Windows.Forms.Label fat;
        private System.Windows.Forms.TextBox textBoxServings;
        private System.Windows.Forms.TextBox textBoxCarbs;
        private System.Windows.Forms.TextBox textBoxProtein;
        private System.Windows.Forms.TextBox textBoxFat;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox comboBoxFoodTypes;
        private System.Windows.Forms.Label labelNewMealHeader;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}