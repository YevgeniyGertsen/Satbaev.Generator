using LiteDB;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbaev.Generator
{
    internal class Repository
    {
        public bool CrateQuetion(QuestionTemplate Qute)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"C:\Temp\SatbaevGen.db"))
                {
                    var result = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    result.Insert(Qute);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateQuestion(QuestionTemplate questionTemplate)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"C:\Temp\SatbaevGen.db"))
                {
                    var result = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    result.Update(questionTemplate);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteQuestion(int id)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"C:\Temp\SatbaevGen.db"))
                {
                    var result = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    result.Delete(id);
                }
                return true;

            }
            catch { return false; }
        }
        public List<QuestionTemplate> GetAllQuestion()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"C:\Temp\SatbaevGen.db"))
                {
                    var result = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    return result.FindAll().ToList();
                }

            }
            catch (Exception) { return null; }

        }
    }


}
