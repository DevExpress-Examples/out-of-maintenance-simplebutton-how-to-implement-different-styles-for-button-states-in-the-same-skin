namespace dxSample_CustomSimpleButton {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.customButton3 = new dxSample_CustomSimpleButton.Custom_Button.CustomButton();
            this.customButton2 = new dxSample_CustomSimpleButton.Custom_Button.CustomButton();
            this.customButton1 = new dxSample_CustomSimpleButton.Custom_Button.CustomButton();
            this.SuspendLayout();
            // 
            // customButton3
            // 
            this.customButton3.CustomStyle = dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3;
            this.customButton3.Location = new System.Drawing.Point(455, 109);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(101, 36);
            this.customButton3.TabIndex = 2;
            this.customButton3.Text = "customButton3";
            // 
            // customButton2
            // 
            this.customButton2.CustomStyle = dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3;
            this.customButton2.Location = new System.Drawing.Point(253, 109);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(101, 36);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "customButton2";
            // 
            // customButton1
            // 
            this.customButton1.CustomStyle = dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3;
            this.customButton1.Location = new System.Drawing.Point(55, 109);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(101, 36);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "customButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Button.CustomButton customButton1;
        private Custom_Button.CustomButton customButton2;
        private Custom_Button.CustomButton customButton3;



    }
}

