using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

namespace yonunca
{
    public partial class Form1 : Form
    {
        string[] vectorconectados = new string[40]; // Vector para guardar los conectados
        Socket server;
        Thread atender;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Necesario para que los elementos de los formularios puedan ser
            //accedidos desde threads diferentes a los que los crearon
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9055);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje = trozos[1].Split('\0')[0];

                switch (codigo)
                {

                    case 1:  // LogIn

                        MessageBox.Show("Estas dentro: " + mensaje);
                        break;
                    case 2:   // Ganador en esa fecha 

                        MessageBox.Show("El ganador es: " + mensaje);
                        break;

                    case 3: // listadeconectados

                        dataGridView1.Rows.Clear(); //limpiamos para que no se nos vuelva a repeir laa lista en el data
                            
                        string[] partes = Encoding.ASCII.GetString(msg2).Split('/');
                        string mensajefinal = partes[1].Split('\0')[0];
                        string[] mensaje2 = mensajefinal.Split('|');

                        for (int i = 0; i < (mensaje2.Length - 1); i++)
                        {

                            dataGridView1.Rows.Add(mensaje2[i + 1]);
                            MessageBox.Show("Ha entrado: " + mensaje2[i + 1]);
                            vectorconectados[i] = mensaje2[i + 1];

                        }


                        //for (int i = 0; i < trozos.Length; i++)
                        //   {
                        //       dataGridView1.Rows.Add(mensaje);
                        //       MessageBox.Show("Ha entrado: " + mensaje);
                        //       vectorconectados[i] = mensaje;

                        //   }


                        /*string[] trozo = Encoding.ASCII.GetString(msg2).Split('-');
                        int cod = Convert.ToInt32(trozo[1]);
                        mensaje = trozo[1].Split('\0')[1];
                        */
                        Conectados.Text = mensaje;
                        // MessageBox.Show("si:" + mensaje);
                        
                        break;
                }
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (login.Checked)
            {
                //Enviamos nombre y contraseña 
                string mensaje = "1/" + nombre.Text + "/" + contraseña.Text;
                // Enviamos al servidor el nombre tecleado y  la contraseña
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);         
            }

            else if (ganador.Checked)
            {
                string mensaje = "2/" + fecha.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("El ganador es: " + mensaje);
 

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
