
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
            this.atributesGridView1 = new System.Windows.Forms.DataGridView();
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelvaluesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsBox1 = new System.Windows.Forms.ListBox();
            this.eQUIPIPEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eQUI_PIPEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributesGridView1)).BeginInit();
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
            // atributesGridView1
            // 
            this.atributesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atributesGridView1.Location = new System.Drawing.Point(397, 91);
            this.atributesGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.atributesGridView1.Name = "atributesGridView1";
            this.atributesGridView1.RowHeadersWidth = 51;
            this.atributesGridView1.RowTemplate.Height = 24;
            this.atributesGridView1.Size = new System.Drawing.Size(524, 292);
            this.atributesGridView1.TabIndex = 2;
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
            // modelsBox1
            // 
            this.modelsBox1.FormattingEnabled = true;
            this.modelsBox1.ItemHeight = 16;
            this.modelsBox1.Location = new System.Drawing.Point(12, 91);
            this.modelsBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelsBox1.Name = "modelsBox1";
            this.modelsBox1.Size = new System.Drawing.Size(363, 292);
            this.modelsBox1.TabIndex = 3;
            this.modelsBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eQUIPIPEDataSetBindingSource
            // 
            this.eQUIPIPEDataSetBindingSource.DataSource = this.eQUI_PIPEDataSet;
            this.eQUIPIPEDataSetBindingSource.Position = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.atributesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
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
            // atributesToolStripMenuItem
            // 
            this.atributesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.atributesToolStripMenuItem.Name = "atributesToolStripMenuItem";
            this.atributesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.atributesToolStripMenuItem.Text = "Атрибуты";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Дополнить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
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
            this.Controls.Add(this.modelsBox1);
            this.Controls.Add(this.atributesGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Приложение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eQUI_PIPEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributesGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView atributesGridView1;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private EQUI_PIPEDataSetTableAdapters.label_valuesTableAdapter label_valuesTableAdapter;
        private System.Windows.Forms.BindingSource labelvaluesBindingSource;
        private System.Windows.Forms.ListBox modelsBox1;
        private System.Windows.Forms.BindingSource eQUIPIPEDataSetBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

