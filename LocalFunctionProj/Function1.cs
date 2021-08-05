using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace LocalFunctionProj
{
    public static class Function1
    {
        [Function("Function1")]
        public static void Run([ServiceBusTrigger("responsedataproviderqueueid", Connection = "connectionString")] string myQueueItem, FunctionContext context)
        {
            var logger = context.GetLogger("Function1");
            logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
