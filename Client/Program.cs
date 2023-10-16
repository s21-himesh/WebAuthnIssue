using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json.Serialization.Metadata;
using WebAuthnIssue.Client;
using System.Text.Json.Serialization;
using Fido2NetLib;

namespace WebAuthnIssue.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }

    [JsonSerializable(typeof(AssertionOptions))]
    [JsonSerializable(typeof(AuthenticatorAssertionRawResponse))]
    [JsonSerializable(typeof(AuthenticatorAttestationRawResponse))]
    [JsonSerializable(typeof(CredentialCreateOptions))]
    public partial class FidoBlazorSerializerContext : JsonSerializerContext
    {
    }


}