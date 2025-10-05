using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFD
{
    internal class Predict_SNL
    {
        private List<Token.Tex> pre;
        public Dictionary<int, List<WFD.Token.Tex>> Predict = new Dictionary<int, List<WFD.Token.Tex>>();
        public Predict_SNL()
        {
            pre = new List<Token.Tex> { Token.Tex.PROGRAM };
            Predict.Add(0, pre);
            pre = new List<Token.Tex> { Token.Tex.PROGRAM };
            Predict.Add(1, pre);
            pre = new List<Token.Tex> { Token.Tex.PROGRAM };
            Predict.Add(2, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(3, pre);
            pre = new List<Token.Tex> { Token.Tex.TYPE, Token.Tex.VAR, Token.Tex.PROCEDURE, Token.Tex.BEGIN1 };
            Predict.Add(4, pre);
            pre = new List<Token.Tex> { Token.Tex.VAR, Token.Tex.PROCEDURE, Token.Tex.BEGIN1 };
            Predict.Add(5, pre);
            pre = new List<Token.Tex> { Token.Tex.TYPE };
            Predict.Add(6, pre);
            pre = new List<Token.Tex> { Token.Tex.TYPE };
            Predict.Add(7, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(8, pre);
            pre = new List<Token.Tex> { Token.Tex.VAR, Token.Tex.PROCEDURE, Token.Tex.BEGIN1 };
            Predict.Add(9, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(10, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(11, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1 };/////
            Predict.Add(12, pre);
            pre = new List<Token.Tex> { Token.Tex.ARRAY, Token.Tex.RECORD };
            Predict.Add(13, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(14, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER };
            Predict.Add(15, pre);
            pre = new List<Token.Tex> { Token.Tex.CHAR1 };
            Predict.Add(16, pre);
            pre = new List<Token.Tex> { Token.Tex.ARRAY };
            Predict.Add(17, pre);
            pre = new List<Token.Tex> { Token.Tex.RECORD };
            Predict.Add(18, pre);
            pre = new List<Token.Tex> { Token.Tex.ARRAY };
            Predict.Add(19, pre);
            pre = new List<Token.Tex> { Token.Tex.INTC };
            Predict.Add(20, pre);
            pre = new List<Token.Tex> { Token.Tex.INTC };
            Predict.Add(21, pre);
            pre = new List<Token.Tex> { Token.Tex.RECORD };
            Predict.Add(22, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1 };
            Predict.Add(23, pre);
            pre = new List<Token.Tex> { Token.Tex.ARRAY };
            Predict.Add(24, pre);
            pre = new List<Token.Tex> { Token.Tex.END1 };
            Predict.Add(25, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1, Token.Tex.ARRAY };
            Predict.Add(26, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(27, pre);
            pre = new List<Token.Tex> { Token.Tex.SEMI };
            Predict.Add(28, pre);
            pre = new List<Token.Tex> { Token.Tex.COMMA };
            Predict.Add(29, pre);
            pre = new List<Token.Tex> { Token.Tex.PROCEDURE, Token.Tex.BEGIN1 };
            Predict.Add(30, pre);
            pre = new List<Token.Tex> { Token.Tex.VAR };
            Predict.Add(31, pre);
            pre = new List<Token.Tex> { Token.Tex.VAR };
            Predict.Add(32, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1, Token.Tex.ARRAY, Token.Tex.RECORD, Token.Tex.ID };
            Predict.Add(33, pre);
            pre = new List<Token.Tex> { Token.Tex.PROCEDURE, Token.Tex.BEGIN1 };
            Predict.Add(34, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1, Token.Tex.ARRAY, Token.Tex.RECORD, Token.Tex.ID };
            Predict.Add(35, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(36, pre);
            pre = new List<Token.Tex> { Token.Tex.SEMI }; //;
            Predict.Add(37, pre);
            pre = new List<Token.Tex> { Token.Tex.COMMA };
            Predict.Add(38, pre);
            pre = new List<Token.Tex> { Token.Tex.BEGIN1 };
            Predict.Add(39, pre);
            pre = new List<Token.Tex> { Token.Tex.PROCEDURE };
            Predict.Add(40, pre);
            pre = new List<Token.Tex> { Token.Tex.PROCEDURE };
            Predict.Add(41, pre);
            pre = new List<Token.Tex> { Token.Tex.BEGIN1 };
            Predict.Add(42, pre);
            pre = new List<Token.Tex> { Token.Tex.PROCEDURE };
            Predict.Add(43, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(44, pre);
            pre = new List<Token.Tex> { Token.Tex.RPAPEN };// )
            Predict.Add(45, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1, Token.Tex.ARRAY, Token.Tex.RECORD, Token.Tex.ID, Token.Tex.VAR };
            Predict.Add(46, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1, Token.Tex.ARRAY, Token.Tex.RECORD, Token.Tex.ID, Token.Tex.VAR };
            Predict.Add(47, pre);
            pre = new List<Token.Tex> { Token.Tex.RPAPEN }; // (
            Predict.Add(48, pre);
            pre = new List<Token.Tex> { Token.Tex.SEMI };  // ;
            Predict.Add(49, pre);
            pre = new List<Token.Tex> { Token.Tex.INTEGER, Token.Tex.CHAR1, Token.Tex.ARRAY, Token.Tex.RECORD, Token.Tex.ID };
            Predict.Add(50, pre);
            pre = new List<Token.Tex> { Token.Tex.VAR };
            Predict.Add(51, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(52, pre);
            pre = new List<Token.Tex> { Token.Tex.SEMI, Token.Tex.RPAPEN };//;  )
            Predict.Add(53, pre);
            pre = new List<Token.Tex> { Token.Tex.COMMA };
            Predict.Add(54, pre);
            pre = new List<Token.Tex> { Token.Tex.TYPE, Token.Tex.VAR, Token.Tex.PROCEDURE, Token.Tex.BEGIN1 };
            Predict.Add(55, pre);
            pre = new List<Token.Tex> { Token.Tex.BEGIN1 };
            Predict.Add(56, pre);
            pre = new List<Token.Tex> { Token.Tex.BEGIN1 };
            Predict.Add(57, pre);
            pre = new List<Token.Tex> { Token.Tex.ID, Token.Tex.IF, Token.Tex.WHILE, Token.Tex.RETURN1, Token.Tex.READ, Token.Tex.WRITE };
            Predict.Add(58, pre);
            pre = new List<Token.Tex> { Token.Tex.ELSE, Token.Tex.FI, Token.Tex.END1, Token.Tex.ENDWH };
            Predict.Add(59, pre);
            pre = new List<Token.Tex> { Token.Tex.SEMI };//;
            Predict.Add(60, pre);
            pre = new List<Token.Tex> { Token.Tex.IF };
            Predict.Add(61, pre);
            pre = new List<Token.Tex> { Token.Tex.WHILE };
            Predict.Add(62, pre);
            pre = new List<Token.Tex> { Token.Tex.READ };
            Predict.Add(63, pre);
            pre = new List<Token.Tex> { Token.Tex.WRITE };
            Predict.Add(64, pre);
            pre = new List<Token.Tex> { Token.Tex.RETURN1 };
            Predict.Add(65, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(66, pre);
            pre = new List<Token.Tex> { Token.Tex.ASSIGN, Token.Tex.LMIDPAREN, Token.Tex.DOT };//:=
            Predict.Add(67, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN };//(
            Predict.Add(68, pre);
            pre = new List<Token.Tex> { Token.Tex.LMIDPAREN, Token.Tex.DOT, Token.Tex.ASSIGN };
            Predict.Add(69, pre);
            pre = new List<Token.Tex> { Token.Tex.IF };
            Predict.Add(70, pre);
            pre = new List<Token.Tex> { Token.Tex.WHILE };
            Predict.Add(71, pre);
            pre = new List<Token.Tex> { Token.Tex.READ };
            Predict.Add(72, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(73, pre);
            pre = new List<Token.Tex> { Token.Tex.WRITE };
            Predict.Add(74, pre);
            pre = new List<Token.Tex> { Token.Tex.RETURN1 };
            Predict.Add(75, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN };
            Predict.Add(76, pre);
            pre = new List<Token.Tex> { Token.Tex.RPAPEN };
            Predict.Add(77, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN, Token.Tex.INTC, Token.Tex.ID };
            Predict.Add(78, pre);
            pre = new List<Token.Tex> { Token.Tex.RPAPEN };
            Predict.Add(79, pre);
            pre = new List<Token.Tex> { Token.Tex.COMMA };
            Predict.Add(80, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN, Token.Tex.INTC, Token.Tex.ID };
            Predict.Add(81, pre);
            pre = new List<Token.Tex> { Token.Tex.LT, Token.Tex.EQ };
            Predict.Add(82, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN, Token.Tex.INTC, Token.Tex.ID };
            Predict.Add(83, pre);
            pre = new List<Token.Tex> { Token.Tex.LT, Token.Tex.EQ, Token.Tex.RMIDPAREN,
                Token.Tex.THEN,Token.Tex.ELSE, Token.Tex.FI, Token.Tex.DO,
                Token.Tex.ENDWH,Token.Tex.RPAPEN,Token.Tex.END1,Token.Tex.SEMI,Token.Tex.COMMA};
            Predict.Add(84, pre);
            pre = new List<Token.Tex> { Token.Tex.PLUS, Token.Tex.MINUS };//+ -
            Predict.Add(85, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN, Token.Tex.INTC, Token.Tex.ID };
            Predict.Add(86, pre);
            pre = new List<Token.Tex> { Token.Tex.PLUS,Token.Tex.MINUS, Token.Tex.LT,Token.Tex.EQ,
                 Token.Tex.RMIDPAREN,Token.Tex.THEN,Token.Tex.ELSE,Token.Tex.FI,
                 Token.Tex.DO,Token.Tex.ENDWH,Token.Tex.RPAPEN,Token.Tex.END1,
                 Token.Tex.SEMI,Token.Tex.COMMA};
            Predict.Add(87, pre);
            pre = new List<Token.Tex> { Token.Tex.TIMES, Token.Tex.OVER };
            Predict.Add(88, pre);
            pre = new List<Token.Tex> { Token.Tex.LPAREN };
            Predict.Add(89, pre);
            pre = new List<Token.Tex> { Token.Tex.INTC };
            Predict.Add(90, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(91, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(92, pre);
            pre = new List<Token.Tex> { Token.Tex.ASSIGN, Token.Tex.TIMES, Token.Tex.OVER,
                 Token.Tex.PLUS,Token.Tex.MINUS,Token.Tex.LT,Token.Tex.EQ,
                 Token.Tex.THEN,Token.Tex.ELSE,Token.Tex.FI,Token.Tex.DO,Token.Tex.RMIDPAREN
                 ,Token.Tex.ENDWH,Token.Tex.RPAPEN,Token.Tex.END1,Token.Tex.SEMI,Token.Tex.COMMA};
            Predict.Add(93, pre);
            pre = new List<Token.Tex> { Token.Tex.LMIDPAREN };//[
            Predict.Add(94, pre);
            pre = new List<Token.Tex> { Token.Tex.DOT };
            Predict.Add(95, pre);
            pre = new List<Token.Tex> { Token.Tex.ID };
            Predict.Add(96, pre);
            pre = new List<Token.Tex> { Token.Tex.ASSIGN, Token.Tex.TIMES, Token.Tex.OVER,
                 Token.Tex.PLUS,Token.Tex.MINUS,Token.Tex.LT,Token.Tex.EQ,
                 Token.Tex.THEN,Token.Tex.ELSE,Token.Tex.FI,Token.Tex.DO,
                 Token.Tex.ENDWH,Token.Tex.RPAPEN,Token.Tex.END1,Token.Tex.SEMI,Token.Tex.COMMA,Token.Tex.RMIDPAREN};
            Predict.Add(97, pre);
            pre = new List<Token.Tex> { Token.Tex.LMIDPAREN };//[
            Predict.Add(98, pre);
            pre = new List<Token.Tex> { Token.Tex.LT };
            Predict.Add(99, pre);
            pre = new List<Token.Tex> { Token.Tex.EQ };
            Predict.Add(100, pre);
            pre = new List<Token.Tex> { Token.Tex.PLUS };
            Predict.Add(101, pre);
            pre = new List<Token.Tex> { Token.Tex.MINUS };
            Predict.Add(102, pre);
            pre = new List<Token.Tex> { Token.Tex.TIMES };
            Predict.Add(103, pre);
            pre = new List<Token.Tex> { Token.Tex.OVER };
            Predict.Add(104, pre);
        }

    }

    public class Node
    {
        public int flag;   //0非终极符，1终极符
        public string name;
        public Token token;
        public VN vn = VN.END;
        public List<Node> son;
        public int level;
        public Node()
        {
            son = new List<Node>();
            token = new Token(0, Token.Tex.DO, "a", 0);
        }
    }     //语法树节点

    //空的处理
    internal class Grammar
    {
        private Token token;
        private Scanner scanner;
        private int token_count;
        private int tokenindex;
        private Predict_SNL Predict;
        public Node root;
        public List<string> error_inf = new List<string>();

        public Grammar(Scanner scanner_s)        //构造函数
        {
            scanner = scanner_s;
            token_count = scanner_s.token_list.Count;
            tokenindex = 0;
            Predict = new Predict_SNL();
            root = new Node();
            root.name = "Program";
            root.flag = 0;
            root.vn = VN.Program;
            root.level = 0;
        }

        public int ReadToken()    //成功为1，失败0
        {
            if (tokenindex < token_count)
            {
                token = scanner.token_list[tokenindex];
                tokenindex++;
                return 1;
            }
            else
                return 0;
        }

        public int Match(Node node, Token.Tex tex)
        {
            if (token.tex == tex)
            {
                node.flag = 1;
                if (token.content == null)
                    node.name = token.tex.ToString();
                else
                    node.name = token.content;
                node.token = token;
                ReadToken();
                return 1;
            }
            else
            {
                error();
                ReadToken();
                return 0;
            }
        }

        public void Program_start()  //1
        {
            if (Predict.Predict[1].Contains(token.tex))
            {
                Node programhead = new Node();
                programhead.level = 1;
                programhead.name = "ProgramHead";
                programhead.flag = 0;
                programhead.vn = VN.ProgramHead;
                root.son.Add(programhead);
                ProgramHead(programhead);

                Node declarepart = new Node();
                declarepart.level = 1;
                declarepart.name = "DeclarePart";
                declarepart.flag = 0;
                declarepart.vn = VN.DeclarePart;
                root.son.Add(declarepart);
                DeclarePart(declarepart);

                Node programbody = new Node();
                programbody.level = 1;
                programbody.name = "ProgramBody";
                programbody.flag = 0;
                programbody.vn = VN.ProgramBody;
                root.son.Add(programbody);
                ProgramBody(programbody);

                Node dotend = new Node();
                dotend.level = 1;
                root.son.Add(dotend);
                Match(dotend, Token.Tex.DOT);
            }
            else
                error();
        }

        private void ProgramHead(Node father)  //2
        {
            if (Predict.Predict[2].Contains(token.tex))
            {
                Node program_2 = new Node();
                program_2.level = father.level + 1;
                father.son.Add(program_2);
                Match(program_2, Token.Tex.PROGRAM);//program

                Node programname_2 = new Node();
                programname_2.level = father.level + 1;
                programname_2.name = "ProgramName";
                programname_2.flag = 0;
                programname_2.vn = VN.ProgramName;
                father.son.Add(programname_2);
                ProgramName(programname_2);
            }
            else
                error();
        }

        private void ProgramName(Node father)   //3
        {
            if (Predict.Predict[3].Contains(token.tex))
            {
                Node id_3 = new Node();
                id_3.level = father.level + 1;
                father.son.Add(id_3);
                Match(id_3, Token.Tex.ID);
            }
            else
                error();
        }

        private void DeclarePart(Node father)   //4
        {
            if (Predict.Predict[4].Contains(token.tex))
            {
                Node typedec_4 = new Node();
                typedec_4.level = father.level + 1;
                typedec_4.name = "TypeDec";
                typedec_4.flag = 0;
                typedec_4.vn = VN.TypeDec;
                father.son.Add(typedec_4);///
                TypeDec(typedec_4);

                Node vardec_4 = new Node();
                vardec_4.level = father.level + 1;
                vardec_4.name = "VarDec";
                vardec_4.flag = 0;
                vardec_4.vn = VN.VarDec;
                father.son.Add(vardec_4);
                VarDec(vardec_4);

                Node procdec_4 = new Node();
                procdec_4.level = father.level + 1;
                procdec_4.name = "ProcDec";
                procdec_4.flag = 0;
                procdec_4.vn = VN.ProcDec;
                father.son.Add(procdec_4);
                ProcDec(procdec_4);
            }
            else error();
        }

        private void TypeDec(Node father) //5
        {
            if (Predict.Predict[5].Contains(token.tex)) //空
            {
                Node Null_5 = new Node();
                Null_5.level = father.level + 1;
                Null_5.name = "Null";
                Null_5.flag = 0;
                Null_5.vn = VN.Null;
                father.son.Add(Null_5);
            }
            else if (Predict.Predict[6].Contains(token.tex))
            {
                Node typedeclaration_6 = new Node();
                typedeclaration_6.level = father.level + 1;
                typedeclaration_6.name = "TypeDeclaration";
                typedeclaration_6.flag = 0;
                typedeclaration_6.vn = VN.TypeDeclaration;
                father.son.Add(typedeclaration_6);
                TypeDeclaration(typedeclaration_6);   // 6
            }
            else error();
        }

        private void TypeDeclaration(Node father)    //7
        {
            if (Predict.Predict[7].Contains(token.tex))
            {
                Node type_7 = new Node();
                type_7.level = father.level + 1;
                father.son.Add(type_7);
                Match(type_7, Token.Tex.TYPE); //TYPE

                Node typedeclist_7 = new Node();
                typedeclist_7.level = father.level + 1;
                typedeclist_7.name = "TypeDecList";
                typedeclist_7.flag = 0;
                typedeclist_7.vn = VN.TypeDecList;
                father.son.Add(typedeclist_7);
                TypeDecList(typedeclist_7);
            }
            else
                error();
        }

        private void TypeDecList(Node father)   //8
        {
            if (Predict.Predict[8].Contains(token.tex))
            {
                Node typeid_8 = new Node();
                typeid_8.level = father.level + 1;
                typeid_8.name = "TypeId";
                typeid_8.flag = 0;
                typeid_8.vn = VN.TypeId;
                father.son.Add(typeid_8);
                TypeId(typeid_8);

                Node eq_8 = new Node();
                eq_8.level = father.level + 1;
                father.son.Add(eq_8);
                Match(eq_8, Token.Tex.EQ);   //=

                Node typename_8 = new Node();
                typename_8.level = father.level + 1;
                typename_8.name = "TypeName";
                typename_8.flag = 0;
                typename_8.vn = VN.TypeName;
                father.son.Add(typename_8);
                TypeName(typename_8);

                Node semi_8 = new Node();
                semi_8.level = father.level + 1;
                father.son.Add(semi_8);
                Match(semi_8, Token.Tex.SEMI);   //;

                Node typedecmore_8 = new Node();
                typedecmore_8.level = father.level + 1;
                typedecmore_8.name = "TypeDecMore";
                typedecmore_8.flag = 0;
                typedecmore_8.vn = VN.TypeDecMore;
                father.son.Add(typedecmore_8);
                TypeDecMore(typedecmore_8);
            }
            else
                error();
        }

        private void TypeDecMore(Node father)  //9
        {
            if (Predict.Predict[9].Contains(token.tex)) //空
            {
                Node Null_9 = new Node();
                Null_9.level = father.level + 1;
                Null_9.name = "Null";
                Null_9.flag = 0;
                Null_9.vn = VN.Null;
                father.son.Add(Null_9);
            }
            else if (Predict.Predict[10].Contains(token.tex))              //10
            {
                Node typedeclist_10 = new Node();
                typedeclist_10.level = father.level + 1;
                typedeclist_10.name = "TypeDecList";
                typedeclist_10.flag = 0;
                typedeclist_10.vn = VN.TypeDecList;
                father.son.Add(typedeclist_10);
                TypeDecList(typedeclist_10);
            }
            else error();
        }

        private void TypeId(Node father) //11
        {
            if (Predict.Predict[11].Contains(token.tex))
            {
                Node id_11 = new Node();
                id_11.level = father.level + 1;
                father.son.Add(id_11);
                Match(id_11, Token.Tex.ID);
            }
            else
                error();
        }

        private void TypeName(Node father) //12
        {
            if (Predict.Predict[12].Contains(token.tex))
            {
                Node basetype_12 = new Node();
                basetype_12.level = father.level + 1;
                basetype_12.name = "BaseType";
                basetype_12.flag = 0;
                basetype_12.vn = VN.BaseType;
                father.son.Add(basetype_12);
                BaseType(basetype_12);
            }
            else if (Predict.Predict[13].Contains(token.tex))
            {
                Node structuretype_13 = new Node();
                structuretype_13.level = father.level + 1;
                structuretype_13.name = "StructType";
                structuretype_13.flag = 0;
                structuretype_13.vn = VN.StructType;
                father.son.Add(structuretype_13);
                StructureType(structuretype_13);  //13
            }
            else if (Predict.Predict[14].Contains(token.tex))
            {
                Node id_14 = new Node();
                id_14.level = father.level + 1;
                father.son.Add(id_14);
                Match(id_14, Token.Tex.ID);  //ID   14
            }
            else
                error();
        }

        private void BaseType(Node father)    //15
        {
            if (Predict.Predict[15].Contains(token.tex))
            {
                Node integer_15 = new Node();
                integer_15.level = father.level + 1;
                father.son.Add(integer_15);
                Match(integer_15, Token.Tex.INTEGER); //INTEGER
            }
            else if (Predict.Predict[16].Contains(token.tex))           //16
            {
                Node char1_16 = new Node();
                char1_16.level = father.level + 1;
                father.son.Add(char1_16);
                Match(char1_16, Token.Tex.CHAR1);  //CHAR
            }
            else
                error();
        }

        private void StructureType(Node father)   //17
        {
            if (Predict.Predict[17].Contains(token.tex))
            {
                Node arraytype_17 = new Node();
                arraytype_17.level = father.level + 1;
                arraytype_17.name = "ArrayType";
                arraytype_17.flag = 0;
                arraytype_17.vn = VN.ArrayType;
                father.son.Add(arraytype_17);
                ArrayType(arraytype_17);
            }
            else if (Predict.Predict[18].Contains(token.tex))//18
            {
                Node rectype_18 = new Node();
                rectype_18.level = father.level + 1;
                rectype_18.name = "RecType";
                rectype_18.flag = 0;
                rectype_18.vn = VN.RecType;
                father.son.Add(rectype_18);
                RecType(rectype_18);
            }
            else error();
        }

        private void ArrayType(Node father)   //19
        {
            if (Predict.Predict[19].Contains(token.tex))
            {
                Node array_19 = new Node();
                array_19.level = father.level + 1;
                father.son.Add(array_19);
                Match(array_19, Token.Tex.ARRAY); //ARRAY

                Node lmidparen_19 = new Node();
                lmidparen_19.level = father.level + 1;
                father.son.Add(lmidparen_19);
                Match(lmidparen_19, Token.Tex.LMIDPAREN); //[

                Node low_19 = new Node();
                low_19.level = father.level + 1;
                low_19.name = "Low";
                low_19.flag = 0;
                low_19.vn = VN.Low;
                father.son.Add(low_19);
                Low(low_19);

                Node under_19 = new Node();
                under_19.level = father.level + 1;
                father.son.Add(under_19);
                Match(under_19, Token.Tex.UNDERANGE);

                Node top_19 = new Node();
                top_19.level = father.level + 1;
                top_19.name = "Top";
                top_19.flag = 0;
                top_19.vn = VN.Top;
                father.son.Add(top_19);
                Top(top_19);

                Node rmidparen_19 = new Node();
                rmidparen_19.level = father.level + 1;
                father.son.Add(rmidparen_19);
                Match(rmidparen_19, Token.Tex.RMIDPAREN); //]

                Node of_19 = new Node();
                of_19.level = father.level + 1;
                father.son.Add(of_19);
                Match(of_19, Token.Tex.OF); //OF

                Node basetype_19 = new Node();
                basetype_19.level = father.level + 1;
                basetype_19.name = "BaseType";
                basetype_19.flag = 0;
                basetype_19.vn = VN.BaseType;
                father.son.Add(basetype_19);
                BaseType(basetype_19);
            }
            else error();
        }

        private void Low(Node father)  //20
        {
            if (Predict.Predict[20].Contains(token.tex))
            {
                Node intc_20 = new Node();
                intc_20.level = father.level + 1;
                father.son.Add(intc_20);
                Match(intc_20, Token.Tex.INTC); //INTC
            }
            else error();
        }

        private void Top(Node father)  //21
        {
            if (Predict.Predict[21].Contains(token.tex))
            {
                Node intc_21 = new Node();
                intc_21.level = father.level + 1;
                father.son.Add(intc_21);
                Match(intc_21, Token.Tex.INTC); //INTC
            }
            else error();
        }

        private void RecType(Node father)  //22
        {
            if (Predict.Predict[22].Contains(token.tex))
            {
                Node record_22 = new Node();
                record_22.level = father.level + 1;
                father.son.Add(record_22);
                Match(record_22, Token.Tex.RECORD); //RECORD

                Node fielddeclist_22 = new Node();
                fielddeclist_22.level = father.level + 1;
                fielddeclist_22.name = "FieldDecList";
                fielddeclist_22.flag = 0;
                fielddeclist_22.vn = VN.FieldDecList;
                father.son.Add(fielddeclist_22);
                FieldDecList(fielddeclist_22);

                Node end1_22 = new Node();
                end1_22.level = father.level + 1;
                father.son.Add(end1_22);
                Match(end1_22, Token.Tex.END1);  //END
            }
            else error();

        }

        private void FieldDecList(Node father)  //23
        {
            if (Predict.Predict[23].Contains(token.tex))
            {
                Node basetype_23 = new Node();
                basetype_23.level = father.level + 1;
                basetype_23.name = "BaseType";
                basetype_23.flag = 0;
                basetype_23.vn = VN.BaseType;
                father.son.Add(basetype_23);
                BaseType(basetype_23);

                Node idlist_23 = new Node();
                idlist_23.level = father.level + 1;
                idlist_23.name = "IdList";
                idlist_23.flag = 0;
                idlist_23.vn = VN.IdList;
                father.son.Add(idlist_23);
                IdList(idlist_23);

                Node semi_23 = new Node();
                semi_23.level = father.level + 1;
                father.son.Add(semi_23);
                Match(semi_23, Token.Tex.SEMI);  //;

                Node fielddecmore_23 = new Node();
                fielddecmore_23.level = father.level + 1;
                fielddecmore_23.name = "FieldDecMore";
                fielddecmore_23.flag = 0;
                fielddecmore_23.vn = VN.FieldDecMore;
                father.son.Add(fielddecmore_23);
                FieldDecMore(fielddecmore_23);
            }
            else if (Predict.Predict[24].Contains(token.tex))            //24
            {
                Node ArrayType_24 = new Node();
                ArrayType_24.level = father.level + 1;
                ArrayType_24.name = "ArrayType";
                ArrayType_24.flag = 0;
                ArrayType_24.vn = VN.ArrayType;
                father.son.Add(ArrayType_24);
                ArrayType(ArrayType_24);

                Node IdList_24 = new Node();
                IdList_24.level = father.level + 1;
                IdList_24.name = "IdList";
                IdList_24.flag = 0;
                IdList_24.vn = VN.IdList;
                father.son.Add(IdList_24);
                IdList(IdList_24);

                Node SEMI_24 = new Node();
                SEMI_24.level = father.level + 1;
                father.son.Add(SEMI_24);
                Match(SEMI_24, Token.Tex.SEMI); //;

                Node FieldDecMore_24 = new Node();
                FieldDecMore_24.level = father.level + 1;
                FieldDecMore_24.name = "FieldDecMore";
                FieldDecMore_24.flag = 0;
                FieldDecMore_24.vn = VN.FieldDecMore;
                father.son.Add(FieldDecMore_24);
                FieldDecMore(FieldDecMore_24);
            }
            else error();
        }

        private void FieldDecMore(Node father)   //25
        {
            if (Predict.Predict[25].Contains(token.tex))
            {
                Node Null_25 = new Node();
                Null_25.level = father.level + 1;
                Null_25.name = "Null";
                Null_25.flag = 0;
                Null_25.vn = VN.Null;
                father.son.Add(Null_25);
            }
            else if (Predict.Predict[26].Contains(token.tex))               //26
            {
                Node FieldDecList_26 = new Node();
                FieldDecList_26.level = father.level + 1;
                FieldDecList_26.name = "FieldDecList";
                FieldDecList_26.flag = 0;
                FieldDecList_26.vn = VN.FieldDecList;
                father.son.Add(FieldDecList_26);
                FieldDecList(FieldDecList_26);
            }
            else error();
        }

        private void IdList(Node father)       //27
        {
            if (Predict.Predict[27].Contains(token.tex))
            {
                Node ID_27 = new Node();
                ID_27.level = father.level + 1;
                father.son.Add(ID_27);
                Match(ID_27, Token.Tex.ID); //ID


                Node IdMore_27 = new Node();
                IdMore_27.level = father.level + 1;
                IdMore_27.name = "IdMore";
                IdMore_27.flag = 0;
                IdMore_27.vn = VN.IdMore;
                father.son.Add(IdMore_27);
                IdMore(IdMore_27);
            }
            else error();
        }
        private void IdMore(Node father)      //28
        {
            if (Predict.Predict[28].Contains(token.tex))
            {
                Node Null_28 = new Node();
                Null_28.level = father.level + 1;
                Null_28.name = "Null";
                Null_28.flag = 0;
                Null_28.vn = VN.Null;
                father.son.Add(Null_28);
            }
            else if (Predict.Predict[29].Contains(token.tex))            //29
            {
                Node COMMA_29 = new Node();
                COMMA_29.level = father.level + 1;
                father.son.Add(COMMA_29);
                Match(COMMA_29, Token.Tex.COMMA);  //,

                Node IdList_29 = new Node();
                IdList_29.level = father.level + 1;
                IdList_29.name = "IdList";
                IdList_29.flag = 0;
                IdList_29.vn = VN.IdList;
                father.son.Add(IdList_29);
                IdList(IdList_29);
            }
            else error();
        }

        private void VarDec(Node father)    //30
        {
            if (Predict.Predict[30].Contains(token.tex))
            {
                Node Null_30 = new Node();
                Null_30.level = father.level + 1;
                Null_30.flag = 0;
                Null_30.name = "Null";
                Null_30.vn = VN.Null;
                father.son.Add(Null_30);
            }
            else if (Predict.Predict[31].Contains(token.tex))           //31
            {
                Node VarDeclaration_31 = new Node();
                VarDeclaration_31.level = father.level + 1;
                VarDeclaration_31.name = "VarDeclaration";
                VarDeclaration_31.flag = 0;
                VarDeclaration_31.vn = VN.VarDeclaration;
                father.son.Add(VarDeclaration_31);
                VarDeclaration(VarDeclaration_31);
            }
            else error();
        }

        private void VarDeclaration(Node father)   //32
        {
            if (Predict.Predict[32].Contains(token.tex))
            {
                Node Var_32 = new Node();
                Var_32.level = father.level + 1;
                father.son.Add(Var_32);
                Match(Var_32, Token.Tex.VAR);         //VAR

                Node VarDecList_32 = new Node();
                VarDecList_32.level = father.level + 1;
                VarDecList_32.name = "VarDecList";
                VarDecList_32.flag = 0;
                VarDecList_32.vn = VN.VarDecList;
                father.son.Add(VarDecList_32);
                VarDecList(VarDecList_32);
            }
            else error();
        }

        private void VarDecList(Node father)  //33
        {
            if (Predict.Predict[33].Contains(token.tex))
            {
                Node TypeName_33 = new Node();
                TypeName_33.level = father.level + 1;
                TypeName_33.name = "TypeName";
                TypeName_33.flag = 0;
                TypeName_33.vn = VN.TypeName;
                father.son.Add(TypeName_33);
                TypeName(TypeName_33);

                Node VarIdList_33 = new Node();
                VarIdList_33.level = father.level + 1;
                VarIdList_33.name = "VarIdList";
                VarIdList_33.flag = 0;
                VarIdList_33.vn = VN.VarIdList;
                father.son.Add(VarIdList_33);
                VarIdList(VarIdList_33);

                Node SEMI_33 = new Node();
                SEMI_33.level = father.level + 1;
                father.son.Add(SEMI_33);
                Match(SEMI_33, Token.Tex.SEMI);    //;

                Node VarDecMore_33 = new Node();
                VarDecMore_33.level = father.level + 1;
                VarDecMore_33.name = "VarDecMore";
                VarDecMore_33.flag = 0;
                VarDecMore_33.vn = VN.VarDecMore;
                father.son.Add(VarDecMore_33);
                VarDecMore(VarDecMore_33);
            }
            else error();
        }

        private void VarDecMore(Node father)      //34
        {
            if (Predict.Predict[34].Contains(token.tex))
            {
                Node Null_34 = new Node();
                Null_34.level = father.level + 1;
                Null_34.flag = 0;
                Null_34.name = "Null";
                Null_34.vn = VN.Null;
                father.son.Add(Null_34);
            }
            else if (Predict.Predict[35].Contains(token.tex))              //35
            {
                Node VarDecList_35 = new Node();
                VarDecList_35.level = father.level + 1;
                VarDecList_35.name = "VarDecList";
                VarDecList_35.flag = 0;
                VarDecList_35.vn = VN.VarDecList;
                father.son.Add(VarDecList_35);
                VarDecList(VarDecList_35);
            }
            else
                error();
        }

        private void VarIdList(Node father)    //36
        {
            if (Predict.Predict[36].Contains(token.tex))
            {
                Node ID_36 = new Node();
                ID_36.level = father.level + 1;
                father.son.Add(ID_36);
                Match(ID_36, Token.Tex.ID);          //ID

                Node VarIdMore_36 = new Node();
                VarIdMore_36.level = father.level + 1;
                VarIdMore_36.name = "VarIdMore";
                VarIdMore_36.flag = 0;
                VarIdMore_36.vn = VN.VarIdMore;
                father.son.Add(VarIdMore_36);
                VarIdMore(VarIdMore_36);
            }
            else error();
        }

        private void VarIdMore(Node father)    //37
        {
            if (Predict.Predict[37].Contains(token.tex))
            {
                Node Null_37 = new Node();
                Null_37.level = father.level + 1;
                Null_37.flag = 0;
                Null_37.name = "Null";
                Null_37.vn = VN.Null;
                father.son.Add(Null_37); ;
            }
            else if (Predict.Predict[38].Contains(token.tex))       //38
            {
                Node COMMA_38 = new Node();
                COMMA_38.level = father.level + 1;
                father.son.Add(COMMA_38);
                Match(COMMA_38, Token.Tex.COMMA);   //,

                Node VarIdList_38 = new Node();
                VarIdList_38.level = father.level + 1;
                VarIdList_38.name = "VarIdList";
                VarIdList_38.flag = 0;
                VarIdList_38.vn = VN.VarIdList;
                father.son.Add(VarIdList_38);
                VarIdList(VarIdList_38);
            }
            else error();
        }

        private void ProcDec(Node father)  //39
        {
            if (Predict.Predict[39].Contains(token.tex))
            {
                Node Null_39 = new Node();
                Null_39.level = father.level + 1;
                Null_39.flag = 0;
                Null_39.name = "Null";
                Null_39.vn = VN.Null;
                father.son.Add(Null_39); ;
            }
            else if (Predict.Predict[40].Contains(token.tex))              //40
            {
                Node ProcDeclaration_40 = new Node();
                ProcDeclaration_40.level = father.level + 1;
                ProcDeclaration_40.name = "ProcDeclaration";
                ProcDeclaration_40.flag = 0;
                ProcDeclaration_40.vn = VN.ProcDeclaration;
                father.son.Add(ProcDeclaration_40);
                ProcDeclaration(ProcDeclaration_40);
            }
            else error();
        }

        private void ProcDeclaration(Node father)     //41
        {
            if (Predict.Predict[41].Contains(token.tex))
            {
                Node PROCEDURE_41 = new Node();
                PROCEDURE_41.level = father.level + 1;
                father.son.Add(PROCEDURE_41);
                Match(PROCEDURE_41, Token.Tex.PROCEDURE);   //PROCEDURE

                Node ProcName_41 = new Node();
                ProcName_41.level = father.level + 1;
                ProcName_41.name = "ProcName";
                ProcName_41.flag = 0;
                ProcName_41.vn = VN.ProcName;
                father.son.Add(ProcName_41);
                ProcName(ProcName_41);

                Node LPAREN_41 = new Node();
                LPAREN_41.level = father.level + 1;
                father.son.Add(LPAREN_41);
                Match(LPAREN_41, Token.Tex.LPAREN);    //(

                Node ParamList_41 = new Node();
                ParamList_41.level = father.level + 1;
                ParamList_41.name = "ParamList";
                ParamList_41.flag = 0;
                ParamList_41.vn = VN.ParamList;
                father.son.Add(ParamList_41);
                ParamList(ParamList_41);

                Node RPAPEN_41 = new Node();
                RPAPEN_41.level = father.level + 1;
                father.son.Add(RPAPEN_41);
                Match(RPAPEN_41, Token.Tex.RPAPEN);  //)

                Node SEMI_41 = new Node();
                SEMI_41.level = father.level + 1;
                father.son.Add(SEMI_41);
                Match(SEMI_41, Token.Tex.SEMI);   //;

                Node ProcDecPart_41 = new Node();
                ProcDecPart_41.level = father.level + 1;
                ProcDecPart_41.name = "ProcDecPart";
                ProcDecPart_41.flag = 0;
                ProcDecPart_41.vn = VN.ProcDecPart;
                father.son.Add(ProcDecPart_41);
                ProcDecPart(ProcDecPart_41);

                Node ProcBody_41 = new Node();
                ProcBody_41.level = father.level + 1;
                ProcBody_41.name = "ProcBody";
                ProcBody_41.flag = 0;
                ProcBody_41.vn = VN.ProcBody;
                father.son.Add(ProcBody_41);
                ProcBody(ProcBody_41);

                Node ProcDecMore_41 = new Node();
                ProcDecMore_41.level = father.level + 1;
                ProcDecMore_41.name = "ProcDecMore";
                ProcDecMore_41.flag = 0;
                ProcDecMore_41.vn = VN.ProcDecMore;
                father.son.Add(ProcDecMore_41);
                ProcDecMore(ProcDecMore_41);
            }
            else error();
        }

        private void ProcDecMore(Node father)    //42
        {
            if (Predict.Predict[42].Contains(token.tex))
            {
                Node Null_42 = new Node();
                Null_42.level = father.level + 1;
                Null_42.flag = 0;
                Null_42.name = "Null";
                Null_42.vn = VN.Null;
                father.son.Add(Null_42);
            }
            else if (Predict.Predict[43].Contains(token.tex)) //43
            {
                Node ProcDeclaration_43 = new Node();
                ProcDeclaration_43.level = father.level + 1;
                ProcDeclaration_43.name = "ProcDeclaration";
                ProcDeclaration_43.flag = 0;
                ProcDeclaration_43.vn = VN.ProcDeclaration;
                father.son.Add(ProcDeclaration_43);
                ProcDeclaration(ProcDeclaration_43);
            }
            else error();
        }

        private void ProcName(Node father)      //44
        {
            if (Predict.Predict[44].Contains(token.tex))
            {
                Node ID_44 = new Node();
                ID_44.level = father.level + 1;
                father.son.Add(ID_44);
                Match(ID_44, Token.Tex.ID);   //ID
            }
            else
                error();
        }

        private void ParamList(Node father)    //45
        {
            if (Predict.Predict[45].Contains(token.tex))
            {
                Node Null_45 = new Node();
                Null_45.level = father.level + 1;
                Null_45.flag = 0;
                Null_45.name = "Null";
                Null_45.vn = VN.Null;
                father.son.Add(Null_45);
            }
            else if (Predict.Predict[46].Contains(token.tex))              //46
            {
                Node ParamDecList_46 = new Node();
                ParamDecList_46.level = father.level + 1;
                ParamDecList_46.name = "ParamDecList";
                ParamDecList_46.flag = 0;
                ParamDecList_46.vn = VN.ParamDecList;
                father.son.Add(ParamDecList_46);
                ParamDecList(ParamDecList_46);
            }
            else
                error();
        }

        private void ParamDecList(Node father)   //47
        {
            if (Predict.Predict[47].Contains(token.tex))
            {
                Node Param_47 = new Node();
                Param_47.level = father.level + 1;
                Param_47.name = "Param";
                Param_47.flag = 0;
                Param_47.vn = VN.Param;
                father.son.Add(Param_47);
                Param(Param_47);

                Node ParamMore_47 = new Node();
                ParamMore_47.level = father.level + 1;
                ParamMore_47.name = "ParamMore";
                ParamMore_47.flag = 0;
                ParamMore_47.vn = VN.ParamMore;
                father.son.Add(ParamMore_47);
                ParamMore(ParamMore_47);
            }
            else error();
        }

        private void ParamMore(Node father)     //48
        {
            if (Predict.Predict[48].Contains(token.tex))
            {
                Node Null_48 = new Node();
                Null_48.level = father.level + 1;
                Null_48.flag = 0;
                Null_48.name = "Null";
                Null_48.vn = VN.Null;
                father.son.Add(Null_48);
            }
            else if (Predict.Predict[49].Contains(token.tex))                //49
            {
                Node SEMI_49 = new Node();
                SEMI_49.level = father.level + 1;
                father.son.Add(SEMI_49);
                Match(SEMI_49, Token.Tex.SEMI);  //;

                Node ParamDecList_49 = new Node();
                ParamDecList_49.level = father.level + 1;
                ParamDecList_49.name = "ParamDecList";
                ParamDecList_49.flag = 0;
                ParamDecList_49.vn = VN.ParamDecList;
                father.son.Add(ParamDecList_49);
                ParamDecList(ParamDecList_49);
            }
            else error();
        }

        private void Param(Node father)         //50
        {
            if (Predict.Predict[50].Contains(token.tex))
            {
                Node TypeName_50 = new Node();
                TypeName_50.level = father.level + 1;
                TypeName_50.name = "TypeName";
                TypeName_50.flag = 0;
                TypeName_50.vn = VN.TypeName;
                father.son.Add(TypeName_50);
                TypeName(TypeName_50);

                Node FormList_50 = new Node();
                FormList_50.level = father.level + 1;
                FormList_50.name = "FormList";
                FormList_50.flag = 0;
                FormList_50.vn = VN.FormList;
                father.son.Add(FormList_50);
                FormList(FormList_50);
            }
            else if (Predict.Predict[51].Contains(token.tex))            //51
            {
                Node VAR_51 = new Node();
                VAR_51.level = father.level + 1;
                father.son.Add(VAR_51);
                Match(VAR_51, Token.Tex.VAR);   //VAR

                Node TypeName_51 = new Node();
                TypeName_51.level = father.level + 1;
                TypeName_51.name = "TypeName";
                TypeName_51.flag = 0;
                TypeName_51.vn = VN.TypeName;
                father.son.Add(TypeName_51);
                TypeName(TypeName_51);

                Node FormList_51 = new Node();
                FormList_51.level = father.level + 1;
                FormList_51.name = "FormList";
                FormList_51.flag = 0;
                FormList_51.vn = VN.FormList;
                father.son.Add(FormList_51);
                FormList(FormList_51);
            }
            else error();
        }

        private void FormList(Node father)        //52
        {
            if (Predict.Predict[52].Contains(token.tex))
            {
                Node ID_52 = new Node();
                ID_52.level = father.level + 1;
                father.son.Add(ID_52);
                Match(ID_52, Token.Tex.ID);   //ID

                Node FidMore_52 = new Node();
                FidMore_52.level = father.level + 1;
                FidMore_52.name = "FidMore";
                FidMore_52.flag = 0;
                FidMore_52.vn = VN.FidMore;
                father.son.Add(FidMore_52);
                FidMore(FidMore_52);
            }
            else
                error();
        }

        private void FidMore(Node father)        //53
        {
            if (Predict.Predict[53].Contains(token.tex))
            {
                Node Null_53 = new Node();
                Null_53.level = father.level + 1;
                Null_53.flag = 0;
                Null_53.name = "Null";
                Null_53.vn = VN.Null;
                father.son.Add(Null_53);
            }
            else if (Predict.Predict[54].Contains(token.tex))          //54
            {
                Node COMMA_54 = new Node();
                COMMA_54.level = father.level + 1;
                father.son.Add(COMMA_54);
                Match(COMMA_54, Token.Tex.COMMA);     //,

                Node FormList_54 = new Node();
                FormList_54.level = father.level + 1;
                FormList_54.name = "FormList";
                FormList_54.flag = 0;
                FormList_54.vn = VN.FormList;
                father.son.Add(FormList_54);
                FormList(FormList_54);
            }
            else error();

        }

        private void ProcDecPart(Node father)     //55
        {
            if (Predict.Predict[55].Contains(token.tex))
            {
                Node DeclarePart_55 = new Node();
                DeclarePart_55.level = father.level + 1;
                DeclarePart_55.name = "DeclarePart";
                DeclarePart_55.flag = 0;
                DeclarePart_55.vn = VN.DeclarePart;
                father.son.Add(DeclarePart_55);
                DeclarePart(DeclarePart_55);
            }
            else error();
        }

        private void ProcBody(Node father)    //56
        {
            if (Predict.Predict[56].Contains(token.tex))
            {
                Node ProgramBody_56 = new Node();
                ProgramBody_56.level = father.level + 1;
                ProgramBody_56.name = "ProgramBody";
                ProgramBody_56.flag = 0;
                ProgramBody_56.vn = VN.ProgramBody;
                father.son.Add(ProgramBody_56);
                ProgramBody(ProgramBody_56);
            }
            else error();
        }

        private void ProgramBody(Node father)      //57
        {
            if (Predict.Predict[57].Contains(token.tex))
            {
                Node BEGIN1_57 = new Node();
                BEGIN1_57.level = father.level + 1;
                father.son.Add(BEGIN1_57);
                Match(BEGIN1_57, Token.Tex.BEGIN1);    //BEGIN

                Node StmList_57 = new Node();
                StmList_57.level = father.level + 1;
                StmList_57.name = "StmList";
                StmList_57.flag = 0;
                StmList_57.vn = VN.StmList;
                father.son.Add(StmList_57);
                StmList(StmList_57);

                Node END1_57 = new Node();
                END1_57.level = father.level + 1;
                father.son.Add(END1_57);
                Match(END1_57, Token.Tex.END1);    //END
            }
            else error();
        }

        private void StmList(Node father)        //58
        {
            if (Predict.Predict[58].Contains(token.tex))
            {
                Node Stm_58 = new Node();
                Stm_58.level = father.level + 1;
                Stm_58.name = "Stm";
                Stm_58.flag = 0;
                Stm_58.vn = VN.Stm;
                father.son.Add(Stm_58);
                Stm(Stm_58);

                Node StmMore_58 = new Node();
                StmMore_58.level = father.level + 1;
                StmMore_58.name = "StmMore";
                StmMore_58.flag = 0;
                StmMore_58.vn = VN.StmMore;
                father.son.Add(StmMore_58);
                StmMore(StmMore_58);
            }
            else error();
        }

        private void StmMore(Node father)    //59
        {
            if (Predict.Predict[59].Contains(token.tex))
            {
                Node Null_59 = new Node();
                Null_59.level = father.level + 1;
                Null_59.flag = 0;
                Null_59.name = "Null";
                Null_59.vn = VN.Null;
                father.son.Add(Null_59);
            }
            else if (Predict.Predict[60].Contains(token.tex))     //60
            {
                Node SEMI_60 = new Node();
                SEMI_60.level = father.level + 1;
                father.son.Add(SEMI_60);
                Match(SEMI_60, Token.Tex.SEMI);   //;


                Node StmList_60 = new Node();
                StmList_60.level = father.level + 1;
                StmList_60.name = "StmList";
                StmList_60.flag = 0;
                StmList_60.vn = VN.StmList;
                father.son.Add(StmList_60);
                StmList(StmList_60);
            }
        }

        private void MultOp(Node father)
        {
            if (Predict.Predict[103].Contains(token.tex))//103
            {
                Node TIMES_103 = new Node();
                TIMES_103.level = father.level + 1;
                father.son.Add(TIMES_103);
                Match(TIMES_103, Token.Tex.TIMES);  // *
            }
            else if (Predict.Predict[104].Contains(token.tex))  //104
            {
                Node OVER_104 = new Node();
                OVER_104.level = father.level + 1;
                father.son.Add(OVER_104);
                Match(OVER_104, Token.Tex.OVER);  // /
            }
            else
                error();
        }

        private void AddOp(Node father)
        {
            if (Predict.Predict[101].Contains(token.tex))//101
            {
                Node PLUS_101 = new Node();
                PLUS_101.level = father.level + 1;
                father.son.Add(PLUS_101);
                Match(PLUS_101, Token.Tex.PLUS);//+
            }
            else if (Predict.Predict[102].Contains(token.tex))  //102
            {
                Node MINUS_102 = new Node();
                MINUS_102.level = father.level + 1;
                father.son.Add(MINUS_102);
                Match(MINUS_102, Token.Tex.MINUS);//-
            }
            else
                error();
        }

        private void CmpOp(Node father)//99
        {
            if (Predict.Predict[99].Contains(token.tex))
            {
                Node LT_99 = new Node();
                LT_99.level = father.level + 1;
                father.son.Add(LT_99);
                Match(LT_99, Token.Tex.LT);//<
            }
            else if (Predict.Predict[100].Contains(token.tex))//100
            {
                Node EQ_100 = new Node();
                EQ_100.level = father.level + 1;
                father.son.Add(EQ_100);
                Match(EQ_100, Token.Tex.EQ);//=
            }
            else
                error();
        }

        private void FieldVarMore(Node father)//97
        {
            if (Predict.Predict[97].Contains(token.tex))
            {
                Node Null_97 = new Node();
                Null_97.level = father.level + 1;
                Null_97.flag = 0;
                Null_97.name = "Null";
                Null_97.vn = VN.Null;
                father.son.Add(Null_97);
            }
            else if (Predict.Predict[98].Contains(token.tex))//98
            {
                Node LMIDPAREN_98 = new Node();
                LMIDPAREN_98.level = father.level + 1;
                father.son.Add(LMIDPAREN_98);
                Match(LMIDPAREN_98, Token.Tex.LMIDPAREN);//[


                Node exp_98 = new Node();
                exp_98.level = father.level + 1;
                exp_98.name = "Exp";
                exp_98.flag = 0;
                exp_98.vn = VN.Exp;
                father.son.Add(exp_98);
                Exp(exp_98);


                Node RMIDPAREN_98 = new Node();
                RMIDPAREN_98.level = father.level + 1;
                father.son.Add(RMIDPAREN_98);
                Match(RMIDPAREN_98, Token.Tex.RMIDPAREN);//]
            }
            else
                error();
        }

        private void FieldVar(Node father)//96
        {
            if (Predict.Predict[96].Contains(token.tex))
            {
                Node ID_96 = new Node();
                ID_96.level = father.level + 1;
                father.son.Add(ID_96);
                Match(ID_96, Token.Tex.ID);//ID'


                Node fieldvarmore_96 = new Node();
                fieldvarmore_96.level = father.level + 1;
                fieldvarmore_96.name = "FieldVarMore";
                fieldvarmore_96.flag = 0;
                fieldvarmore_96.vn = VN.FieldVarMore;
                father.son.Add(fieldvarmore_96);
                FieldVarMore(fieldvarmore_96);
            }
            else
                error();
        }

        private void VariMore(Node father)//93
        {
            if (Predict.Predict[93].Contains(token.tex))
            {
                Node Null_93 = new Node();
                Null_93.level = father.level + 1;
                Null_93.flag = 0;
                Null_93.name = "Null";
                Null_93.vn = VN.Null;
                father.son.Add(Null_93); ;
            }
            else if (Predict.Predict[94].Contains(token.tex))//94
            {
                Node LMIDPAREN_94 = new Node();
                LMIDPAREN_94.level = father.level + 1;
                father.son.Add(LMIDPAREN_94);
                Match(LMIDPAREN_94, Token.Tex.LMIDPAREN);//[


                Node exp_94 = new Node();
                exp_94.level = father.level + 1;
                exp_94.name = "Exp";
                exp_94.flag = 0;
                exp_94.vn = VN.Exp;
                father.son.Add(exp_94);
                Exp(exp_94);


                Node RMIDPAREN_94 = new Node();
                RMIDPAREN_94.level = father.level + 1;
                father.son.Add(RMIDPAREN_94);
                Match(RMIDPAREN_94, Token.Tex.RMIDPAREN);//]
            }
            else if (Predict.Predict[95].Contains(token.tex))//95
            {
                Node DOT_95 = new Node();
                DOT_95.level = father.level + 1;
                father.son.Add(DOT_95);
                Match(DOT_95, Token.Tex.DOT);//.


                Node fieldvar_95 = new Node();
                fieldvar_95.level = father.level + 1;
                fieldvar_95.name = "FieldVar";
                fieldvar_95.flag = 0;
                fieldvar_95.vn = VN.FieldVar;
                father.son.Add(fieldvar_95);
                FieldVar(fieldvar_95);
            }
            else
                error();
        }

        private void Variable(Node father)//92
        {
            if (Predict.Predict[92].Contains(token.tex))
            {
                Node ID_92 = new Node();
                ID_92.level = father.level + 1;
                father.son.Add(ID_92);
                Match(ID_92, Token.Tex.ID);//ID


                Node varimore_92 = new Node();
                varimore_92.level = father.level + 1;
                varimore_92.name = "VariMore";
                varimore_92.flag = 0;
                varimore_92.vn = VN.VariMore;
                father.son.Add(varimore_92);
                VariMore(varimore_92);
            }
            else
                error();
        }

        private void Factor(Node father)//89
        {
            if (Predict.Predict[89].Contains(token.tex))
            {
                Node LPAREN_89 = new Node();
                LPAREN_89.level = father.level + 1;
                father.son.Add(LPAREN_89);
                Match(LPAREN_89, Token.Tex.LPAREN);//(


                Node exp_89 = new Node();
                exp_89.level = father.level + 1;
                exp_89.name = "Exp";
                exp_89.flag = 0;
                exp_89.vn = VN.Exp;
                father.son.Add(exp_89);
                Exp(exp_89);


                Node RPAPEN_89 = new Node();
                RPAPEN_89.level = father.level + 1;
                father.son.Add(RPAPEN_89);
                Match(RPAPEN_89, Token.Tex.RPAPEN);//)
            }
            else if (Predict.Predict[90].Contains(token.tex))//90
            {
                Node INTC_90 = new Node();
                INTC_90.level = father.level + 1;
                father.son.Add(INTC_90);
                Match(INTC_90, Token.Tex.INTC);//INTC
            }
            else if (Predict.Predict[91].Contains(token.tex))//91
            {
                Node variable_91 = new Node();
                variable_91.level = father.level + 1;
                variable_91.name = "Variable";
                variable_91.flag = 0;
                variable_91.vn = VN.Variable;
                father.son.Add(variable_91);
                Variable(variable_91);
            }
            else
                error();
        }

        private void OtherFactor(Node father)//87
        {
            if (Predict.Predict[87].Contains(token.tex))
            {
                Node Null_87 = new Node();
                Null_87.level = father.level + 1;
                Null_87.flag = 0;
                Null_87.name = "Null";
                Null_87.vn = VN.Null;
                father.son.Add(Null_87); ;
            }
            else if (Predict.Predict[88].Contains(token.tex))//88
            {
                Node multop_88 = new Node();
                multop_88.level = father.level + 1;
                multop_88.name = "MultOp";
                multop_88.flag = 0;
                multop_88.vn = VN.MultOp;
                father.son.Add(multop_88);
                MultOp(multop_88);

                Node term_88 = new Node();
                term_88.level = father.level + 1;
                term_88.name = "Term";
                term_88.flag = 0;
                term_88.vn = VN.Term;
                father.son.Add(term_88);
                Term(term_88);
            }
            else
                error();
        }

        private void Term(Node father)//86
        {
            if (Predict.Predict[86].Contains(token.tex))
            {
                Node factor_86 = new Node();
                factor_86.level = father.level + 1;
                factor_86.name = "Factor";
                factor_86.flag = 0;
                factor_86.vn = VN.Factor;
                father.son.Add(factor_86);
                Factor(factor_86);

                Node otherfactor_86 = new Node();
                otherfactor_86.level = father.level + 1;
                otherfactor_86.name = "OtherFactor";
                otherfactor_86.flag = 0;
                otherfactor_86.vn = VN.OtherFactor;
                father.son.Add(otherfactor_86);
                OtherFactor(otherfactor_86);
            }
            else
                error();
        }

        private void OtherTerm(Node father)
        {
            if (Predict.Predict[84].Contains(token.tex))//84
            {
                Node Null_84 = new Node();
                Null_84.level = father.level + 1;
                Null_84.flag = 0;
                Null_84.name = "Null";
                Null_84.vn = VN.Null;
                father.son.Add(Null_84); ;
            }
            else if (Predict.Predict[85].Contains(token.tex))//85
            {
                Node addop_85 = new Node();
                addop_85.level = father.level + 1;
                addop_85.name = "AddOp";
                addop_85.flag = 0;
                addop_85.vn = VN.AddOp;
                father.son.Add(addop_85);
                AddOp(addop_85);

                Node exp_85 = new Node();
                exp_85.level = father.level + 1;
                exp_85.name = "Exp";
                exp_85.flag = 0;
                exp_85.vn = VN.Exp;
                father.son.Add(exp_85);
                Exp(exp_85);
            }
            else
                error();
        }

        private void Exp(Node father)//83
        {
            if (Predict.Predict[83].Contains(token.tex))
            {
                Node term_83 = new Node();
                term_83.level = father.level + 1;
                term_83.name = "Term";
                term_83.flag = 0;
                term_83.vn = VN.Term;
                father.son.Add(term_83);
                Term(term_83);

                Node otherterm_83 = new Node();
                otherterm_83.level = father.level + 1;
                otherterm_83.name = "OtherTerm";
                otherterm_83.flag = 0;
                otherterm_83.vn = VN.OtherTerm;
                father.son.Add(otherterm_83);
                OtherTerm(otherterm_83);
            }
            else
                error();
        }

        private void OtherRelE(Node father)//82
        {
            if (Predict.Predict[82].Contains(token.tex))
            {
                Node cmpop_82 = new Node();
                cmpop_82.level = father.level + 1;
                cmpop_82.name = "CmpOp";
                cmpop_82.flag = 0;
                cmpop_82.vn = VN.CmpOp;
                father.son.Add(cmpop_82);
                CmpOp(cmpop_82);

                Node exp_82 = new Node();
                exp_82.level = father.level + 1;
                exp_82.name = "Exp";
                exp_82.flag = 0;
                exp_82.vn = VN.Exp;
                father.son.Add(exp_82);
                Exp(exp_82);
            }
            else
                error();
        }

        private void RelExp(Node father)//81
        {
            if (Predict.Predict[81].Contains(token.tex))
            {
                Node exp_81 = new Node();
                exp_81.level = father.level + 1;
                exp_81.name = "Exp";
                exp_81.flag = 0;
                exp_81.vn = VN.Exp;
                father.son.Add(exp_81);
                Exp(exp_81);

                Node otherrele_81 = new Node();
                otherrele_81.level = father.level + 1;
                otherrele_81.name = "OtherRelE";
                otherrele_81.flag = 0;
                otherrele_81.vn = VN.OtherRelE;
                father.son.Add(otherrele_81);
                OtherRelE(otherrele_81);
            }
            else
                error();
        }

        private void ActParamMore(Node father)//79
        {
            if (Predict.Predict[79].Contains(token.tex))
            {
                Node Null_79 = new Node();
                Null_79.level = father.level + 1;
                Null_79.flag = 0;
                Null_79.name = "Null";
                Null_79.vn = VN.Null;
                father.son.Add(Null_79); ;
            }
            else if (Predict.Predict[80].Contains(token.tex))//80
            {
                Node COMMA_80 = new Node();
                COMMA_80.level = father.level + 1;
                father.son.Add(COMMA_80);
                Match(COMMA_80, Token.Tex.COMMA);//,


                Node actparamlist_80 = new Node();
                actparamlist_80.level = father.level + 1;
                actparamlist_80.name = "ActParamList";
                actparamlist_80.flag = 0;
                actparamlist_80.vn = VN.ActParamList;
                father.son.Add(actparamlist_80);
                ActParamList(actparamlist_80);
            }
            else
                error();
        }

        private void ActParamList(Node father)//77
        {
            if (Predict.Predict[77].Contains(token.tex))
            {
                Node Null_77 = new Node();
                Null_77.level = father.level + 1;
                Null_77.flag = 0;
                Null_77.name = "Null";
                Null_77.vn = VN.Null;
                father.son.Add(Null_77); ;
            }
            else if (Predict.Predict[78].Contains(token.tex))//78
            {
                Node exp_78 = new Node();
                exp_78.level = father.level + 1;
                exp_78.name = "Exp";
                exp_78.flag = 0;
                exp_78.vn = VN.Exp;
                father.son.Add(exp_78);
                Exp(exp_78);

                Node actparammore_78 = new Node();
                actparammore_78.level = father.level + 1;
                actparammore_78.name = "ActParamMore";
                actparammore_78.flag = 0;
                actparammore_78.vn = VN.ActParamMore;
                father.son.Add(actparammore_78);
                ActParamMore(actparammore_78);
            }
            else
                error();
        }

        private void CallStmRest(Node father)//76
        {
            if (Predict.Predict[76].Contains(token.tex))
            {
                Node LPAREN_76 = new Node();
                LPAREN_76.level = father.level + 1;
                father.son.Add(LPAREN_76);
                Match(LPAREN_76, Token.Tex.LPAREN);//(


                Node actparamlist_76 = new Node();
                actparamlist_76.level = father.level + 1;
                actparamlist_76.name = "ActParamList";
                actparamlist_76.flag = 0;
                actparamlist_76.vn = VN.ActParamList;
                father.son.Add(actparamlist_76);
                ActParamList(actparamlist_76);


                Node RPAPEN_76 = new Node();
                RPAPEN_76.level = father.level + 1;
                father.son.Add(RPAPEN_76);
                Match(RPAPEN_76, Token.Tex.RPAPEN);//)
            }
            else
                error();
        }

        private void ReturnStm(Node father)//75
        {
            if (Predict.Predict[75].Contains(token.tex))
            {
                Node RETURN1_75 = new Node();
                RETURN1_75.level = father.level + 1;
                father.son.Add(RETURN1_75);
                Match(RETURN1_75, Token.Tex.RETURN1);//RETURN
            }
            else
                error();
        }

        private void OutputStm(Node father)//74
        {
            if (Predict.Predict[74].Contains(token.tex))
            {
                Node WRITE_74 = new Node();
                WRITE_74.level = father.level + 1;
                father.son.Add(WRITE_74);
                Match(WRITE_74, Token.Tex.WRITE);//WRITE

                Node LPAREN_74 = new Node();
                LPAREN_74.level = father.level + 1;
                father.son.Add(LPAREN_74);
                Match(LPAREN_74, Token.Tex.LPAREN);//(

                Node Exp_74 = new Node();
                Exp_74.level = father.level + 1;
                Exp_74.name = "Exp";
                Exp_74.flag = 0;
                Exp_74.vn = VN.Exp;
                father.son.Add(Exp_74);
                Exp(Exp_74);

                Node RPAPEN_74 = new Node();
                RPAPEN_74.level = father.level + 1;
                father.son.Add(RPAPEN_74);
                Match(RPAPEN_74, Token.Tex.RPAPEN);//)
            }
            else
                error();
        }

        private void Invar(Node father)//73
        {
            if (Predict.Predict[73].Contains(token.tex))
            {
                Node ID_73 = new Node();
                ID_73.level = father.level + 1;
                father.son.Add(ID_73);
                Match(ID_73, Token.Tex.ID);//ID
            }
            else
                error();
        }

        private void InputStm(Node father)//72
        {
            if (Predict.Predict[72].Contains(token.tex))
            {
                Node READ_72 = new Node();
                READ_72.level = father.level + 1;
                father.son.Add(READ_72);
                Match(READ_72, Token.Tex.READ);//READ

                Node LPAREN_72 = new Node();
                LPAREN_72.level = father.level + 1;
                father.son.Add(LPAREN_72);
                Match(LPAREN_72, Token.Tex.LPAREN);//(

                Node Invar_72 = new Node();
                Invar_72.level = father.level + 1;
                Invar_72.name = "Invar";
                Invar_72.flag = 0;
                Invar_72.vn = VN.Invar;
                father.son.Add(Invar_72);
                Invar(Invar_72);

                Node RPAPEN_72 = new Node();
                RPAPEN_72.level = father.level + 1;
                father.son.Add(RPAPEN_72);
                Match(RPAPEN_72, Token.Tex.RPAPEN);//)
            }
            else
                error();
        }

        private void LoopStm(Node father)//71
        {
            if (Predict.Predict[71].Contains(token.tex))
            {
                Node WHILE_71 = new Node();
                WHILE_71.level = father.level + 1;
                father.son.Add(WHILE_71);
                Match(WHILE_71, Token.Tex.WHILE);//WHILE

                Node RelExp_71 = new Node();
                RelExp_71.level = father.level + 1;
                RelExp_71.name = "RelExp";
                RelExp_71.flag = 0;
                RelExp_71.vn = VN.RelExp;
                father.son.Add(RelExp_71);
                RelExp(RelExp_71);

                Node DO_71 = new Node();
                DO_71.level = father.level + 1;
                father.son.Add(DO_71);
                Match(DO_71, Token.Tex.DO);//DO

                Node StmList_71 = new Node();
                StmList_71.level = father.level + 1;
                StmList_71.name = "StmList";
                StmList_71.flag = 0;
                StmList_71.vn = VN.StmList;
                father.son.Add(StmList_71);
                StmList(StmList_71);

                Node ENDWH_71 = new Node();
                ENDWH_71.level = father.level + 1;
                father.son.Add(ENDWH_71);
                Match(ENDWH_71, Token.Tex.ENDWH);//ENDWH
            }
            else
                error();
        }

        private void ConditionalStm(Node father)//70
        {
            if (Predict.Predict[70].Contains(token.tex))
            {
                Node IF_70 = new Node();
                IF_70.level = father.level + 1;
                father.son.Add(IF_70);
                Match(IF_70, Token.Tex.IF);//IF

                Node RelExp_70 = new Node();
                RelExp_70.level = father.level + 1;
                RelExp_70.name = "RelExp";
                RelExp_70.flag = 0;
                RelExp_70.vn = VN.RelExp;
                father.son.Add(RelExp_70);
                RelExp(RelExp_70);

                Node THEN_70 = new Node();
                THEN_70.level = father.level + 1;
                father.son.Add(THEN_70);
                Match(THEN_70, Token.Tex.THEN);//THEN

                Node StmList_70 = new Node();
                StmList_70.level = father.level + 1;
                StmList_70.name = "StmList";
                StmList_70.flag = 0;
                StmList_70.vn = VN.StmList;
                father.son.Add(StmList_70);
                StmList(StmList_70);

                Node ELSE_70 = new Node();
                ELSE_70.level = father.level + 1;
                father.son.Add(ELSE_70);
                Match(ELSE_70, Token.Tex.ELSE);//ELSE

                Node StmList_70_ = new Node();
                StmList_70_.level = father.level + 1;
                StmList_70_.name = "StmList";
                StmList_70_.flag = 0;
                StmList_70_.vn = VN.StmList;
                father.son.Add(StmList_70_);
                StmList(StmList_70_);

                Node FI_70 = new Node();
                FI_70.level = father.level + 1;
                father.son.Add(FI_70);
                Match(FI_70, Token.Tex.FI);//FI
            }
        }

        private void AssignmentRest(Node father)//69
        {
            if (Predict.Predict[69].Contains(token.tex))
            {
                Node VariMore_69 = new Node();
                VariMore_69.level = father.level + 1;
                VariMore_69.name = "VariMore";
                VariMore_69.flag = 0;
                VariMore_69.vn = VN.VariMore;
                father.son.Add(VariMore_69);
                VariMore(VariMore_69);

                Node ASSIGN_69 = new Node();
                ASSIGN_69.level = father.level + 1;
                father.son.Add(ASSIGN_69);
                Match(ASSIGN_69, Token.Tex.ASSIGN);//:=

                Node Exp_69 = new Node();
                Exp_69.level = father.level + 1;
                Exp_69.name = "Exp";
                Exp_69.flag = 0;
                Exp_69.vn = VN.Exp;
                father.son.Add(Exp_69);
                Exp(Exp_69);
            }
            else
                error();
        }

        private void AssCall(Node father)//67
        {
            if (Predict.Predict[67].Contains(token.tex))
            {
                Node AssignmentRest_67 = new Node();
                AssignmentRest_67.level = father.level + 1;
                AssignmentRest_67.name = "AssignmentRest";
                AssignmentRest_67.flag = 0;
                AssignmentRest_67.vn = VN.AssignmentRest;
                father.son.Add(AssignmentRest_67);
                AssignmentRest(AssignmentRest_67);
            }
            else if (Predict.Predict[68].Contains(token.tex))//68
            {
                Node CallStmRest_68 = new Node();
                CallStmRest_68.level = father.level + 1;
                CallStmRest_68.name = "CallStmRest";
                CallStmRest_68.flag = 0;
                CallStmRest_68.vn = VN.CallStmRest;
                father.son.Add(CallStmRest_68);
                CallStmRest(CallStmRest_68);
            }
            else
                error();
        }

        private void Stm(Node father)//61
        {
            if (Predict.Predict[61].Contains(token.tex))
            {
                Node ConditionalStm_61 = new Node();
                ConditionalStm_61.level = father.level + 1;
                ConditionalStm_61.name = "ConditionalStm";
                ConditionalStm_61.flag = 0;
                ConditionalStm_61.vn = VN.ConditionalStm;
                father.son.Add(ConditionalStm_61);
                ConditionalStm(ConditionalStm_61);
            }
            else if (Predict.Predict[62].Contains(token.tex))//62
            {
                Node LoopStm_62 = new Node();
                LoopStm_62.level = father.level + 1;
                LoopStm_62.name = "LoopStm";
                LoopStm_62.flag = 0;
                LoopStm_62.vn = VN.LoopStm;
                father.son.Add(LoopStm_62);
                LoopStm(LoopStm_62);
            }
            else if (Predict.Predict[63].Contains(token.tex))//63
            {
                Node InputStm_63 = new Node();
                InputStm_63.level = father.level + 1;
                InputStm_63.name = "InputStm";
                InputStm_63.flag = 0;
                InputStm_63.vn = VN.InputStm;
                father.son.Add(InputStm_63);
                InputStm(InputStm_63);
            }
            else if (Predict.Predict[64].Contains(token.tex))//64
            {
                Node OutputStm_64 = new Node();
                OutputStm_64.level = father.level + 1;
                OutputStm_64.name = "OutputStm";
                OutputStm_64.flag = 0;
                OutputStm_64.vn = VN.OutputStm;
                father.son.Add(OutputStm_64);
                OutputStm(OutputStm_64);
            }
            else if (Predict.Predict[65].Contains(token.tex))//65
            {
                Node ReturnStm_65 = new Node();
                ReturnStm_65.level = father.level + 1;
                ReturnStm_65.name = "ReturnStm";
                ReturnStm_65.flag = 0;
                ReturnStm_65.vn = VN.ReturnStm;
                father.son.Add(ReturnStm_65);
                ReturnStm(ReturnStm_65);
            }
            else if (Predict.Predict[66].Contains(token.tex))//66
            {
                Node ID_66 = new Node();
                ID_66.level = father.level + 1;
                father.son.Add(ID_66);
                Match(ID_66, Token.Tex.ID);//ID

                Node AssCall_66 = new Node();
                AssCall_66.level = father.level + 1;
                AssCall_66.name = "AssCall";
                AssCall_66.flag = 0;
                AssCall_66.vn = VN.AssCall;
                father.son.Add(AssCall_66);
                AssCall(AssCall_66);
            }
            else
                error();
        }
        private void error()    //错误处理
        {
            if (token.content != null)
                error_inf.Add("第" + token.row + "行" + token.content + "存在语法错误");
            else
                error_inf.Add("第" + token.row + "行" + token.tex.ToString() + "存在语法错误");
        }


        public List<string> tree_str = new List<string>();
        void tostr(Node root)   //遍历root存到数组tree_str中
        {
            string str_temp = "";
            for (int i = 0; i < root.level; i++)
            {
                str_temp += "   ";
            }
            str_temp = str_temp + root.name + "\r\n";
            tree_str.Add(str_temp);
            if (root.son == null)
            {
                return;
            }
            foreach (Node ele in root.son)
            {
                tostr(ele);
            }
        }

        public void grammar()
        {
            ReadToken();
            Program_start();
            tostr(root);
        }
    }

    internal class LL1
    {
        private int[,] LL1_Table;
        private Token token;
        private Scanner scanner1;   //词法分析器结果
        private Dictionary<VN, List<int>> VN_List; //终极符和产生式的配对
        private Predict_SNL Predict;
        private Dictionary<int, List<Generator>> generators;  //产生式们
        public Node TREE;
        public List<string> error = new List<string>();

        private void Load_LL1()
        {
            int which = 0;
            int count_list = 0;
            int count_vt = 0;
            int vt_num = 0;

            for (int i = 0; i < 67; i++)
            {
                count_list = VN_List[(VN)i].Count;       //该非终极符对应的产生式个数
                for (int j = 0; j < count_list; j++)
                {
                    which = VN_List[(VN)i][j];   //产生式编号
                    count_vt = Predict.Predict[which].Count;  //该产生式的predict集的vt个数
                    for (int k = 0; k < count_vt; k++)
                    {
                        vt_num = (int)Predict.Predict[which][k]; //二维坐标
                        LL1_Table[i, vt_num] = which;
                    }
                }
            }
        }
        public LL1()
        {
            generators = new Dictionary<int, List<Generator>>();
            Predict = new Predict_SNL();
            LL1_Table = new int[69, 42];
            VN_List = new Dictionary<VN, List<int>>();
            List<int> list;
            list = new List<int> { 1 };
            VN_List.Add(VN.Program, list);

            list = new List<int> { 2 };
            VN_List.Add(VN.ProgramHead, list);

            list = new List<int> { 3 };
            VN_List.Add(VN.ProgramName, list);

            list = new List<int> { 4 };
            VN_List.Add(VN.DeclarePart, list);

            list = new List<int> { 5, 6 };
            VN_List.Add(VN.TypeDec, list);

            list = new List<int> { 7 };
            VN_List.Add(VN.TypeDeclaration, list);

            list = new List<int> { 8 };
            VN_List.Add(VN.TypeDecList, list);

            list = new List<int> { 9, 10 };
            VN_List.Add(VN.TypeDecMore, list);

            list = new List<int> { 11 };
            VN_List.Add(VN.TypeId, list);

            list = new List<int> { 12, 13, 14 };
            VN_List.Add(VN.TypeName, list);

            list = new List<int> { 15, 16 };
            VN_List.Add(VN.BaseType, list);

            list = new List<int> { 17, 18 };
            VN_List.Add(VN.StructType, list);

            list = new List<int> { 19 };
            VN_List.Add(VN.ArrayType, list);

            list = new List<int> { 20 };
            VN_List.Add(VN.Low, list);

            list = new List<int> { 21 };
            VN_List.Add(VN.Top, list);

            list = new List<int> { 22 };
            VN_List.Add(VN.RecType, list);

            list = new List<int> { 23, 24 };
            VN_List.Add(VN.FieldDecList, list);

            list = new List<int> { 25, 26 };
            VN_List.Add(VN.FieldDecMore, list);

            list = new List<int> { 27 };
            VN_List.Add(VN.IdList, list);

            list = new List<int> { 28, 29 };
            VN_List.Add(VN.IdMore, list);

            list = new List<int> { 30, 31 };
            VN_List.Add(VN.VarDec, list);

            list = new List<int> { 32 };
            VN_List.Add(VN.VarDeclaration, list);

            list = new List<int> { 33 };
            VN_List.Add(VN.VarDecList, list);

            list = new List<int> { 34, 35 };
            VN_List.Add(VN.VarDecMore, list);

            list = new List<int> { 36 };
            VN_List.Add(VN.VarIdList, list);

            list = new List<int> { 37, 38 };
            VN_List.Add(VN.VarIdMore, list);

            list = new List<int> { 39, 40 };
            VN_List.Add(VN.ProcDec, list);

            list = new List<int> { 41 };
            VN_List.Add(VN.ProcDeclaration, list);

            list = new List<int> { 42, 43 };
            VN_List.Add(VN.ProcDecMore, list);

            list = new List<int> { 44 };
            VN_List.Add(VN.ProcName, list);

            list = new List<int> { 45, 46 };
            VN_List.Add(VN.ParamList, list);

            list = new List<int> { 47 };
            VN_List.Add(VN.ParamDecList, list);

            list = new List<int> { 48, 49 };
            VN_List.Add(VN.ParamMore, list);

            list = new List<int> { 50, 51 };
            VN_List.Add(VN.Param, list);

            list = new List<int> { 52 };
            VN_List.Add(VN.FormList, list);

            list = new List<int> { 53, 54 };
            VN_List.Add(VN.FidMore, list);

            list = new List<int> { 55 };
            VN_List.Add(VN.ProcDecPart, list);

            list = new List<int> { 56 };
            VN_List.Add(VN.ProcBody, list);

            list = new List<int> { 57 };
            VN_List.Add(VN.ProgramBody, list);

            list = new List<int> { 58 };
            VN_List.Add(VN.StmList, list);

            list = new List<int> { 59, 60 };
            VN_List.Add(VN.StmMore, list);

            list = new List<int> { 61, 62, 63, 64, 65, 66 };
            VN_List.Add(VN.Stm, list);

            list = new List<int> { 67, 68 };
            VN_List.Add(VN.AssCall, list);

            list = new List<int> { 69 };
            VN_List.Add(VN.AssignmentRest, list);

            list = new List<int> { 70 };
            VN_List.Add(VN.ConditionalStm, list);

            list = new List<int> { 71 };
            VN_List.Add(VN.LoopStm, list);

            list = new List<int> { 72 };
            VN_List.Add(VN.InputStm, list);

            list = new List<int> { 73 };
            VN_List.Add(VN.Invar, list);

            list = new List<int> { 74 };
            VN_List.Add(VN.OutputStm, list);

            list = new List<int> { 75 };
            VN_List.Add(VN.ReturnStm, list);

            list = new List<int> { 76 };
            VN_List.Add(VN.CallStmRest, list);

            list = new List<int> { 77, 78 };
            VN_List.Add(VN.ActParamList, list);

            list = new List<int> { 79, 80 };
            VN_List.Add(VN.ActParamMore, list);

            list = new List<int> { 81 };
            VN_List.Add(VN.RelExp, list);

            list = new List<int> { 82 };
            VN_List.Add(VN.OtherRelE, list);

            list = new List<int> { 83 };
            VN_List.Add(VN.Exp, list);

            list = new List<int> { 84, 85 };
            VN_List.Add(VN.OtherTerm, list);

            list = new List<int> { 86 };
            VN_List.Add(VN.Term, list);

            list = new List<int> { 87, 88 };
            VN_List.Add(VN.OtherFactor, list);

            list = new List<int> { 89, 90, 91 };
            VN_List.Add(VN.Factor, list);

            list = new List<int> { 92 };
            VN_List.Add(VN.Variable, list);

            list = new List<int> { 93, 94, 95 };
            VN_List.Add(VN.VariMore, list);

            list = new List<int> { 96 };
            VN_List.Add(VN.FieldVar, list);

            list = new List<int> { 97, 98 };
            VN_List.Add(VN.FieldVarMore, list);

            list = new List<int> { 99, 100 };
            VN_List.Add(VN.CmpOp, list);

            list = new List<int> { 101, 102 };
            VN_List.Add(VN.AddOp, list);

            list = new List<int> { 103, 104 };
            VN_List.Add(VN.MultOp, list);

            Generator part;                             //1
            List<Generator> gene = new List<Generator>();
            part = new Generator(0, VN.ProgramHead);
            gene.Add(part);
            part = new Generator(0, VN.DeclarePart);
            gene.Add(part);
            part = new Generator(0, VN.ProgramBody);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.DOT);
            gene.Add(part);
            generators.Add(1, gene);

            gene = new List<Generator>();
            part = new Generator(1, VN.END, Token.Tex.PROGRAM);   //2
            gene.Add(part);
            part = new Generator(0, VN.ProgramName);
            gene.Add(part);
            generators.Add(2, gene);

            gene = new List<Generator>();           //3
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            generators.Add(3, gene);

            gene = new List<Generator>();        //4
            part = new Generator(0, VN.TypeDec);
            gene.Add(part);
            part = new Generator(0, VN.VarDec);
            gene.Add(part);
            part = new Generator(0, VN.ProcDec);
            gene.Add(part);
            generators.Add(4, gene);

            gene = new List<Generator>();         //5
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(5, gene);

            gene = new List<Generator>();       //6
            part = new Generator(0, VN.TypeDeclaration);
            gene.Add(part);
            generators.Add(6, gene);

            gene = new List<Generator>();       //7
            part = new Generator(1, VN.END, Token.Tex.TYPE);
            gene.Add(part);
            part = new Generator(0, VN.TypeDecList);
            gene.Add(part);
            generators.Add(7, gene);

            gene = new List<Generator>();  //8
            part = new Generator(0, VN.TypeId);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.EQ);
            gene.Add(part);
            part = new Generator(0, VN.TypeName);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.TypeDecMore);
            gene.Add(part);
            generators.Add(8, gene);

            gene = new List<Generator>();   //9 
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(9, gene);

            gene = new List<Generator>(); //10
            part = new Generator(0, VN.TypeDecList);
            gene.Add(part);
            generators.Add(10, gene);

            gene = new List<Generator>();  //11
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            generators.Add(11, gene);

            gene = new List<Generator>();  //12
            part = new Generator(0, VN.BaseType);
            gene.Add(part);
            generators.Add(12, gene);

            gene = new List<Generator>();   //13
            part = new Generator(0, VN.StructType);
            gene.Add(part);
            generators.Add(13, gene);

            gene = new List<Generator>();   //14
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            generators.Add(14, gene);

            gene = new List<Generator>();    //15
            part = new Generator(1, VN.END, Token.Tex.INTEGER);
            gene.Add(part);
            generators.Add(15, gene);

            gene = new List<Generator>();    //16
            part = new Generator(1, VN.END, Token.Tex.CHAR1);
            gene.Add(part);
            generators.Add(16, gene);

            gene = new List<Generator>();    //17
            part = new Generator(0, VN.ArrayType);
            gene.Add(part);
            generators.Add(17, gene);

            gene = new List<Generator>();    //18
            part = new Generator(0, VN.RecType);
            gene.Add(part);
            generators.Add(18, gene);

            gene = new List<Generator>();   //19
            part = new Generator(1, VN.END, Token.Tex.ARRAY);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.LMIDPAREN);
            gene.Add(part);
            part = new Generator(0, VN.Low);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.UNDERANGE);
            gene.Add(part);
            part = new Generator(0, VN.Top);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RMIDPAREN);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.OF);
            gene.Add(part);
            part = new Generator(0, VN.BaseType);
            gene.Add(part);
            generators.Add(19, gene);

            gene = new List<Generator>();         //20
            part = new Generator(1, VN.END, Token.Tex.INTC);
            gene.Add(part);
            generators.Add(20, gene);

            gene = new List<Generator>();         //21
            part = new Generator(1, VN.END, Token.Tex.INTC);
            gene.Add(part);
            generators.Add(21, gene);

            gene = new List<Generator>();         //22
            part = new Generator(1, VN.END, Token.Tex.RECORD);
            gene.Add(part);
            part = new Generator(0, VN.FieldDecList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.END1);
            gene.Add(part);
            generators.Add(22, gene);

            gene = new List<Generator>();         //23
            part = new Generator(0, VN.BaseType);
            gene.Add(part);
            part = new Generator(0, VN.IdList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.FieldDecMore);
            gene.Add(part);
            generators.Add(23, gene);

            gene = new List<Generator>();         //24
            part = new Generator(0, VN.ArrayType);
            gene.Add(part);
            part = new Generator(0, VN.IdList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.FieldDecMore);
            gene.Add(part);
            generators.Add(24, gene);

            gene = new List<Generator>();         //25
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(25, gene);

            gene = new List<Generator>();         //26
            part = new Generator(0, VN.FieldDecList);
            gene.Add(part);
            generators.Add(26, gene);

            gene = new List<Generator>();         //27
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            part = new Generator(0, VN.IdMore);
            gene.Add(part);
            generators.Add(27, gene);

            gene = new List<Generator>();         //28
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(28, gene);

            gene = new List<Generator>();         //29
            part = new Generator(1, VN.END, Token.Tex.COMMA);
            gene.Add(part);
            part = new Generator(0, VN.IdList);
            gene.Add(part);
            generators.Add(29, gene);

            gene = new List<Generator>();         //30
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(30, gene);

            gene = new List<Generator>();         //31
            part = new Generator(0, VN.VarDeclaration);
            gene.Add(part);
            generators.Add(31, gene);

            gene = new List<Generator>();         //32
            part = new Generator(1, VN.END, Token.Tex.VAR);
            gene.Add(part);
            part = new Generator(0, VN.VarDecList);
            gene.Add(part);
            generators.Add(32, gene);

            gene = new List<Generator>();         //33
            part = new Generator(0, VN.TypeName);
            gene.Add(part);
            part = new Generator(0, VN.VarIdList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.VarDecMore);
            gene.Add(part);
            generators.Add(33, gene);

            gene = new List<Generator>();         //34
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(34, gene);

            gene = new List<Generator>();       //35
            part = new Generator(0, VN.VarDecList);
            gene.Add(part);
            generators.Add(35, gene);

            gene = new List<Generator>();       //36
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            part = new Generator(0, VN.VarIdMore);
            gene.Add(part);
            generators.Add(36, gene);

            gene = new List<Generator>();       //37
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(37, gene);

            gene = new List<Generator>();       //38
            part = new Generator(1, VN.END, Token.Tex.COMMA);
            gene.Add(part);
            part = new Generator(0, VN.VarIdList);
            gene.Add(part);
            generators.Add(38, gene);

            gene = new List<Generator>();       //39
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(39, gene);

            gene = new List<Generator>();       //40
            part = new Generator(0, VN.ProcDeclaration);
            gene.Add(part);
            generators.Add(40, gene);

            gene = new List<Generator>();       //41
            part = new Generator(1, VN.END, Token.Tex.PROCEDURE);
            gene.Add(part);
            part = new Generator(0, VN.ProcName);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.LPAREN);
            gene.Add(part);
            part = new Generator(0, VN.ParamList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RPAPEN);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.ProcDecPart);
            gene.Add(part);
            part = new Generator(0, VN.ProcBody);
            gene.Add(part);
            part = new Generator(0, VN.ProcDecMore);
            gene.Add(part);
            generators.Add(41, gene);

            gene = new List<Generator>();       //42
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(42, gene);

            gene = new List<Generator>();       //43
            part = new Generator(0, VN.ProcDeclaration);
            gene.Add(part);
            generators.Add(43, gene);

            gene = new List<Generator>();       //44
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            generators.Add(44, gene);

            gene = new List<Generator>();       //45
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(45, gene);

            gene = new List<Generator>();       //46
            part = new Generator(0, VN.ParamDecList);
            gene.Add(part);
            generators.Add(46, gene);

            gene = new List<Generator>();       //47
            part = new Generator(0, VN.Param);
            gene.Add(part);
            part = new Generator(0, VN.ParamMore);
            gene.Add(part);
            generators.Add(47, gene);

            gene = new List<Generator>();       //48
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(48, gene);

            gene = new List<Generator>();       //49
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.ParamDecList);
            gene.Add(part);
            generators.Add(49, gene);

            gene = new List<Generator>();       //50
            part = new Generator(0, VN.TypeName);
            gene.Add(part);
            part = new Generator(0, VN.FormList);
            gene.Add(part);
            generators.Add(50, gene);

            gene = new List<Generator>();       //51
            part = new Generator(1, VN.END, Token.Tex.VAR);
            gene.Add(part);
            part = new Generator(0, VN.TypeName);
            gene.Add(part);
            part = new Generator(0, VN.FormList);
            gene.Add(part);
            generators.Add(51, gene);

            gene = new List<Generator>();       //52
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            part = new Generator(0, VN.FidMore);
            gene.Add(part);
            generators.Add(52, gene);

            gene = new List<Generator>();       //53
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(53, gene);

            gene = new List<Generator>();       //54
            part = new Generator(1, VN.END, Token.Tex.COMMA);
            gene.Add(part);
            part = new Generator(0, VN.FormList);
            gene.Add(part);
            generators.Add(54, gene);

            gene = new List<Generator>();       //55
            part = new Generator(0, VN.DeclarePart);
            gene.Add(part);
            generators.Add(55, gene);

            gene = new List<Generator>();       //56
            part = new Generator(0, VN.ProgramBody);
            gene.Add(part);
            generators.Add(56, gene);

            gene = new List<Generator>();       //57
            part = new Generator(1, VN.END, Token.Tex.BEGIN1);
            gene.Add(part);
            part = new Generator(0, VN.StmList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.END1);
            gene.Add(part);
            generators.Add(57, gene);

            gene = new List<Generator>();       //58
            part = new Generator(0, VN.Stm);
            gene.Add(part);
            part = new Generator(0, VN.StmMore);
            gene.Add(part);
            generators.Add(58, gene);

            gene = new List<Generator>();       //59
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(59, gene);

            gene = new List<Generator>();       //60
            part = new Generator(1, VN.END, Token.Tex.SEMI);
            gene.Add(part);
            part = new Generator(0, VN.StmList);
            gene.Add(part);
            generators.Add(60, gene);

            gene = new List<Generator>();       //61
            part = new Generator(0, VN.ConditionalStm);
            gene.Add(part);
            generators.Add(61, gene);

            gene = new List<Generator>();       //62
            part = new Generator(0, VN.LoopStm);
            gene.Add(part);
            generators.Add(62, gene);

            gene = new List<Generator>();       //63
            part = new Generator(0, VN.InputStm);
            gene.Add(part);
            generators.Add(63, gene);

            gene = new List<Generator>();       //64
            part = new Generator(0, VN.OutputStm);
            gene.Add(part);
            generators.Add(64, gene);

            gene = new List<Generator>();       //65
            part = new Generator(0, VN.ReturnStm);
            gene.Add(part);
            generators.Add(65, gene);

            gene = new List<Generator>();       //66
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            part = new Generator(0, VN.AssCall);
            gene.Add(part);
            generators.Add(66, gene);

            gene = new List<Generator>();       //67
            part = new Generator(0, VN.AssignmentRest);
            gene.Add(part);
            generators.Add(67, gene);

            gene = new List<Generator>();       //68
            part = new Generator(0, VN.CallStmRest);
            gene.Add(part);
            generators.Add(68, gene);

            gene = new List<Generator>();       //69
            part = new Generator(0, VN.VariMore);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.ASSIGN);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            generators.Add(69, gene);

            gene = new List<Generator>();       //70
            part = new Generator(1, VN.END, Token.Tex.IF);
            gene.Add(part);
            part = new Generator(0, VN.RelExp);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.THEN);
            gene.Add(part);
            part = new Generator(0, VN.StmList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.ELSE);
            gene.Add(part);
            part = new Generator(0, VN.StmList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.FI);
            gene.Add(part);
            generators.Add(70, gene);

            gene = new List<Generator>();       //71
            part = new Generator(1, VN.END, Token.Tex.WHILE);
            gene.Add(part);
            part = new Generator(0, VN.RelExp);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.DO);
            gene.Add(part);
            part = new Generator(0, VN.StmList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.ENDWH);
            gene.Add(part);
            generators.Add(71, gene);

            gene = new List<Generator>();       //72
            part = new Generator(1, VN.END, Token.Tex.READ);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.LPAREN);
            gene.Add(part);
            part = new Generator(0, VN.Invar);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RPAPEN);
            gene.Add(part);
            generators.Add(72, gene);

            gene = new List<Generator>();       //73
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            generators.Add(73, gene);

            gene = new List<Generator>();       //74
            part = new Generator(1, VN.END, Token.Tex.WRITE);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.LPAREN);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RPAPEN);
            gene.Add(part);
            generators.Add(74, gene);

            gene = new List<Generator>();  //75
            part = new Generator(1, VN.END, Token.Tex.RETURN1);
            gene.Add(part);
            generators.Add(75, gene);

            gene = new List<Generator>();  //76
            part = new Generator(1, VN.END, Token.Tex.LPAREN);
            gene.Add(part);
            part = new Generator(0, VN.ActParamList);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RPAPEN);
            gene.Add(part);
            generators.Add(76, gene);

            gene = new List<Generator>();  //77
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(77, gene);

            gene = new List<Generator>();  //78
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            part = new Generator(0, VN.ActParamMore);
            gene.Add(part);
            generators.Add(78, gene);

            gene = new List<Generator>();  //79
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(79, gene);

            gene = new List<Generator>();  //80
            part = new Generator(1, VN.END, Token.Tex.COMMA);
            gene.Add(part);
            part = new Generator(0, VN.ActParamList);
            gene.Add(part);
            generators.Add(80, gene);

            gene = new List<Generator>();  //81
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            part = new Generator(0, VN.OtherRelE);
            gene.Add(part);
            generators.Add(81, gene);

            gene = new List<Generator>();  //82
            part = new Generator(0, VN.CmpOp);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            generators.Add(82, gene);

            gene = new List<Generator>();  //83
            part = new Generator(0, VN.Term);
            gene.Add(part);
            part = new Generator(0, VN.OtherTerm);
            gene.Add(part);
            generators.Add(83, gene);

            gene = new List<Generator>();  //84
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(84, gene);

            gene = new List<Generator>();  //85
            part = new Generator(0, VN.AddOp);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            generators.Add(85, gene);

            gene = new List<Generator>();  //86
            part = new Generator(0, VN.Factor);
            gene.Add(part);
            part = new Generator(0, VN.OtherFactor);
            gene.Add(part);
            generators.Add(86, gene);

            gene = new List<Generator>();  //87
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(87, gene);

            gene = new List<Generator>();  //88
            part = new Generator(0, VN.MultOp);
            gene.Add(part);
            part = new Generator(0, VN.Term);
            gene.Add(part);
            generators.Add(88, gene);

            gene = new List<Generator>();  //89
            part = new Generator(1, VN.END, Token.Tex.LPAREN);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RPAPEN);
            gene.Add(part);
            generators.Add(89, gene);

            gene = new List<Generator>();  //90
            part = new Generator(1, VN.END, Token.Tex.INTC);
            gene.Add(part);
            generators.Add(90, gene);

            gene = new List<Generator>();  //91
            part = new Generator(0, VN.Variable);
            gene.Add(part);
            generators.Add(91, gene);

            gene = new List<Generator>();  //92
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            part = new Generator(0, VN.VariMore);
            gene.Add(part);
            generators.Add(92, gene);

            gene = new List<Generator>();  //93
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(93, gene);

            gene = new List<Generator>();  //94
            part = new Generator(1, VN.END, Token.Tex.LMIDPAREN);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RMIDPAREN);
            gene.Add(part);
            generators.Add(94, gene);

            gene = new List<Generator>();  //95
            part = new Generator(1, VN.END, Token.Tex.DOT);
            gene.Add(part);
            part = new Generator(0, VN.FieldVar);
            gene.Add(part);
            generators.Add(95, gene);

            gene = new List<Generator>();  //96
            part = new Generator(1, VN.END, Token.Tex.ID);
            gene.Add(part);
            part = new Generator(0, VN.FieldVarMore);
            gene.Add(part);
            generators.Add(96, gene);

            gene = new List<Generator>();  //97
            part = new Generator(0, VN.Null);
            gene.Add(part);
            generators.Add(97, gene);

            gene = new List<Generator>();  //98
            part = new Generator(1, VN.END, Token.Tex.LMIDPAREN);
            gene.Add(part);
            part = new Generator(0, VN.Exp);
            gene.Add(part);
            part = new Generator(1, VN.END, Token.Tex.RMIDPAREN);
            gene.Add(part);
            generators.Add(98, gene);

            gene = new List<Generator>();  //99
            part = new Generator(1, VN.END, Token.Tex.LT);
            gene.Add(part);
            generators.Add(99, gene);

            gene = new List<Generator>();  //100
            part = new Generator(1, VN.END, Token.Tex.EQ);
            gene.Add(part);
            generators.Add(100, gene);

            gene = new List<Generator>();  //101
            part = new Generator(1, VN.END, Token.Tex.PLUS);  //+
            gene.Add(part);
            generators.Add(101, gene);

            gene = new List<Generator>();  //102
            part = new Generator(1, VN.END, Token.Tex.MINUS);
            gene.Add(part);
            generators.Add(102, gene);

            gene = new List<Generator>();  //103
            part = new Generator(1, VN.END, Token.Tex.TIMES); //*
            gene.Add(part);
            generators.Add(103, gene);

            gene = new List<Generator>();  //104
            part = new Generator(1, VN.END, Token.Tex.OVER);
            gene.Add(part);
            generators.Add(104, gene);


        }

        public int StackMatch()
        {
            Stack<Generator> LL1_stack = new Stack<Generator>();     //LL1分析栈
            Stack<Node> Tree_stack = new Stack<Node>();              //辅助语法树建立

            Generator first = new Generator(1, VN.END, Token.Tex.ENDFILE);
            Node root_node = new Node();
            root_node.level = 0;
            root_node.name = "ENDFILE";

            LL1_stack.Push(first);         //压入程序结束符号
            Tree_stack.Push(root_node);    //压入根节点

            first = new Generator(0, VN.Program);
            TREE = new Node();
            TREE.level = 0;
            TREE.name = "Program";
            TREE.vn = VN.Program;
            TREE.flag = 0;
            LL1_stack.Push(first);
            Tree_stack.Push(TREE);    //压入根节点

            Generator topVN;
            Node topNode;
            int generate_num = 0;
            int vn_vt = 0;
            int read_stream = 0;
            topNode = Tree_stack.Peek();

            while (read_stream < scanner1.token_list.Count)
            {
                token = scanner1.token_list[read_stream];
                if (LL1_stack.Count == 0)
                {
                    error.Add("LL1栈已空，存在语法错误，退出语法分析");
                    return -1;
                }
                topVN = LL1_stack.Pop();
                if (Tree_stack.Count > 0 && topNode.name != "ENDFILE")
                { topNode = Tree_stack.Pop(); }
                vn_vt = topVN.flag;
                if (vn_vt == 0)                 //非终极符
                {
                    if (topVN.vn == VN.Null)
                        continue;

                    generate_num = LL1_Table[(int)topVN.vn, (int)scanner1.token_list[read_stream].tex];   //查表寻找产生式
                    if (generate_num == 0)
                    {
                        error.Add("找不到可用产生式，存在语法错误，退出语法分析");
                        return -1;

                    }
                    int genlen = generators[generate_num].Count;

                    for (int i = 0; i < genlen; i++)
                    {
                        Generator symbol = generators[generate_num][i];
                        Node son_node = new Node();
                        if (symbol.flag == 0)
                        {
                            son_node.name = symbol.vn.ToString();
                        }
                        else
                        {
                            son_node.name = symbol.vt.ToString();
                        }
                        son_node.vn = symbol.vn;
                        son_node.flag = symbol.flag;
                        son_node.level = topNode.level + 1;
                        topNode.son.Add(son_node);


                    }
                    for (int i = genlen - 1; i >= 0; i--)   //反向压栈
                    {
                        Generator symbol = generators[generate_num][i];
                        LL1_stack.Push(symbol);
                        Tree_stack.Push(topNode.son[i]);
                    }

                }
                else
                {
                    if (scanner1.token_list[read_stream].tex == topVN.vt)
                    {
                        if (scanner1.token_list[read_stream].tex == Token.Tex.ENDFILE)
                        {
                            if (LL1_stack.Count == 0 && topVN.vt == Token.Tex.ENDFILE)
                                return 0;
                            else
                            {
                                error.Add("栈中存在未匹配的元素，语法存在错误，退出语法分析");
                                return -1;
                            }
                        }
                        if (scanner1.token_list[read_stream].content == null)
                        {
                            topNode.name = scanner1.token_list[read_stream].tex.ToString();
                        }
                        else
                        {
                            topNode.name = scanner1.token_list[read_stream].content;
                        }
                        topNode.flag = 1;
                        topNode.token = scanner1.token_list[read_stream];
                        read_stream++;
                    }
                    else
                    {
                        error.Add("当前token与栈顶元素不匹配，存在语法错误，退出语法分析");
                        return -1;
                    }
                }

            }
            if (LL1_stack.Count == 0)
                return 0;
            else
            {
                error.Add("栈中存在未匹配的元素，语法存在错误，退出语法分析");
                return -1;
            }
        }

        public List<string> tree_str = new List<string>();
        void tostr(Node root)   //遍历root存到数组tree_str中
        {
            string str_temp = "";
            for (int i = 0; i < root.level; i++)
            {
                str_temp += "   ";
            }
            str_temp = str_temp + root.name + "\r\n";
            tree_str.Add(str_temp);
            if (root.son == null)
            {
                return;
            }
            foreach (Node ele in root.son)
            {
                tostr(ele);
            }
        }
        public void LL1_main(Scanner scanner)
        {
            scanner1 = scanner;
            token = scanner.token_list[0];
            Load_LL1();
            StackMatch();
            tostr(TREE);
        }


    }
    public enum VN
    {
        Program, ProgramHead, ProgramName, DeclarePart, TypeDec, TypeDeclaration, TypeDecList, TypeDecMore, TypeId,
        TypeName, BaseType, StructType, ArrayType, Low, Top, RecType, FieldDecList, FieldDecMore, IdList,
        IdMore, VarDec, VarDeclaration, VarDecList, VarDecMore, VarIdList, VarIdMore, ProcDec, ProcDeclaration,
        ProcDecMore, ProcName, ParamList, ParamDecList, ParamMore, Param, FormList, FidMore, ProcDecPart, ProcBody,
        ProgramBody, StmList, StmMore, Stm, AssCall, AssignmentRest, ConditionalStm, LoopStm,
        InputStm, Invar, OutputStm, ReturnStm, CallStmRest, ActParamList, ActParamMore, RelExp, OtherRelE, Exp,
        OtherTerm, Term, OtherFactor, Factor, Variable, VariMore, FieldVar, FieldVarMore, CmpOp, AddOp, MultOp,
        Null, END              //END即为#
    };

    internal class Generator
    {
        public int flag;
        public VN vn;
        public Token.Tex vt;
        public Generator(int n, VN vn = VN.END, Token.Tex vt = Token.Tex.ENDFILE)
        {
            this.flag = n;
            this.vn = vn;
            this.vt = vt;
        }
    }
}