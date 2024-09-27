namespace Multi_Room_Chatting_Client
{
    partial class CreateRoom
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
            label1 = new Label();
            roomNameTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(111, 38);
            label1.TabIndex = 0;
            label1.Text = "방 제목";
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            roomNameTextBox.Location = new Point(172, 23);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new Size(450, 45);
            roomNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(642, 17);
            button1.Name = "button1";
            button1.Size = new Size(146, 56);
            button1.TabIndex = 2;
            button1.Text = "생성";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 98);
            Controls.Add(button1);
            Controls.Add(roomNameTextBox);
            Controls.Add(label1);
            Name = "CreateRoom";
            Text = "CreateRoom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox roomNameTextBox;
        private Button button1;
    }
}