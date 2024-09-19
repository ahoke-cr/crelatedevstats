using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace Crelate.PullRequestStats;

public class PullRequestLeaderboardFunction
{
	[FunctionName("PullRequestLeaderboardFunction")]
	public void Run([TimerTrigger("0 0 1 * * Mon")]TimerInfo myTimer, ILogger log)
	{
		log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
	}
}