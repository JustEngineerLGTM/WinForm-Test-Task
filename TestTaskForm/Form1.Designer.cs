namespace TestTaskForm;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tab = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        tabPage2 = new System.Windows.Forms.TabPage();
        dataGridView_workers = new System.Windows.Forms.DataGridView();
        tab.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_workers).BeginInit();
        SuspendLayout();
        // 
        // tab
        // 
        tab.Controls.Add(tabPage1);
        tab.Controls.Add(tabPage2);
        tab.Dock = System.Windows.Forms.DockStyle.Fill;
        tab.Location = new System.Drawing.Point(0, 0);
        tab.Name = "tab";
        tab.SelectedIndex = 0;
        tab.Size = new System.Drawing.Size(800, 450);
        tab.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(dataGridView_workers);
        tabPage1.Location = new System.Drawing.Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(792, 412);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Данные сотрудников";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new System.Drawing.Point(4, 34);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(3);
        tabPage2.Size = new System.Drawing.Size(792, 412);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Статистика";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // dataGridView_workers
        // 
        dataGridView_workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView_workers.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView_workers.Location = new System.Drawing.Point(3, 3);
        dataGridView_workers.Name = "dataGridView_workers";
        dataGridView_workers.RowHeadersWidth = 62;
        dataGridView_workers.Size = new System.Drawing.Size(786, 259);
        dataGridView_workers.TabIndex = 0;
        dataGridView_workers.Text = "dataGridView1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tab);
        Text = "Form1";
        tab.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView_workers).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tab;
    private System.Windows.Forms.DataGridView dataGridView_workers;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;

    #endregion
}
