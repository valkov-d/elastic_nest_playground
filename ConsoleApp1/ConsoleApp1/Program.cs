using ConsoleApp1.Models;
using Elasticsearch.Net;
using Nest;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        private static readonly string _elasticAddress = "http://192.168.88.128:9200";
        private static readonly string _defaultIndex = "kibana_sample_data_ecommerce";
        //private static readonly string _keepAlive = "180s";
        //private static readonly int _size = 1000;
        public static async Task Main()
        {
            var connectionSettings = new ConnectionSettings(new Uri(_elasticAddress))
                .DefaultIndex(_defaultIndex);
            var client = new ElasticClient(connectionSettings).LowLevel;

            var response = await client.DoRequestAsync<SearchResponse<Order>>(
                Elasticsearch.Net.HttpMethod.GET,
                $"{_defaultIndex}/_search",
                CancellationToken.None,
                @"{
                ""query"": {
                    ""match_all"": { }
                }
            }");

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        //private static async Task UseSearchAfterAsync()
        //{
        //    var connectionSettings = new ConnectionSettings(new Uri(_elasticAddress))
        //        .DefaultIndex(_defaultIndex);
        //    var client = new ElasticClient(connectionSettings);

        //    var pitResponse = await client.OpenPointInTimeAsync(_defaultIndex, p => p.KeepAlive(_keepAlive));
        //    if (pitResponse.IsValid)
        //    {
        //        var response = await client.SearchAsync<Order>(s =>
        //            s.Size(_size)
        //             .Query(q => q.MatchAll())
        //             .PointInTime(pitResponse.Id)
        //             .Sort(s => s.Descending(f => f.Id)));

        //        while (response.Documents.Any())
        //        {
        //            var lastHit = response.Hits.Last();

        //            response = await client.SearchAsync<Order>(s =>
        //                s.Size(_size)
        //                 .Query(q => q.MatchAll())
        //                 .PointInTime(pitResponse.Id)
        //                 .Sort(s => s.Descending(f => f.Id))
        //                 .SearchAfter(lastHit.Sorts));
        //        }

        //        var closeResponse = await client.ClosePointInTimeAsync(p => p.Id(pitResponse.Id));
        //    }
        //}

        //private static async Task UseScrollAsync()
        //{
        //    var connectionSettings = new ConnectionSettings(new Uri(_elasticAddress))
        //        .DefaultIndex(_defaultIndex);
        //    var client = new ElasticClient(connectionSettings);

        //    var response = await client.SearchAsync<Order>(s =>
        //        s.Size(_size)
        //         .Query(q => q.MatchAll())
        //         //.Sort(s => s.Descending(f => f.Id))
        //         .Scroll(_keepAlive));

        //    if (response.IsValid)
        //    {
        //        while (response.Documents.Any())
        //        {
        //            response = client.Scroll<Order>(_keepAlive, response.ScrollId);
        //        }
        //    }
        //}
    }
}