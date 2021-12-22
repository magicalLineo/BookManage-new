namespace BookManage
{
    partial class frmReport
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
            this.components = new System.ComponentModel.Container();
            
           
            this.BookLibraryDataSet = new BookManage.BookLibraryDataSet();
            this.ReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReaderTableAdapter = new BookManage.BookLibraryDataSetTableAdapters.ReaderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
         
        
            // 
            // BookLibraryDataSet
            // 
            this.BookLibraryDataSet.DataSetName = "BookLibraryDataSet";
            this.BookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReaderBindingSource
            // 
            this.ReaderBindingSource.DataMember = "Reader";
            this.ReaderBindingSource.DataSource = this.BookLibraryDataSet;
            // 
            // ReaderTableAdapter
            // 
            this.ReaderTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 566);
           
            this.Name = "frmReport";
            this.Text = "frmReport";
           
            ((System.ComponentModel.ISupportInitialize)(this.BookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ReaderBindingSource;
        private BookLibraryDataSet BookLibraryDataSet;
        private BookManage.BookLibraryDataSetTableAdapters.ReaderTableAdapter ReaderTableAdapter;
    }
}