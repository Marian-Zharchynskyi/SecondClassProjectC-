namespace FinalProject.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            listBoxCoaches = new ListBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            buttonCancelCoach = new Button();
            buttonFindCoach = new Button();
            label10 = new Label();
            textBoxFindCoach = new TextBox();
            buttonEditCoach = new Button();
            buttonRemoveCoach = new Button();
            buttonAddCoach = new Button();
            label9 = new Label();
            pictureBoxCoach = new PictureBox();
            textBoxDrawnMatches = new TextBox();
            textBoxLoosedMatches = new TextBox();
            textBoxWonMatches = new TextBox();
            textBoxCoachCurrentMatches = new TextBox();
            textBoxCoachWonTrofies = new TextBox();
            textBoxCoachAge = new TextBox();
            textBoxCoachFullName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            label26 = new Label();
            label25 = new Label();
            comboBoxContractCoaches = new ComboBox();
            label23 = new Label();
            dateTimePickerDateEnd = new DateTimePicker();
            label16 = new Label();
            dateTimePickerDateStart = new DateTimePicker();
            buttonFindCoachContract = new Button();
            buttonEditCoachContract = new Button();
            buttonRemoveCoachContract = new Button();
            buttonAddCoachContract = new Button();
            textBoxContractSalary = new TextBox();
            label21 = new Label();
            label1 = new Label();
            textBoxFindCoachContract = new TextBox();
            listBoxCoachesContracts = new ListBox();
            tabPage3 = new TabPage();
            buttonCancelFootballTeam = new Button();
            label44 = new Label();
            buttonFindFootballTeam = new Button();
            label45 = new Label();
            textBoxFindFootballTeam = new TextBox();
            label22 = new Label();
            dateTimePickerFootballTeamCreationDate = new DateTimePicker();
            textBoxFootballTeamCountry = new TextBox();
            label20 = new Label();
            label27 = new Label();
            comboBoxFootballTeamCoach = new ComboBox();
            buttonEditFootballTeam = new Button();
            buttonRemoveFootballTeam = new Button();
            buttonAddFootballTeam = new Button();
            textBoxFootballTeamFullName = new TextBox();
            label28 = new Label();
            listBoxFootballTeams = new ListBox();
            tabPage4 = new TabPage();
            checkBoxPlayerIsCaptain = new CheckBox();
            buttonFindPlayer = new Button();
            label11 = new Label();
            textBoxFindPlayer = new TextBox();
            buttonEditPlayer = new Button();
            buttonRemovePlayer = new Button();
            buttonAddPlayer = new Button();
            textBoxAssists = new TextBox();
            textBoxPlayerGoals = new TextBox();
            textBoxPlayerWorkingLeg = new TextBox();
            textBoxPlayerAge = new TextBox();
            textBoxPlayerFullName = new TextBox();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            listBoxPlayers = new ListBox();
            tabPage5 = new TabPage();
            textBoxPlayerContractSalary = new TextBox();
            label33 = new Label();
            label35 = new Label();
            comboBoxPlayerContractFootballTeam = new ComboBox();
            label24 = new Label();
            label29 = new Label();
            comboBoxPlayerContractPlayer = new ComboBox();
            label30 = new Label();
            dateTimePickerPlayerContractDateEnd = new DateTimePicker();
            label31 = new Label();
            dateTimePickerPlayerContractDateStart = new DateTimePicker();
            buttonFindPlayerContract = new Button();
            buttonEditPlayerContract = new Button();
            buttonRemovePlayerContract = new Button();
            buttonAddPlayerContract = new Button();
            label34 = new Label();
            textBoxFindPlayerContract = new TextBox();
            listBoxPlayersContracts = new ListBox();
            tabPage6 = new TabPage();
            label43 = new Label();
            checkBoxIsRent = new CheckBox();
            checkBoxIsFullFledged = new CheckBox();
            label42 = new Label();
            textBoxPlayerTransferTeamTo = new TextBox();
            label36 = new Label();
            label37 = new Label();
            comboBoxPlayerTransferTeamFrom = new ComboBox();
            label38 = new Label();
            comboBoxPlayerTransferPlayer = new ComboBox();
            label39 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label40 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            buttonEditPlayerTransfer = new Button();
            buttonRemovePlayerTransfer = new Button();
            buttonAddPlayerTransfer = new Button();
            label41 = new Label();
            textBox2 = new TextBox();
            listBoxPlayersTransfers = new ListBox();
            tabPage7 = new TabPage();
            buttonEditPosition = new Button();
            buttonRemovePosition = new Button();
            buttonFindPosition = new Button();
            label13 = new Label();
            textBoxFindPosition = new TextBox();
            buttonAddPosition = new Button();
            textBoxPosition = new TextBox();
            label32 = new Label();
            listBoxPositions = new ListBox();
            button1 = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoach).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxCoaches
            // 
            listBoxCoaches.FormattingEnabled = true;
            listBoxCoaches.ItemHeight = 20;
            listBoxCoaches.Location = new Point(-4, 0);
            listBoxCoaches.Name = "listBoxCoaches";
            listBoxCoaches.Size = new Size(1140, 184);
            listBoxCoaches.TabIndex = 0;
            listBoxCoaches.SelectedIndexChanged += listBoxCoaches_SelectedIndexChanged;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Controls.Add(tabPage6);
            tabControl.Controls.Add(tabPage7);
            tabControl.Location = new Point(0, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1508, 684);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(buttonCancelCoach);
            tabPage1.Controls.Add(buttonFindCoach);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBoxFindCoach);
            tabPage1.Controls.Add(buttonEditCoach);
            tabPage1.Controls.Add(buttonRemoveCoach);
            tabPage1.Controls.Add(buttonAddCoach);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(pictureBoxCoach);
            tabPage1.Controls.Add(textBoxDrawnMatches);
            tabPage1.Controls.Add(textBoxLoosedMatches);
            tabPage1.Controls.Add(textBoxWonMatches);
            tabPage1.Controls.Add(textBoxCoachCurrentMatches);
            tabPage1.Controls.Add(textBoxCoachWonTrofies);
            tabPage1.Controls.Add(textBoxCoachAge);
            tabPage1.Controls.Add(textBoxCoachFullName);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(listBoxCoaches);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1500, 651);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Coaches";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCancelCoach
            // 
            buttonCancelCoach.Location = new Point(505, 466);
            buttonCancelCoach.Name = "buttonCancelCoach";
            buttonCancelCoach.Size = new Size(120, 29);
            buttonCancelCoach.TabIndex = 25;
            buttonCancelCoach.Text = "Cancel";
            buttonCancelCoach.UseVisualStyleBackColor = true;
            buttonCancelCoach.Click += buttonCancelCoach_Click;
            // 
            // buttonFindCoach
            // 
            buttonFindCoach.Location = new Point(505, 415);
            buttonFindCoach.Name = "buttonFindCoach";
            buttonFindCoach.Size = new Size(120, 29);
            buttonFindCoach.TabIndex = 24;
            buttonFindCoach.Text = "Find coach";
            buttonFindCoach.UseVisualStyleBackColor = true;
            buttonFindCoach.Click += buttonFindCoach_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(505, 308);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 23;
            label10.Text = "Find coach by name";
            // 
            // textBoxFindCoach
            // 
            textBoxFindCoach.Location = new Point(505, 337);
            textBoxFindCoach.Multiline = true;
            textBoxFindCoach.Name = "textBoxFindCoach";
            textBoxFindCoach.Size = new Size(120, 61);
            textBoxFindCoach.TabIndex = 22;
            // 
            // buttonEditCoach
            // 
            buttonEditCoach.Location = new Point(341, 417);
            buttonEditCoach.Name = "buttonEditCoach";
            buttonEditCoach.Size = new Size(120, 29);
            buttonEditCoach.TabIndex = 21;
            buttonEditCoach.Text = "Edit coach";
            buttonEditCoach.UseVisualStyleBackColor = true;
            buttonEditCoach.Click += buttonEditCoach_Click;
            // 
            // buttonRemoveCoach
            // 
            buttonRemoveCoach.Location = new Point(184, 417);
            buttonRemoveCoach.Name = "buttonRemoveCoach";
            buttonRemoveCoach.Size = new Size(120, 29);
            buttonRemoveCoach.TabIndex = 20;
            buttonRemoveCoach.Text = "Remove coach";
            buttonRemoveCoach.UseVisualStyleBackColor = true;
            buttonRemoveCoach.Click += buttonRemoveCoach_Click;
            // 
            // buttonAddCoach
            // 
            buttonAddCoach.Location = new Point(23, 417);
            buttonAddCoach.Name = "buttonAddCoach";
            buttonAddCoach.Size = new Size(120, 29);
            buttonAddCoach.TabIndex = 19;
            buttonAddCoach.Text = "Add new coach";
            buttonAddCoach.UseVisualStyleBackColor = true;
            buttonAddCoach.Click += buttonAddCoach_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(778, 221);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 18;
            label9.Text = "Coach photo";
            // 
            // pictureBoxCoach
            // 
            pictureBoxCoach.Location = new Point(702, 253);
            pictureBoxCoach.Name = "pictureBoxCoach";
            pictureBoxCoach.Size = new Size(230, 215);
            pictureBoxCoach.TabIndex = 17;
            pictureBoxCoach.TabStop = false;
            // 
            // textBoxDrawnMatches
            // 
            textBoxDrawnMatches.Location = new Point(341, 340);
            textBoxDrawnMatches.Multiline = true;
            textBoxDrawnMatches.Name = "textBoxDrawnMatches";
            textBoxDrawnMatches.Size = new Size(98, 34);
            textBoxDrawnMatches.TabIndex = 16;
            // 
            // textBoxLoosedMatches
            // 
            textBoxLoosedMatches.Location = new Point(505, 253);
            textBoxLoosedMatches.Multiline = true;
            textBoxLoosedMatches.Name = "textBoxLoosedMatches";
            textBoxLoosedMatches.Size = new Size(98, 34);
            textBoxLoosedMatches.TabIndex = 15;
            // 
            // textBoxWonMatches
            // 
            textBoxWonMatches.Location = new Point(341, 253);
            textBoxWonMatches.Multiline = true;
            textBoxWonMatches.Name = "textBoxWonMatches";
            textBoxWonMatches.Size = new Size(98, 34);
            textBoxWonMatches.TabIndex = 14;
            // 
            // textBoxCoachCurrentMatches
            // 
            textBoxCoachCurrentMatches.Location = new Point(171, 253);
            textBoxCoachCurrentMatches.Multiline = true;
            textBoxCoachCurrentMatches.Name = "textBoxCoachCurrentMatches";
            textBoxCoachCurrentMatches.Size = new Size(98, 34);
            textBoxCoachCurrentMatches.TabIndex = 13;
            // 
            // textBoxCoachWonTrofies
            // 
            textBoxCoachWonTrofies.Location = new Point(184, 340);
            textBoxCoachWonTrofies.Multiline = true;
            textBoxCoachWonTrofies.Name = "textBoxCoachWonTrofies";
            textBoxCoachWonTrofies.Size = new Size(98, 34);
            textBoxCoachWonTrofies.TabIndex = 12;
            // 
            // textBoxCoachAge
            // 
            textBoxCoachAge.Location = new Point(27, 253);
            textBoxCoachAge.Multiline = true;
            textBoxCoachAge.Name = "textBoxCoachAge";
            textBoxCoachAge.Size = new Size(98, 34);
            textBoxCoachAge.TabIndex = 11;
            // 
            // textBoxCoachFullName
            // 
            textBoxCoachFullName.Location = new Point(23, 340);
            textBoxCoachFullName.Multiline = true;
            textBoxCoachFullName.Name = "textBoxCoachFullName";
            textBoxCoachFullName.Size = new Size(120, 58);
            textBoxCoachFullName.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 308);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 8;
            label8.Text = "Drawn matches";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(505, 221);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 7;
            label7.Text = "Loosed matches";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 221);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 6;
            label6.Text = "Won matches";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 221);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 5;
            label5.Text = "Current matches amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 308);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 4;
            label4.Text = "Won trofies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 221);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 308);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Full name";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(comboBoxContractCoaches);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(dateTimePickerDateEnd);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(dateTimePickerDateStart);
            tabPage2.Controls.Add(buttonFindCoachContract);
            tabPage2.Controls.Add(buttonEditCoachContract);
            tabPage2.Controls.Add(buttonRemoveCoachContract);
            tabPage2.Controls.Add(buttonAddCoachContract);
            tabPage2.Controls.Add(textBoxContractSalary);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBoxFindCoachContract);
            tabPage2.Controls.Add(listBoxCoachesContracts);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1500, 651);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Coaches contracts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.WhiteSmoke;
            label26.ForeColor = SystemColors.ActiveCaptionText;
            label26.Location = new Point(408, 192);
            label26.Name = "label26";
            label26.Size = new Size(103, 20);
            label26.TabIndex = 80;
            label26.Text = "Choose Coach";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(1223, 297);
            label25.Name = "label25";
            label25.Size = new Size(0, 20);
            label25.TabIndex = 79;
            // 
            // comboBoxContractCoaches
            // 
            comboBoxContractCoaches.FormattingEnabled = true;
            comboBoxContractCoaches.Location = new Point(378, 226);
            comboBoxContractCoaches.Name = "comboBoxContractCoaches";
            comboBoxContractCoaches.Size = new Size(168, 28);
            comboBoxContractCoaches.TabIndex = 78;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.WhiteSmoke;
            label23.Location = new Point(917, 293);
            label23.Name = "label23";
            label23.Size = new Size(70, 20);
            label23.TabIndex = 77;
            label23.Text = "Date end";
            // 
            // dateTimePickerDateEnd
            // 
            dateTimePickerDateEnd.Location = new Point(832, 325);
            dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            dateTimePickerDateEnd.Size = new Size(250, 27);
            dateTimePickerDateEnd.TabIndex = 76;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.WhiteSmoke;
            label16.ForeColor = SystemColors.ControlText;
            label16.Location = new Point(917, 206);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
            label16.TabIndex = 75;
            label16.Text = "Date start";
            // 
            // dateTimePickerDateStart
            // 
            dateTimePickerDateStart.Location = new Point(832, 238);
            dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            dateTimePickerDateStart.Size = new Size(250, 27);
            dateTimePickerDateStart.TabIndex = 74;
            // 
            // buttonFindCoachContract
            // 
            buttonFindCoachContract.Location = new Point(1172, 281);
            buttonFindCoachContract.Name = "buttonFindCoachContract";
            buttonFindCoachContract.Size = new Size(120, 53);
            buttonFindCoachContract.TabIndex = 72;
            buttonFindCoachContract.Text = "Find coach contract";
            buttonFindCoachContract.UseVisualStyleBackColor = true;
            buttonFindCoachContract.Click += buttonFindCoachContract_Click;
            // 
            // buttonEditCoachContract
            // 
            buttonEditCoachContract.Location = new Point(395, 349);
            buttonEditCoachContract.Name = "buttonEditCoachContract";
            buttonEditCoachContract.Size = new Size(120, 50);
            buttonEditCoachContract.TabIndex = 69;
            buttonEditCoachContract.Text = "Edit coach contract";
            buttonEditCoachContract.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCoachContract
            // 
            buttonRemoveCoachContract.Location = new Point(627, 349);
            buttonRemoveCoachContract.Name = "buttonRemoveCoachContract";
            buttonRemoveCoachContract.Size = new Size(120, 53);
            buttonRemoveCoachContract.TabIndex = 68;
            buttonRemoveCoachContract.Text = "Remove coach contract";
            buttonRemoveCoachContract.UseVisualStyleBackColor = true;
            buttonRemoveCoachContract.Click += buttonRemoveCoachContract_Click;
            // 
            // buttonAddCoachContract
            // 
            buttonAddCoachContract.Location = new Point(627, 279);
            buttonAddCoachContract.Name = "buttonAddCoachContract";
            buttonAddCoachContract.Size = new Size(116, 53);
            buttonAddCoachContract.TabIndex = 67;
            buttonAddCoachContract.Text = "Add new coach contract";
            buttonAddCoachContract.UseVisualStyleBackColor = true;
            buttonAddCoachContract.Click += buttonAddCoachContract_Click;
            // 
            // textBoxContractSalary
            // 
            textBoxContractSalary.Location = new Point(627, 224);
            textBoxContractSalary.Multiline = true;
            textBoxContractSalary.Name = "textBoxContractSalary";
            textBoxContractSalary.Size = new Size(133, 34);
            textBoxContractSalary.TabIndex = 61;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.WhiteSmoke;
            label21.Location = new Point(660, 192);
            label21.Name = "label21";
            label21.Size = new Size(49, 20);
            label21.TabIndex = 54;
            label21.Text = "Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Location = new Point(1143, 206);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 50;
            label1.Text = "Find coach contract by id";
            // 
            // textBoxFindCoachContract
            // 
            textBoxFindCoachContract.Location = new Point(1157, 235);
            textBoxFindCoachContract.Multiline = true;
            textBoxFindCoachContract.Name = "textBoxFindCoachContract";
            textBoxFindCoachContract.Size = new Size(149, 33);
            textBoxFindCoachContract.TabIndex = 49;
            // 
            // listBoxCoachesContracts
            // 
            listBoxCoachesContracts.FormattingEnabled = true;
            listBoxCoachesContracts.ItemHeight = 20;
            listBoxCoachesContracts.Location = new Point(191, 0);
            listBoxCoachesContracts.Name = "listBoxCoachesContracts";
            listBoxCoachesContracts.Size = new Size(1279, 164);
            listBoxCoachesContracts.TabIndex = 1;
            listBoxCoachesContracts.SelectedIndexChanged += listBoxCoachesContracts_SelectedIndexChanged_1;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(buttonCancelFootballTeam);
            tabPage3.Controls.Add(label44);
            tabPage3.Controls.Add(buttonFindFootballTeam);
            tabPage3.Controls.Add(label45);
            tabPage3.Controls.Add(textBoxFindFootballTeam);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(dateTimePickerFootballTeamCreationDate);
            tabPage3.Controls.Add(textBoxFootballTeamCountry);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(comboBoxFootballTeamCoach);
            tabPage3.Controls.Add(buttonEditFootballTeam);
            tabPage3.Controls.Add(buttonRemoveFootballTeam);
            tabPage3.Controls.Add(buttonAddFootballTeam);
            tabPage3.Controls.Add(textBoxFootballTeamFullName);
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(listBoxFootballTeams);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1500, 651);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Football teams";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCancelFootballTeam
            // 
            buttonCancelFootballTeam.Location = new Point(794, 291);
            buttonCancelFootballTeam.Name = "buttonCancelFootballTeam";
            buttonCancelFootballTeam.Size = new Size(120, 29);
            buttonCancelFootballTeam.TabIndex = 96;
            buttonCancelFootballTeam.Text = "Cancel";
            buttonCancelFootballTeam.UseVisualStyleBackColor = true;
            buttonCancelFootballTeam.Click += buttonCancelFootballTeam_Click;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(765, 291);
            label44.Name = "label44";
            label44.Size = new Size(0, 20);
            label44.TabIndex = 95;
            // 
            // buttonFindFootballTeam
            // 
            buttonFindFootballTeam.Location = new Point(658, 279);
            buttonFindFootballTeam.Name = "buttonFindFootballTeam";
            buttonFindFootballTeam.Size = new Size(120, 53);
            buttonFindFootballTeam.TabIndex = 94;
            buttonFindFootballTeam.Text = "Find football team";
            buttonFindFootballTeam.UseVisualStyleBackColor = true;
            buttonFindFootballTeam.Click += buttonFindFootballTeam_Click;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = Color.WhiteSmoke;
            label45.Location = new Point(685, 200);
            label45.Name = "label45";
            label45.Size = new Size(193, 20);
            label45.TabIndex = 93;
            label45.Text = "Find football team by name";
            // 
            // textBoxFindFootballTeam
            // 
            textBoxFindFootballTeam.Location = new Point(699, 229);
            textBoxFindFootballTeam.Multiline = true;
            textBoxFindFootballTeam.Name = "textBoxFindFootballTeam";
            textBoxFindFootballTeam.Size = new Size(149, 33);
            textBoxFindFootballTeam.TabIndex = 92;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.WhiteSmoke;
            label22.Location = new Point(446, 258);
            label22.Name = "label22";
            label22.Size = new Size(99, 20);
            label22.TabIndex = 91;
            label22.Text = "Creation date";
            // 
            // dateTimePickerFootballTeamCreationDate
            // 
            dateTimePickerFootballTeamCreationDate.Location = new Point(360, 293);
            dateTimePickerFootballTeamCreationDate.Name = "dateTimePickerFootballTeamCreationDate";
            dateTimePickerFootballTeamCreationDate.Size = new Size(250, 27);
            dateTimePickerFootballTeamCreationDate.TabIndex = 90;
            // 
            // textBoxFootballTeamCountry
            // 
            textBoxFootballTeamCountry.Location = new Point(430, 210);
            textBoxFootballTeamCountry.Multiline = true;
            textBoxFootballTeamCountry.Name = "textBoxFootballTeamCountry";
            textBoxFootballTeamCountry.Size = new Size(133, 34);
            textBoxFootballTeamCountry.TabIndex = 89;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.WhiteSmoke;
            label20.Location = new Point(463, 178);
            label20.Name = "label20";
            label20.Size = new Size(60, 20);
            label20.TabIndex = 88;
            label20.Text = "Country";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.WhiteSmoke;
            label27.Location = new Point(47, 178);
            label27.Name = "label27";
            label27.Size = new Size(101, 20);
            label27.TabIndex = 87;
            label27.Text = "Choose coach";
            // 
            // comboBoxFootballTeamCoach
            // 
            comboBoxFootballTeamCoach.FormattingEnabled = true;
            comboBoxFootballTeamCoach.Location = new Point(17, 212);
            comboBoxFootballTeamCoach.Name = "comboBoxFootballTeamCoach";
            comboBoxFootballTeamCoach.Size = new Size(168, 28);
            comboBoxFootballTeamCoach.TabIndex = 86;
            // 
            // buttonEditFootballTeam
            // 
            buttonEditFootballTeam.Location = new Point(34, 335);
            buttonEditFootballTeam.Name = "buttonEditFootballTeam";
            buttonEditFootballTeam.Size = new Size(120, 50);
            buttonEditFootballTeam.TabIndex = 85;
            buttonEditFootballTeam.Text = "Edit football team";
            buttonEditFootballTeam.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveFootballTeam
            // 
            buttonRemoveFootballTeam.Location = new Point(204, 354);
            buttonRemoveFootballTeam.Name = "buttonRemoveFootballTeam";
            buttonRemoveFootballTeam.Size = new Size(120, 53);
            buttonRemoveFootballTeam.TabIndex = 84;
            buttonRemoveFootballTeam.Text = "Remove football team";
            buttonRemoveFootballTeam.UseVisualStyleBackColor = true;
            buttonRemoveFootballTeam.Click += buttonRemoveFootballTeam_Click;
            // 
            // buttonAddFootballTeam
            // 
            buttonAddFootballTeam.Location = new Point(204, 280);
            buttonAddFootballTeam.Name = "buttonAddFootballTeam";
            buttonAddFootballTeam.Size = new Size(116, 53);
            buttonAddFootballTeam.TabIndex = 83;
            buttonAddFootballTeam.Text = "Add new football team";
            buttonAddFootballTeam.UseVisualStyleBackColor = true;
            buttonAddFootballTeam.Click += buttonAddFootballTeam_Click;
            // 
            // textBoxFootballTeamFullName
            // 
            textBoxFootballTeamFullName.Location = new Point(204, 210);
            textBoxFootballTeamFullName.Multiline = true;
            textBoxFootballTeamFullName.Name = "textBoxFootballTeamFullName";
            textBoxFootballTeamFullName.Size = new Size(142, 57);
            textBoxFootballTeamFullName.TabIndex = 82;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.WhiteSmoke;
            label28.Location = new Point(237, 178);
            label28.Name = "label28";
            label28.Size = new Size(73, 20);
            label28.TabIndex = 81;
            label28.Text = "Full name";
            // 
            // listBoxFootballTeams
            // 
            listBoxFootballTeams.FormattingEnabled = true;
            listBoxFootballTeams.ItemHeight = 20;
            listBoxFootballTeams.Location = new Point(0, 0);
            listBoxFootballTeams.Name = "listBoxFootballTeams";
            listBoxFootballTeams.Size = new Size(930, 164);
            listBoxFootballTeams.TabIndex = 1;
            listBoxFootballTeams.SelectedIndexChanged += listBoxFootballTeams_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(checkBoxPlayerIsCaptain);
            tabPage4.Controls.Add(buttonFindPlayer);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(textBoxFindPlayer);
            tabPage4.Controls.Add(buttonEditPlayer);
            tabPage4.Controls.Add(buttonRemovePlayer);
            tabPage4.Controls.Add(buttonAddPlayer);
            tabPage4.Controls.Add(textBoxAssists);
            tabPage4.Controls.Add(textBoxPlayerGoals);
            tabPage4.Controls.Add(textBoxPlayerWorkingLeg);
            tabPage4.Controls.Add(textBoxPlayerAge);
            tabPage4.Controls.Add(textBoxPlayerFullName);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(listBoxPlayers);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1500, 651);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Players";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlayerIsCaptain
            // 
            checkBoxPlayerIsCaptain.AutoSize = true;
            checkBoxPlayerIsCaptain.Location = new Point(176, 386);
            checkBoxPlayerIsCaptain.Name = "checkBoxPlayerIsCaptain";
            checkBoxPlayerIsCaptain.Size = new Size(18, 17);
            checkBoxPlayerIsCaptain.TabIndex = 45;
            checkBoxPlayerIsCaptain.UseVisualStyleBackColor = true;
            // 
            // buttonFindPlayer
            // 
            buttonFindPlayer.Location = new Point(480, 458);
            buttonFindPlayer.Name = "buttonFindPlayer";
            buttonFindPlayer.Size = new Size(120, 29);
            buttonFindPlayer.TabIndex = 44;
            buttonFindPlayer.Text = "Find player";
            buttonFindPlayer.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.WhiteSmoke;
            label11.Location = new Point(480, 351);
            label11.Name = "label11";
            label11.Size = new Size(145, 20);
            label11.TabIndex = 43;
            label11.Text = "Find Player by Name";
            // 
            // textBoxFindPlayer
            // 
            textBoxFindPlayer.Location = new Point(480, 380);
            textBoxFindPlayer.Multiline = true;
            textBoxFindPlayer.Name = "textBoxFindPlayer";
            textBoxFindPlayer.Size = new Size(120, 61);
            textBoxFindPlayer.TabIndex = 42;
            // 
            // buttonEditPlayer
            // 
            buttonEditPlayer.Location = new Point(333, 547);
            buttonEditPlayer.Name = "buttonEditPlayer";
            buttonEditPlayer.Size = new Size(120, 29);
            buttonEditPlayer.TabIndex = 41;
            buttonEditPlayer.Text = "Edit player";
            buttonEditPlayer.UseVisualStyleBackColor = true;
            buttonEditPlayer.Click += buttonEditPlayer_Click;
            // 
            // buttonRemovePlayer
            // 
            buttonRemovePlayer.Location = new Point(176, 547);
            buttonRemovePlayer.Name = "buttonRemovePlayer";
            buttonRemovePlayer.Size = new Size(120, 29);
            buttonRemovePlayer.TabIndex = 40;
            buttonRemovePlayer.Text = "Remove player";
            buttonRemovePlayer.UseVisualStyleBackColor = true;
            buttonRemovePlayer.Click += buttonRemovePlayer_Click;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Location = new Point(15, 547);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(134, 29);
            buttonAddPlayer.TabIndex = 39;
            buttonAddPlayer.Text = "Add new player";
            buttonAddPlayer.UseVisualStyleBackColor = true;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // textBoxAssists
            // 
            textBoxAssists.Location = new Point(333, 470);
            textBoxAssists.Multiline = true;
            textBoxAssists.Name = "textBoxAssists";
            textBoxAssists.Size = new Size(98, 34);
            textBoxAssists.TabIndex = 38;
            // 
            // textBoxPlayerGoals
            // 
            textBoxPlayerGoals.Location = new Point(333, 383);
            textBoxPlayerGoals.Multiline = true;
            textBoxPlayerGoals.Name = "textBoxPlayerGoals";
            textBoxPlayerGoals.Size = new Size(98, 34);
            textBoxPlayerGoals.TabIndex = 36;
            // 
            // textBoxPlayerWorkingLeg
            // 
            textBoxPlayerWorkingLeg.Location = new Point(176, 470);
            textBoxPlayerWorkingLeg.Multiline = true;
            textBoxPlayerWorkingLeg.Name = "textBoxPlayerWorkingLeg";
            textBoxPlayerWorkingLeg.Size = new Size(98, 34);
            textBoxPlayerWorkingLeg.TabIndex = 34;
            // 
            // textBoxPlayerAge
            // 
            textBoxPlayerAge.Location = new Point(19, 383);
            textBoxPlayerAge.Multiline = true;
            textBoxPlayerAge.Name = "textBoxPlayerAge";
            textBoxPlayerAge.Size = new Size(98, 34);
            textBoxPlayerAge.TabIndex = 33;
            // 
            // textBoxPlayerFullName
            // 
            textBoxPlayerFullName.Location = new Point(15, 470);
            textBoxPlayerFullName.Multiline = true;
            textBoxPlayerFullName.Name = "textBoxPlayerFullName";
            textBoxPlayerFullName.Size = new Size(120, 58);
            textBoxPlayerFullName.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.WhiteSmoke;
            label12.Location = new Point(333, 438);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 31;
            label12.Text = "Assists scored";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.WhiteSmoke;
            label14.Location = new Point(333, 351);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 29;
            label14.Text = "Goals scored";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.WhiteSmoke;
            label15.Location = new Point(202, 380);
            label15.Name = "label15";
            label15.Size = new Size(72, 20);
            label15.TabIndex = 28;
            label15.Text = "Is captain";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.WhiteSmoke;
            label17.Location = new Point(176, 438);
            label17.Name = "label17";
            label17.Size = new Size(89, 20);
            label17.TabIndex = 27;
            label17.Text = "Working leg";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Gainsboro;
            label18.Location = new Point(45, 351);
            label18.Name = "label18";
            label18.Size = new Size(36, 20);
            label18.TabIndex = 26;
            label18.Text = "Age";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.WhiteSmoke;
            label19.Location = new Point(34, 438);
            label19.Name = "label19";
            label19.Size = new Size(73, 20);
            label19.TabIndex = 25;
            label19.Text = "Full name";
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 20;
            listBoxPlayers.Location = new Point(-4, 0);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(1486, 244);
            listBoxPlayers.TabIndex = 1;
            listBoxPlayers.SelectedIndexChanged += listBoxPlayers_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage5.Controls.Add(textBoxPlayerContractSalary);
            tabPage5.Controls.Add(label33);
            tabPage5.Controls.Add(label35);
            tabPage5.Controls.Add(comboBoxPlayerContractFootballTeam);
            tabPage5.Controls.Add(label24);
            tabPage5.Controls.Add(label29);
            tabPage5.Controls.Add(comboBoxPlayerContractPlayer);
            tabPage5.Controls.Add(label30);
            tabPage5.Controls.Add(dateTimePickerPlayerContractDateEnd);
            tabPage5.Controls.Add(label31);
            tabPage5.Controls.Add(dateTimePickerPlayerContractDateStart);
            tabPage5.Controls.Add(buttonFindPlayerContract);
            tabPage5.Controls.Add(buttonEditPlayerContract);
            tabPage5.Controls.Add(buttonRemovePlayerContract);
            tabPage5.Controls.Add(buttonAddPlayerContract);
            tabPage5.Controls.Add(label34);
            tabPage5.Controls.Add(textBoxFindPlayerContract);
            tabPage5.Controls.Add(listBoxPlayersContracts);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1500, 651);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Players contracts";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayerContractSalary
            // 
            textBoxPlayerContractSalary.Location = new Point(160, 527);
            textBoxPlayerContractSalary.Multiline = true;
            textBoxPlayerContractSalary.Name = "textBoxPlayerContractSalary";
            textBoxPlayerContractSalary.Size = new Size(133, 34);
            textBoxPlayerContractSalary.TabIndex = 99;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.WhiteSmoke;
            label33.Location = new Point(193, 495);
            label33.Name = "label33";
            label33.Size = new Size(49, 20);
            label33.TabIndex = 98;
            label33.Text = "Salary";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.WhiteSmoke;
            label35.Location = new Point(247, 415);
            label35.Name = "label35";
            label35.Size = new Size(155, 20);
            label35.TabIndex = 97;
            label35.Text = "Choose Football team";
            // 
            // comboBoxPlayerContractFootballTeam
            // 
            comboBoxPlayerContractFootballTeam.FormattingEnabled = true;
            comboBoxPlayerContractFootballTeam.Location = new Point(234, 449);
            comboBoxPlayerContractFootballTeam.Name = "comboBoxPlayerContractFootballTeam";
            comboBoxPlayerContractFootballTeam.Size = new Size(168, 28);
            comboBoxPlayerContractFootballTeam.TabIndex = 96;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.WhiteSmoke;
            label24.Location = new Point(74, 415);
            label24.Name = "label24";
            label24.Size = new Size(102, 20);
            label24.TabIndex = 95;
            label24.Text = "Choose Player";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(766, 506);
            label29.Name = "label29";
            label29.Size = new Size(0, 20);
            label29.TabIndex = 94;
            // 
            // comboBoxPlayerContractPlayer
            // 
            comboBoxPlayerContractPlayer.FormattingEnabled = true;
            comboBoxPlayerContractPlayer.Location = new Point(44, 449);
            comboBoxPlayerContractPlayer.Name = "comboBoxPlayerContractPlayer";
            comboBoxPlayerContractPlayer.Size = new Size(168, 28);
            comboBoxPlayerContractPlayer.TabIndex = 93;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.WhiteSmoke;
            label30.Location = new Point(511, 502);
            label30.Name = "label30";
            label30.Size = new Size(70, 20);
            label30.TabIndex = 92;
            label30.Text = "Date end";
            // 
            // dateTimePickerPlayerContractDateEnd
            // 
            dateTimePickerPlayerContractDateEnd.Location = new Point(426, 534);
            dateTimePickerPlayerContractDateEnd.Name = "dateTimePickerPlayerContractDateEnd";
            dateTimePickerPlayerContractDateEnd.Size = new Size(250, 27);
            dateTimePickerPlayerContractDateEnd.TabIndex = 91;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.WhiteSmoke;
            label31.Location = new Point(511, 415);
            label31.Name = "label31";
            label31.Size = new Size(74, 20);
            label31.TabIndex = 90;
            label31.Text = "Date start";
            // 
            // dateTimePickerPlayerContractDateStart
            // 
            dateTimePickerPlayerContractDateStart.Location = new Point(426, 447);
            dateTimePickerPlayerContractDateStart.Name = "dateTimePickerPlayerContractDateStart";
            dateTimePickerPlayerContractDateStart.Size = new Size(250, 27);
            dateTimePickerPlayerContractDateStart.TabIndex = 89;
            // 
            // buttonFindPlayerContract
            // 
            buttonFindPlayerContract.Location = new Point(719, 534);
            buttonFindPlayerContract.Name = "buttonFindPlayerContract";
            buttonFindPlayerContract.Size = new Size(120, 53);
            buttonFindPlayerContract.TabIndex = 88;
            buttonFindPlayerContract.Text = "Find coach contract";
            buttonFindPlayerContract.UseVisualStyleBackColor = true;
            // 
            // buttonEditPlayerContract
            // 
            buttonEditPlayerContract.Location = new Point(210, 572);
            buttonEditPlayerContract.Name = "buttonEditPlayerContract";
            buttonEditPlayerContract.Size = new Size(120, 50);
            buttonEditPlayerContract.TabIndex = 87;
            buttonEditPlayerContract.Text = "Edit Player contract";
            buttonEditPlayerContract.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePlayerContract
            // 
            buttonRemovePlayerContract.Location = new Point(358, 569);
            buttonRemovePlayerContract.Name = "buttonRemovePlayerContract";
            buttonRemovePlayerContract.Size = new Size(120, 53);
            buttonRemovePlayerContract.TabIndex = 86;
            buttonRemovePlayerContract.Text = "Remove player contract";
            buttonRemovePlayerContract.UseVisualStyleBackColor = true;
            buttonRemovePlayerContract.Click += buttonRemovePlayerContract_Click;
            // 
            // buttonAddPlayerContract
            // 
            buttonAddPlayerContract.Location = new Point(60, 571);
            buttonAddPlayerContract.Name = "buttonAddPlayerContract";
            buttonAddPlayerContract.Size = new Size(116, 53);
            buttonAddPlayerContract.TabIndex = 85;
            buttonAddPlayerContract.Text = "Add new player contract";
            buttonAddPlayerContract.UseVisualStyleBackColor = true;
            buttonAddPlayerContract.Click += buttonAddPlayerContract_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.WhiteSmoke;
            label34.Location = new Point(672, 415);
            label34.Name = "label34";
            label34.Size = new Size(199, 20);
            label34.TabIndex = 82;
            label34.Text = "Find coach contract by name";
            // 
            // textBoxFindPlayerContract
            // 
            textBoxFindPlayerContract.Location = new Point(700, 444);
            textBoxFindPlayerContract.Multiline = true;
            textBoxFindPlayerContract.Name = "textBoxFindPlayerContract";
            textBoxFindPlayerContract.Size = new Size(149, 61);
            textBoxFindPlayerContract.TabIndex = 81;
            // 
            // listBoxPlayersContracts
            // 
            listBoxPlayersContracts.FormattingEnabled = true;
            listBoxPlayersContracts.ItemHeight = 20;
            listBoxPlayersContracts.Location = new Point(0, 0);
            listBoxPlayersContracts.Name = "listBoxPlayersContracts";
            listBoxPlayersContracts.Size = new Size(1026, 304);
            listBoxPlayersContracts.TabIndex = 1;
            listBoxPlayersContracts.SelectedIndexChanged += listBoxPlayerContracts_SelectedIndexChanged;
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = (Image)resources.GetObject("tabPage6.BackgroundImage");
            tabPage6.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage6.Controls.Add(label43);
            tabPage6.Controls.Add(checkBoxIsRent);
            tabPage6.Controls.Add(checkBoxIsFullFledged);
            tabPage6.Controls.Add(label42);
            tabPage6.Controls.Add(textBoxPlayerTransferTeamTo);
            tabPage6.Controls.Add(label36);
            tabPage6.Controls.Add(label37);
            tabPage6.Controls.Add(comboBoxPlayerTransferTeamFrom);
            tabPage6.Controls.Add(label38);
            tabPage6.Controls.Add(comboBoxPlayerTransferPlayer);
            tabPage6.Controls.Add(label39);
            tabPage6.Controls.Add(dateTimePicker1);
            tabPage6.Controls.Add(label40);
            tabPage6.Controls.Add(dateTimePicker2);
            tabPage6.Controls.Add(button2);
            tabPage6.Controls.Add(buttonEditPlayerTransfer);
            tabPage6.Controls.Add(buttonRemovePlayerTransfer);
            tabPage6.Controls.Add(buttonAddPlayerTransfer);
            tabPage6.Controls.Add(label41);
            tabPage6.Controls.Add(textBox2);
            tabPage6.Controls.Add(listBoxPlayersTransfers);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1500, 651);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Players transfers";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = Color.WhiteSmoke;
            label43.Location = new Point(927, 416);
            label43.Name = "label43";
            label43.Size = new Size(62, 20);
            label43.TabIndex = 119;
            label43.Text = "Is it rent";
            // 
            // checkBoxIsRent
            // 
            checkBoxIsRent.AutoSize = true;
            checkBoxIsRent.Location = new Point(901, 419);
            checkBoxIsRent.Name = "checkBoxIsRent";
            checkBoxIsRent.Size = new Size(18, 17);
            checkBoxIsRent.TabIndex = 118;
            checkBoxIsRent.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsFullFledged
            // 
            checkBoxIsFullFledged.AutoSize = true;
            checkBoxIsFullFledged.Location = new Point(901, 392);
            checkBoxIsFullFledged.Name = "checkBoxIsFullFledged";
            checkBoxIsFullFledged.Size = new Size(18, 17);
            checkBoxIsFullFledged.TabIndex = 117;
            checkBoxIsFullFledged.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = Color.WhiteSmoke;
            label42.Location = new Point(927, 386);
            label42.Name = "label42";
            label42.Size = new Size(113, 20);
            label42.TabIndex = 116;
            label42.Text = "Is it full fledged";
            // 
            // textBoxPlayerTransferTeamTo
            // 
            textBoxPlayerTransferTeamTo.Location = new Point(658, 331);
            textBoxPlayerTransferTeamTo.Multiline = true;
            textBoxPlayerTransferTeamTo.Name = "textBoxPlayerTransferTeamTo";
            textBoxPlayerTransferTeamTo.Size = new Size(133, 34);
            textBoxPlayerTransferTeamTo.TabIndex = 115;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = Color.WhiteSmoke;
            label36.Location = new Point(702, 299);
            label36.Name = "label36";
            label36.Size = new Size(63, 20);
            label36.TabIndex = 114;
            label36.Text = "Team to";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.WhiteSmoke;
            label37.Location = new Point(680, 229);
            label37.Name = "label37";
            label37.Size = new Size(81, 20);
            label37.TabIndex = 113;
            label37.Text = "Team from";
            // 
            // comboBoxPlayerTransferTeamFrom
            // 
            comboBoxPlayerTransferTeamFrom.FormattingEnabled = true;
            comboBoxPlayerTransferTeamFrom.Location = new Point(637, 263);
            comboBoxPlayerTransferTeamFrom.Name = "comboBoxPlayerTransferTeamFrom";
            comboBoxPlayerTransferTeamFrom.Size = new Size(168, 28);
            comboBoxPlayerTransferTeamFrom.TabIndex = 112;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.WhiteSmoke;
            label38.Location = new Point(477, 229);
            label38.Name = "label38";
            label38.Size = new Size(102, 20);
            label38.TabIndex = 111;
            label38.Text = "Choose Player";
            // 
            // comboBoxPlayerTransferPlayer
            // 
            comboBoxPlayerTransferPlayer.FormattingEnabled = true;
            comboBoxPlayerTransferPlayer.Location = new Point(447, 263);
            comboBoxPlayerTransferPlayer.Name = "comboBoxPlayerTransferPlayer";
            comboBoxPlayerTransferPlayer.Size = new Size(168, 28);
            comboBoxPlayerTransferPlayer.TabIndex = 110;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = Color.WhiteSmoke;
            label39.Location = new Point(914, 316);
            label39.Name = "label39";
            label39.Size = new Size(70, 20);
            label39.TabIndex = 109;
            label39.Text = "Date end";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(829, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 108;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = Color.WhiteSmoke;
            label40.Location = new Point(914, 229);
            label40.Name = "label40";
            label40.Size = new Size(74, 20);
            label40.TabIndex = 107;
            label40.Text = "Date start";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(829, 261);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 106;
            // 
            // button2
            // 
            button2.Location = new Point(1122, 348);
            button2.Name = "button2";
            button2.Size = new Size(120, 53);
            button2.TabIndex = 105;
            button2.Text = "Find coach contract";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonEditPlayerTransfer
            // 
            buttonEditPlayerTransfer.Location = new Point(613, 386);
            buttonEditPlayerTransfer.Name = "buttonEditPlayerTransfer";
            buttonEditPlayerTransfer.Size = new Size(120, 50);
            buttonEditPlayerTransfer.TabIndex = 104;
            buttonEditPlayerTransfer.Text = "Edit Player contract";
            buttonEditPlayerTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePlayerTransfer
            // 
            buttonRemovePlayerTransfer.Location = new Point(761, 383);
            buttonRemovePlayerTransfer.Name = "buttonRemovePlayerTransfer";
            buttonRemovePlayerTransfer.Size = new Size(120, 53);
            buttonRemovePlayerTransfer.TabIndex = 103;
            buttonRemovePlayerTransfer.Text = "Remove player contract";
            buttonRemovePlayerTransfer.UseVisualStyleBackColor = true;
            buttonRemovePlayerTransfer.Click += buttonRemovePlayerTransfer_Click;
            // 
            // buttonAddPlayerTransfer
            // 
            buttonAddPlayerTransfer.Location = new Point(463, 385);
            buttonAddPlayerTransfer.Name = "buttonAddPlayerTransfer";
            buttonAddPlayerTransfer.Size = new Size(116, 53);
            buttonAddPlayerTransfer.TabIndex = 102;
            buttonAddPlayerTransfer.Text = "Add new player contract";
            buttonAddPlayerTransfer.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = Color.WhiteSmoke;
            label41.Location = new Point(1075, 229);
            label41.Name = "label41";
            label41.Size = new Size(199, 20);
            label41.TabIndex = 101;
            label41.Text = "Find coach contract by name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1103, 258);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 61);
            textBox2.TabIndex = 100;
            // 
            // listBoxPlayersTransfers
            // 
            listBoxPlayersTransfers.FormattingEnabled = true;
            listBoxPlayersTransfers.ItemHeight = 20;
            listBoxPlayersTransfers.Location = new Point(351, 0);
            listBoxPlayersTransfers.Name = "listBoxPlayersTransfers";
            listBoxPlayersTransfers.Size = new Size(1139, 164);
            listBoxPlayersTransfers.TabIndex = 1;
            listBoxPlayersTransfers.SelectedIndexChanged += listBoxPlayersTransfers_SelectedIndexChanged;
            // 
            // tabPage7
            // 
            tabPage7.BackgroundImage = (Image)resources.GetObject("tabPage7.BackgroundImage");
            tabPage7.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage7.Controls.Add(buttonEditPosition);
            tabPage7.Controls.Add(buttonRemovePosition);
            tabPage7.Controls.Add(buttonFindPosition);
            tabPage7.Controls.Add(label13);
            tabPage7.Controls.Add(textBoxFindPosition);
            tabPage7.Controls.Add(buttonAddPosition);
            tabPage7.Controls.Add(textBoxPosition);
            tabPage7.Controls.Add(label32);
            tabPage7.Controls.Add(listBoxPositions);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1500, 651);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Positions";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonEditPosition
            // 
            buttonEditPosition.Location = new Point(222, 180);
            buttonEditPosition.Name = "buttonEditPosition";
            buttonEditPosition.Size = new Size(120, 29);
            buttonEditPosition.TabIndex = 64;
            buttonEditPosition.Text = "Edit position";
            buttonEditPosition.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePosition
            // 
            buttonRemovePosition.Location = new Point(222, 257);
            buttonRemovePosition.Name = "buttonRemovePosition";
            buttonRemovePosition.Size = new Size(120, 29);
            buttonRemovePosition.TabIndex = 63;
            buttonRemovePosition.Text = "Remove position";
            buttonRemovePosition.UseVisualStyleBackColor = true;
            buttonRemovePosition.Click += buttonRemovePosition_Click;
            // 
            // buttonFindPosition
            // 
            buttonFindPosition.Location = new Point(403, 255);
            buttonFindPosition.Name = "buttonFindPosition";
            buttonFindPosition.Size = new Size(120, 29);
            buttonFindPosition.TabIndex = 62;
            buttonFindPosition.Text = "Find position";
            buttonFindPosition.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.WhiteSmoke;
            label13.Location = new Point(403, 148);
            label13.Name = "label13";
            label13.Size = new Size(145, 20);
            label13.TabIndex = 61;
            label13.Text = "Find Player by Name";
            // 
            // textBoxFindPosition
            // 
            textBoxFindPosition.Location = new Point(403, 177);
            textBoxFindPosition.Multiline = true;
            textBoxFindPosition.Name = "textBoxFindPosition";
            textBoxFindPosition.Size = new Size(120, 61);
            textBoxFindPosition.TabIndex = 60;
            // 
            // buttonAddPosition
            // 
            buttonAddPosition.Location = new Point(30, 257);
            buttonAddPosition.Name = "buttonAddPosition";
            buttonAddPosition.Size = new Size(134, 29);
            buttonAddPosition.TabIndex = 57;
            buttonAddPosition.Text = "Add new position";
            buttonAddPosition.UseVisualStyleBackColor = true;
            buttonAddPosition.Click += buttonAddPosition_Click;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(30, 180);
            textBoxPosition.Multiline = true;
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(134, 58);
            textBoxPosition.TabIndex = 52;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.WhiteSmoke;
            label32.Location = new Point(49, 148);
            label32.Name = "label32";
            label32.Size = new Size(73, 20);
            label32.TabIndex = 46;
            label32.Text = "Full name";
            // 
            // listBoxPositions
            // 
            listBoxPositions.FormattingEnabled = true;
            listBoxPositions.ItemHeight = 20;
            listBoxPositions.Location = new Point(0, 0);
            listBoxPositions.Name = "listBoxPositions";
            listBoxPositions.Size = new Size(1486, 124);
            listBoxPositions.TabIndex = 1;
            listBoxPositions.SelectedIndexChanged += listBoxPositions_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(323, 329);
            button1.Name = "button1";
            button1.Size = new Size(120, 52);
            button1.TabIndex = 46;
            button1.Text = "Find coach contract";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 686);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "User Form";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoach).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCoaches;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private ListBox listBoxCoachesContracts;
        private ListBox listBoxFootballTeams;
        private ListBox listBoxPlayers;
        private ListBox listBoxPlayersContracts;
        private ListBox listBoxPlayersTransfers;
        private ListBox listBoxPositions;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxCoachCurrentMatches;
        private TextBox textBoxCoachWonTrofies;
        private TextBox textBoxCoachAge;
        private TextBox textBoxCoachFullName;
        private TextBox textBoxDrawnMatches;
        private TextBox textBoxLoosedMatches;
        private TextBox textBoxWonMatches;
        private Label label9;
        private PictureBox pictureBoxCoach;
        private Button buttonEditCoach;
        private Button buttonRemoveCoach;
        private Button buttonAddCoach;
        private Button buttonFindCoach;
        private Label label10;
        private TextBox textBoxFindCoach;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBoxPlayerGoals;
        private TextBox textBoxPlayerAge;
        private DateTimePicker dateTimePickerStartDate;
        private Label label1;
        private TextBox textBoxFindCoachContract;
        private Button buttonFindCoachContract;
        private Button buttonEditCoachContract;
        private Button buttonRemoveCoachContract;
        private Button buttonAddCoachContract;
        private TextBox textBoxPlayerWorkingLeg;
        private TextBox textBoxPlayerFullName;
        private TextBox textBox9;
        private TextBox textBoxContractSalary;
        private TextBox textBox11;
        private TextBox textBox13;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label labelCContract;
        private Label label23;
        private DateTimePicker dateTimePickerDateEnd;
        private Label label16;
        private DateTimePicker dateTimePickerDateStart;
        private ComboBox comboBoxContractCoaches;
        private Label label26;
        private Label label25;
        private Button buttonFindPlayer;
        private Label label11;
        private TextBox textBoxFindPlayer;
        private Button buttonEditPlayer;
        private Button buttonRemovePlayer;
        private Button buttonAddPlayer;
        private TextBox textBoxAssists;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label17;
        private CheckBox checkBoxPlayerIsCaptain;
        private Button buttonFindPosition;
        private Button buttonAddPosition;
        private TextBox textBoxPosition;
        private Label label32;
        private Label label13;
        private TextBox textBoxFindPosition;
        private Button buttonEditPosition;
        private Button buttonRemovePosition;
        private Label label27;
        private ComboBox comboBoxFootballTeamCoach;
        private Button buttonEditFootballTeam;
        private Button buttonRemoveFootballTeam;
        private Button buttonAddFootballTeam;
        private TextBox textBoxFootballTeamFullName;
        private Label label28;
        private TextBox textBoxFootballTeamCountry;
        private Label label22;
        private DateTimePicker dateTimePickerFootballTeamCreationDate;
        private Label label24;
        private Label label29;
        private ComboBox comboBoxPlayerContractPlayer;
        private Label label30;
        private DateTimePicker dateTimePickerPlayerContractDateEnd;
        private Label label31;
        private DateTimePicker dateTimePickerPlayerContractDateStart;
        private Button buttonFindPlayerContract;
        private Button buttonEditPlayerContract;
        private Button buttonRemovePlayerContract;
        private Button buttonAddPlayerContract;
        private Label label34;
        private TextBox textBoxFindPlayerContract;
        private Label label35;
        private ComboBox comboBoxPlayerContractFootballTeam;
        private TextBox textBoxPlayerContractSalary;
        private Label label33;
        private CheckBox checkBoxIsFullFledged;
        private Label label42;
        private TextBox textBoxPlayerTransferTeamTo;
        private Label label36;
        private Label label37;
        private ComboBox comboBoxPlayerTransferTeamFrom;
        private Label label38;
        private ComboBox comboBoxPlayerTransferPlayer;
        private Label label39;
        private DateTimePicker dateTimePicker1;
        private Label label40;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Button buttonEditPlayerTransfer;
        private Button buttonRemovePlayerTransfer;
        private Button buttonAddPlayerTransfer;
        private Label label41;
        private TextBox textBox2;
        private Label label43;
        private CheckBox checkBoxIsRent;
        private Button buttonCancelCoach;
        private Label label44;
        private Button buttonFindFootballTeam;
        private Label label45;
        private TextBox textBoxFindFootballTeam;
        private Button buttonCancelFootballTeam;
    }
}