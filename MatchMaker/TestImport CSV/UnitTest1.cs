using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMatchMaker
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Student_Create_Success()
        {
            //given
            //declare a student type object
            Student testStudent;

            //then
            //Grab object
            testStudent = new Student();

            //when
            //Compare the object student values with parameters passed in builder
        }
    }
}
