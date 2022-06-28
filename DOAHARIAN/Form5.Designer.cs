
namespace DOAHARIAN
{
    partial class Form5
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
            this.dOA_DOA_HARIANNDataSet = new DOAHARIAN.DOA_DOA_HARIANNDataSet();
            this.doaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doaTableAdapter = new DOAHARIAN.DOA_DOA_HARIANNDataSetTableAdapters.DoaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dOA_DOA_HARIANNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dOA_DOA_HARIANNDataSet
            // 
            this.dOA_DOA_HARIANNDataSet.DataSetName = "DOA_DOA_HARIANNDataSet";
            this.dOA_DOA_HARIANNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doaBindingSource
            // 
            this.doaBindingSource.DataMember = "Doa";
            this.doaBindingSource.DataSource = this.dOA_DOA_HARIANNDataSet;
            // 
            // doaTableAdapter
            // 
            this.doaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "NamaDoa", true));
            this.label1.Location = new System.Drawing.Point(76, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 624);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOA_DOA_HARIANNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DOA_DOA_HARIANNDataSet dOA_DOA_HARIANNDataSet;
        private System.Windows.Forms.BindingSource doaBindingSource;
        private DOA_DOA_HARIANNDataSetTableAdapters.DoaTableAdapter doaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}