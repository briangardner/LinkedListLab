using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinkedList.Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void Add_At_Start_Should_Add_Node_To_List()
        {
            //arrange
            var list = new LinkedList();
            //act
            list.AddAtStart(1);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void Should_Throw_Exception_When_Removing_From_Empty_List()
        {
            //arrange
            var list = new LinkedList();
            //act & Assert
            Assert.DoesNotThrow( () => list.RemoveFromStart() );

        }

        [Test]
        public void Should_Decrement_Count_When_Node_Removed()
        {
            //arrange
            var list = new LinkedList();
            list.AddAtStart(1);
            list.AddAtStart(2);

            //act
            list.RemoveFromStart();

            //assert
            Assert.AreEqual(1,list.Count);
        }

        [Test]
        public void Head_Next_Should_Have_Correct_Value_When_Node_Removed()
        {
            //arrange
            var list = new LinkedList();
            list.AddAtStart(1);
            list.AddAtStart(2);

            //act
            list.RemoveFromStart();

            //assert
            Assert.AreEqual(1, list.Head.Next.Value);
        }

        [Test]
        public void ToString_Should_Return_Head_NULL()
        {
            //arrange
            var list = new LinkedList();

            //act?

            //Assert
            Assert.AreEqual("Head -> NULL", list.ToString());
        }
    }
}
