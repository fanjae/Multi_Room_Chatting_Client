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
        private void button1_Click(object sender, EventArgs e)
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
                string request = "/Get_Chatting_Room";
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                socket.Send(buffer);

                byte[] recvBuffer = new byte[1024];
                int recvLength = socket.Receive(recvBuffer);
                string rooms = Encoding.UTF8.GetString(recvBuffer, 0, recvLength);

                if (rooms == "/No_Room")
                {
                    MessageBox.Show("���� ������ ���� �����ϴ�.", "�� ����Ʈ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomList.Items.Clear();  // ListBox �ʱ�ȭ
                }
                else
                {
                    string[] roomList = rooms.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
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
                    string request = "/Create_Chatting_Room " + Room.getRoomNameTextBox();
                    byte[] buffer = Encoding.UTF8.GetBytes(request);
                    socket.Send(buffer);

                    byte[] recvBuffer = new byte[1024];
                    int recvLength = socket.Receive(recvBuffer);
                    string rooms = Encoding.UTF8.GetString(recvBuffer, 0, recvLength);

                    if (rooms == "/Exist Room")
                    {
                        MessageBox.Show("�̹� �����ϴ� ���Դϴ�.", "�� ���� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        request = "/Join_Chatting_Room " + Room.getRoomNameTextBox();
                        buffer = Encoding.UTF8.GetBytes(request);
                        socket.Send(buffer);


                    }
                }
            }
        }
    }
}
