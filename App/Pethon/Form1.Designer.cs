
namespace Pethon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eQUI_PIPEDataSet = new Pethon.EQUI_PIPEDataSet();
            this.all_sites_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_sites_tableTableAdapter = new Pethon.EQUI_PIPEDataSetTableAdapters.all_sites_tableTableAdapter();
            this.tableAdapterManager = new Pethon.EQUI_PIPEDataSetTableAdapters.TableAdapterManager();
            this.label_valuesTableAdapter = new Pethon.EQUI_PIPEDataSetTableAdapters.label_valuesTableAdapter();
            this.labelsTableAdapter = new Pethon.EQUI_PIPEDataSetTableAdapters.labelsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelvaluesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eQUIPIPEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.атрибутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eQUI_PIPEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelvaluesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPIPEDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eQUI_PIPEDataSet
            // 
            this.eQUI_PIPEDataSet.DataSetName = "EQUI_PIPEDataSet";
            this.eQUI_PIPEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // all_sites_tableBindingSource
            // 
            this.all_sites_tableBindingSource.DataMember = "all_sites_table";
            this.all_sites_tableBindingSource.DataSource = this.eQUI_PIPEDataSet;
            // 
            // all_sites_tableTableAdapter
            // 
            this.all_sites_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.all_sites_tableTableAdapter = this.all_sites_tableTableAdapter;
            this.tableAdapterManager.audit_trailTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.category_tableTableAdapter = null;
            this.tableAdapterManager.component_label_names_assocTableAdapter = null;
            this.tableAdapterManager.component_tableTableAdapter = null;
            this.tableAdapterManager.creation_upgrade_tableTableAdapter = null;
            this.tableAdapterManager.date_table_extendedTableAdapter = null;
            this.tableAdapterManager.date_tableTableAdapter = null;
            this.tableAdapterManager.hierarchy_component_assocTableAdapter = null;
            this.tableAdapterManager.hierarchy_tableTableAdapter = null;
            this.tableAdapterManager.interface_label_names_assocTableAdapter = null;
            this.tableAdapterManager.interface_tableTableAdapter = null;
            this.tableAdapterManager.label_name_valueTableAdapter = null;
            this.tableAdapterManager.label_namesTableAdapter = null;
            this.tableAdapterManager.label_valuesTableAdapter = this.label_valuesTableAdapter;
            this.tableAdapterManager.labels_misc_textTableAdapter = null;
            this.tableAdapterManager.labelsTableAdapter = this.labelsTableAdapter;
            this.tableAdapterManager.linkageTableAdapter = null;
            this.tableAdapterManager.parent_leaf_tableTableAdapter = null;
            this.tableAdapterManager.property_tableTableAdapter = null;
            this.tableAdapterManager.relationship_tableTableAdapter = null;
            this.tableAdapterManager.security_tableTableAdapter = null;
            this.tableAdapterManager.site_tableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pethon.EQUI_PIPEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label_valuesTableAdapter
            // 
            this.label_valuesTableAdapter.ClearBeforeFill = true;
            // 
            // labelsTableAdapter
            // 
            this.labelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 292);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelsBindingSource
            // 
            this.labelsBindingSource.DataMember = "labels";
            this.labelsBindingSource.DataSource = this.eQUI_PIPEDataSet;
            // 
            // labelvaluesBindingSource
            // 
            this.labelvaluesBindingSource.DataMember = "label_values";
            this.labelvaluesBindingSource.DataSource = this.eQUI_PIPEDataSet;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 292);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eQUIPIPEDataSetBindingSource
            // 
            this.eQUIPIPEDataSetBindingSource.DataSource = this.eQUI_PIPEDataSet;
            this.eQUIPIPEDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(789, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.атрибутыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModelsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // loadModelsToolStripMenuItem
            // 
            this.loadModelsToolStripMenuItem.Name = "loadModelsToolStripMenuItem";
            this.loadModelsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadModelsToolStripMenuItem.Text = "Загрузить модели";
            this.loadModelsToolStripMenuItem.Click += new System.EventHandler(this.loadModelsToolStripMenuItem_Click);
            // 
            // атрибутыToolStripMenuItem
            // 
            this.атрибутыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дополнитьToolStripMenuItem});
            this.атрибутыToolStripMenuItem.Name = "атрибутыToolStripMenuItem";
            this.атрибутыToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.атрибутыToolStripMenuItem.Text = "Атрибуты";
            // 
            // дополнитьToolStripMenuItem
            // 
            this.дополнитьToolStripMenuItem.Name = "дополнитьToolStripMenuItem";
            this.дополнитьToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.дополнитьToolStripMenuItem.Text = "Дополнить";
            this.дополнитьToolStripMenuItem.Click += new System.EventHandler(this.дополнитьToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Атрибуты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eQUI_PIPEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelvaluesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPIPEDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EQUI_PIPEDataSet eQUI_PIPEDataSet;
        private System.Windows.Forms.BindingSource all_sites_tableBindingSource;
        private EQUI_PIPEDataSetTableAdapters.all_sites_tableTableAdapter all_sites_tableTableAdapter;
        private EQUI_PIPEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EQUI_PIPEDataSetTableAdapters.labelsTableAdapter labelsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private EQUI_PIPEDataSetTableAdapters.label_valuesTableAdapter label_valuesTableAdapter;
        private System.Windows.Forms.BindingSource labelvaluesBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource eQUIPIPEDataSetBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem атрибутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнитьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

