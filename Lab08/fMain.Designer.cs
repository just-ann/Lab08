
namespace Lab08
{
    partial class fMain
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
            this.tbPrintersInfo = new System.Windows.Forms.TextBox();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrintersInfo
            // 
            this.tbPrintersInfo.Location = new System.Drawing.Point(12, 12);
            this.tbPrintersInfo.Multiline = true;
            this.tbPrintersInfo.Name = "tbPrintersInfo";
            this.tbPrintersInfo.ReadOnly = true;
            this.tbPrintersInfo.Size = new System.Drawing.Size(562, 300);
            this.tbPrintersInfo.TabIndex = 0;
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.Location = new System.Drawing.Point(593, 25);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(115, 42);
            this.btnAddPrinter.TabIndex = 1;
            this.btnAddPrinter.Text = "Додати інформацію про принтер";
            this.btnAddPrinter.UseVisualStyleBackColor = true;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddTown_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(593, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPrinter);
            this.Controls.Add(this.tbPrintersInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота No8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrintersInfo;
        private System.Windows.Forms.Button btnAddPrinter;
        private System.Windows.Forms.Button btnClose;
    }
}

