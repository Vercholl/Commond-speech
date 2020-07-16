namespace SpeechRecognition
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.Ex = new System.Windows.Forms.Button();
            this.MinMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Commond speech";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // Ex
            // 
            this.Ex.BackColor = System.Drawing.Color.Transparent;
            this.Ex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ex.BackgroundImage")));
            this.Ex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ex.Location = new System.Drawing.Point(278, 3);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(21, 21);
            this.Ex.TabIndex = 1;
            this.Ex.UseVisualStyleBackColor = false;
            this.Ex.Click += new System.EventHandler(this.Ex_Click);
            // 
            // MinMax
            // 
            this.MinMax.BackColor = System.Drawing.Color.Transparent;
            this.MinMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinMax.BackgroundImage")));
            this.MinMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinMax.Location = new System.Drawing.Point(251, 3);
            this.MinMax.Name = "MinMax";
            this.MinMax.Size = new System.Drawing.Size(21, 21);
            this.MinMax.TabIndex = 2;
            this.MinMax.UseVisualStyleBackColor = false;
            this.MinMax.Click += new System.EventHandler(this.MinMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 31);
            this.Controls.Add(this.MinMax);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Button Ex;
        private System.Windows.Forms.Button MinMax;
    }
}

