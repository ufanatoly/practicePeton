
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eQUI_PIPEDataSet = new Pethon.EQUI_PIPEDataSet();
            this.all_sites_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_sites_tableTableAdapter = new Pethon.EQUI_PIPEDataSetTableAdapters.all_sites_tableTableAdapter();
            this.tableAdapterManager = new Pethon.EQUI_PIPEDataSetTableAdapters.TableAdapterManager();
            this.label_valuesTableAdapter = new Pethon.EQUI_PIPEDataSetTableAdapters.label_valuesTableAdapter();
            this.labelsTableAdapter = new Pethon.EQUI_PIPEDataSetTableAdapters.labelsTableAdapter();
            this.all_sites_tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.all_sites_tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelvaluesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eQUIPIPEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eQUI_PIPEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingNavigator)).BeginInit();
            this.all_sites_tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelvaluesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPIPEDataSetBindingSource)).BeginInit();
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
            // all_sites_tableBindingNavigator
            // 
            this.all_sites_tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.all_sites_tableBindingNavigator.BindingSource = this.all_sites_tableBindingSource;
            this.all_sites_tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.all_sites_tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.all_sites_tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.all_sites_tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.all_sites_tableBindingNavigatorSaveItem});
            this.all_sites_tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.all_sites_tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.all_sites_tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.all_sites_tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.all_sites_tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.all_sites_tableBindingNavigator.Name = "all_sites_tableBindingNavigator";
            this.all_sites_tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.all_sites_tableBindingNavigator.Size = new System.Drawing.Size(944, 27);
            this.all_sites_tableBindingNavigator.TabIndex = 0;
            this.all_sites_tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // all_sites_tableBindingNavigatorSaveItem
            // 
            this.all_sites_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.all_sites_tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("all_sites_tableBindingNavigatorSaveItem.Image")));
            this.all_sites_tableBindingNavigatorSaveItem.Name = "all_sites_tableBindingNavigatorSaveItem";
            this.all_sites_tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.all_sites_tableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.all_sites_tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.all_sites_tableBindingNavigatorSaveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(476, 301);
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
            this.listBox1.Location = new System.Drawing.Point(0, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 276);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eQUIPIPEDataSetBindingSource
            // 
            this.eQUIPIPEDataSetBindingSource.DataSource = this.eQUI_PIPEDataSet;
            this.eQUIPIPEDataSetBindingSource.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.all_sites_tableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eQUI_PIPEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sites_tableBindingNavigator)).EndInit();
            this.all_sites_tableBindingNavigator.ResumeLayout(false);
            this.all_sites_tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelvaluesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPIPEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EQUI_PIPEDataSet eQUI_PIPEDataSet;
        private System.Windows.Forms.BindingSource all_sites_tableBindingSource;
        private EQUI_PIPEDataSetTableAdapters.all_sites_tableTableAdapter all_sites_tableTableAdapter;
        private EQUI_PIPEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator all_sites_tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton all_sites_tableBindingNavigatorSaveItem;
        private EQUI_PIPEDataSetTableAdapters.labelsTableAdapter labelsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private EQUI_PIPEDataSetTableAdapters.label_valuesTableAdapter label_valuesTableAdapter;
        private System.Windows.Forms.BindingSource labelvaluesBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource eQUIPIPEDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}

