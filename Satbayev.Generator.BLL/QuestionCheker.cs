using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbaev.Generator;

namespace Satbayev.Generator.BLL
{
    public class QuestionCheker
    {
        public string AddQuestions(QuestionTemplate question) 
        {
            Repository repository = new Repository();

           bool result = repository.CrateQuetion(question);
           if (result == true) 
            {
                return "Вопрос удачно создан!";
            }
           else 
            {
                return "Не получилось!";
            }
        }
        public List<QuestionTemplate> GetQuestions(int categoryId) 
        {
            Repository repository = new Repository();
            List<QuestionTemplate> result = repository.GetAllQuestion();

            return result;
        }
    }
}
