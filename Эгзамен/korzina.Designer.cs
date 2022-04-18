namespace Эгзамен
{
    partial class korzina
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
            System.Windows.Forms.Label жанрLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label авторLabel;
            System.Windows.Forms.Label ценаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ценаLabel1 = new System.Windows.Forms.Label();
            this.лист1_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._44п_кляпнев_эгзDataSet2 = new Эгзамен._44п_кляпнев_эгзDataSet2();
            this.авторLabel1 = new System.Windows.Forms.Label();
            this.названиеLabel2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.жанрLabel1 = new System.Windows.Forms.Label();
            this.названиеLabel1 = new System.Windows.Forms.Label();
            this.vozvrat = new System.Windows.Forms.Button();
            this.лист1_TableAdapter = new Эгзамен._44п_кляпнев_эгзDataSet2TableAdapters.Лист1_TableAdapter();
            this.tableAdapterManager = new Эгзамен._44п_кляпнев_эгзDataSet2TableAdapters.TableAdapterManager();
            жанрLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            авторLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лист1_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44п_кляпнев_эгзDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Location = new System.Drawing.Point(391, 18);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(47, 16);
            жанрLabel.TabIndex = 20;
            жанрLabel.Text = "Жанр:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(175, 82);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 16);
            названиеLabel.TabIndex = 22;
            названиеLabel.Text = "Название:";
            // 
            // авторLabel
            // 
            авторLabel.AutoSize = true;
            авторLabel.Location = new System.Drawing.Point(178, 105);
            авторLabel.Name = "авторLabel";
            авторLabel.Size = new System.Drawing.Size(50, 16);
            авторLabel.TabIndex = 23;
            авторLabel.Text = "Автор:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(176, 128);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(43, 16);
            ценаLabel.TabIndex = 24;
            ценаLabel.Text = "Цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Корзина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(ценаLabel);
            this.groupBox1.Controls.Add(this.ценаLabel1);
            this.groupBox1.Controls.Add(авторLabel);
            this.groupBox1.Controls.Add(this.авторLabel1);
            this.groupBox1.Controls.Add(названиеLabel);
            this.groupBox1.Controls.Add(this.названиеLabel2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(жанрLabel);
            this.groupBox1.Controls.Add(this.жанрLabel1);
            this.groupBox1.Controls.Add(this.названиеLabel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 260);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ценаLabel1
            // 
            this.ценаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лист1_BindingSource, "Цена", true));
            this.ценаLabel1.Location = new System.Drawing.Point(225, 128);
            this.ценаLabel1.Name = "ценаLabel1";
            this.ценаLabel1.Size = new System.Drawing.Size(100, 23);
            this.ценаLabel1.TabIndex = 25;
            this.ценаLabel1.Text = "label2";
            // 
            // лист1_BindingSource
            // 
            this.лист1_BindingSource.DataMember = "Лист1$";
            this.лист1_BindingSource.DataSource = this._44п_кляпнев_эгзDataSet2;
            // 
            // _44п_кляпнев_эгзDataSet2
            // 
            this._44п_кляпнев_эгзDataSet2.DataSetName = "_44п_кляпнев_эгзDataSet2";
            this._44п_кляпнев_эгзDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авторLabel1
            // 
            this.авторLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лист1_BindingSource, "Автор", true));
            this.авторLabel1.Location = new System.Drawing.Point(234, 105);
            this.авторLabel1.Name = "авторLabel1";
            this.авторLabel1.Size = new System.Drawing.Size(100, 23);
            this.авторLabel1.TabIndex = 24;
            this.авторLabel1.Text = "label2";
            // 
            // названиеLabel2
            // 
            this.названиеLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лист1_BindingSource, "Название", true));
            this.названиеLabel2.Location = new System.Drawing.Point(257, 82);
            this.названиеLabel2.Name = "названиеLabel2";
            this.названиеLabel2.Size = new System.Drawing.Size(100, 23);
            this.названиеLabel2.TabIndex = 23;
            this.названиеLabel2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Эгзамен.Properties.Resources.Долгая_прогулка;
            this.pictureBox1.Location = new System.Drawing.Point(6, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 164);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // жанрLabel1
            // 
            this.жанрLabel1.Location = new System.Drawing.Point(444, 18);
            this.жанрLabel1.Name = "жанрLabel1";
            this.жанрLabel1.Size = new System.Drawing.Size(100, 23);
            this.жанрLabel1.TabIndex = 21;
            this.жанрLabel1.Text = "label1";
            // 
            // названиеLabel1
            // 
            this.названиеLabel1.Location = new System.Drawing.Point(246, 23);
            this.названиеLabel1.Name = "названиеLabel1";
            this.названиеLabel1.Size = new System.Drawing.Size(125, 23);
            this.названиеLabel1.TabIndex = 20;
            this.названиеLabel1.Text = "label1";
            // 
            // vozvrat
            // 
            this.vozvrat.Location = new System.Drawing.Point(560, 358);
            this.vozvrat.Name = "vozvrat";
            this.vozvrat.Size = new System.Drawing.Size(177, 39);
            this.vozvrat.TabIndex = 20;
            this.vozvrat.Text = "Вернуться";
            this.vozvrat.UseVisualStyleBackColor = true;
            this.vozvrat.Click += new System.EventHandler(this.vozvrat_Click);
            // 
            // лист1_TableAdapter
            // 
            this.лист1_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Эгзамен._44п_кляпнев_эгзDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Лист1_TableAdapter = this.лист1_TableAdapter;
            // 
            // korzina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vozvrat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "korzina";
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.korzina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лист1_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44п_кляпнев_эгзDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label жанрLabel1;
        private System.Windows.Forms.Label названиеLabel1;
        private System.Windows.Forms.Button vozvrat;
        private _44п_кляпнев_эгзDataSet2 _44п_кляпнев_эгзDataSet2;
        private System.Windows.Forms.BindingSource лист1_BindingSource;
        private _44п_кляпнев_эгзDataSet2TableAdapters.Лист1_TableAdapter лист1_TableAdapter;
        private _44п_кляпнев_эгзDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label ценаLabel1;
        private System.Windows.Forms.Label авторLabel1;
        private System.Windows.Forms.Label названиеLabel2;
    }
}