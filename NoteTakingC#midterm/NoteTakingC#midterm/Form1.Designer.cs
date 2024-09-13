namespace NoteTakingC_midterm
{
    partial class frmNotes
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
            components = new System.ComponentModel.Container();
            grdNotes = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bodyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteBindingSource = new BindingSource(components);
            btnAddNote = new Button();
            txtNote = new TextBox();
            txtTitle = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grdNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grdNotes
            // 
            grdNotes.AutoGenerateColumns = false;
            grdNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdNotes.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, bodyDataGridViewTextBoxColumn });
            grdNotes.DataSource = noteBindingSource;
            grdNotes.Location = new Point(626, 12);
            grdNotes.Name = "grdNotes";
            grdNotes.RowHeadersWidth = 51;
            grdNotes.RowTemplate.Height = 29;
            grdNotes.Size = new Size(428, 455);
            grdNotes.TabIndex = 7;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            bodyDataGridViewTextBoxColumn.MinimumWidth = 6;
            bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            bodyDataGridViewTextBoxColumn.Width = 300;
            // 
            // noteBindingSource
            // 
            noteBindingSource.DataSource = typeof(Note);
            noteBindingSource.CurrentChanged += noteBindingSource_CurrentChanged;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(626, 473);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(110, 38);
            btnAddNote.TabIndex = 6;
            btnAddNote.Text = "New";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // txtNote
            // 
            txtNote.DataBindings.Add(new Binding("Text", noteBindingSource, "Body", true));
            txtNote.Location = new Point(12, 45);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Add Note";
            txtNote.Size = new Size(590, 466);
            txtNote.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.DataBindings.Add(new Binding("Text", noteBindingSource, "Title", true));
            txtTitle.Location = new Point(12, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Add Title";
            txtTitle.Size = new Size(590, 27);
            txtTitle.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(742, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 38);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmNotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 530);
            Controls.Add(btnDelete);
            Controls.Add(grdNotes);
            Controls.Add(btnAddNote);
            Controls.Add(txtNote);
            Controls.Add(txtTitle);
            Name = "frmNotes";
            Text = "Notes";
            Load += frmNotes_Load;
            ((System.ComponentModel.ISupportInitialize)grdNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdNotes;
        private Button btnAddNote;
        private TextBox txtNote;
        private TextBox txtTitle;
        private Button btnDelete;
        private BindingSource noteBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
    }
}