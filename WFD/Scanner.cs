using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFD
{
    public class SNL_info
    {
        public char c;
        public int row;
    }

    public class Token
    {
        public enum Tex
        {
            //薄记单词符号
            ENDFILE, ERROR,
            //保留字
            PROGRAM, PROCEDURE, TYPE, VAR, IF, THEN, ELSE, FI,
            WHILE, DO, ENDWH, BEGIN1, END1, READ, WRITE, ARRAY, OF,
            RECORD, RETURN1,
            //类型
            INTEGER, CHAR1,
            //多字符单词符号
            ID, INTC, CHARC,
            //特殊符号
            ASSIGN, EQ, LT, PLUS, MINUS, TIMES, OVER, LPAREN, RPAPEN, DOT, COLON,
            SEMI, COMMA, LMIDPAREN, RMIDPAREN, UNDERANGE
        };

        public Token(int row, Tex a, string str, int n)  //构造函数,待识别完单词后调用
        {

            this.row = row;
            this.tex = a;
            content = str;
            content_num = n;
        }
        public int row;
        public Tex tex;
        public string content;
        public int content_num;

    }

    public class Scanner
    {
        public enum State
        {
            START, INASSIGN, INCOMMENT, INNUM, INID, INCHAR, INRANGE, DONE, ERR
        }
        public List<Token> token_list;
        private State state;
        private string source;
        private int next_num, current_num, former_num;
        private char current, next, former;
        private List<string> read_from;
        private int row, current_row, former_row;//当前读到哪一行
        private Dictionary<string, Token.Tex> reserved;
        private StringBuilder result;
        private Token add_token;
        private Token.Tex tem;
        public List<string> error_row;
        Dictionary<int, SNL_info> snl_info;
        private List<char> D = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private List<char> L = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','A','B','C','D','E','F','G','H','I','J','K','L',
            'M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        private List<char> Done = new List<char> { '+', '-', '*', '/', '(', ')', ';', '[', ']', '=', '<', ' ', ',', '\t', '\n', '\r' }; //EOF


        public Scanner()
        {
            token_list = new List<Token>();  //token_list就是最后生成的Token序列
            error_row = new List<string>();
            snl_info = new Dictionary<int, SNL_info>();
            state = State.START;
            next_num = 0;
            former_num = -2;
            current_num = -1;
            former = current = next = ' ';
            result = new StringBuilder();
            row = current_row = former_row = 1;
            read_from = new List<string>();
            reserved = new Dictionary<string, Token.Tex>()
                {
                    { "program",Token.Tex.PROGRAM},{ "procedure",Token.Tex.PROCEDURE},{"type" ,Token.Tex.TYPE},
                    { "var",Token.Tex.VAR },{ "if",Token.Tex.IF},{ "then",Token.Tex.THEN},{ "else",Token.Tex.ELSE},
                    { "fi",Token.Tex.FI},{ "while",Token.Tex.WHILE},{ "do",Token.Tex.DO},{ "endwh",Token.Tex.ENDWH},

                    { "begin",Token.Tex.BEGIN1},{ "end",Token.Tex.END1},{ "read",Token.Tex.READ},{ "write",Token.Tex.WRITE},

                    { "array",Token.Tex.ARRAY},{"of",Token.Tex.OF},{"record", Token.Tex.RECORD},{"return",Token.Tex.RETURN1},

                    {"integer",Token.Tex.INTEGER},{"char",Token.Tex.CHAR1}

                };
        }

        public void read_from_source(string wanted)
        {
            source = wanted;
            read_from = source.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();
        }

        private void create_SNL_info()
        {
            int line = read_from.Count();
            int numc = 0;
            int reg = 0;
            for (int i = 0; i < line; i++)
            {
                numc = read_from[i].Length;
                for (int j = 0; j < numc; j++)
                {
                    SNL_info one_char = new SNL_info();
                    one_char.c = read_from.ElementAt(i).ElementAt(j);
                    one_char.row = i;
                    snl_info.Add(reg, one_char);
                    reg++;
                }
            }
            SNL_info last_char = new SNL_info();
            last_char.c = '#';
            last_char.row = 0;
            snl_info.Add(reg, last_char);
        }

        public void init()
        {
            token_list.Clear();  //token_list就是最后生成的Token序列
            error_row.Clear();
            snl_info.Clear();
            state = State.START;
            next_num = 0;
            former_num = -2;
            current_num = -1;
            former = current = next = ' ';
            source = null;
            result.Clear();
            row = current_row = former_row = 1;
        }

        private int getNextChar()   //结束
        {
            if (next_num >= 0 && next_num < snl_info.Count())
            {
                next = snl_info[next_num].c;
                row = snl_info[next_num].row;
                next_num++;
            }
            if (current_num >= 0 && current_num < snl_info.Count())
            {
                current = snl_info[current_num].c;
                current_row = snl_info[current_num].row;
                current_num++;
            }
            else
            {
                if (current_num < 0)
                    current_num++;
                else
                    return -1;
            }
            if (former_num >= 0 && former_num < snl_info.Count())
            {
                former = snl_info[former_num].c;
                former_row = snl_info[former_num].row;
                former_num++;
            }
            else
            {
                if (former_num < 0)
                    former_num++;
                else
                    return -1;
            }
            return 1;
        }

        private int UngetNextChar()
        {
            if (current_num > 0)
            {
                next_num -= 1;
                current_num -= 1;
                former_num -= 1;
            }
            else
                return -1;
            return 1;
        }

        public int ChainToFile(string path)
        {
            const string FILE_NAME = "name.txt";//设置文件名称
            string strFileName = Path.Combine(path, FILE_NAME);//创建文件在指定位置

            if (File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} already exists!", strFileName);
                Console.ReadLine();
                return -1;
            }
            FileInfo myFile = new FileInfo(strFileName);//创建文件
                                                        //用Creat方法创建文件，返回一个FileStr对象
            StreamWriter w = myFile.CreateText();

            w.WriteLine("       词法分析后的TOKEN序列       ");
            w.WriteLine("行数        词法信息        语义信息    ");

            for (int i = 0; i < token_list.Count; i++)//将链表写入文件
            {
                //ss.Count();

                w.Write(token_list.ElementAt(i).row.ToString());//向文件中写入
                w.Write("              ");
                w.Write(token_list.ElementAt(i).tex.ToString());
                w.Write("              ");
                w.Write(token_list.ElementAt(i).content.ToString());
                w.Write("              ");
                w.Write(token_list.ElementAt(i).content_num.ToString());
                w.WriteLine("   ");

            }
            w.Flush();
            w.Close();
            return 1;
        }

        private void DFA()
        {
            switch (state)
            {
                case State.INID:
                    {
                        if (L.Contains(current) || D.Contains(current))
                        {

                            if (current_row != former_row)
                            {
                                state = State.START;
                                if (ReservedLookUP(result.ToString()) == Token.Tex.ID)
                                    add_token = new Token(former_row, Token.Tex.ID, result.ToString(), 0);
                                else
                                    add_token = new Token(former_row, ReservedLookUP(result.ToString()), result.ToString(), 0);
                                token_list.Add(add_token);
                                state = State.START;
                                result.Clear();
                                UngetNextChar();
                                break;
                            }
                            else
                            {
                                result.Append(current);
                            }
                        }
                        else
                        {
                            if (current_row!=former_row)
                            {
                                state = State.START;
                                UngetNextChar();
                                if (ReservedLookUP(result.ToString()) == Token.Tex.ID)
                                    add_token = new Token(current_row, Token.Tex.ID, result.ToString(), 0);
                                else
                                    add_token = new Token(current_row, ReservedLookUP(result.ToString()), result.ToString(), 0);
                                token_list.Add(add_token);
                                result.Clear();
                                break;

                            }
                            if (Done.Contains(current) || current == ':' || current == '.')
                            {
                                state = State.START;
                                UngetNextChar();
                                if (ReservedLookUP(result.ToString()) == Token.Tex.ID)
                                    add_token = new Token(current_row, Token.Tex.ID, result.ToString(), 0);
                                else
                                    add_token = new Token(current_row, ReservedLookUP(result.ToString()), result.ToString(), 0);
                                token_list.Add(add_token);
                                result.Clear();
                                break;
                            }
                            else
                            {
                                state = State.ERR;
                                if (ReservedLookUP(result.ToString()) == Token.Tex.ID)
                                    add_token = new Token(current_row, Token.Tex.ID, result.ToString(), 0);
                                else
                                    add_token = new Token(current_row, ReservedLookUP(result.ToString()), result.ToString(), 0);
                                token_list.Add(add_token);
                                result.Clear();
                                break;
                            }


                        }
                        /*
                        if (row != current_row)
                        {
                            if (ReservedLookUP(result.ToString()) == Token.Tex.ID)
                                add_token = new Token(current_row, Token.Tex.ID, result.ToString(), 0);
                            else
                                add_token = new Token(current_row, ReservedLookUP(result.ToString()), result.ToString(), 0);
                            token_list.Add(add_token);
                            state = State.START;
                            result.Clear();
                        }*/
                        break;
                    }
                case State.INASSIGN:
                    {
                        if (current == '=')   //如果:=拐弯怎么办
                        {
                            add_token = new Token(current_row, Token.Tex.ASSIGN, null, 0);

                        }
                        else
                        {
                            add_token = new Token(current_row, Token.Tex.COLON, null, 0);
                            UngetNextChar();

                        }
                        token_list.Add(add_token);
                        result.Clear();
                        state = State.START;
                        break;
                    }

                case State.INCOMMENT:
                    {
                        state = State.INCOMMENT;
                        if (current == '}')
                            state = State.START;
                        break;
                    }

                case State.INCHAR:
                    {
                        if (L.Contains(current) || D.Contains(current))
                        {
                            result.Append(current);
                        }
                        else if (current == '\'')
                        {
                            add_token = new Token(current_row, Token.Tex.CHARC, result.ToString(), 0);
                            token_list.Add(add_token);
                            state = State.START;
                            result.Clear();
                        }
                        else
                            state = State.ERR;
                        break;
                    }

                case State.INNUM:
                    if (D.Contains(current))
                    {

                        if (current_row != former_row)
                        {
                            state = State.START;
                            add_token = new Token(former_row, Token.Tex.INTC, null, int.Parse(result.ToString()));
                            token_list.Add(add_token);
                            state = State.START;
                            if (result.Length > 1 && result[0] == '0')
                                error_row.Add("第" + former_row.ToString() + "行，数字不能以0开头");
                            result.Clear();
                            UngetNextChar();
                            break;
                        }
                        else
                            result.Append(current);
                    }
                    else
                    {
                        if (current_row != former_row)
                        {
                            state = State.START;
                            UngetNextChar();
                            add_token = new Token(current_row, Token.Tex.INTC, null, int.Parse(result.ToString()));
                            token_list.Add(add_token);
                            state = State.START;
                            if (result.Length > 1 && result[0] == '0')
                                error_row.Add("第" + former_row.ToString() + "行，数字不能以0开头");
                            result.Clear();
                            break;
                        }
                        if (Done.Contains(current) || current == ':' || current == '.')
                        {
                            add_token = new Token(current_row, Token.Tex.INTC, null, int.Parse(result.ToString()));
                            token_list.Add(add_token);
                            state = State.START;
                            if (result.Length > 1 && result[0] == '0')
                                error_row.Add("第" + current_row.ToString() + "行，数字不能以0开头");
                            result.Clear();
                            UngetNextChar();
                        }
                        else
                        {
                            state = State.ERR;
                            add_token = new Token(current_row, Token.Tex.INTC, null, int.Parse(result.ToString()));
                            token_list.Add(add_token);
                            if (result.Length > 1 && result[0] == '0')
                                error_row.Add("第" + current_row.ToString() + "行，数字不能以0开头");
                            result.Clear();
                            break;
                        }
                    }

                    break;


                case State.INRANGE:
                    {
                        if (current == '.')
                        {
                            add_token = new Token(current_row, Token.Tex.UNDERANGE, null, 0);
                            token_list.Add(add_token);
                            result.Clear();
                            state = State.START;
                        }
                        else
                        {
                            add_token = new Token(former_row, Token.Tex.DOT, null, 0);
                            token_list.Add(add_token);
                            result.Clear();
                            UngetNextChar();
                            state = State.START;
                        }
                        break;
                    }

                case State.DONE:
                    state = State.START;
                    switch (former)
                    {
                        case '+':
                            tem = Token.Tex.PLUS;
                            break;
                        case '-':
                            tem = Token.Tex.MINUS;
                            break;
                        case '*':
                            tem = Token.Tex.TIMES;
                            break;
                        case '/':
                            tem = Token.Tex.OVER;
                            break;
                        case '(':
                            tem = Token.Tex.LPAREN;
                            break;
                        case ')':
                            tem = Token.Tex.RPAPEN;
                            break;
                        case ';':
                            tem = Token.Tex.SEMI;
                            break;
                        case '[':
                            tem = Token.Tex.LMIDPAREN;
                            break;
                        case ']':
                            tem = Token.Tex.RMIDPAREN;
                            break;
                        case '=':
                            tem = Token.Tex.EQ;
                            break;
                        case '<':
                            tem = Token.Tex.LT;
                            break;
                        case ',':
                            tem = Token.Tex.COMMA;
                            break;
                    }
                    add_token = new Token(former_row, tem, null, 0);
                    token_list.Add(add_token);
                    result.Clear();
                    UngetNextChar();
                    break;

                case State.START:
                    if (D.Contains(current) == true)
                    {
                        state = State.INNUM;
                        result.Append(current);
                    }
                    else if (L.Contains(current) == true)
                    {
                        state = State.INID;
                        result.Append(current);
                    }
                    else if (current == ' ' || current == '\t')
                    {
                        state = State.START;
                    }
                    else if (current != ' ' && current != '\t' && Done.Contains(current) == true)
                    {
                        state = State.DONE;
                        result.Append(current);
                    }
                    else if (current == '{')
                    {
                        state = State.INCOMMENT;
                    }
                    else if (current == ':')
                    {
                        state = State.INASSIGN;
                        result.Append(current);
                    }
                    else if (current == '.')
                    {
                        state = State.INRANGE;
                        result.Append(current);
                    }
                    else if (current == '\'')
                    {
                        state = State.INCHAR;
                        result.Append(current);
                    }
                    else
                        state = State.ERR;
                    break;

                default:
                    state = State.START;
                    UngetNextChar();
                    error_row.Add("第" + former_row + "行出错");
                    break;

            }
        }

        private Token.Tex ReservedLookUP(string str)
        {
            Token.Tex val;
            bool ret = reserved.TryGetValue(str, out val);
            if (ret == true)
                return val;
            else
                return (Token.Tex.ID);
        }

        public void Scan()
        {
            create_SNL_info();
            while (getNextChar() != -1)
            {
                DFA();
            }
            if (state == State.INCOMMENT)
                error_row.Add("缺少}");
            Token token = new Token(0, Token.Tex.ENDFILE, null, 0);
            token_list.Add(token);
        }
    }
}