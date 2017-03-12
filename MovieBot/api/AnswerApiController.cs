using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieBot.Models;

namespace MovieBot.Controllers
{
    public class AnswerApiController : ApiController
    {

        private readonly ApplicationDbContext _context;

        public AnswerApiController()
        {
            _context = new ApplicationDbContext();
        }


        //this action was just for testing
        [HttpGet]
        public QuestionAnswerPair TheAnswer()
        {
            var qa = _context.QuestionAnswerPairs.SingleOrDefault(q => q.Id == 1);
            return qa;
        }


        [HttpGet]
        public string GetAnswer(string question)
        {


            question = question.Trim();


            var questionLower = question.ToLower();

            try
            {
                Random rnd = new Random();

                //List<QuestionAnswerPair> answers = new List<QuestionAnswerPair>();

                var answers = _context.QuestionAnswerPairs.Where(qa => qa.Question.Contains(question)).ToList();



                int r = rnd.Next(answers.Count);
                //[0].Answer;
                var answer = answers[r].Answer;

                if (answer.IndexOf("\n\n") > -1)
                {
                    return (answer.Substring(0, answer.IndexOf("\n\n")));
                }

                else if (answer == "\n")
                {
                    return (answers[r + 1].Answer);
                }

                else if (answer.Trim() == "")
                {
                    return (answers[r + 1].Answer);
                }
                else
                {
                    return (answer);
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                return ("I'm not sure what you're asking");
            }
        }   
    }
}
