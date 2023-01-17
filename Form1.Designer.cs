namespace CDDA_Bars
{
	partial class Form1
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
			this.trackBarInput = new System.Windows.Forms.TrackBar();
			this.labelBar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBarInput)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBarInput
			// 
			this.trackBarInput.Location = new System.Drawing.Point(92, 29);
			this.trackBarInput.Maximum = 100;
			this.trackBarInput.Name = "trackBarInput";
			this.trackBarInput.Size = new System.Drawing.Size(240, 45);
			this.trackBarInput.TabIndex = 0;
			this.trackBarInput.Scroll += new System.EventHandler(this.TrackBarInput_Scroll);
			// 
			// labelBar
			// 
			this.labelBar.AutoSize = true;
			this.labelBar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBar.Location = new System.Drawing.Point(99, 150);
			this.labelBar.Name = "labelBar";
			this.labelBar.Size = new System.Drawing.Size(0, 14);
			this.labelBar.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 286);
			this.Controls.Add(this.labelBar);
			this.Controls.Add(this.trackBarInput);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.trackBarInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar trackBarInput;
		private System.Windows.Forms.Label labelBar;
	}
}

