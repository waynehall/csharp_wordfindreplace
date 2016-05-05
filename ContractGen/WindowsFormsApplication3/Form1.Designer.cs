namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.masterPropListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newTestDataSet = new WindowsFormsApplication3.NewTestDataSet();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadDoc = new System.Windows.Forms.OpenFileDialog();
            this.SaveDoc = new System.Windows.Forms.SaveFileDialog();
            this.propertiesTableAdapter = new WindowsFormsApplication3.NewTestDataSetTableAdapters.PropertiesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new WindowsFormsApplication3.NewTestDataSetTableAdapters.VendorsTableAdapter();
            this.masterPropListTableAdapter = new WindowsFormsApplication3.NewTestDataSetTableAdapters.MasterPropListTableAdapter();
            this.tFilename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textContractDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textWorkBegin = new System.Windows.Forms.TextBox();
            this.textEndDate = new System.Windows.Forms.TextBox();
            this.enddate = new System.Windows.Forms.Label();
            this.textSummary = new System.Windows.Forms.TextBox();
            this.labelsummary = new System.Windows.Forms.Label();
            this.textDollars = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDollarWords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterPropListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.masterPropListBindingSource;
            this.comboBox1.DisplayMember = "Property Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // masterPropListBindingSource
            // 
            this.masterPropListBindingSource.DataMember = "MasterPropList";
            this.masterPropListBindingSource.DataSource = this.newTestDataSet;
            // 
            // newTestDataSet
            // 
            this.newTestDataSet.DataSetName = "NewTestDataSet";
            this.newTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.newTestDataSet;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Template";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(339, 384);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 45);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Waynerize";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Property";
            // 
            // comboVendor
            // 
            this.comboVendor.DataSource = this.vendorsBindingSource;
            this.comboVendor.DisplayMember = "Vendor Name";
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(25, 71);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(293, 21);
            this.comboVendor.TabIndex = 5;
            this.comboVendor.SelectedIndexChanged += new System.EventHandler(this.comboVendor_SelectedIndexChanged);
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.newTestDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // masterPropListTableAdapter
            // 
            this.masterPropListTableAdapter.ClearBeforeFill = true;
            // 
            // tFilename
            // 
            this.tFilename.AutoSize = true;
            this.tFilename.Location = new System.Drawing.Point(177, 441);
            this.tFilename.Name = "tFilename";
            this.tFilename.Size = new System.Drawing.Size(35, 13);
            this.tFilename.TabIndex = 6;
            this.tFilename.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vendor";
            // 
            // textContractDate
            // 
            this.textContractDate.Location = new System.Drawing.Point(25, 115);
            this.textContractDate.Name = "textContractDate";
            this.textContractDate.Size = new System.Drawing.Size(178, 20);
            this.textContractDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contract Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Work Begin Date";
            // 
            // textWorkBegin
            // 
            this.textWorkBegin.Location = new System.Drawing.Point(25, 154);
            this.textWorkBegin.Name = "textWorkBegin";
            this.textWorkBegin.Size = new System.Drawing.Size(175, 20);
            this.textWorkBegin.TabIndex = 11;
            // 
            // textEndDate
            // 
            this.textEndDate.Location = new System.Drawing.Point(25, 193);
            this.textEndDate.Name = "textEndDate";
            this.textEndDate.Size = new System.Drawing.Size(173, 20);
            this.textEndDate.TabIndex = 12;
            // 
            // enddate
            // 
            this.enddate.AutoSize = true;
            this.enddate.Location = new System.Drawing.Point(22, 177);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(81, 13);
            this.enddate.TabIndex = 13;
            this.enddate.Text = "Work End Date";
            // 
            // textSummary
            // 
            this.textSummary.Location = new System.Drawing.Point(25, 232);
            this.textSummary.Multiline = true;
            this.textSummary.Name = "textSummary";
            this.textSummary.Size = new System.Drawing.Size(381, 68);
            this.textSummary.TabIndex = 14;
            // 
            // labelsummary
            // 
            this.labelsummary.AutoSize = true;
            this.labelsummary.Location = new System.Drawing.Point(22, 216);
            this.labelsummary.Name = "labelsummary";
            this.labelsummary.Size = new System.Drawing.Size(77, 13);
            this.labelsummary.TabIndex = 15;
            this.labelsummary.Text = "Work summary";
            // 
            // textDollars
            // 
            this.textDollars.Location = new System.Drawing.Point(25, 319);
            this.textDollars.Name = "textDollars";
            this.textDollars.Size = new System.Drawing.Size(187, 20);
            this.textDollars.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contract $ Amount";
            // 
            // textDollarWords
            // 
            this.textDollarWords.Location = new System.Drawing.Point(25, 358);
            this.textDollarWords.Name = "textDollarWords";
            this.textDollarWords.Size = new System.Drawing.Size(381, 20);
            this.textDollarWords.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "$ As Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "KM Contract Generator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Step 1.  Fill out form.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Step 2.  Press \"Load Template\" and select the";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = " MasterTemplate document from ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "F:\\users\\Property Management\\Tenant--Vendor Databases\\";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(281, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Step 3.  Select \"Waynerize\" and save the new document ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "where you want.  Congrats on your new contract!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "DO NOT SAVE OVER MASTER TEMPLATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 463);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDollarWords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDollars);
            this.Controls.Add(this.labelsummary);
            this.Controls.Add(this.textSummary);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.textEndDate);
            this.Controls.Add(this.textWorkBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textContractDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tFilename);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterPropListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog LoadDoc;
        private System.Windows.Forms.SaveFileDialog SaveDoc;
        private System.Windows.Forms.ComboBox comboBox1;
        private NewTestDataSet newTestDataSet;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private NewTestDataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private NewTestDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.BindingSource masterPropListBindingSource;
        private NewTestDataSetTableAdapters.MasterPropListTableAdapter masterPropListTableAdapter;
        private System.Windows.Forms.Label tFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textContractDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textWorkBegin;
        private System.Windows.Forms.TextBox textEndDate;
        private System.Windows.Forms.Label enddate;
        private System.Windows.Forms.TextBox textSummary;
        private System.Windows.Forms.Label labelsummary;
        private System.Windows.Forms.TextBox textDollars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDollarWords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

