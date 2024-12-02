namespace WinFormsDapper.UserControls
{
    partial class PersonSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            searchButton = new Button();
            lastNameLabel = new Label();
            lastNameText = new TextBox();
            peopleFoundListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(177, 41);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(700, 443);
            dataGridView1.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.Location = new Point(802, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(553, 15);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(77, 15);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Search Name";
            // 
            // lastNameText
            // 
            lastNameText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lastNameText.Location = new Point(636, 12);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(157, 23);
            lastNameText.TabIndex = 6;
            // 
            // peopleFoundListBox
            // 
            peopleFoundListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            peopleFoundListBox.FormattingEnabled = true;
            peopleFoundListBox.ItemHeight = 15;
            peopleFoundListBox.Location = new Point(3, 41);
            peopleFoundListBox.Name = "peopleFoundListBox";
            peopleFoundListBox.Size = new Size(168, 439);
            peopleFoundListBox.TabIndex = 5;
            // 
            // PersonSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dataGridView1);
            Controls.Add(searchButton);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameText);
            Controls.Add(peopleFoundListBox);
            Name = "PersonSearch";
            Size = new Size(880, 487);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button searchButton;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private ListBox peopleFoundListBox;
    }
}
