using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Multi_Room_Chatting_Client
{
    public partial class LobbyForm : Form
    {
        private Socket socket;
        public LobbyForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(LobbyForm_FormClosing);
        }
        private bool IsSocketConnected(Socket socket)
        {
            try
            {
                if (socket == null || socket.Connected == false)
                {
                    throw new InvalidOperationException("������ ������ �� �����ϴ�.");
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("�� �� ���� ������ �߻��߽��ϴ�: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text == "")
            {
                MessageBox.Show("IP �ּҴ� �ʼ� �Է� ���Դϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PortTextBox.Text == "")
            {
                MessageBox.Show("Port�� �ʼ� �Է� ���Դϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IPAddress serverIp = IPAddress.Parse(IPTextBox.Text);
                IPEndPoint endPoint = new IPEndPoint(serverIp, int.Parse(PortTextBox.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    socket.Connect(endPoint);
                    MessageBox.Show("������ ����Ǿ����ϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogTextBox.Text += "[Log] ���� ������ �����Ͽ����ϴ�. \r\n";
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("������ ������ �� �����ϴ�: " + ex.Message, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetRoomListButton_Click(object sender, EventArgs e)
        {
            if (IsSocketConnected(socket))
            {
                string request = Constants.GET_CHATTING_ROOM;
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                socket.Send(buffer);

                byte[] recvBuffer = new byte[1024];
                int recvLength = socket.Receive(recvBuffer);
                string rooms = Encoding.UTF8.GetString(recvBuffer, 0, recvLength);

                if (rooms == Constants.NO_ROOM)
                {
                    MessageBox.Show("���� ������ ���� �����ϴ�.", "�� ����Ʈ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomList.Items.Clear();  // ListBox �ʱ�ȭ
                }
                else
                {
                    string[] roomList = rooms.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                    RoomList.Items.Clear();
                    RoomList.Items.AddRange(roomList);
                }
            }
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            if (IsSocketConnected(socket))
            {
                CreateRoom Room = new CreateRoom();

                var result = Room.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string request = Constants.CREATE_CHATTING_ROOM + Room.getRoomNameTextBox();
                    byte[] buffer = Encoding.UTF8.GetBytes(request);
                    socket.Send(buffer);

                    byte[] recvBuffer = new byte[1024];
                    int recvLength = socket.Receive(recvBuffer);
                    string rooms = Encoding.UTF8.GetString(recvBuffer, 0, recvLength);

                    if (rooms == Constants.EXIST_ROOM)
                    {
                        MessageBox.Show("�̹� �����ϴ� ���Դϴ�.", "�� ���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("�� ������ �Ϸ�Ǿ����ϴ�.", "�� ���� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogTextBox.Text += "[Log] ���� �����Ͽ����ϴ�. \r\n";

                        request = Constants.JOIN_CHATTING_ROOM + rooms;
                        JoinChattingRoom(request);
                    }
                }
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (RoomList.SelectedItem == null)
            {
                MessageBox.Show("���õ� ���� �����ϴ�.", "�� ���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IsSocketConnected(socket))
            {
                string request = Constants.JOIN_CHATTING_ROOM + RoomList.SelectedItem.ToString();
                JoinChattingRoom(request);
            }
        }

        private void JoinChattingRoom(string request)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(request);
            socket.Send(buffer);

            byte[] recvBuffer = new byte[1024];
            int recvLength = socket.Receive(recvBuffer);
            string message = Encoding.UTF8.GetString(recvBuffer, 0, recvLength);

            if (message == Constants.NOT_EXIST_ROOM)
            {
                MessageBox.Show("���� �������� �ʽ��ϴ�.", "�� ���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ChattingRoom_Form room = new ChattingRoom_Form(socket, message);

                room.ShowDialog();
            }
        }

        private void LobbyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socket != null && socket.Connected == true)
            {
                string request = Constants.CLOSE_SOCKET;
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                socket.Send(buffer);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
