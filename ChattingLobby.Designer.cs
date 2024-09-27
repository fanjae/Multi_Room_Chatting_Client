namespace Multi_Room_Chatting_Client
{
    partial class LobbyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            IPTextBox = new TextBox();
            PortTextBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            GetRoomListButton = new Button();
            RoomList = new ListBox();
            label4 = new Label();
            LogTextBox = new TextBox();
            JoinButton = new Button();
            CreateRoomButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(41, 38);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // IPTextBox
            // 
            IPTextBox.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            IPTextBox.Location = new Point(97, 23);
            IPTextBox.Name = "IPTextBox";
            IPTextBox.Size = new Size(212, 39);
            IPTextBox.TabIndex = 1;
            // 
            // PortTextBox
            // 
            PortTextBox.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            PortTextBox.Location = new Point(416, 23);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(179, 39);
            PortTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(331, 21);
            label2.Name = "label2";
            label2.Size = new Size(70, 38);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(626, 16);
            button1.Name = "button1";
            button1.Size = new Size(213, 49);
            button1.TabIndex = 4;
            button1.Text = "연결";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(37, 110);
            label3.Name = "label3";
            label3.Size = new Size(145, 38);
            label3.TabIndex = 5;
            label3.Text = "Room List";
            // 
            // GetRoomListButton
            // 
            GetRoomListButton.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            GetRoomListButton.Location = new Point(188, 105);
            GetRoomListButton.Name = "GetRoomListButton";
            GetRoomListButton.Size = new Size(224, 49);
            GetRoomListButton.TabIndex = 6;
            GetRoomListButton.Text = "새로고침";
            GetRoomListButton.UseVisualStyleBackColor = true;
            GetRoomListButton.Click += GetRoomListButton_Click;
            // 
            // RoomList
            // 
            RoomList.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RoomList.FormattingEnabled = true;
            RoomList.ItemHeight = 38;
            RoomList.Location = new Point(47, 173);
            RoomList.Name = "RoomList";
            RoomList.Size = new Size(365, 270);
            RoomList.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(551, 110);
            label4.Name = "label4";
            label4.Size = new Size(165, 38);
            label4.TabIndex = 8;
            label4.Text = "System Log";
            // 
            // LogTextBox
            // 
            LogTextBox.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LogTextBox.Location = new Point(440, 173);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.Size = new Size(408, 270);
            LogTextBox.TabIndex = 9;
            // 
            // JoinButton
            // 
            JoinButton.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            JoinButton.Location = new Point(47, 474);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(365, 49);
            JoinButton.TabIndex = 10;
            JoinButton.Text = "입장";
            JoinButton.UseVisualStyleBackColor = true;
            // 
            // CreateRoomButton
            // 
            CreateRoomButton.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CreateRoomButton.Location = new Point(440, 474);
            CreateRoomButton.Name = "CreateRoomButton";
            CreateRoomButton.Size = new Size(408, 49);
            CreateRoomButton.TabIndex = 11;
            CreateRoomButton.Text = "방만들기";
            CreateRoomButton.UseVisualStyleBackColor = true;
            CreateRoomButton.Click += CreateRoomButton_Click;
            // 
            // LobbyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 548);
            Controls.Add(CreateRoomButton);
            Controls.Add(JoinButton);
            Controls.Add(LogTextBox);
            Controls.Add(label4);
            Controls.Add(RoomList);
            Controls.Add(GetRoomListButton);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(PortTextBox);
            Controls.Add(label2);
            Controls.Add(IPTextBox);
            Controls.Add(label1);
            Name = "LobbyForm";
            Text = "Chatting Room Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox IPTextBox;
        private TextBox PortTextBox;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button GetRoomListButton;
        private ListBox RoomList;
        private Label label4;
        private TextBox LogTextBox;
        private Button JoinButton;
        private Button CreateRoomButton;
    }
}
