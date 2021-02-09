using ModelsLibrary.Models;
using ModelsLibrary.Utilities;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Link.XUnit
{
    public class UserProcessorTests
    {
        IDataAccess _dataAccess;
        public UserProcessorTests(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [Fact]
        public void LogInTest()
        {
            Mock<IDataAccess> mock = new Mock<IDataAccess>();
            mock.Setup(x => x.LoadData<User>("SELECT * FROM users WHERE Username = @Username AND Password = @Password"))
                .Returns(GetSampleUsers());

            User user = new User(mock.Object);
           /* bool login = user.LogIn(user.UserNAme,user.Password);*/
           

        }

        private List<User> GetSampleUsers()
        {
            List<User> output = new List<User>();
            User user1 = new User();
            user1.UserNAme = "osa";
            user1.Password = "elh";

            output.Add(user1);

            return output;
        }

    }
}
