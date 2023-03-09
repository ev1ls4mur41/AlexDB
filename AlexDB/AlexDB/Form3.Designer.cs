namespace AlexDB
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label фИО_вкладчикаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label дата_вкладаLabel;
            System.Windows.Forms.Label дата_возвратаLabel;
            System.Windows.Forms.Label код_вкладаLabel;
            System.Windows.Forms.Label сумма_вкладаLabel;
            System.Windows.Forms.Label сумма_возвратаLabel;
            System.Windows.Forms.Label отметка_о_возврате_вкладаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dB_AlexDataSet = new AlexDB.DB_AlexDataSet();
            this.вкладчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладчикиTableAdapter = new AlexDB.DB_AlexDataSetTableAdapters.ВкладчикиTableAdapter();
            this.tableAdapterManager = new AlexDB.DB_AlexDataSetTableAdapters.TableAdapterManager();
            this.вкладчикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.вкладчикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.фИО_вкладчикаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.дата_вкладаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_возвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.сумма_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.сумма_возвратаTextBox = new System.Windows.Forms.TextBox();
            this.отметка_о_возврате_вкладаCheckBox = new System.Windows.Forms.CheckBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            кодLabel = new System.Windows.Forms.Label();
            фИО_вкладчикаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            дата_вкладаLabel = new System.Windows.Forms.Label();
            дата_возвратаLabel = new System.Windows.Forms.Label();
            код_вкладаLabel = new System.Windows.Forms.Label();
            сумма_вкладаLabel = new System.Windows.Forms.Label();
            сумма_возвратаLabel = new System.Windows.Forms.Label();
            отметка_о_возврате_вкладаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AlexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладчикиBindingNavigator)).BeginInit();
            this.вкладчикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(300, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Вкладчики\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dB_AlexDataSet
            // 
            this.dB_AlexDataSet.DataSetName = "DB_AlexDataSet";
            this.dB_AlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вкладчикиBindingSource
            // 
            this.вкладчикиBindingSource.DataMember = "Вкладчики";
            this.вкладчикиBindingSource.DataSource = this.dB_AlexDataSet;
            // 
            // вкладчикиTableAdapter
            // 
            this.вкладчикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AlexDB.DB_AlexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВалютаTableAdapter = null;
            this.tableAdapterManager.ВкладчикиTableAdapter = this.вкладчикиTableAdapter;
            this.tableAdapterManager.ВкладыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // вкладчикиBindingNavigator
            // 
            this.вкладчикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.вкладчикиBindingNavigator.BindingSource = this.вкладчикиBindingSource;
            this.вкладчикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.вкладчикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.вкладчикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.вкладчикиBindingNavigatorSaveItem});
            this.вкладчикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.вкладчикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.вкладчикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.вкладчикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.вкладчикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.вкладчикиBindingNavigator.Name = "вкладчикиBindingNavigator";
            this.вкладчикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.вкладчикиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.вкладчикиBindingNavigator.TabIndex = 1;
            this.вкладчикиBindingNavigator.Text = "bindingNavigator1";
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
            // вкладчикиBindingNavigatorSaveItem
            // 
            this.вкладчикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вкладчикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("вкладчикиBindingNavigatorSaveItem.Image")));
            this.вкладчикиBindingNavigatorSaveItem.Name = "вкладчикиBindingNavigatorSaveItem";
            this.вкладчикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.вкладчикиBindingNavigatorSaveItem.Text = "Save Data";
            this.вкладчикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.вкладчикиBindingNavigatorSaveItem_Click);
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(269, 127);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 2;
            кодLabel.Text = "Код:";
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(304, 124);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодTextBox.TabIndex = 3;
            // 
            // фИО_вкладчикаLabel
            // 
            фИО_вкладчикаLabel.AutoSize = true;
            фИО_вкладчикаLabel.Location = new System.Drawing.Point(205, 153);
            фИО_вкладчикаLabel.Name = "фИО_вкладчикаLabel";
            фИО_вкладчикаLabel.Size = new System.Drawing.Size(93, 13);
            фИО_вкладчикаLabel.TabIndex = 4;
            фИО_вкладчикаLabel.Text = "ФИО вкладчика:";
            // 
            // фИО_вкладчикаTextBox
            // 
            this.фИО_вкладчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "ФИО вкладчика", true));
            this.фИО_вкладчикаTextBox.Location = new System.Drawing.Point(304, 150);
            this.фИО_вкладчикаTextBox.Name = "фИО_вкладчикаTextBox";
            this.фИО_вкладчикаTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИО_вкладчикаTextBox.TabIndex = 5;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(257, 179);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 6;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(304, 176);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 7;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(243, 205);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(304, 202);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 20);
            this.телефонTextBox.TabIndex = 9;
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(184, 231);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(114, 13);
            паспортные_данныеLabel.TabIndex = 10;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(304, 228);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 20);
            this.паспортные_данныеTextBox.TabIndex = 11;
            // 
            // дата_вкладаLabel
            // 
            дата_вкладаLabel.AutoSize = true;
            дата_вкладаLabel.Location = new System.Drawing.Point(223, 258);
            дата_вкладаLabel.Name = "дата_вкладаLabel";
            дата_вкладаLabel.Size = new System.Drawing.Size(75, 13);
            дата_вкладаLabel.TabIndex = 12;
            дата_вкладаLabel.Text = "Дата вклада:";
            // 
            // дата_вкладаDateTimePicker
            // 
            this.дата_вкладаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.вкладчикиBindingSource, "Дата вклада", true));
            this.дата_вкладаDateTimePicker.Location = new System.Drawing.Point(304, 254);
            this.дата_вкладаDateTimePicker.Name = "дата_вкладаDateTimePicker";
            this.дата_вкладаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_вкладаDateTimePicker.TabIndex = 13;
            // 
            // дата_возвратаLabel
            // 
            дата_возвратаLabel.AutoSize = true;
            дата_возвратаLabel.Location = new System.Drawing.Point(212, 284);
            дата_возвратаLabel.Name = "дата_возвратаLabel";
            дата_возвратаLabel.Size = new System.Drawing.Size(86, 13);
            дата_возвратаLabel.TabIndex = 14;
            дата_возвратаLabel.Text = "Дата возврата:";
            // 
            // дата_возвратаDateTimePicker
            // 
            this.дата_возвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.вкладчикиBindingSource, "Дата возврата", true));
            this.дата_возвратаDateTimePicker.Location = new System.Drawing.Point(304, 280);
            this.дата_возвратаDateTimePicker.Name = "дата_возвратаDateTimePicker";
            this.дата_возвратаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_возвратаDateTimePicker.TabIndex = 15;
            // 
            // код_вкладаLabel
            // 
            код_вкладаLabel.AutoSize = true;
            код_вкладаLabel.Location = new System.Drawing.Point(230, 309);
            код_вкладаLabel.Name = "код_вкладаLabel";
            код_вкладаLabel.Size = new System.Drawing.Size(68, 13);
            код_вкладаLabel.TabIndex = 16;
            код_вкладаLabel.Text = "Код вклада:";
            // 
            // код_вкладаTextBox
            // 
            this.код_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Код вклада", true));
            this.код_вкладаTextBox.Location = new System.Drawing.Point(304, 306);
            this.код_вкладаTextBox.Name = "код_вкладаTextBox";
            this.код_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_вкладаTextBox.TabIndex = 17;
            // 
            // сумма_вкладаLabel
            // 
            сумма_вкладаLabel.AutoSize = true;
            сумма_вкладаLabel.Location = new System.Drawing.Point(215, 335);
            сумма_вкладаLabel.Name = "сумма_вкладаLabel";
            сумма_вкладаLabel.Size = new System.Drawing.Size(83, 13);
            сумма_вкладаLabel.TabIndex = 18;
            сумма_вкладаLabel.Text = "Сумма вклада:";
            // 
            // сумма_вкладаTextBox
            // 
            this.сумма_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Сумма вклада", true));
            this.сумма_вкладаTextBox.Location = new System.Drawing.Point(304, 332);
            this.сумма_вкладаTextBox.Name = "сумма_вкладаTextBox";
            this.сумма_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.сумма_вкладаTextBox.TabIndex = 19;
            // 
            // сумма_возвратаLabel
            // 
            сумма_возвратаLabel.AutoSize = true;
            сумма_возвратаLabel.Location = new System.Drawing.Point(204, 361);
            сумма_возвратаLabel.Name = "сумма_возвратаLabel";
            сумма_возвратаLabel.Size = new System.Drawing.Size(94, 13);
            сумма_возвратаLabel.TabIndex = 20;
            сумма_возвратаLabel.Text = "Сумма возврата:";
            // 
            // сумма_возвратаTextBox
            // 
            this.сумма_возвратаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Сумма возврата", true));
            this.сумма_возвратаTextBox.Location = new System.Drawing.Point(304, 358);
            this.сумма_возвратаTextBox.Name = "сумма_возвратаTextBox";
            this.сумма_возвратаTextBox.Size = new System.Drawing.Size(100, 20);
            this.сумма_возвратаTextBox.TabIndex = 21;
            // 
            // отметка_о_возврате_вкладаLabel
            // 
            отметка_о_возврате_вкладаLabel.AutoSize = true;
            отметка_о_возврате_вкладаLabel.Location = new System.Drawing.Point(146, 389);
            отметка_о_возврате_вкладаLabel.Name = "отметка_о_возврате_вкладаLabel";
            отметка_о_возврате_вкладаLabel.Size = new System.Drawing.Size(152, 13);
            отметка_о_возврате_вкладаLabel.TabIndex = 22;
            отметка_о_возврате_вкладаLabel.Text = "Отметка о возврате вклада:";
            // 
            // отметка_о_возврате_вкладаCheckBox
            // 
            this.отметка_о_возврате_вкладаCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.вкладчикиBindingSource, "Отметка о возврате вклада", true));
            this.отметка_о_возврате_вкладаCheckBox.Location = new System.Drawing.Point(304, 384);
            this.отметка_о_возврате_вкладаCheckBox.Name = "отметка_о_возврате_вкладаCheckBox";
            this.отметка_о_возврате_вкладаCheckBox.Size = new System.Drawing.Size(104, 24);
            this.отметка_о_возврате_вкладаCheckBox.TabIndex = 23;
            this.отметка_о_возврате_вкладаCheckBox.Text = "Возвращен";
            this.отметка_о_возврате_вкладаCheckBox.UseVisualStyleBackColor = true;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(208, 417);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 24;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладчикиBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(304, 414);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_сотрудникаTextBox.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(отметка_о_возврате_вкладаLabel);
            this.Controls.Add(this.отметка_о_возврате_вкладаCheckBox);
            this.Controls.Add(сумма_возвратаLabel);
            this.Controls.Add(this.сумма_возвратаTextBox);
            this.Controls.Add(сумма_вкладаLabel);
            this.Controls.Add(this.сумма_вкладаTextBox);
            this.Controls.Add(код_вкладаLabel);
            this.Controls.Add(this.код_вкладаTextBox);
            this.Controls.Add(дата_возвратаLabel);
            this.Controls.Add(this.дата_возвратаDateTimePicker);
            this.Controls.Add(дата_вкладаLabel);
            this.Controls.Add(this.дата_вкладаDateTimePicker);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(фИО_вкладчикаLabel);
            this.Controls.Add(this.фИО_вкладчикаTextBox);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодTextBox);
            this.Controls.Add(this.вкладчикиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_AlexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладчикиBindingNavigator)).EndInit();
            this.вкладчикиBindingNavigator.ResumeLayout(false);
            this.вкладчикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DB_AlexDataSet dB_AlexDataSet;
        private System.Windows.Forms.BindingSource вкладчикиBindingSource;
        private DB_AlexDataSetTableAdapters.ВкладчикиTableAdapter вкладчикиTableAdapter;
        private DB_AlexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator вкладчикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton вкладчикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.TextBox фИО_вкладчикаTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.DateTimePicker дата_вкладаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_возвратаDateTimePicker;
        private System.Windows.Forms.TextBox код_вкладаTextBox;
        private System.Windows.Forms.TextBox сумма_вкладаTextBox;
        private System.Windows.Forms.TextBox сумма_возвратаTextBox;
        private System.Windows.Forms.CheckBox отметка_о_возврате_вкладаCheckBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
    }
}