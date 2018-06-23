using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Kata;

namespace DLinkedListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddValueToTheList()
        {
            DLinkedList DL = new  DLinkedList();

            DL.Add("Amigo");
            DL.Add("Hermano");

            Assert.AreEqual("Hermano", DL.Tail.Value);

        }

        [TestMethod]
        public void FindNodeInTheList()
        {
            DLinkedList DL = new DLinkedList();

            DL.Add("Amigo");
            DL.Add("Hermano");
            
            Assert.AreEqual("Hermano", DL.FindNode("Hermano"));
        }

        [TestMethod]
        public void DeleteANodeInAListWith1Node()
        {
            DLinkedList DL = new DLinkedList();

            DL.Add("Hermano");

            DL.Delete("Hermano");

            Assert.AreNotEqual("Hermano", DL.FindNode("Hermano"));
        }

        [TestMethod]
        public void DeleteANoExistingNode()
        {
            DLinkedList DL = new DLinkedList();

            DL.Add("Hermano");

            DL.Delete("Primo");
            
            Assert.AreNotEqual("Primo", DL.FindNode("Primo"));
        }

        [TestMethod]
        public void GeneralDelete()
        {
            DLinkedList DL = new DLinkedList();

            DL.Add("Hermano");
            DL.Add("Amigo");

            DL.Delete("Hermano");

            Assert.AreNotEqual("Hermano", DL.FindNode("Hermano"));
        }

        [TestMethod]
        public void ShowValues()
        {
            DLinkedList DL = new DLinkedList();

            DL.Add("Hermano");
            DL.Add("Amigo");

            Assert.AreEqual("(Hermano, Amigo)", DL.ToString());
        }

        [TestMethod]
        public void PreprendTwoListWhenSecondIsEmpty()
        {
            DLinkedList DL = new DLinkedList();
            DLinkedList DL2 = new DLinkedList();

            DL.Add("Hermano");
            DL.Add("Amigo");


            DL.Preprend(DL2);

            Assert.AreEqual("(Hermano, Amigo)", DL.ToString());
        }

        [TestMethod]
        public void PreprendTwoListWhenFirstIsEmpty()
        {
            DLinkedList DL = new DLinkedList();
            DLinkedList DL2 = new DLinkedList();

           
            DL2.Add("Jesus");

            DL2.Preprend(DL);

            Assert.AreEqual("(Jesus)", DL2.ToString());
        }

        [TestMethod]
        public void PreprendTwoList()
        {
            DLinkedList DL = new DLinkedList();
            DLinkedList DL2 = new DLinkedList();

            DL.Add("Hermano");
            DL.Add("Amigo");
            DL2.Add("Jesus");

            DL.Preprend(DL2);

            Assert.AreEqual("(Jesus, Hermano, Amigo)", DL.ToString());
        }

        [TestMethod]
        public void PreprendTwoEmptyList()
        {
            DLinkedList DL = new DLinkedList();
            DLinkedList DL2 = new DLinkedList();

            DL.Preprend(DL2);

            Assert.AreEqual("()", DL.ToString());
        }



    }
}
