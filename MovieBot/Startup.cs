using Microsoft.Owin;
using Owin;
using System.IO;
using Newtonsoft.Json;
using MovieBot.Models;
using System.Collections.Generic;
using System.Web;

[assembly: OwinStartupAttribute(typeof(MovieBot.Startup))]
namespace MovieBot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //string currentDir = Directory.GetCurrentDirectory();
            //DirectoryInfo dir = new DirectoryInfo(currentDir);
            ////var fileName = Path.Combine(dir.FullName, "jsonQuotesArray.json");
            //var fileName = HttpContext.Current.Server.MapPath("/") + "\\jsonQuotesArray.json";


            //var pairs = DeserializePairs(fileName);

            //using (var context = new Context())
            //{
            //    foreach (var pair in pairs)
            //    {
            //        context.QuestionAnswerPairs.Add(pair);
            //    }

            //    context.SaveChanges();
            //}



        }

        //public static List<QuestionAnswerPair> DeserializePairs(string fileName)
        //{
        //    var pairs = new List<QuestionAnswerPair>();
        //    var serializer = new JsonSerializer();
        //    using (var reader = new StreamReader(fileName))
        //    using (var jsonReader = new JsonTextReader(reader))
        //    {
        //        pairs = serializer.Deserialize<List<QuestionAnswerPair>>(jsonReader);
        //    }

        //    return pairs;
        //}
    }
}
