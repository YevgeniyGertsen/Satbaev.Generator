using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbaev.Generator;
using Satbayev.Generator.BLL;

namespace Satbayev.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuestionCheker questionCheker = new QuestionCheker();

            QuestionTemplate question = new QuestionTemplate();
            question.HardMark = 5;
            question.Mark = 7;
            question.CreateDate = DateTime.Now;

            Category category = new Category();
            category.Name = "C#";
            category.CreateData = DateTime.Now;
            question.Category = category;
            question.Question = "???";


            string result = questionCheker.AddQuestions(question);
            Console.WriteLine(result);

            List<QuestionTemplate> result1 = questionCheker.GetQuestions(1);
            foreach (QuestionTemplate item in result1)
            {
                Console.WriteLine(item.Question);                
            }
        }
    }
}
