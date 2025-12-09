
namespace DemoProject
{
    partial class MainForm
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnCounter = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.ColorChangeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.BackColor = System.Drawing.Color.Green;
            this.btnClickThis.Location = new System.Drawing.Point(12, 60);
            this.btnClickThis.Location = new System.Drawing.Point(16, 74);
            this.btnClickThis.Margin = new System.Windows.Forms.Padding(4);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(81, 25);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(109, 66);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 13);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(12, 92);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(75, 23);
            this.btnCounter.TabIndex = 2;
            this.btnCounter.Text = "add one";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(94, 101);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 13);
            this.lblCounter.TabIndex = 3;
            // ColorChangeBtn
            // 
            this.ColorChangeBtn.Location = new System.Drawing.Point(16, 40);
            this.ColorChangeBtn.Name = "ColorChangeBtn";
            this.ColorChangeBtn.Size = new System.Drawing.Size(108, 27);
            this.ColorChangeBtn.TabIndex = 2;
            this.ColorChangeBtn.Text = "change Color";
            this.ColorChangeBtn.UseVisualStyleBackColor = true;
            this.ColorChangeBtn.Click += new System.EventHandler(this.ColorChangeBtn_Click);
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(337, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 145);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.ClientSize = new System.Drawing.Size(433, 178);
            this.Controls.Add(this.ColorChangeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Git-Beispiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button ColorChangeBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

