using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using chatbotrepo.Controllers;

namespace PatientMonitorChatBotTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenQuestionId1_WhenItIsValid_ThenDisplayCorrectQuestion2()
        {
            ChatBotController m = new ChatBotController();
            string Actual = "What is the basic requirement of your monitor?" + Environment.NewLine + " 1.Maternal and Fetal " + Environment.NewLine + " 2.Vital Signs" + Environment.NewLine + " 3.Bedside Patient Monitor" + Environment.NewLine + " 4.Central Monitoring System" + Environment.NewLine + " 5.IntelliVue(serves a wide range of care environment)";
            string expected = m.Get();
            Assert.AreNotEqual(expected, Actual);
        }
        [TestMethod]
        public void Given_QuestionId_1_and_OptionId_1_Return_LinkId_2()
        {
            ChatBotController chatbot = new ChatBotController();
            int expected = chatbot.GetLink(new WebApplication2.DAL.optiontable { question_id = 1, optionid = 1 });
            int actual = 2;
            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void Given_LinkId_4_Return_Question_And_Options_with_Id_4()
        {
            ChatBotController chatbot = new ChatBotController();
            string expected = chatbot.FetchQuestion(new WebApplication2.DAL.optiontable { linkid = 4 });
            string actual = "Do you want video and audio interface?" + Environment.NewLine + "1.Yes" + Environment.NewLine + "2.No";
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Given_QId_And_OptId_fetch_MonitorName()
        {
            ChatBotController chatbot = new ChatBotController();
            string expected = chatbot.MonitorFetch(new WebApplication2.DAL.optiontable { optionid = 3, question_id = 12 });
            string actual = "Intellivue GS";
            Assert.AreEqual(expected, actual);

        }
    }
}

    

