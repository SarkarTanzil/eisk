﻿/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Architecture Designed and Implemented By:
Mohammad Ashraful Alam
Microsoft Most Valuable Professional, ASP.NET 2007 – 2011
Twitter: http://twitter.com/AshrafulAlam | Blog: http://blog.ashraful.net | Portfolio: http://www.ashraful.net
   
*******************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eisk.BusinessEntities;

namespace Eisk.Tests.UnitTests.PositiveTests
{
    [TestClass]
    public class Employee_Property_GetSet_Tests
    {
        [TestMethod]
        public void FirstName_ValidValueAssigned_ShouldGetSameValue()
        {
            //Arrange
            Employee employee = new Employee();
            const string EXPECTED_FIRST_NAME = "Ashraf";

            //Act
            employee.FirstName = EXPECTED_FIRST_NAME;
            
            //Assert
            string ACTUAL_FIRST_NAME = employee.FirstName;
            Assert.AreEqual(EXPECTED_FIRST_NAME, ACTUAL_FIRST_NAME, "First name has not been properly set.");
        }
    }
}
