
namespace CalorieCounter
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCaloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCarbsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProteinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegetableServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fruitServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grainsServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutsServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meatServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fishServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dairyServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eggsServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junkServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherServingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a Sunday for the week you want to view data for";
            // 
            // dateTimePickerReport
            // 
            this.dateTimePickerReport.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReport.Location = new System.Drawing.Point(269, 59);
            this.dateTimePickerReport.Name = "dateTimePickerReport";
            this.dateTimePickerReport.Size = new System.Drawing.Size(280, 26);
            this.dateTimePickerReport.TabIndex = 3;
            this.dateTimePickerReport.ValueChanged += new System.EventHandler(this.dateTimePickerReport_ValueChanged);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeColumns = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.AutoGenerateColumns = false;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.totalCaloriesDataGridViewTextBoxColumn,
            this.totalCarbsDataGridViewTextBoxColumn,
            this.totalProteinDataGridViewTextBoxColumn,
            this.totalFatDataGridViewTextBoxColumn,
            this.vegetableServingsDataGridViewTextBoxColumn,
            this.fruitServingsDataGridViewTextBoxColumn,
            this.grainsServingsDataGridViewTextBoxColumn,
            this.nutsServingsDataGridViewTextBoxColumn,
            this.meatServingsDataGridViewTextBoxColumn,
            this.fishServingsDataGridViewTextBoxColumn,
            this.dairyServingsDataGridViewTextBoxColumn,
            this.eggsServingsDataGridViewTextBoxColumn,
            this.junkServingsDataGridViewTextBoxColumn,
            this.otherServingsDataGridViewTextBoxColumn});
            this.dataGridViewReport.DataSource = this.reportDataBindingSource;
            this.dataGridViewReport.Location = new System.Drawing.Point(1, 120);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ShowCellErrors = false;
            this.dataGridViewReport.ShowCellToolTips = false;
            this.dataGridViewReport.ShowEditingIcon = false;
            this.dataGridViewReport.ShowRowErrors = false;
            this.dataGridViewReport.Size = new System.Drawing.Size(783, 205);
            this.dataGridViewReport.TabIndex = 4;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // totalCaloriesDataGridViewTextBoxColumn
            // 
            this.totalCaloriesDataGridViewTextBoxColumn.DataPropertyName = "TotalCalories";
            this.totalCaloriesDataGridViewTextBoxColumn.HeaderText = "TotalCalories";
            this.totalCaloriesDataGridViewTextBoxColumn.Name = "totalCaloriesDataGridViewTextBoxColumn";
            // 
            // totalCarbsDataGridViewTextBoxColumn
            // 
            this.totalCarbsDataGridViewTextBoxColumn.DataPropertyName = "TotalCarbs";
            this.totalCarbsDataGridViewTextBoxColumn.HeaderText = "TotalCarbs";
            this.totalCarbsDataGridViewTextBoxColumn.Name = "totalCarbsDataGridViewTextBoxColumn";
            // 
            // totalProteinDataGridViewTextBoxColumn
            // 
            this.totalProteinDataGridViewTextBoxColumn.DataPropertyName = "TotalProtein";
            this.totalProteinDataGridViewTextBoxColumn.HeaderText = "TotalProtein";
            this.totalProteinDataGridViewTextBoxColumn.Name = "totalProteinDataGridViewTextBoxColumn";
            // 
            // totalFatDataGridViewTextBoxColumn
            // 
            this.totalFatDataGridViewTextBoxColumn.DataPropertyName = "TotalFat";
            this.totalFatDataGridViewTextBoxColumn.HeaderText = "TotalFat";
            this.totalFatDataGridViewTextBoxColumn.Name = "totalFatDataGridViewTextBoxColumn";
            // 
            // vegetableServingsDataGridViewTextBoxColumn
            // 
            this.vegetableServingsDataGridViewTextBoxColumn.DataPropertyName = "VegetableServings";
            this.vegetableServingsDataGridViewTextBoxColumn.HeaderText = "VegetableServings";
            this.vegetableServingsDataGridViewTextBoxColumn.Name = "vegetableServingsDataGridViewTextBoxColumn";
            // 
            // fruitServingsDataGridViewTextBoxColumn
            // 
            this.fruitServingsDataGridViewTextBoxColumn.DataPropertyName = "FruitServings";
            this.fruitServingsDataGridViewTextBoxColumn.HeaderText = "FruitServings";
            this.fruitServingsDataGridViewTextBoxColumn.Name = "fruitServingsDataGridViewTextBoxColumn";
            // 
            // grainsServingsDataGridViewTextBoxColumn
            // 
            this.grainsServingsDataGridViewTextBoxColumn.DataPropertyName = "GrainsServings";
            this.grainsServingsDataGridViewTextBoxColumn.HeaderText = "GrainsServings";
            this.grainsServingsDataGridViewTextBoxColumn.Name = "grainsServingsDataGridViewTextBoxColumn";
            // 
            // nutsServingsDataGridViewTextBoxColumn
            // 
            this.nutsServingsDataGridViewTextBoxColumn.DataPropertyName = "NutsServings";
            this.nutsServingsDataGridViewTextBoxColumn.HeaderText = "NutsServings";
            this.nutsServingsDataGridViewTextBoxColumn.Name = "nutsServingsDataGridViewTextBoxColumn";
            // 
            // meatServingsDataGridViewTextBoxColumn
            // 
            this.meatServingsDataGridViewTextBoxColumn.DataPropertyName = "MeatServings";
            this.meatServingsDataGridViewTextBoxColumn.HeaderText = "MeatServings";
            this.meatServingsDataGridViewTextBoxColumn.Name = "meatServingsDataGridViewTextBoxColumn";
            // 
            // fishServingsDataGridViewTextBoxColumn
            // 
            this.fishServingsDataGridViewTextBoxColumn.DataPropertyName = "FishServings";
            this.fishServingsDataGridViewTextBoxColumn.HeaderText = "FishServings";
            this.fishServingsDataGridViewTextBoxColumn.Name = "fishServingsDataGridViewTextBoxColumn";
            // 
            // dairyServingsDataGridViewTextBoxColumn
            // 
            this.dairyServingsDataGridViewTextBoxColumn.DataPropertyName = "DairyServings";
            this.dairyServingsDataGridViewTextBoxColumn.HeaderText = "DairyServings";
            this.dairyServingsDataGridViewTextBoxColumn.Name = "dairyServingsDataGridViewTextBoxColumn";
            // 
            // eggsServingsDataGridViewTextBoxColumn
            // 
            this.eggsServingsDataGridViewTextBoxColumn.DataPropertyName = "EggsServings";
            this.eggsServingsDataGridViewTextBoxColumn.HeaderText = "EggsServings";
            this.eggsServingsDataGridViewTextBoxColumn.Name = "eggsServingsDataGridViewTextBoxColumn";
            // 
            // junkServingsDataGridViewTextBoxColumn
            // 
            this.junkServingsDataGridViewTextBoxColumn.DataPropertyName = "JunkServings";
            this.junkServingsDataGridViewTextBoxColumn.HeaderText = "JunkServings";
            this.junkServingsDataGridViewTextBoxColumn.Name = "junkServingsDataGridViewTextBoxColumn";
            // 
            // otherServingsDataGridViewTextBoxColumn
            // 
            this.otherServingsDataGridViewTextBoxColumn.DataPropertyName = "OtherServings";
            this.otherServingsDataGridViewTextBoxColumn.HeaderText = "OtherServings";
            this.otherServingsDataGridViewTextBoxColumn.Name = "otherServingsDataGridViewTextBoxColumn";
            // 
            // reportDataBindingSource
            // 
            this.reportDataBindingSource.DataSource = typeof(CalorieCounter.models.ReportData);
            // 
            // mealBindingSource
            // 
            this.mealBindingSource.DataSource = typeof(CalorieCounter.models.Meal);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 326);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.dateTimePickerReport);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
        private System.Windows.Forms.BindingSource mealBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.BindingSource reportDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCaloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCarbsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProteinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegetableServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fruitServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grainsServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutsServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meatServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fishServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dairyServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eggsServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn junkServingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherServingsDataGridViewTextBoxColumn;
    }
}