using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArkEcosystem.Client.Tests.API.One
{
    [TestClass]
    public class AccountsTest
    {
        [TestMethod]
        public void All()
        {
            Helpers.MockHttpRequest("accounts/getAllAccounts");

            var response = Helpers.MockConnection(1).Accounts().All();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task AllAsync()
        {
            Helpers.MockHttpRequest("accounts/getAllAccounts");

            var response = await Helpers.MockConnection(1).Accounts().AllAsync();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void Show()
        {
            Helpers.MockHttpRequest("accounts");

            var response = Helpers.MockConnection(1).Accounts().Show("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task ShowAsync()
        {
            Helpers.MockHttpRequest("accounts");

            var response = await Helpers.MockConnection(1).Accounts().ShowAsync("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void Count()
        {
            Helpers.MockHttpRequest("accounts/count");

            var response = Helpers.MockConnection(1).Accounts().Count();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task CountAsync()
        {
            Helpers.MockHttpRequest("accounts/count");

            var response = await Helpers.MockConnection(1).Accounts().CountAsync();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void Delegates()
        {
            Helpers.MockHttpRequest("accounts/delegates");

            var response = Helpers.MockConnection(1).Accounts().Delegates("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task DelegatesAsync()
        {
            Helpers.MockHttpRequest("accounts/delegates");

            var response = await Helpers.MockConnection(1).Accounts().DelegatesAsync("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void Fee()
        {
            Helpers.MockHttpRequest("accounts/delegates/fee");

            var response = Helpers.MockConnection(1).Accounts().Fee();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task FeeAsync()
        {
            Helpers.MockHttpRequest("accounts/delegates/fee");

            var response = await Helpers.MockConnection(1).Accounts().FeeAsync();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void Balance()
        {
            Helpers.MockHttpRequest("accounts/getBalance");

            var response = Helpers.MockConnection(1).Accounts().Balance("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task BalanceAsync()
        {
            Helpers.MockHttpRequest("accounts/getBalance");

            var response = await Helpers.MockConnection(1).Accounts().BalanceAsync("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void PublicKey()
        {
            Helpers.MockHttpRequest("accounts/getPublicKey");

            var response = Helpers.MockConnection(1).Accounts().PublicKey("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task PublicKeyAsync()
        {
            Helpers.MockHttpRequest("accounts/getPublicKey");

            var response = await Helpers.MockConnection(1).Accounts().PublicKeyAsync("dummy");

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public void Top()
        {
            Helpers.MockHttpRequest("accounts/top");

            var response = Helpers.MockConnection(1).Accounts().Top();

            Helpers.AssertSuccessResponse(response);
        }

        [TestMethod]
        public async Task TopAsync()
        {
            Helpers.MockHttpRequest("accounts/top");

            var response = await Helpers.MockConnection(1).Accounts().TopAsync();

            Helpers.AssertSuccessResponse(response);
        }
    }
}