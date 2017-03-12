using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace MovieBot
{
    public class QuestionAnswerPair
    {
        public int Id { get; set; }

        [JsonProperty(PropertyName = "question")]
        public string Question { get; set; }

        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }

        public bool Contain(string question)
        {
            question = question.Replace("?", string.Empty);

            string[] questionArr = question.Split(' ');


            int questLength = questionArr.Count();

            int questCount = 0;

            for (var i = 0; i < questionArr.Count(); i++)
            {
                if (Question.Contains(questionArr[i].ToUpper()) || Question.Contains(questionArr[i].ToLower()))
                {
                    questCount += 1;
                }
            }

            if (questCount >= (questLength - 1))
            {
                return true;
            }

            return false;
        }


    }
}