﻿using Matrix.Xmpp.Google.Mobile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matrix.Xmpp.Tests.Google.GCM
{
    [TestClass]
    public class GcmTest
    {
        string XML1 = @"<message id='foo' xmlns='jabber:client'>
  <gcm xmlns='google:mobile:data'>{'to':'REGISTRATION_ID'}</gcm>
</message>";
        [TestMethod]
        public void BuildGcmMessage()
        {
            var msg = new Matrix.Xmpp.Client.Message {Id = "foo"};
            msg.Add(new Gcm {Value = "{'to':'REGISTRATION_ID'}" });
            msg.ShouldBe(XML1);
        }
    }
}
