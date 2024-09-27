namespace Multi_Room_Chatting_Client
{
    partial class ChattingRoom
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
            textBox1 = new TextBox();
            SendButton = new Button();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(26, 472);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(577, 45);
            textBox1.TabIndex = 1;
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
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(769, 472);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 3;
            button1.Text = "나가기";
            button1.UseVisualStyleBackColor = true;
            // 
            // ChattingRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 547);
            Controls.Add(button1);
            Controls.Add(SendButton);
            Controls.Add(textBox1);
            Controls.Add(chattingRoomTextBox);
            Name = "ChattingRoom";
            Text = "ChattingRoom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox chattingRoomTextBox;
        private TextBox textBox1;
        private Button SendButton;
        private Button button1;
    }
}