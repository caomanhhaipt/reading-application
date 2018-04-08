using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Controller
{
    public class Search
    {
        private int Chapter;
        private ArrayList ArrayIndex;
        private int Len;
        private ArrayList ArrayLen;
        private int CountLine;

        public Search(int Chapter, int Len)
        {
            this.Chapter = Chapter;
            this.ArrayIndex = new ArrayList();
            this.ArrayLen = new ArrayList();
            this.Len = Len;
        }

        public int CHAPTER
        {
            get { return Chapter; }
            set { Chapter = value; }
        }

        public int COUNTLINE
        {
            get { return CountLine; }
            set { CountLine = value; }
        }

        public int LEN
        {
            get { return Len; }
            set { Len = value; }
        }

        public ArrayList ARRAYINDEX
        {
            get { return ArrayIndex; }
            set { ArrayIndex = value; }
        }

        public ArrayList ARRAYLEN
        {
            get { return ArrayLen; }
            set { ArrayLen = value; }
        }

        public static Search isSearch(string input, string chapter, int numberChapter)
        {
            Search search = new Search(-1, -1);
            Regex splitChapter = new Regex("(\\w|(\\!\\.)|\\040|\\t|\\f|\\v|" + "\\" + "\"" + "|\\“|\\”|\\„|\\,|\\-|\\.{3}|\\.{2}|(\\* ){1}|(\\?\\.){1}){1,}(\\W|\\z)(\\n{0,1})");
            Regex splitInput = new Regex("\\w{1,}(\\s|\\W|\\z)");
            Regex formatInput = new Regex("\\w{1,}");

            int count = splitInput.Matches(input).Count;
            string[] str = new string[count];

            int index = 0;

            foreach (Match item in splitInput.Matches(input))
            {
                foreach (Match item2 in formatInput.Matches(item.ToString()))
                {
                    str[index] = item2.ToString().ToUpper();
                }
                index++;
            }

            String tmp = "(";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 1)
                {
                    tmp += str[i].ToUpper();
                }
                else
                {
                    tmp += str[i].ToUpper() + "|";
                }
            }
            tmp += ")";

            Regex correct = new Regex(tmp);

            int len = 0;
            int countLine = 0;
            int odd = 0;
            string title = "";
            bool checkNewLine = false;
            foreach (Match item in splitChapter.Matches(chapter))
            {
                if (len == 0)
                {
                    title = item.ToString();
                }

                if (item.ToString()[0] == '\t') 
                {
                    if (!item.ToString().Contains("\n\n"))
                    {
                        checkNewLine = true;
                    }
                    else
                    {
                        checkNewLine = false;
                    }
                }
                else
                {
                    if (checkNewLine == true)
                    {
                        len += 1;
                    }
                    checkNewLine = false;
                }

                bool check = true;
                for (int i = 0; i < str.Length; i++)
                {
                    if (!item.ToString().ToUpper().Contains("" + str[i].ToUpper()))
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    MessageBox.Show("Chapter " + (numberChapter + 1) + ": " + title + "\n" + item.ToString());
                    search = new Search(numberChapter, len);
                    foreach (Match item2 in correct.Matches(item.ToString().ToUpper()))
                    {
                        search.ArrayIndex.Add(item2.Index);
                        search.ArrayLen.Add(item2.Length);
                    }

                    if(odd != 0)
                    {
                        countLine += 1;
                    }

                    search.CountLine = countLine;

                    break;
                }

                //Count length
                if (item.ToString().Contains("\n") && !item.ToString().Contains("\n\n") && !item.ToString().Contains("\t"))
                {
                    len += item.ToString().Length + 1;
                }
                else
                {
                    len += item.ToString().Length;
                }

                if (item.ToString().Equals("* *\n"))
                {
                    len += 3;
                }

                //Count Line
                if (item.ToString().Contains("\n"))
                {
                    if(item.ToString().Length / 125 >= 1)
                    {
                        if (item.ToString().Length % 125 == 0)
                        {
                            countLine += item.ToString().Length / 125 + 1;
                        }
                        else
                        {
                            countLine += item.ToString().Length / 125 + 2;
                        }
                    }
                    else
                    {
                        countLine += 2;
                    }

                    if (item.ToString().Contains("\t"))
                    {
                        countLine -= 1;
                    }
                    odd = 0;
                }
                else
                {
                    if(item.ToString().Length / 125 >= 1)
                    {
                        if (item.ToString().Length % 125 == 0)
                        {
                            countLine += item.ToString().Length / 125 + 1;
                        }
                        else
                        {
                            countLine += item.ToString().Length / 125 + 2;
                            odd += item.ToString().Length % 125;
                        }
                        
                    }
                    else
                    {
                        odd += item.ToString().Length;
                    }
                }

                if(odd / 125 >= 1)
                {
                    countLine += odd / 125;
                    odd = odd % 125;
                }
            }

            return search;
        }
    }
}
