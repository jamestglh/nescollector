using NesCollector.Data.Context;
using NesCollector.Data.ScheduledTasks.Scheduling;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesCollector.Data.ScheduledTasks
{
    public class PriceUpdaterTask : IScheduledTask
    {
        public string Schedule => "* */6 * * *";

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            using (var db = new NesCollectorDBContext())
            {
                WebClient client = new WebClient();
                foreach (var g in db.Games)
                {
                    int apiGameId = g.ApiGameId;
                    string apiToken = "b2e9fc7e71959fabc1a1074bc64b5c645d292b6e";
                    string url = $"https://www.pricecharting.com/api/product?t={apiToken}&id={apiGameId}";
                    string downloadString = client.DownloadString(url);
                    string[] downloadStrings = downloadString.Split(',');

                    foreach (var x in downloadStrings)
                    {
                        if (x.Contains("cib-price"))
                        {
                            double cibPrice = double.Parse(x.Split(':')[1]) / 100;
                            g.CibPrice = cibPrice;
                        }
                        if (x.Contains("loose-price"))
                        {
                            double loosePrice = double.Parse(x.Split(':')[1]) / 100;
                            g.LoosePrice = loosePrice;
                        }
                    }
                }
                db.SaveChanges();
            }
            await Task.Delay(5000, cancellationToken);
        }
    }
}
