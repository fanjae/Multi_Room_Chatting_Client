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
            listBox1 = new ListBox();
            label4 = new Label();
            textBox1 = new TextBox();
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
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(47, 173);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 270);
            listBox1.TabIndex = 7;
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
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(434, 173);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(414, 270);
            textBox1.TabIndex = 9;
            // 
            // LobbyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 548);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox1;
    }
}
