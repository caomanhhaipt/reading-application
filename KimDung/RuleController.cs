using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using Model;

namespace Controller
{

    class RuleController
    {
        private ArrayList ArrayContent;
        private ArrayList ContainError;
        private int Chapter;

        public RuleController(int Chapter)
        {
            this.Chapter = Chapter;
            this.ArrayContent = new ArrayList();
            this.ContainError = new ArrayList();
        }

        public int CHAPTER
        {
            get { return Chapter; }
            set { Chapter = value; }
        }

        public ArrayList ARRAYCONTENT
        {
            get { return ArrayContent; }
            set { ArrayContent = value; }
        }

        public ArrayList CONTAINERROR
        {
            get { return ContainError; }
            set { ContainError = value; }
        }

        public static RuleController IsError(string Content, int Chapter)
        {
            RuleController ruleController = new RuleController(-1);

            Rule[] allRules = new Rule[]{new Rule1(), new Rule2(), new Rule3(), new Rule4(),
            new Rule5(), new Rule6(), new Rule7(), new Rule8(), new Rule9(), new Rule10()};

            Regex splitChapter = new Regex("(\\w|\\040|\\t|\\f|\\v|" + "\\" + "\"" + "|\\“|\\”|\\„|\\,|\\-){1,}(\\W|\\z)");
            Regex splitWord = new Regex("\\“{0,}(\\w{1,}|\\.{3}|\\.{2})\\”{0,}(\\s{1,}|(\\W\\s{0,})|\\z)");

            foreach (Match item in splitChapter.Matches(Content))
            {
                foreach (Match item2 in splitWord.Matches(item.ToString()))
                {
                    if (Rule.IsWord(item2.ToString()))
                    {
                        bool mark = false;
                        Error error = new Error();
                        for (int i = 0; i < allRules.Length; i++)
                        {
                            if (allRules[i].IsValid(item2.ToString()))
                            {
                                if(mark == false)
                                {
                                    ruleController.ARRAYCONTENT.Add(item.ToString());
                                    mark = true;
                                }
                                error.ARRAYINDEX.Add(item2.Index);
                                error.ARRAYLEN.Add(item2.ToString().Length);
                                break;
                            }
                        }

                        if(mark == true)
                        {
                            if(ruleController.CHAPTER == -1)
                            {
                                ruleController.CHAPTER = Chapter;
                            }
                            ruleController.ContainError.Add(error);
                        }
                    }
                }
            }
            return ruleController;
        }
    }
}
