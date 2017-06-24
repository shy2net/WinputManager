namespace WinputManager
{
    partial class TestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capturedInputListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consumeKeyboardEventsCheckBox = new System.Windows.Forms.CheckBox();
            this.consumeMouseEventsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "To setup hooks, a Window must be created. To use this as a library, change this t" +
    "o a \"Class Library\" in the WinputManager project properties and compile it to us" +
    "e within your code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "This is a hook Window";
            // 
            // capturedInputListBox
            // 
            this.capturedInputListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capturedInputListBox.FormattingEnabled = true;
            this.capturedInputListBox.Location = new System.Drawing.Point(8, 22);
            this.capturedInputListBox.Name = "capturedInputListBox";
            this.capturedInputListBox.Size = new System.Drawing.Size(277, 197);
            this.capturedInputListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capturedInputListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 228);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captured inputs:";
            // 
            // consumeKeyboardEventsCheckBox
            // 
            this.consumeKeyboardEventsCheckBox.AutoSize = true;
            this.consumeKeyboardEventsCheckBox.Location = new System.Drawing.Point(11, 347);
            this.consumeKeyboardEventsCheckBox.Name = "consumeKeyboardEventsCheckBox";
            this.consumeKeyboardEventsCheckBox.Size = new System.Drawing.Size(165, 17);
            this.consumeKeyboardEventsCheckBox.TabIndex = 4;
            this.consumeKeyboardEventsCheckBox.Text = "Consume all keyboard events";
            this.consumeKeyboardEventsCheckBox.UseVisualStyleBackColor = true;
            // 
            // consumeMouseEventsCheckBox
            // 
            this.consumeMouseEventsCheckBox.AutoSize = true;
            this.consumeMouseEventsCheckBox.Location = new System.Drawing.Point(11, 370);
            this.consumeMouseEventsCheckBox.Name = "consumeMouseEventsCheckBox";
            this.consumeMouseEventsCheckBox.Size = new System.Drawing.Size(152, 17);
            this.consumeMouseEventsCheckBox.TabIndex = 5;
            this.consumeMouseEventsCheckBox.Text = "Consume all mouse events";
            this.consumeMouseEventsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 397);
            this.Controls.Add(this.consumeMouseEventsCheckBox);
            this.Controls.Add(this.consumeKeyboardEventsCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hook Window";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox capturedInputListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox consumeKeyboardEventsCheckBox;
        private System.Windows.Forms.CheckBox consumeMouseEventsCheckBox;
    }
}