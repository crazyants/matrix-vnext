﻿using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Matrix.Xmpp.Tests.Roster
{
    [TestClass]
    public class RosterManagerTest
    {
        private const string XML1 = @"<iq id='TestAdd' type='set' xmlns='jabber:client'>
          <query xmlns='jabber:iq:roster'>
            <item jid='me@server.com' name='Alex'>
              <group>Group1</group>
            </item>
          </query>
        </iq>";
        
        //[TestMethod]
        //public void TestAdd()
        //{
        //    var rm = new RosterManager();
        //    var iq = rm.CreateAddStanza("me@server.com", "Alex", new[] { "Group1" });
        //    iq.Id = "TestAdd";

        //    XmlAssertion.AssertXmlEquals(Util.GetXmlDiff(XML1, iq));
        //}
    }
}
