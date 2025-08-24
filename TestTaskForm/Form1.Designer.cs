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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        comboBoxStatus = new System.Windows.Forms.ComboBox();
        textboxLastName = new System.Windows.Forms.TextBox();
        dataGridView_employees = new System.Windows.Forms.DataGridView();
        comboBoxPost = new System.Windows.Forms.ComboBox();
        comboBoxDep = new System.Windows.Forms.ComboBox();
        tabPage2 = new System.Windows.Forms.TabPage();
        tab.SuspendLayout();
        tabPage1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_employees).BeginInit();
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
        tabPage1.Controls.Add(tableLayoutPanel1);
        tabPage1.Location = new System.Drawing.Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(792, 412);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Данные сотрудников";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(comboBoxStatus, 0, 0);
        tableLayoutPanel1.Controls.Add(textboxLastName, 3, 0);
        tableLayoutPanel1.Controls.Add(dataGridView_employees, 0, 1);
        tableLayoutPanel1.Controls.Add(comboBoxPost, 2, 0);
        tableLayoutPanel1.Controls.Add(comboBoxDep, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanel1.Size = new System.Drawing.Size(786, 406);
        tableLayoutPanel1.TabIndex = 5;
        // 
        // comboBoxStatus
        // 
        comboBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
        comboBoxStatus.FormattingEnabled = true;
        comboBoxStatus.Location = new System.Drawing.Point(3, 3);
        comboBoxStatus.MinimumSize = new System.Drawing.Size(10, 0);
        comboBoxStatus.Name = "comboBoxStatus";
        comboBoxStatus.Size = new System.Drawing.Size(190, 33);
        comboBoxStatus.TabIndex = 1;
        // 
        // textboxLastName
        // 
        textboxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
        textboxLastName.Location = new System.Drawing.Point(591, 3);
        textboxLastName.MinimumSize = new System.Drawing.Size(10, 0);
        textboxLastName.Name = "textboxLastName";
        textboxLastName.Size = new System.Drawing.Size(192, 31);
        textboxLastName.TabIndex = 4;
        // 
        // dataGridView_employees
        // 
        dataGridView_employees.AllowUserToAddRows = false;
        dataGridView_employees.AllowUserToDeleteRows = false;
        dataGridView_employees.AllowUserToOrderColumns = true;
        dataGridView_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanel1.SetColumnSpan(dataGridView_employees, 4);
        dataGridView_employees.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView_employees.Location = new System.Drawing.Point(3, 42);
        dataGridView_employees.Name = "dataGridView_employees";
        dataGridView_employees.ReadOnly = true;
        dataGridView_employees.RowHeadersVisible = false;
        dataGridView_employees.RowHeadersWidth = 62;
        dataGridView_employees.Size = new System.Drawing.Size(780, 361);
        dataGridView_employees.TabIndex = 0;
        dataGridView_employees.Text = "dataGridView1";
        // 
        // comboBoxPost
        // 
        comboBoxPost.Dock = System.Windows.Forms.DockStyle.Fill;
        comboBoxPost.FormattingEnabled = true;
        comboBoxPost.Location = new System.Drawing.Point(395, 3);
        comboBoxPost.MinimumSize = new System.Drawing.Size(10, 0);
        comboBoxPost.Name = "comboBoxPost";
        comboBoxPost.Size = new System.Drawing.Size(190, 33);
        comboBoxPost.TabIndex = 3;
        // 
        // comboBoxDep
        // 
        comboBoxDep.Dock = System.Windows.Forms.DockStyle.Fill;
        comboBoxDep.FormattingEnabled = true;
        comboBoxDep.Location = new System.Drawing.Point(199, 3);
        comboBoxDep.MinimumSize = new System.Drawing.Size(10, 0);
        comboBoxDep.Name = "comboBoxDep";
        comboBoxDep.Size = new System.Drawing.Size(190, 33);
        comboBoxDep.TabIndex = 2;
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
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tab);
        MinimumSize = new System.Drawing.Size(500, 500);
        Text = "Form1";
        tab.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_employees).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.TextBox textboxLastName;

    private System.Windows.Forms.ComboBox comboBoxStatus;
    private System.Windows.Forms.ComboBox comboBoxDep;
    private System.Windows.Forms.ComboBox comboBoxPost;

    private System.Windows.Forms.TabControl tab;
    private System.Windows.Forms.DataGridView dataGridView_employees;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;

    #endregion
}
