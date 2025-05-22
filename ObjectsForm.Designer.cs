namespace PR5
{
    partial class ObjectsForm
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
            backBtn = new Button();
            objectsList = new FlowLayoutPanel();
            editGrid = new DataGridView();
            saveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)editGrid).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(66, 5, 2);
            backBtn.ForeColor = SystemColors.Control;
            backBtn.Location = new Point(12, 336);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(138, 28);
            backBtn.TabIndex = 2;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // objectsList
            // 
            objectsList.AutoScroll = true;
            objectsList.BackColor = Color.FromArgb(142, 173, 196);
            objectsList.Font = new Font("Times New Roman", 10F);
            objectsList.Location = new Point(12, 10);
            objectsList.Name = "objectsList";
            objectsList.Size = new Size(440, 320);
            objectsList.TabIndex = 1;
            // 
            // editGrid
            // 
            editGrid.BackgroundColor = Color.FromArgb(142, 173, 196);
            editGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editGrid.GridColor = Color.DarkGray;
            editGrid.Location = new Point(12, 10);
            editGrid.Name = "editGrid";
            editGrid.Size = new Size(440, 320);
            editGrid.TabIndex = 3;
            editGrid.Visible = false;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(66, 5, 2);
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(156, 336);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(138, 28);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // ObjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(464, 371);
            Controls.Add(saveBtn);
            Controls.Add(editGrid);
            Controls.Add(backBtn);
            Controls.Add(objectsList);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ObjectsForm";
            Text = "Objects";
            ((System.ComponentModel.ISupportInitialize)editGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button backBtn;
        private FlowLayoutPanel objectsList;
        private DataGridView editGrid;
        private Button saveBtn;
    }
}