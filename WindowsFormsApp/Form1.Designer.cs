
namespace WindowsFormsApp
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonGetFilteredData = new System.Windows.Forms.Button();
            this.buttonSaveToFiles = new System.Windows.Forms.Button();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(12, 12);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(215, 66);
            this.buttonAddData.TabIndex = 0;
            this.buttonAddData.Text = "buttonAddData";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonGetFilteredData
            // 
            this.buttonGetFilteredData.Location = new System.Drawing.Point(12, 156);
            this.buttonGetFilteredData.Name = "buttonGetFilteredData";
            this.buttonGetFilteredData.Size = new System.Drawing.Size(215, 66);
            this.buttonGetFilteredData.TabIndex = 1;
            this.buttonGetFilteredData.Text = "buttonGetFilteredData";
            this.buttonGetFilteredData.UseVisualStyleBackColor = true;
            this.buttonGetFilteredData.Click += new System.EventHandler(this.buttonGetFilteredData_Click);
            // 
            // buttonSaveToFiles
            // 
            this.buttonSaveToFiles.Location = new System.Drawing.Point(12, 84);
            this.buttonSaveToFiles.Name = "buttonSaveToFiles";
            this.buttonSaveToFiles.Size = new System.Drawing.Size(215, 66);
            this.buttonSaveToFiles.TabIndex = 2;
            this.buttonSaveToFiles.Text = "buttonSaveToFiles";
            this.buttonSaveToFiles.UseVisualStyleBackColor = true;
            this.buttonSaveToFiles.Click += new System.EventHandler(this.buttonSaveToFiles_Click);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(233, 12);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(215, 22);
            this.textBoxStreet.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(233, 40);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(215, 182);
            this.textBoxResult.TabIndex = 4;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 231);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.buttonSaveToFiles);
            this.Controls.Add(this.buttonGetFilteredData);
            this.Controls.Add(this.buttonAddData);
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonGetFilteredData;
        private System.Windows.Forms.Button buttonSaveToFiles;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

