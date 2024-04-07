namespace BookManagement_HoangNgocTrinh
{
    partial class BookDetailForm
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
            btnSave = new Button();
            grbBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            lblPrice = new Label();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(961, 96);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(44, 85);
            grbBookInfo.Margin = new Padding(3, 2, 3, 2);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Padding = new Padding(3, 2, 3, 2);
            grbBookInfo.Size = new Size(894, 431);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(256, 383);
            cboBookCategoryId.Margin = new Padding(3, 2, 3, 2);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(192, 33);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(256, 244);
            dtpPublicationDate.Margin = new Padding(3, 2, 3, 2);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(212, 32);
            dtpPublicationDate.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(618, 291);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 25);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(256, 337);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(610, 32);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(692, 289);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(174, 32);
            txtPrice.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(256, 135);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(610, 89);
            txtDescription.TabIndex = 2;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(256, 87);
            txtBookName.Margin = new Padding(3, 2, 3, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(610, 32);
            txtBookName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(31, 386);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 25);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(31, 339);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(75, 25);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(31, 291);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(89, 25);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(31, 249);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(159, 25);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(31, 137);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(256, 289);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(174, 32);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(256, 43);
            txtBookId.Margin = new Padding(3, 2, 3, 2);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(610, 32);
            txtBookId.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(31, 89);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(116, 25);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookID.ForeColor = Color.Yellow;
            lblBookID.Location = new Point(31, 45);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(84, 25);
            lblBookID.TabIndex = 3;
            lblBookID.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(28, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(364, 47);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(961, 162);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1150, 537);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookDetailForm";
            Text = "Add | Update a Book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grbBookInfo;
        private TextBox txtQuantity;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblBookID;
        private Label lblHeader;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblDescription;
        private Button btnCancel;
        private Label lblPrice;
        private ComboBox cboBookCategoryId;
        private DateTimePicker dtpPublicationDate;
    }
}