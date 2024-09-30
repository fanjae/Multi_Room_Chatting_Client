namespace Multi_Room_Chatting_Client
{
    partial class ChattingRoom_Form
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
            chattingRoomTextBox = new TextBox();
            sendTextBox = new TextBox();
            SendButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // chattingRoomTextBox
            // 
            chattingRoomTextBox.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chattingRoomTextBox.Location = new Point(26, 23);
            chattingRoomTextBox.Multiline = true;
            chattingRoomTextBox.Name = "chattingRoomTextBox";
            chattingRoomTextBox.ReadOnly = true;
            chattingRoomTextBox.Size = new Size(883, 420);
            chattingRoomTextBox.TabIndex = 0;
            // 
            // sendTextBox
            // 
            sendTextBox.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            sendTextBox.Location = new Point(26, 472);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.Size = new Size(577, 45);
            sendTextBox.TabIndex = 1;
            sendTextBox.KeyDown += sendTextBox_KeyDown;
            // 
            // SendButton
            // 
            SendButton.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SendButton.Location = new Point(620, 472);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(143, 45);
            SendButton.TabIndex = 2;
            SendButton.Text = "보내기";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ExitButton.Location = new Point(769, 472);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(143, 45);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "나가기";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ChattingRoom_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 547);
            Controls.Add(ExitButton);
            Controls.Add(SendButton);
            Controls.Add(sendTextBox);
            Controls.Add(chattingRoomTextBox);
            Name = "ChattingRoom_Form";
            Text = "ChattingRoom";
            FormClosing += ChattingRoom_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox chattingRoomTextBox;
        private TextBox sendTextBox;
        private Button SendButton;
        private Button ExitButton;
    }
}