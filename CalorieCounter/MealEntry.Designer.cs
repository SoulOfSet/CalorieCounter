
namespace CalorieCounter
{
    partial class MealEntry
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
            this.labelNewMealHeader = new System.Windows.Forms.Label();
            this.timePickerNewMeal = new System.Windows.Forms.DateTimePicker();
            this.datePickerNewMeal = new System.Windows.Forms.DateTimePicker();
            this.labelDateConsumed = new System.Windows.Forms.Label();
            this.labelMealName = new System.Windows.Forms.Label();
            this.textBoxMealName = new System.Windows.Forms.TextBox();
            this.buttonFoodEntry = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewMealHeader
            // 
            this.labelNewMealHeader.AutoSize = true;
            this.labelNewMealHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMealHeader.Location = new System.Drawing.Point(224, 26);
            this.labelNewMealHeader.Name = "labelNewMealHeader";
            this.labelNewMealHeader.Size = new System.Drawing.Size(268, 39);
            this.labelNewMealHeader.TabIndex = 4;
            this.labelNewMealHeader.Text = "Add a New Meal";
            // 
            // timePickerNewMeal
            // 
            this.timePickerNewMeal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerNewMeal.Location = new System.Drawing.Point(464, 94);
            this.timePickerNewMeal.Name = "timePickerNewMeal";
            this.timePickerNewMeal.ShowUpDown = true;
            this.timePickerNewMeal.Size = new System.Drawing.Size(91, 20);
            this.timePickerNewMeal.TabIndex = 14;
            // 
            // datePickerNewMeal
            // 
            this.datePickerNewMeal.Location = new System.Drawing.Point(258, 94);
            this.datePickerNewMeal.Name = "datePickerNewMeal";
            this.datePickerNewMeal.Size = new System.Drawing.Size(200, 20);
            this.datePickerNewMeal.TabIndex = 15;
            // 
            // labelDateConsumed
            // 
            this.labelDateConsumed.AutoSize = true;
            this.labelDateConsumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateConsumed.Location = new System.Drawing.Point(112, 94);
            this.labelDateConsumed.Name = "labelDateConsumed";
            this.labelDateConsumed.Size = new System.Drawing.Size(140, 16);
            this.labelDateConsumed.TabIndex = 16;
            this.labelDateConsumed.Text = "Date/Time Consumed";
            // 
            // labelMealName
            // 
            this.labelMealName.AutoSize = true;
            this.labelMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMealName.Location = new System.Drawing.Point(207, 137);
            this.labelMealName.Name = "labelMealName";
            this.labelMealName.Size = new System.Drawing.Size(45, 16);
            this.labelMealName.TabIndex = 16;
            this.labelMealName.Text = "Name";
            // 
            // textBoxMealName
            // 
            this.textBoxMealName.Location = new System.Drawing.Point(258, 137);
            this.textBoxMealName.Name = "textBoxMealName";
            this.textBoxMealName.Size = new System.Drawing.Size(200, 20);
            this.textBoxMealName.TabIndex = 17;
            // 
            // buttonFoodEntry
            // 
            this.buttonFoodEntry.Location = new System.Drawing.Point(285, 202);
            this.buttonFoodEntry.Name = "buttonFoodEntry";
            this.buttonFoodEntry.Size = new System.Drawing.Size(125, 45);
            this.buttonFoodEntry.TabIndex = 18;
            this.buttonFoodEntry.Text = "Add Food";
            this.buttonFoodEntry.UseVisualStyleBackColor = true;
            this.buttonFoodEntry.Click += new System.EventHandler(this.buttonFoodEntry_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(353, 298);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 45);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(222, 298);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 45);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MealEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFoodEntry);
            this.Controls.Add(this.textBoxMealName);
            this.Controls.Add(this.labelMealName);
            this.Controls.Add(this.labelDateConsumed);
            this.Controls.Add(this.datePickerNewMeal);
            this.Controls.Add(this.timePickerNewMeal);
            this.Controls.Add(this.labelNewMealHeader);
            this.Name = "MealEntry";
            this.Text = "New Meal";
            this.Shown += new System.EventHandler(this.MealEntry_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewMealHeader;
        private System.Windows.Forms.DateTimePicker timePickerNewMeal;
        private System.Windows.Forms.DateTimePicker datePickerNewMeal;
        private System.Windows.Forms.Label labelDateConsumed;
        private System.Windows.Forms.Label labelMealName;
        private System.Windows.Forms.TextBox textBoxMealName;
        private System.Windows.Forms.Button buttonFoodEntry;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}