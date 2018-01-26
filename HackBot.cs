using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using Robocode;
using Robocode.RobotInterfaces.Peer;

namespace ANB.BattleBot
{
    public class HackBot : Robot
    {
        public override void Run()
        {
            var peerField = GetType().GetField("peer", BindingFlags.Instance | BindingFlags.NonPublic);

            var peer = (IBasicRobotPeer) peerField.GetValue(this);

            Out.WriteLine("Peer: " + peer);
            
//            peerField.SetValue(this, new PeerProxy(peer, Out));
        }

/*
        private class PeerProxy : RealProxy
        {
            private readonly IBasicRobotPeer peer;
            private readonly TextWriter writer;

            public PeerProxy(IBasicRobotPeer peer, TextWriter writer)
            {
                this.peer = peer;
                this.writer = writer;
            }

            public override IMessage Invoke(IMessage msg)
            {
                IMethodCallMessage methodMessage = new MethodCallMessageWrapper((IMethodCallMessage) msg);
                MethodBase method = methodMessage.MethodBase;

                object returnValue;

                writer.WriteLine("Calling: " + method.Name);
                
                if (method.Name == "GetEnergy")
                {
                    returnValue = 100.0;
                }
                else
                {
                    returnValue = method.Invoke(peer, methodMessage.Args);
                }

                return new ReturnMessage(returnValue, methodMessage.Args, methodMessage.ArgCount, methodMessage.LogicalCallContext, methodMessage);
            }
        }
*/
    }
}