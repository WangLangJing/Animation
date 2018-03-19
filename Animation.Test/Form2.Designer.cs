namespace Animation.Test
{
    partial class Form2
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
            this._tbInput = new System.Windows.Forms.TextBox();
            this._tbPattern = new System.Windows.Forms.TextBox();
            this._tbReplacement = new System.Windows.Forms.TextBox();
            this._btnReplace = new System.Windows.Forms.Button();
            this._tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _tbInput
            // 
            this._tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbInput.Location = new System.Drawing.Point(31, 17);
            this._tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbInput.Multiline = true;
            this._tbInput.Name = "_tbInput";
            this._tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._tbInput.Size = new System.Drawing.Size(718, 360);
            this._tbInput.TabIndex = 0;
            // 
            // _tbPattern
            // 
            this._tbPattern.Location = new System.Drawing.Point(140, 396);
            this._tbPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbPattern.Name = "_tbPattern";
            this._tbPattern.Size = new System.Drawing.Size(238, 23);
            this._tbPattern.TabIndex = 1;
            // 
            // _tbReplacement
            // 
            this._tbReplacement.Location = new System.Drawing.Point(140, 435);
            this._tbReplacement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbReplacement.Name = "_tbReplacement";
            this._tbReplacement.Size = new System.Drawing.Size(238, 23);
            this._tbReplacement.TabIndex = 2;
            // 
            // _btnReplace
            // 
            this._btnReplace.Location = new System.Drawing.Point(427, 396);
            this._btnReplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnReplace.Name = "_btnReplace";
            this._btnReplace.Size = new System.Drawing.Size(74, 28);
            this._btnReplace.TabIndex = 4;
            this._btnReplace.Text = "replace";
            this._btnReplace.UseVisualStyleBackColor = true;
            this._btnReplace.Click += new System.EventHandler(this._tbReplace_Click);
            // 
            // _tbOutput
            // 
            this._tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbOutput.Location = new System.Drawing.Point(31, 476);
            this._tbOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbOutput.Multiline = true;
            this._tbOutput.Name = "_tbOutput";
            this._tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._tbOutput.Size = new System.Drawing.Size(718, 218);
            this._tbOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "replacement";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 713);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbOutput);
            this.Controls.Add(this._btnReplace);
            this.Controls.Add(this._tbReplacement);
            this.Controls.Add(this._tbPattern);
            this.Controls.Add(this._tbInput);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Replacement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbInput;
        private System.Windows.Forms.TextBox _tbPattern;
        private System.Windows.Forms.TextBox _tbReplacement;
        private System.Windows.Forms.Button _btnReplace;
        private System.Windows.Forms.TextBox _tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}