﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix.Xml;
using Matrix.Xmpp.Vcard;

namespace Matrix.Xmpp.Tests.Vcard
{
    [TestClass]
    public class TelephoneTest
    {
        string xml1 = @"<TEL xmlns='vcard-temp'><VOICE/><WORK/><NUMBER>303-308-3282</NUMBER></TEL>";
        string xml2 = @"<TEL xmlns='vcard-temp'><FAX/><WORK/><NUMBER>12345</NUMBER></TEL>";
        string xml3 = @"<TEL xmlns='vcard-temp'><MSG/><WORK/><NUMBER>67890</NUMBER></TEL>";

        string xml4 = @"<TEL xmlns='vcard-temp'><PREF/><NUMBER>12345</NUMBER></TEL>";
        string xml5 = @"<TEL xmlns='vcard-temp'><HOME/><PREF/><NUMBER>12345</NUMBER></TEL>";
        string xml6 = @"<TEL xmlns='vcard-temp'><WORK/><PREF/><NUMBER>12345</NUMBER></TEL>";
        
        [TestMethod]
        public void Test1()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(xml1);
            Assert.AreEqual(true, xmpp1 is Telephone);

            Telephone tel1 = xmpp1 as Telephone;
            Assert.AreEqual(tel1.Number, "303-308-3282");
            Assert.AreEqual(tel1.IsVoice, true);
            Assert.AreEqual(tel1.IsWork, true);
            Assert.AreEqual(tel1.IsHome, false);


            XmppXElement xmpp2 = XmppXElement.LoadXml(xml2);
            Telephone tel2 = xmpp2 as Telephone;
            Assert.AreEqual(true, xmpp2 is Telephone);
            Assert.AreEqual(tel2.Number, "12345");
            Assert.AreEqual(tel2.IsWork, true);
            Assert.AreEqual(tel2.IsFax, true);


            XmppXElement xmpp3 = XmppXElement.LoadXml(xml3);
            Assert.AreEqual(true, xmpp3 is Telephone);
            Telephone tel3 = xmpp3 as Telephone;
            Assert.AreEqual(true, xmpp3 is Telephone);
            Assert.AreEqual(tel3.Number, "67890");
            Assert.AreEqual(tel2.IsWork, true);
            Assert.AreEqual(tel2.IsMessagingService, false);    
            
        }

        [TestMethod]
        public void Test2()
        {           
            Telephone tel1 = new Telephone("12345", true);     
            tel1.ShouldBe(xml4);       
            
            Telephone tel2 = new Telephone("12345", true);
            tel2.IsHome = true;
            tel2.ShouldBe(xml5);
            
            Telephone tel3 = new Telephone("12345", true);
            tel3.IsWork = true;
            tel3.ShouldBe(xml6);
        }


    }
}
