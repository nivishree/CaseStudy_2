using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using chatbotrepo;

namespace UnitTestProject1
{
    [TestClass]
    public class ChatBotControllerTest
    {
        [TestMethod]
        public void GivenMonitoId_WhenItIsValid_ThenGiveCorrectMonitorName()
        {
            MonitorRepository m = new MonitorRepository();
            string Actual = "Avalon CL";
            string expected = m.DataFetch(1);
            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenMonitoId_WhenItIsValid_ThenGiveCorrectMonitorName2()
        {
            MonitorRepository m = new MonitorRepository();
            string Actual = "IntelliVue MP5SC";
            string expected = m.DataFetch(22);
            Assert.AreEqual(Actual, expected);
        }


        [TestMethod]
        public void GivenMonitoId_WhenItIsNotValid_ThenShouldNotGiveCorrecttMonitorName()
        {
            MonitorRepository m = new MonitorRepository();
            string Actual = "IntelliVue MP5SC";
            string expected = m.DataFetch(2);
            Assert.AreNotEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenQuestionId_WhenItIsValid_ThenDisplayCorrectQuestion()
        {
            QuestionRepository m = new QuestionRepository();
            string Actual = "Do you want a monitor with cable or cableless?";
            string expected = m.DataFetch(2);
            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenQuestionIdAndOptionId_WhenItIsValid_ThenReturnNextQuestionId()
        {
            OptionsRepository m = new OptionsRepository();
            int Actual = 13;
            int expected = m.datafetch(12, 1);
            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenQuestionIdAndOptionId_WhenItIsNotValid_ThenShouldNotReturnNextQuestionId()
        {
            OptionsRepository m = new OptionsRepository();
            int Actual = 3;
            int expected = m.datafetch(12, 1);
            Assert.AreNotEqual(Actual, expected);
        }


        [TestMethod]
        public void GivenQuestionIdAndOptionId_WhenItIsValid_ThenReturnCorrespondingMonitorId()
        {
            OptionsRepository m = new OptionsRepository();
            int Actual = 19;
            int expected = m.datafetch2(12, 5);
            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenQuestionIdAndOptionId_WhenItIsNotValid_ThenShouldNotReturnCorrespondingMonitorId()
        {
            OptionsRepository m = new OptionsRepository();
            int Actual = 1;
            int expected = m.datafetch2(12, 5);
            Assert.AreNotEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenQuestionIdAndOptionId_WhenItIsValid_ThenReturnCorrespondingMonitorId2()
        {
            OptionsRepository m = new OptionsRepository();
            int Actual = 10;
            int expected = m.datafetch2(11, 3);
            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void GivenQuestionIdAndOptionId_WhenItIsValid_ThenReturnCorrespondingNextQuestionId()
        {
            OptionsRepository m = new OptionsRepository();
            int Actual = 13;
            int expected = m.datafetch(12, 2);
            Assert.AreNotEqual(Actual, expected);
        }


        [TestMethod]
        public void GivenQuestionId_WhenItIsValid_ThenDisplayCorrectQuestion2()
        {
            QuestionRepository m = new QuestionRepository();
            string Actual = "Select one of the required features from the following options.";
            string expected = m.DataFetch(14);
            Assert.AreEqual(Actual, expected);
        }

    }
}
