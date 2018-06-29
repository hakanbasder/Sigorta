namespace Sigorta
{
    partial class ModelEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.MdlEkle_txtBox = new System.Windows.Forms.TextBox();
            this.MdlEkle_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sigortaDataSet5 = new Sigorta.sigortaDataSet5();
            this.markalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markalarTableAdapter = new Sigorta.sigortaDataSet5TableAdapters.MarkalarTableAdapter();
            this.sigortaDataSet6 = new Sigorta.sigortaDataSet6();
            this.markalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.markalarTableAdapter1 = new Sigorta.sigortaDataSet6TableAdapters.MarkalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Ekle :\r\n";
            // 
            // MdlEkle_txtBox
            // 
            this.MdlEkle_txtBox.Location = new System.Drawing.Point(125, 85);
            this.MdlEkle_txtBox.Name = "MdlEkle_txtBox";
            this.MdlEkle_txtBox.Size = new System.Drawing.Size(100, 20);
            this.MdlEkle_txtBox.TabIndex = 1;
            // 
            // MdlEkle_Button
            // 
            this.MdlEkle_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MdlEkle_Button.Location = new System.Drawing.Point(77, 111);
            this.MdlEkle_Button.Name = "MdlEkle_Button";
            this.MdlEkle_Button.Size = new System.Drawing.Size(148, 37);
            this.MdlEkle_Button.TabIndex = 2;
            this.MdlEkle_Button.Text = "Kaydet";
            this.MdlEkle_Button.UseVisualStyleBackColor = true;
            this.MdlEkle_Button.Click += new System.EventHandler(this.MdlEkle_Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(173, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.markalarBindingSource1;
            this.comboBox1.DisplayMember = "MarkaAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "MarkaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka Seç :";
            // 
            // sigortaDataSet5
            // 
            this.sigortaDataSet5.DataSetName = "sigortaDataSet5";
            this.sigortaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markalarBindingSource
            // 
            this.markalarBindingSource.DataMember = "Markalar";
            this.markalarBindingSource.DataSource = this.sigortaDataSet5;
            // 
            // markalarTableAdapter
            // 
            this.markalarTableAdapter.ClearBeforeFill = true;
            // 
            // sigortaDataSet6
            // 
            this.sigortaDataSet6.DataSetName = "sigortaDataSet6";
            this.sigortaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markalarBindingSource1
            // 
            this.markalarBindingSource1.DataMember = "Markalar";
            this.markalarBindingSource1.DataSource = this.sigortaDataSet6;
            // 
            // markalarTableAdapter1
            // 
            this.markalarTableAdapter1.ClearBeforeFill = true;
            // 
            // ModelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MdlEkle_Button);
            this.Controls.Add(this.MdlEkle_txtBox);
            this.Controls.Add(this.label1);
            this.Name = "ModelEkle";
            this.Text = "ModelEkle";
            this.Load += new System.EventHandler(this.ModelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sigortaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MdlEkle_txtBox;
        private System.Windows.Forms.Button MdlEkle_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private sigortaDataSet5 sigortaDataSet5;
        private System.Windows.Forms.BindingSource markalarBindingSource;
        private sigortaDataSet5TableAdapters.MarkalarTableAdapter markalarTableAdapter;
        private sigortaDataSet6 sigortaDataSet6;
        private System.Windows.Forms.BindingSource markalarBindingSource1;
        private sigortaDataSet6TableAdapters.MarkalarTableAdapter markalarTableAdapter1;
    }
}