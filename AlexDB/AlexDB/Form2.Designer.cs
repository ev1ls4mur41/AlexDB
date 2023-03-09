namespace AlexDB
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label код_валютыLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label обменный_курсLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dB_AlexDataSet = new AlexDB.DB_AlexDataSet();
            this.валютаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.валютаTableAdapter = new AlexDB.DB_AlexDataSetTableAdapters.ВалютаTableAdapter();
            this.tableAdapterManager = new AlexDB.DB_AlexDataSetTableAdapters.TableAdapterManager();
            this.валютаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.валютаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.код_валютыTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.обменный_курсTextBox = new System.Windows.Forms.TextBox();
            кодLabel = new System.Windows.Forms.Label();
            код_валютыLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            обменный_курсLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AlexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingNavigator)).BeginInit();
            this.валютаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(285, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Валюта\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dB_AlexDataSet
            // 
            this.dB_AlexDataSet.DataSetName = "DB_AlexDataSet";
            this.dB_AlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // валютаBindingSource
            // 
            this.валютаBindingSource.DataMember = "Валюта";
            this.валютаBindingSource.DataSource = this.dB_AlexDataSet;
            // 
            // валютаTableAdapter
            // 
            this.валютаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AlexDB.DB_AlexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВалютаTableAdapter = this.валютаTableAdapter;
            this.tableAdapterManager.ВкладчикиTableAdapter = null;
            this.tableAdapterManager.ВкладыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // валютаBindingNavigator
            // 
            this.валютаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.валютаBindingNavigator.BindingSource = this.валютаBindingSource;
            this.валютаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.валютаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.валютаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.валютаBindingNavigatorSaveItem});
            this.валютаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.валютаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.валютаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.валютаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.валютаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.валютаBindingNavigator.Name = "валютаBindingNavigator";
            this.валютаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.валютаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.валютаBindingNavigator.TabIndex = 1;
            this.валютаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // валютаBindingNavigatorSaveItem
            // 
            this.валютаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.валютаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("валютаBindingNavigatorSaveItem.Image")));
            this.валютаBindingNavigatorSaveItem.Name = "валютаBindingNavigatorSaveItem";
            this.валютаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.валютаBindingNavigatorSaveItem.Text = "Save Data";
            this.валютаBindingNavigatorSaveItem.Click += new System.EventHandler(this.валютаBindingNavigatorSaveItem_Click);
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(274, 105);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 2;
            кодLabel.Text = "Код:";
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(309, 102);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодTextBox.TabIndex = 3;
            // 
            // код_валютыLabel
            // 
            код_валютыLabel.AutoSize = true;
            код_валютыLabel.Location = new System.Drawing.Point(232, 131);
            код_валютыLabel.Name = "код_валютыLabel";
            код_валютыLabel.Size = new System.Drawing.Size(71, 13);
            код_валютыLabel.TabIndex = 4;
            код_валютыLabel.Text = "Код валюты:";
            // 
            // код_валютыTextBox
            // 
            this.код_валютыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "Код валюты", true));
            this.код_валютыTextBox.Location = new System.Drawing.Point(309, 128);
            this.код_валютыTextBox.Name = "код_валютыTextBox";
            this.код_валютыTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_валютыTextBox.TabIndex = 5;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(217, 157);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 6;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(309, 154);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 7;
            // 
            // обменный_курсLabel
            // 
            обменный_курсLabel.AutoSize = true;
            обменный_курсLabel.Location = new System.Drawing.Point(213, 183);
            обменный_курсLabel.Name = "обменный_курсLabel";
            обменный_курсLabel.Size = new System.Drawing.Size(90, 13);
            обменный_курсLabel.TabIndex = 8;
            обменный_курсLabel.Text = "Обменный курс:";
            // 
            // обменный_курсTextBox
            // 
            this.обменный_курсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "Обменный курс", true));
            this.обменный_курсTextBox.Location = new System.Drawing.Point(309, 180);
            this.обменный_курсTextBox.Name = "обменный_курсTextBox";
            this.обменный_курсTextBox.Size = new System.Drawing.Size(100, 20);
            this.обменный_курсTextBox.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(обменный_курсLabel);
            this.Controls.Add(this.обменный_курсTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_валютыLabel);
            this.Controls.Add(this.код_валютыTextBox);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодTextBox);
            this.Controls.Add(this.валютаBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_AlexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingNavigator)).EndInit();
            this.валютаBindingNavigator.ResumeLayout(false);
            this.валютаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DB_AlexDataSet dB_AlexDataSet;
        private System.Windows.Forms.BindingSource валютаBindingSource;
        private DB_AlexDataSetTableAdapters.ВалютаTableAdapter валютаTableAdapter;
        private DB_AlexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator валютаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton валютаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.TextBox код_валютыTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox обменный_курсTextBox;
    }
}