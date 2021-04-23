
namespace Schoolboys
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfoAboutTheSchoolboy = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lClass = new System.Windows.Forms.Label();
            this.tbClassTeacher = new System.Windows.Forms.TextBox();
            this.lClassTeacher = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lBirthDay = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lMiddleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbMiddleNameSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFirstNameSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbClassSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaboutthestudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolboysDataSet = new Schoolboys.schoolboysDataSet();
            this.data_about_the_studentTableAdapter = new Schoolboys.schoolboysDataSetTableAdapters.data_about_the_studentTableAdapter();
            this.gbInfoAboutTheSchoolboy.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaboutthestudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolboysDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoAboutTheSchoolboy
            // 
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.btnRemove);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.btnEdit);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.btnAdd);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.tbClass);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lClass);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.tbClassTeacher);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lClassTeacher);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.tbPhoneNumber);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lPhoneNumber);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.rtbAddress);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lAddress);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.dateTimePicker1);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lBirthDay);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.tbMiddleName);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lMiddleName);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.tbFirstName);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lFirstName);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.tbLastName);
            this.gbInfoAboutTheSchoolboy.Controls.Add(this.lLastName);
            this.gbInfoAboutTheSchoolboy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInfoAboutTheSchoolboy.Location = new System.Drawing.Point(13, 13);
            this.gbInfoAboutTheSchoolboy.Name = "gbInfoAboutTheSchoolboy";
            this.gbInfoAboutTheSchoolboy.Size = new System.Drawing.Size(234, 509);
            this.gbInfoAboutTheSchoolboy.TabIndex = 0;
            this.gbInfoAboutTheSchoolboy.TabStop = false;
            this.gbInfoAboutTheSchoolboy.Text = "Информация о школьнике";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(11, 477);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(201, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(11, 448);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(201, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(11, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbClass
            // 
            this.tbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbClass.Location = new System.Drawing.Point(11, 387);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(202, 20);
            this.tbClass.TabIndex = 15;
            // 
            // lClass
            // 
            this.lClass.AutoSize = true;
            this.lClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClass.Location = new System.Drawing.Point(8, 371);
            this.lClass.Name = "lClass";
            this.lClass.Size = new System.Drawing.Size(38, 13);
            this.lClass.TabIndex = 14;
            this.lClass.Text = "Класс";
            // 
            // tbClassTeacher
            // 
            this.tbClassTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbClassTeacher.Location = new System.Drawing.Point(11, 340);
            this.tbClassTeacher.Name = "tbClassTeacher";
            this.tbClassTeacher.Size = new System.Drawing.Size(202, 20);
            this.tbClassTeacher.TabIndex = 13;
            // 
            // lClassTeacher
            // 
            this.lClassTeacher.AutoSize = true;
            this.lClassTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClassTeacher.Location = new System.Drawing.Point(8, 324);
            this.lClassTeacher.Name = "lClassTeacher";
            this.lClassTeacher.Size = new System.Drawing.Size(131, 13);
            this.lClassTeacher.TabIndex = 12;
            this.lClassTeacher.Text = "Классынй руководитель";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(10, 295);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(202, 20);
            this.tbPhoneNumber.TabIndex = 11;
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPhoneNumber.Location = new System.Drawing.Point(7, 279);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.lPhoneNumber.TabIndex = 10;
            this.lPhoneNumber.Text = "Номер телефона";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAddress.Location = new System.Drawing.Point(10, 222);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(202, 47);
            this.rtbAddress.TabIndex = 9;
            this.rtbAddress.Text = "";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddress.Location = new System.Drawing.Point(8, 206);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(44, 13);
            this.lAddress.TabIndex = 8;
            this.lAddress.Text = "Адресс";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lBirthDay
            // 
            this.lBirthDay.AutoSize = true;
            this.lBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBirthDay.Location = new System.Drawing.Point(8, 159);
            this.lBirthDay.Name = "lBirthDay";
            this.lBirthDay.Size = new System.Drawing.Size(86, 13);
            this.lBirthDay.TabIndex = 6;
            this.lBirthDay.Text = "Дата рождения";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.Location = new System.Drawing.Point(10, 129);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(202, 20);
            this.tbMiddleName.TabIndex = 5;
            // 
            // lMiddleName
            // 
            this.lMiddleName.AutoSize = true;
            this.lMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMiddleName.Location = new System.Drawing.Point(7, 112);
            this.lMiddleName.Name = "lMiddleName";
            this.lMiddleName.Size = new System.Drawing.Size(54, 13);
            this.lMiddleName.TabIndex = 4;
            this.lMiddleName.Text = "Отчество";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstName.Location = new System.Drawing.Point(10, 82);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(202, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFirstName.Location = new System.Drawing.Point(7, 65);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(29, 13);
            this.lFirstName.TabIndex = 2;
            this.lFirstName.Text = "Имя";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.Location = new System.Drawing.Point(10, 37);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(202, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLastName.Location = new System.Drawing.Point(7, 20);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(56, 13);
            this.lLastName.TabIndex = 0;
            this.lLastName.Text = "Фамилия";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbMiddleNameSearch);
            this.gbSearch.Controls.Add(this.label4);
            this.gbSearch.Controls.Add(this.tbFirstNameSearch);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.dataGridView1);
            this.gbSearch.Controls.Add(this.tbClassSearch);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.tbLastNameSearch);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(253, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(885, 521);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // tbMiddleNameSearch
            // 
            this.tbMiddleNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleNameSearch.Location = new System.Drawing.Point(511, 18);
            this.tbMiddleNameSearch.Name = "tbMiddleNameSearch";
            this.tbMiddleNameSearch.Size = new System.Drawing.Size(150, 20);
            this.tbMiddleNameSearch.TabIndex = 22;
            this.tbMiddleNameSearch.TextChanged += new System.EventHandler(this.tbMiddleNameSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(451, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Отчество";
            // 
            // tbFirstNameSearch
            // 
            this.tbFirstNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstNameSearch.Location = new System.Drawing.Point(280, 19);
            this.tbFirstNameSearch.Name = "tbFirstNameSearch";
            this.tbFirstNameSearch.Size = new System.Drawing.Size(150, 20);
            this.tbFirstNameSearch.TabIndex = 20;
            this.tbFirstNameSearch.TextChanged += new System.EventHandler(this.tbFirstNameSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(245, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Имя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.dataaboutthestudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(856, 457);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbClassSearch
            // 
            this.tbClassSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbClassSearch.Location = new System.Drawing.Point(749, 18);
            this.tbClassSearch.Name = "tbClassSearch";
            this.tbClassSearch.Size = new System.Drawing.Size(116, 20);
            this.tbClassSearch.TabIndex = 17;
            this.tbClassSearch.TextChanged += new System.EventHandler(this.tbClassSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(705, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Класс";
            // 
            // tbLastNameSearch
            // 
            this.tbLastNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastNameSearch.Location = new System.Drawing.Point(68, 18);
            this.tbLastNameSearch.Name = "tbLastNameSearch";
            this.tbLastNameSearch.Size = new System.Drawing.Size(150, 20);
            this.tbLastNameSearch.TabIndex = 3;
            this.tbLastNameSearch.TextChanged += new System.EventHandler(this.tbLastNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "middle_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "birth_date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адресс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone_number";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "class_teacher";
            this.dataGridViewTextBoxColumn8.HeaderText = "Классный руковод.";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "class";
            this.dataGridViewTextBoxColumn9.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataaboutthestudentBindingSource
            // 
            this.dataaboutthestudentBindingSource.DataMember = "data_about_the_student";
            this.dataaboutthestudentBindingSource.DataSource = this.schoolboysDataSet;
            // 
            // schoolboysDataSet
            // 
            this.schoolboysDataSet.DataSetName = "schoolboysDataSet";
            this.schoolboysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_about_the_studentTableAdapter
            // 
            this.data_about_the_studentTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 535);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbInfoAboutTheSchoolboy);
            this.Name = "Main";
            this.Text = "Школьники";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbInfoAboutTheSchoolboy.ResumeLayout(false);
            this.gbInfoAboutTheSchoolboy.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaboutthestudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolboysDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoAboutTheSchoolboy;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label lClass;
        private System.Windows.Forms.TextBox tbClassTeacher;
        private System.Windows.Forms.Label lClassTeacher;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lBirthDay;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label lMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbClassSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private schoolboysDataSet schoolboysDataSet;
        private System.Windows.Forms.BindingSource dataaboutthestudentBindingSource;
        private schoolboysDataSetTableAdapters.data_about_the_studentTableAdapter data_about_the_studentTableAdapter;
        private System.Windows.Forms.TextBox tbMiddleNameSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFirstNameSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

