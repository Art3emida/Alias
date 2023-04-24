
namespace ALIAS
{
    partial class AdminDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDB));
            this.aLIASDataSet = new ALIAS.ALIASDataSet();
            this.aliasDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aliasDictionaryTableAdapter = new ALIAS.ALIASDataSetTableAdapters.AliasDictionaryTableAdapter();
            this.tableAdapterManager = new ALIAS.ALIASDataSetTableAdapters.TableAdapterManager();
            this.aliasDictionaryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aliasDictionaryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aliasDictionaryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnToGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aLIASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasDictionaryBindingNavigator)).BeginInit();
            this.aliasDictionaryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aliasDictionaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aLIASDataSet
            // 
            this.aLIASDataSet.DataSetName = "ALIASDataSet";
            this.aLIASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aliasDictionaryBindingSource
            // 
            this.aliasDictionaryBindingSource.DataMember = "AliasDictionary";
            this.aliasDictionaryBindingSource.DataSource = this.aLIASDataSet;
            // 
            // aliasDictionaryTableAdapter
            // 
            this.aliasDictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AliasDictionaryTableAdapter = this.aliasDictionaryTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ALIAS.ALIASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aliasDictionaryBindingNavigator
            // 
            this.aliasDictionaryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aliasDictionaryBindingNavigator.BindingSource = this.aliasDictionaryBindingSource;
            this.aliasDictionaryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aliasDictionaryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aliasDictionaryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aliasDictionaryBindingNavigatorSaveItem});
            this.aliasDictionaryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aliasDictionaryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aliasDictionaryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aliasDictionaryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aliasDictionaryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aliasDictionaryBindingNavigator.Name = "aliasDictionaryBindingNavigator";
            this.aliasDictionaryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aliasDictionaryBindingNavigator.Size = new System.Drawing.Size(606, 25);
            this.aliasDictionaryBindingNavigator.TabIndex = 0;
            this.aliasDictionaryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // aliasDictionaryBindingNavigatorSaveItem
            // 
            this.aliasDictionaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aliasDictionaryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aliasDictionaryBindingNavigatorSaveItem.Image")));
            this.aliasDictionaryBindingNavigatorSaveItem.Name = "aliasDictionaryBindingNavigatorSaveItem";
            this.aliasDictionaryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aliasDictionaryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.aliasDictionaryBindingNavigatorSaveItem.Click += new System.EventHandler(this.aliasDictionaryBindingNavigatorSaveItem_Click);
            // 
            // aliasDictionaryDataGridView
            // 
            this.aliasDictionaryDataGridView.AutoGenerateColumns = false;
            this.aliasDictionaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aliasDictionaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.aliasDictionaryDataGridView.DataSource = this.aliasDictionaryBindingSource;
            this.aliasDictionaryDataGridView.Location = new System.Drawing.Point(0, 28);
            this.aliasDictionaryDataGridView.Name = "aliasDictionaryDataGridView";
            this.aliasDictionaryDataGridView.Size = new System.Drawing.Size(390, 423);
            this.aliasDictionaryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "word";
            this.dataGridViewTextBoxColumn5.HeaderText = "word";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hint";
            this.dataGridViewTextBoxColumn6.HeaderText = "hint";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnReturnToGame
            // 
            this.btnReturnToGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnToGame.Location = new System.Drawing.Point(429, 28);
            this.btnReturnToGame.Name = "btnReturnToGame";
            this.btnReturnToGame.Size = new System.Drawing.Size(139, 48);
            this.btnReturnToGame.TabIndex = 2;
            this.btnReturnToGame.Text = "Game";
            this.btnReturnToGame.UseVisualStyleBackColor = true;
            this.btnReturnToGame.Click += new System.EventHandler(this.btnReturnToGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(429, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 451);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturnToGame);
            this.Controls.Add(this.aliasDictionaryDataGridView);
            this.Controls.Add(this.aliasDictionaryBindingNavigator);
            this.Name = "AdminDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDB";
            this.Load += new System.EventHandler(this.AdminDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLIASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasDictionaryBindingNavigator)).EndInit();
            this.aliasDictionaryBindingNavigator.ResumeLayout(false);
            this.aliasDictionaryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aliasDictionaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ALIASDataSet aLIASDataSet;
        private System.Windows.Forms.BindingSource aliasDictionaryBindingSource;
        private ALIASDataSetTableAdapters.AliasDictionaryTableAdapter aliasDictionaryTableAdapter;
        private ALIASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aliasDictionaryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aliasDictionaryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aliasDictionaryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnReturnToGame;
        private System.Windows.Forms.Button btnExit;
    }
}