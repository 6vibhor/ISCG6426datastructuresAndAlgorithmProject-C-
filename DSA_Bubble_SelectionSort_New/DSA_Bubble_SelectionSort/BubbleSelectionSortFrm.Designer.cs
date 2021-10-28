namespace DSA_Bubble_SelectionSort
{
    partial class BubbleSelectionSortFrm
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
            this.txtArrayLength = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.lblBubbleSort = new System.Windows.Forms.Label();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the length of array :";
            // 
            // txtArrayLength
            // 
            this.txtArrayLength.Location = new System.Drawing.Point(206, 16);
            this.txtArrayLength.Name = "txtArrayLength";
            this.txtArrayLength.Size = new System.Drawing.Size(65, 20);
            this.txtArrayLength.TabIndex = 1;
            this.txtArrayLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArrayLength_KeyPress);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(302, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(243, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubbleSort.Location = new System.Drawing.Point(53, 87);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(156, 50);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionSort.Location = new System.Drawing.Point(352, 87);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(137, 50);
            this.btnSelectionSort.TabIndex = 4;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // lblBubbleSort
            // 
            this.lblBubbleSort.AutoSize = true;
            this.lblBubbleSort.Location = new System.Drawing.Point(53, 175);
            this.lblBubbleSort.Name = "lblBubbleSort";
            this.lblBubbleSort.Size = new System.Drawing.Size(0, 13);
            this.lblBubbleSort.TabIndex = 5;
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Location = new System.Drawing.Point(352, 174);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(0, 13);
            this.lblSelectionSort.TabIndex = 6;
            // 
            // BubbleSelectionSortFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 225);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.lblBubbleSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtArrayLength);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BubbleSelectionSortFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bubble and Selection Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArrayLength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Label lblBubbleSort;
        private System.Windows.Forms.Label lblSelectionSort;
    }
}