using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathoschild.Http.Client;
using Sol_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sol_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task PostApiTestMethod()
        {
            var userModelObj = new UserModel()
            {
                FirstName = "Kishor",
                LastName = "Naik"
            };

            IClient client = new FluentClient("http://localhost:49506/api/users");

            // Post Work
            //var data =
            //        await
            //            client
            //            .PostAsync<UserModel>("postdemo", userModelObj)
            //            .As<UserModel>();

            //// Post Array Work
            //var data =
            //        await
            //            client
            //            .PostAsync("postdemoarray")
            //            .As<List<UserModel>>();

            var data =
                    await
                        client
                        .GetAsync("getdemo/11")
                        .As<int>();

            Assert.IsNotNull(data);
        }
    }
}