using Lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_P2P
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void CreateClient_Click(object sender, EventArgs e)
        {
            Client chatClientForm = new Client();
            chatClientForm.Show();
            CreateClient.Enabled = true;
        }

        private void CreateServer_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThrd = new Thread(ServerThread);
            ServerThrd.Start();
            Thread isServerAli = new Thread(() => isServerAlive(ServerThrd));
            isServerAli.Start();
        }
        private void ServerThread()
        {
            Server ChatServer = new Server();
            ChatServer.ShowDialog();
        }

        private void isServerAlive(Thread ServerThread)
        {
            while (true)
            {
                if (ServerThread.IsAlive)
                {
                    CreateServer.Enabled = false;
                }
                else
                {
                    CreateServer.Enabled = true;
                    break;
                }
            }
        }

    }
}
