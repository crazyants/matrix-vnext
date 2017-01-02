﻿using Matrix.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matrix.Xmpp.Tests.Bosh
{
     [TestClass]
    public class BoshTest
    {
        private const string XML1 = @"<body type='terminate' condition='remote-connection-failed' xmlns='http://jabber.org/protocol/httpbind'/>";
        private const string XML2 = @"<body type='terminate' condition='item-not-found' xmlns='http://jabber.org/protocol/httpbind'/>";
        private const string XML3 = @"<body type='terminate' condition='host-unknown' xmlns='http://jabber.org/protocol/httpbind'/>";
        private const string XML4 = @"<body type='terminate' condition='see-other-uri' xmlns='http://jabber.org/protocol/httpbind'/>";
        private const string XML5 = @"<body type='terminate' condition='bad-request' xmlns='http://jabber.org/protocol/httpbind'/>";
        
        [TestMethod]
        public void Test1()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML1);
            Assert.AreEqual(true, xmpp1 is Matrix.Xmpp.Bosh.Body);

            var body = xmpp1 as Matrix.Xmpp.Bosh.Body;
            if (body != null)
            {
                Assert.AreEqual(body.Condition == Matrix.Xmpp.Bosh.Condition.RemoteConnectionFailed, true);
            }

            var conf = new Matrix.Xmpp.Bosh.Body()
            {
                Type = Matrix.Xmpp.Bosh.Type.Terminate,
                Condition = Matrix.Xmpp.Bosh.Condition.RemoteConnectionFailed
            };

            conf.ShouldBe(XML1);
        }

        [TestMethod]
        public void Test2()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML2);
            Assert.AreEqual(true, xmpp1 is Matrix.Xmpp.Bosh.Body);

            var body = xmpp1 as Matrix.Xmpp.Bosh.Body;
            if (body != null)
            {
                Assert.AreEqual(body.Condition == Matrix.Xmpp.Bosh.Condition.ItemNotFound, true);
            }

            var conf = new Matrix.Xmpp.Bosh.Body()
            {
                Type = Matrix.Xmpp.Bosh.Type.Terminate,
                Condition = Matrix.Xmpp.Bosh.Condition.ItemNotFound
            };

            conf.ShouldBe(XML2);
        }

        [TestMethod]
        public void Test3()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML3);
            Assert.AreEqual(true, xmpp1 is Matrix.Xmpp.Bosh.Body);

            var body = xmpp1 as Matrix.Xmpp.Bosh.Body;
            if (body != null)
            {
                Assert.AreEqual(body.Condition == Matrix.Xmpp.Bosh.Condition.HostUnknown, true);
            }

            var conf = new Matrix.Xmpp.Bosh.Body()
            {
                Type = Matrix.Xmpp.Bosh.Type.Terminate,
                Condition = Matrix.Xmpp.Bosh.Condition.HostUnknown
            };

            conf.ShouldBe(XML3);
        }

        [TestMethod]
        public void Test4()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML4);
            Assert.AreEqual(true, xmpp1 is Matrix.Xmpp.Bosh.Body);

            var body = xmpp1 as Matrix.Xmpp.Bosh.Body;
            if (body != null)
            {
                Assert.AreEqual(body.Condition == Matrix.Xmpp.Bosh.Condition.SeeOtherUri, true);
            }

            var conf = new Matrix.Xmpp.Bosh.Body()
            {
                Type = Matrix.Xmpp.Bosh.Type.Terminate,
                Condition = Matrix.Xmpp.Bosh.Condition.SeeOtherUri
            };

            conf.ShouldBe(XML4);
        }

        [TestMethod]
        public void Test5()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML5);
            Assert.AreEqual(true, xmpp1 is Matrix.Xmpp.Bosh.Body);

            var body = xmpp1 as Matrix.Xmpp.Bosh.Body;
            if (body != null)
            {
                Assert.AreEqual(body.Condition == Matrix.Xmpp.Bosh.Condition.BadRequest, true);
            }

            var conf = new Matrix.Xmpp.Bosh.Body()
            {
                Type = Matrix.Xmpp.Bosh.Type.Terminate,
                Condition = Matrix.Xmpp.Bosh.Condition.BadRequest
            };

            conf.ShouldBe(XML5);
        }
    }
}
