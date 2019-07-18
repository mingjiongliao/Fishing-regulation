namespace Desktop
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
            this.ProvinceBox = new System.Windows.Forms.ComboBox();
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fishingDBDataSet = new Desktop.FishingDBDataSet();
            this.FishingZoneBox = new System.Windows.Forms.ComboBox();
            this.fISHINGZONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fishingDBDataSet1 = new Desktop.FishingDBDataSet1();
            this.FishBox = new System.Windows.Forms.ComboBox();
            this.ProvinceTXT = new System.Windows.Forms.Label();
            this.ZoneTXT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneralInfoTXT = new System.Windows.Forms.Label();
            this.GeneralInfoBox = new System.Windows.Forms.RichTextBox();
            this.FishBoxTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDateTXT = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.NumberLimitTXT = new System.Windows.Forms.Label();
            this.LengthLimitTXT = new System.Windows.Forms.Label();
            this.numberTXT = new System.Windows.Forms.TextBox();
            this.LengthTXT = new System.Windows.Forms.TextBox();
            this.tICKETTableAdapter = new Desktop.FishingDBDataSetTableAdapters.TICKETTableAdapter();
            this.fishingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fishingDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fishingDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fISHING_ZONETableAdapter = new Desktop.FishingDBDataSet1TableAdapters.FISHING_ZONETableAdapter();
            this.fishingDBDataSet2 = new Desktop.FishingDBDataSet2();
            this.fISHINGZONEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fISHING_ZONETableAdapter1 = new Desktop.FishingDBDataSet2TableAdapters.FISHING_ZONETableAdapter();
            this.FishInfoSavebtn = new System.Windows.Forms.Button();
            this.GeneralInfoSavebtn = new System.Windows.Forms.Button();
            this.ilegalWarningTXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fISHINGZONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fISHINGZONEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.DataSource = this.tICKETBindingSource;
            this.ProvinceBox.DisplayMember = "PROVINCE";
            this.ProvinceBox.FormattingEnabled = true;
            this.ProvinceBox.Location = new System.Drawing.Point(283, 89);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(121, 21);
            this.ProvinceBox.TabIndex = 0;
            this.ProvinceBox.ValueMember = "TICKET_ID";
            this.ProvinceBox.SelectionChangeCommitted += new System.EventHandler(this.ProvinceBox_SelectionChangeCommitted);
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataMember = "TICKET";
            this.tICKETBindingSource.DataSource = this.fishingDBDataSet;
            // 
            // fishingDBDataSet
            // 
            this.fishingDBDataSet.DataSetName = "FishingDBDataSet";
            this.fishingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FishingZoneBox
            // 
            this.FishingZoneBox.FormattingEnabled = true;
            this.FishingZoneBox.Location = new System.Drawing.Point(283, 149);
            this.FishingZoneBox.Name = "FishingZoneBox";
            this.FishingZoneBox.Size = new System.Drawing.Size(121, 21);
            this.FishingZoneBox.TabIndex = 1;
            this.FishingZoneBox.SelectedIndexChanged += new System.EventHandler(this.FishingZoneBox_SelectedIndexChanged);
            // 
            // fISHINGZONEBindingSource
            // 
            this.fISHINGZONEBindingSource.DataMember = "FISHING_ZONE";
            this.fISHINGZONEBindingSource.DataSource = this.fishingDBDataSet1;
            // 
            // fishingDBDataSet1
            // 
            this.fishingDBDataSet1.DataSetName = "FishingDBDataSet1";
            this.fishingDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FishBox
            // 
            this.FishBox.FormattingEnabled = true;
            this.FishBox.Location = new System.Drawing.Point(286, 448);
            this.FishBox.Name = "FishBox";
            this.FishBox.Size = new System.Drawing.Size(121, 21);
            this.FishBox.TabIndex = 2;
            this.FishBox.SelectedIndexChanged += new System.EventHandler(this.FishBox_SelectedIndexChanged);
            // 
            // ProvinceTXT
            // 
            this.ProvinceTXT.AutoSize = true;
            this.ProvinceTXT.Location = new System.Drawing.Point(106, 89);
            this.ProvinceTXT.Name = "ProvinceTXT";
            this.ProvinceTXT.Size = new System.Drawing.Size(55, 13);
            this.ProvinceTXT.TabIndex = 3;
            this.ProvinceTXT.Text = "Province: ";
            // 
            // ZoneTXT
            // 
            this.ZoneTXT.AutoSize = true;
            this.ZoneTXT.Location = new System.Drawing.Point(109, 146);
            this.ZoneTXT.Name = "ZoneTXT";
            this.ZoneTXT.Size = new System.Drawing.Size(74, 13);
            this.ZoneTXT.TabIndex = 4;
            this.ZoneTXT.Text = "Fishing Zone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fishing Information Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralInfoTXT
            // 
            this.GeneralInfoTXT.AutoSize = true;
            this.GeneralInfoTXT.Location = new System.Drawing.Point(109, 220);
            this.GeneralInfoTXT.Name = "GeneralInfoTXT";
            this.GeneralInfoTXT.Size = new System.Drawing.Size(105, 13);
            this.GeneralInfoTXT.TabIndex = 6;
            this.GeneralInfoTXT.Text = "General Information: ";
            // 
            // GeneralInfoBox
            // 
            this.GeneralInfoBox.Location = new System.Drawing.Point(283, 220);
            this.GeneralInfoBox.Name = "GeneralInfoBox";
            this.GeneralInfoBox.Size = new System.Drawing.Size(418, 67);
            this.GeneralInfoBox.TabIndex = 7;
            this.GeneralInfoBox.Text = "";
            // 
            // FishBoxTXT
            // 
            this.FishBoxTXT.AutoSize = true;
            this.FishBoxTXT.Location = new System.Drawing.Point(115, 448);
            this.FishBoxTXT.Name = "FishBoxTXT";
            this.FishBoxTXT.Size = new System.Drawing.Size(71, 13);
            this.FishBoxTXT.TabIndex = 8;
            this.FishBoxTXT.Text = "Fish species: ";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "StartDateTXT";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Legal Start date: ";
            // 
            // EndDateTXT
            // 
            this.EndDateTXT.AutoSize = true;
            this.EndDateTXT.Location = new System.Drawing.Point(115, 514);
            this.EndDateTXT.Name = "EndDateTXT";
            this.EndDateTXT.Size = new System.Drawing.Size(85, 13);
            this.EndDateTXT.TabIndex = 10;
            this.EndDateTXT.Text = "Legal End date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 477);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 514);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // NumberLimitTXT
            // 
            this.NumberLimitTXT.AutoSize = true;
            this.NumberLimitTXT.Location = new System.Drawing.Point(115, 541);
            this.NumberLimitTXT.Name = "NumberLimitTXT";
            this.NumberLimitTXT.Size = new System.Drawing.Size(74, 13);
            this.NumberLimitTXT.TabIndex = 13;
            this.NumberLimitTXT.Text = "Number Limit: ";
            // 
            // LengthLimitTXT
            // 
            this.LengthLimitTXT.AutoSize = true;
            this.LengthLimitTXT.Location = new System.Drawing.Point(115, 573);
            this.LengthLimitTXT.Name = "LengthLimitTXT";
            this.LengthLimitTXT.Size = new System.Drawing.Size(70, 13);
            this.LengthLimitTXT.TabIndex = 14;
            this.LengthLimitTXT.Text = "Length Limit: ";
            // 
            // numberTXT
            // 
            this.numberTXT.Location = new System.Drawing.Point(283, 541);
            this.numberTXT.Name = "numberTXT";
            this.numberTXT.Size = new System.Drawing.Size(100, 20);
            this.numberTXT.TabIndex = 15;
            // 
            // LengthTXT
            // 
            this.LengthTXT.Location = new System.Drawing.Point(283, 573);
            this.LengthTXT.Name = "LengthTXT";
            this.LengthTXT.Size = new System.Drawing.Size(100, 20);
            this.LengthTXT.TabIndex = 16;
            // 
            // tICKETTableAdapter
            // 
            this.tICKETTableAdapter.ClearBeforeFill = true;
            // 
            // fishingDBDataSetBindingSource
            // 
            this.fishingDBDataSetBindingSource.DataSource = this.fishingDBDataSet;
            this.fishingDBDataSetBindingSource.Position = 0;
            // 
            // fishingDBDataSetBindingSource1
            // 
            this.fishingDBDataSetBindingSource1.DataSource = this.fishingDBDataSet;
            this.fishingDBDataSetBindingSource1.Position = 0;
            // 
            // fishingDBDataSetBindingSource2
            // 
            this.fishingDBDataSetBindingSource2.DataSource = this.fishingDBDataSet;
            this.fishingDBDataSetBindingSource2.Position = 0;
            // 
            // fISHING_ZONETableAdapter
            // 
            this.fISHING_ZONETableAdapter.ClearBeforeFill = true;
            // 
            // fishingDBDataSet2
            // 
            this.fishingDBDataSet2.DataSetName = "FishingDBDataSet2";
            this.fishingDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fISHINGZONEBindingSource1
            // 
            this.fISHINGZONEBindingSource1.DataMember = "FISHING_ZONE";
            this.fISHINGZONEBindingSource1.DataSource = this.fishingDBDataSet2;
            // 
            // fISHING_ZONETableAdapter1
            // 
            this.fISHING_ZONETableAdapter1.ClearBeforeFill = true;
            // 
            // FishInfoSavebtn
            // 
            this.FishInfoSavebtn.Location = new System.Drawing.Point(286, 600);
            this.FishInfoSavebtn.Name = "FishInfoSavebtn";
            this.FishInfoSavebtn.Size = new System.Drawing.Size(75, 23);
            this.FishInfoSavebtn.TabIndex = 17;
            this.FishInfoSavebtn.Text = "Save";
            this.FishInfoSavebtn.UseVisualStyleBackColor = true;
            this.FishInfoSavebtn.Click += new System.EventHandler(this.FishInfoSavebtn_Click);
            // 
            // GeneralInfoSavebtn
            // 
            this.GeneralInfoSavebtn.Location = new System.Drawing.Point(286, 308);
            this.GeneralInfoSavebtn.Name = "GeneralInfoSavebtn";
            this.GeneralInfoSavebtn.Size = new System.Drawing.Size(75, 23);
            this.GeneralInfoSavebtn.TabIndex = 18;
            this.GeneralInfoSavebtn.Text = "Save";
            this.GeneralInfoSavebtn.UseVisualStyleBackColor = true;
            this.GeneralInfoSavebtn.Click += new System.EventHandler(this.GeneralInfoSavebtn_Click);
            // 
            // ilegalWarningTXT
            // 
            this.ilegalWarningTXT.AutoSize = true;
            this.ilegalWarningTXT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ilegalWarningTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilegalWarningTXT.ForeColor = System.Drawing.Color.Red;
            this.ilegalWarningTXT.Location = new System.Drawing.Point(502, 491);
            this.ilegalWarningTXT.Name = "ilegalWarningTXT";
            this.ilegalWarningTXT.Size = new System.Drawing.Size(0, 16);
            this.ilegalWarningTXT.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 635);
            this.Controls.Add(this.ilegalWarningTXT);
            this.Controls.Add(this.GeneralInfoSavebtn);
            this.Controls.Add(this.FishInfoSavebtn);
            this.Controls.Add(this.LengthTXT);
            this.Controls.Add(this.numberTXT);
            this.Controls.Add(this.LengthLimitTXT);
            this.Controls.Add(this.NumberLimitTXT);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EndDateTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FishBoxTXT);
            this.Controls.Add(this.GeneralInfoBox);
            this.Controls.Add(this.GeneralInfoTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZoneTXT);
            this.Controls.Add(this.ProvinceTXT);
            this.Controls.Add(this.FishBox);
            this.Controls.Add(this.FishingZoneBox);
            this.Controls.Add(this.ProvinceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fISHINGZONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fISHINGZONEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProvinceBox;
        private System.Windows.Forms.ComboBox FishingZoneBox;
        private System.Windows.Forms.ComboBox FishBox;
        private System.Windows.Forms.Label ProvinceTXT;
        private System.Windows.Forms.Label ZoneTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GeneralInfoTXT;
        private System.Windows.Forms.RichTextBox GeneralInfoBox;
        private System.Windows.Forms.Label FishBoxTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EndDateTXT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label NumberLimitTXT;
        private System.Windows.Forms.Label LengthLimitTXT;
        private System.Windows.Forms.TextBox numberTXT;
        private System.Windows.Forms.TextBox LengthTXT;
        private FishingDBDataSet fishingDBDataSet;
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private FishingDBDataSetTableAdapters.TICKETTableAdapter tICKETTableAdapter;
        private System.Windows.Forms.BindingSource fishingDBDataSetBindingSource2;
        private System.Windows.Forms.BindingSource fishingDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource fishingDBDataSetBindingSource1;
        private FishingDBDataSet1 fishingDBDataSet1;
        private System.Windows.Forms.BindingSource fISHINGZONEBindingSource;
        private FishingDBDataSet1TableAdapters.FISHING_ZONETableAdapter fISHING_ZONETableAdapter;
        private FishingDBDataSet2 fishingDBDataSet2;
        private System.Windows.Forms.BindingSource fISHINGZONEBindingSource1;
        private FishingDBDataSet2TableAdapters.FISHING_ZONETableAdapter fISHING_ZONETableAdapter1;
        private System.Windows.Forms.Button FishInfoSavebtn;
        private System.Windows.Forms.Button GeneralInfoSavebtn;
        private System.Windows.Forms.Label ilegalWarningTXT;
    }
}

