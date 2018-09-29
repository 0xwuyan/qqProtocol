using System;
using System.Text;
using QQ.Framework;
using QQ.Framework.Domains;
using QQ.Framework.Sockets;
using QQLoginTest.Robots;

namespace QQLoginTest
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Ӧ������������QQ�ź�����");
            }
            var user = new QQUser(int.Parse(args[0]), args[1]);
            var socketServer = new SocketServiceImpl(user);
            var transponder = new Transponder();
            var sendService = new SendMessageServiceImpl(socketServer, user);

            var manage = new MessageManage(socketServer, user, transponder);

            var robot = new TestRoBot(sendService, transponder, user);

            manage.Init();
            Console.ReadKey();
        }
    }
}