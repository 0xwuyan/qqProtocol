namespace QQ.Framework.Packets.Receive.Message
{
    public class Receive_0X03FC : ReceivePacket
    {
        public Receive_0X03FC(byte[] byteBuffer, QQUser user)
            : base(byteBuffer, user, user.TXProtocol.SessionKey)
        {
        }

        protected override void ParseBody()
        {
            Decrypt(User.TXProtocol.SessionKey);
        }
    }
}