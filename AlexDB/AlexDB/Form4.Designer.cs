namespace AlexDB
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label код_вкладаLabel;
            System.Windows.Forms.Label наименование_вкладаLabel;
            System.Windows.Forms.Label минимальный_срок_вкладаLabel;
            System.Windows.Forms.Label минимальная_сумма_вкладаLabel;
            System.Windows.Forms.Label код_валютыLabel;
            System.Windows.Forms.Label процентная_ставкаLabel;
            System.Windows.Forms.Label дополнительные_условияLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dB_AlexDataSet = new AlexDB.DB_AlexDataSet();
            this.вкладыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладыTableAdapter = new AlexDB.DB_AlexDataSetTableAdapters.ВкладыTableAdapter();
            this.tableAdapterManager = new AlexDB.DB_AlexDataSetTableAdapters.TableAdapterManager();
            this.вкладыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.вкладыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.код_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.наименование_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.минимальный_срок_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.минимальная_сумма_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.код_валютыTextBox = new System.Windows.Forms.TextBox();
            this.процентная_ставкаTextBox = new System.Windows.Forms.TextBox();
            this.дополнительные_условияTextBox = new System.Windows.Forms.TextBox();
            кодLabel = new System.Windows.Forms.Label();
            код_вкладаLabel = new System.Windows.Forms.Label();
            наименование_вкладаLabel = new System.Windows.Forms.Label();
            минимальный_срок_вкладаLabel = new System.Windows.Forms.Label();
            минимальная_сумма_вкладаLabel = new System.Windows.Forms.Label();
            код_валютыLabel = new System.Windows.Forms.Label();
            процентная_ставкаLabel = new System.Windows.Forms.Label();
            дополнительные_условияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AlexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingNavigator)).BeginInit();
            this.вкладыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(316, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Вклады\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dB_AlexDataSet
            // 
            this.dB_AlexDataSet.DataSetName = "DB_AlexDataSet";
            this.dB_AlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вкладыBindingSource
            // 
            this.вкладыBindingSource.DataMember = "Вклады";
            this.вкладыBindingSource.DataSource = this.dB_AlexDataSet;
            // 
            // вкладыTableAdapter
            // 
            this.вкладыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AlexDB.DB_AlexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВалютаTableAdapter = null;
            this.tableAdapterManager.ВкладчикиTableAdapter = null;
            this.tableAdapterManager.ВкладыTableAdapter = this.вкладыTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // вкладыBindingNavigator
            // 
            this.вкладыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.вкладыBindingNavigator.BindingSource = this.вкладыBindingSource;
            this.вкладыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.вкладыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.вкладыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.вкладыBindingNavigatorSaveItem});
            this.вкладыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.вкладыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.вкладыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.вкладыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.вкладыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.вкладыBindingNavigator.Name = "вкладыBindingNavigator";
            this.вкладыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.вкладыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.вкладыBindingNavigator.TabIndex = 1;
            this.вкладыBindingNavigator.Text = "bindingNavigator1";
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
            // вкладыBindingNavigatorSaveItem
            // 
            this.вкладыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вкладыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("вкладыBindingNavigatorSaveItem.Image")));
            this.вкладыBindingNavigatorSaveItem.Name = "вкладыBindingNavigatorSaveItem";
            this.вкладыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.вкладыBindingNavigatorSaveItem.Text = "Save Data";
            this.вкладыBindingNavigatorSaveItem.Click += new System.EventHandler(this.вкладыBindingNavigatorSaveItem_Click);
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(278, 121);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 2;
            кодLabel.Text = "Код:";
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(313, 118);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодTextBox.TabIndex = 3;
            // 
            // код_вкладаLabel
            // 
            код_вкладаLabel.AutoSize = true;
            код_вкладаLabel.Location = new System.Drawing.Point(239, 147);
            код_вкладаLabel.Name = "код_вкладаLabel";
            код_вкладаLabel.Size = new System.Drawing.Size(68, 13);
            код_вкладаLabel.TabIndex = 4;
            код_вкладаLabel.Text = "Код вклада:";
            // 
            // код_вкладаTextBox
            // 
            this.код_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Код вклада", true));
            this.код_вкладаTextBox.Location = new System.Drawing.Point(313, 144);
            this.код_вкладаTextBox.Name = "код_вкладаTextBox";
            this.код_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_вкладаTextBox.TabIndex = 5;
            // 
            // наименование_вкладаLabel
            // 
            наименование_вкладаLabel.AutoSize = true;
            наименование_вкладаLabel.Location = new System.Drawing.Point(182, 173);
            наименование_вкладаLabel.Name = "наименование_вкладаLabel";
            наименование_вкладаLabel.Size = new System.Drawing.Size(125, 13);
            наименование_вкладаLabel.TabIndex = 6;
            наименование_вкладаLabel.Text = "Наименование вклада:";
            // 
            // наименование_вкладаTextBox
            // 
            this.наименование_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Наименование вклада", true));
            this.наименование_вкладаTextBox.Location = new System.Drawing.Point(313, 170);
            this.наименование_вкладаTextBox.Name = "наименование_вкладаTextBox";
            this.наименование_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименование_вкладаTextBox.TabIndex = 7;
            // 
            // минимальный_срок_вкладаLabel
            // 
            минимальный_срок_вкладаLabel.AutoSize = true;
            минимальный_срок_вкладаLabel.Location = new System.Drawing.Point(158, 199);
            минимальный_срок_вкладаLabel.Name = "минимальный_срок_вкладаLabel";
            минимальный_срок_вкладаLabel.Size = new System.Drawing.Size(149, 13);
            минимальный_срок_вкладаLabel.TabIndex = 8;
            минимальный_срок_вкладаLabel.Text = "Минимальный срок вклада:";
            // 
            // минимальный_срок_вкладаTextBox
            // 
            this.минимальный_срок_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Минимальный срок вклада", true));
            this.минимальный_срок_вкладаTextBox.Location = new System.Drawing.Point(313, 196);
            this.минимальный_срок_вкладаTextBox.Name = "минимальный_срок_вкладаTextBox";
            this.минимальный_срок_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.минимальный_срок_вкладаTextBox.TabIndex = 9;
            // 
            // минимальная_сумма_вкладаLabel
            // 
            минимальная_сумма_вкладаLabel.AutoSize = true;
            минимальная_сумма_вкладаLabel.Location = new System.Drawing.Point(151, 225);
            минимальная_сумма_вкладаLabel.Name = "минимальная_сумма_вкладаLabel";
            минимальная_сумма_вкладаLabel.Size = new System.Drawing.Size(156, 13);
            минимальная_сумма_вкладаLabel.TabIndex = 10;
            минимальная_сумма_вкладаLabel.Text = "Минимальная сумма вклада:";
            // 
            // минимальная_сумма_вкладаTextBox
            // 
            this.минимальная_сумма_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Минимальная сумма вклада", true));
            this.минимальная_сумма_вкладаTextBox.Location = new System.Drawing.Point(313, 222);
            this.минимальная_сумма_вкладаTextBox.Name = "минимальная_сумма_вкладаTextBox";
            this.минимальная_сумма_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.минимальная_сумма_вкладаTextBox.TabIndex = 11;
            // 
            // код_валютыLabel
            // 
            код_валютыLabel.AutoSize = true;
            код_валютыLabel.Location = new System.Drawing.Point(236, 251);
            код_валютыLabel.Name = "код_валютыLabel";
            код_валютыLabel.Size = new System.Drawing.Size(71, 13);
            код_валютыLabel.TabIndex = 12;
            код_валютыLabel.Text = "Код валюты:";
            // 
            // код_валютыTextBox
            // 
            this.код_валютыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Код валюты", true));
            this.код_валютыTextBox.Location = new System.Drawing.Point(313, 248);
            this.код_валютыTextBox.Name = "код_валютыTextBox";
            this.код_валютыTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_валютыTextBox.TabIndex = 13;
            // 
            // процентная_ставкаLabel
            // 
            процентная_ставкаLabel.AutoSize = true;
            процентная_ставкаLabel.Location = new System.Drawing.Point(198, 277);
            процентная_ставкаLabel.Name = "процентная_ставкаLabel";
            процентная_ставкаLabel.Size = new System.Drawing.Size(109, 13);
            процентная_ставкаLabel.TabIndex = 14;
            процентная_ставкаLabel.Text = "Процентная ставка:";
            // 
            // процентная_ставкаTextBox
            // 
            this.процентная_ставкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Процентная ставка", true));
            this.процентная_ставкаTextBox.Location = new System.Drawing.Point(313, 274);
            this.процентная_ставкаTextBox.Name = "процентная_ставкаTextBox";
            this.процентная_ставкаTextBox.Size = new System.Drawing.Size(100, 20);
            this.процентная_ставкаTextBox.TabIndex = 15;
            // 
            // дополнительные_условияLabel
            // 
            дополнительные_условияLabel.AutoSize = true;
            дополнительные_условияLabel.Location = new System.Drawing.Point(165, 303);
            дополнительные_условияLabel.Name = "дополнительные_условияLabel";
            дополнительные_условияLabel.Size = new System.Drawing.Size(142, 13);
            дополнительные_условияLabel.TabIndex = 16;
            дополнительные_условияLabel.Text = "Дополнительные условия:";
            // 
            // дополнительные_условияTextBox
            // 
            this.дополнительные_условияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "Дополнительные условия", true));
            this.дополнительные_условияTextBox.Location = new System.Drawing.Point(313, 300);
            this.дополнительные_условияTextBox.Name = "дополнительные_условияTextBox";
            this.дополнительные_условияTextBox.Size = new System.Drawing.Size(100, 20);
            this.дополнительные_условияTextBox.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(дополнительные_условияLabel);
            this.Controls.Add(this.дополнительные_условияTextBox);
            this.Controls.Add(процентная_ставкаLabel);
            this.Controls.Add(this.процентная_ставкаTextBox);
            this.Controls.Add(код_валютыLabel);
            this.Controls.Add(this.код_валютыTextBox);
            this.Controls.Add(минимальная_сумма_вкладаLabel);
            this.Controls.Add(this.минимальная_сумма_вкладаTextBox);
            this.Controls.Add(минимальный_срок_вкладаLabel);
            this.Controls.Add(this.минимальный_срок_вкладаTextBox);
            this.Controls.Add(наименование_вкладаLabel);
            this.Controls.Add(this.наименование_вкладаTextBox);
            this.Controls.Add(код_вкладаLabel);
            this.Controls.Add(this.код_вкладаTextBox);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодTextBox);
            this.Controls.Add(this.вкладыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_AlexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingNavigator)).EndInit();
            this.вкладыBindingNavigator.ResumeLayout(false);
            this.вкладыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DB_AlexDataSet dB_AlexDataSet;
        private System.Windows.Forms.BindingSource вкладыBindingSource;
        private DB_AlexDataSetTableAdapters.ВкладыTableAdapter вкладыTableAdapter;
        private DB_AlexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator вкладыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton вкладыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.TextBox код_вкладаTextBox;
        private System.Windows.Forms.TextBox наименование_вкладаTextBox;
        private System.Windows.Forms.TextBox минимальный_срок_вкладаTextBox;
        private System.Windows.Forms.TextBox минимальная_сумма_вкладаTextBox;
        private System.Windows.Forms.TextBox код_валютыTextBox;
        private System.Windows.Forms.TextBox процентная_ставкаTextBox;
        private System.Windows.Forms.TextBox дополнительные_условияTextBox;
    }
}