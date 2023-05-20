namespace OODProject;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Title = new System.Windows.Forms.Label();
            this.StartShoppingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.LightCoral;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(525, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(247, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "Automatic Machine";
            // 
            // StartShoppingBtn
            // 
            this.StartShoppingBtn.Location = new System.Drawing.Point(525, 113);
            this.StartShoppingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartShoppingBtn.Name = "StartShoppingBtn";
            this.StartShoppingBtn.Size = new System.Drawing.Size(247, 93);
            this.StartShoppingBtn.TabIndex = 1;
            this.StartShoppingBtn.Text = "start shopping";
            this.StartShoppingBtn.UseVisualStyleBackColor = true;
            this.StartShoppingBtn.Click += new System.EventHandler(this.StartShoppingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 1055);
            this.Controls.Add(this.StartShoppingBtn);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label Title;
    private Button StartShoppingBtn;
}