using GRPC.Protos;
using Grpc.Core;
using System.Threading.Tasks;

namespace GRPC.Services
{
    public class HelloService : Protos.HelloService.HelloServiceBase
    {
        public override Task<HelloResponse> Hello(HelloRequest request, ServerCallContext context)
        {
            var nome = request.Nome;
            var response = new HelloResponse() { Msg = $"Hello {nome}" };
            return Task.FromResult(response);
        }
    }
}
