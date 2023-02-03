using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace netfunc
{
    public static class http23
    {
[FunctionName("TimerTriggerCSharp")]
public static void Run([TimerTrigger("0 */2 * * * *", UseMonitor=false)]TimerInfo myTimer, ILogger log)
{
    if (myTimer.IsPastDue)
    {
        log.LogInformation("Timer is running late!");
    }
    Thread.Sleep(180000);
    log.LogInformation(myTimer.ScheduleStatus.Next);
    log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
}
    }
}
