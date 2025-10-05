using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFD
{
    enum IdKind { typeKind, varKind, procKind }
    enum AccessKind { dir, indir }
    internal class VarAttr
    {
        public AccessKind accessKind = AccessKind.dir;
        public int level = 0;
        public int off = 0;
    }

    internal class aParam
    {
        public string name;
        public int whichtype = 0;
    }
    internal class ProcAttr
    {
        public int level = 0;
        public int code = 0;
        public int key_reg = 0;
        public Dictionary<int, aParam> ParamTable = new Dictionary<int, aParam>();  // 形参列表，存形参在类型表的位置
        public int size = 0;
    }
    class AttributeIR
    {
        public int typeIR = 0;     //标识符类型内部表示表的下标
        public IdKind kind = IdKind.typeKind;      //标识符的类别，区分类型，变量，过程
        public VarAttr varAttr = new VarAttr();
        public ProcAttr procAttr = new ProcAttr();
    }

    enum TypeKind { intTy, charTy, arrayTy, recordTy, boolTy }
    class ArrayAttr
    {
        public int indexTy = 0;         //类型信息表的下标
        public int elemTy = 0;
    }

    class Field
    {
        public string idname;
        public int unitType = 0;   //类型信息表的下标
        public int offset = 0;
    }
    class typeIR
    {
        public int size = 0;
        public TypeKind kind;
        public ArrayAttr arrayAttr = new ArrayAttr();             //数组
        public List<Field> FieldList = new List<Field>();  //结构体
    }

    enum DecKind { BaseType, StructureType, ID }
    class SymbTable
    {
        public string idname;
        public AttributeIR attrIR = new AttributeIR();
    }
    internal class Semantic     //语义分析
    {
        List<SymbTable> newTable = new List<SymbTable>();
        List<List<SymbTable>> Scope = new List<List<SymbTable>>(); //scope栈
        List<typeIR> TypeTable = new List<typeIR>();        //类型的内部表示
        public List<string> error = new List<string>();   //错误信息
        public List<List<string>> STables = new List<List<string>>();//符号表
        List<int> Offset = new List<int>();
        int level = -1;
        int[] Entry = new int[2];
        typeIR newtype = new typeIR();
        AccessKind Ekind;
        Node Tree;
        public Semantic(Node tree)
        {
            Entry[0] = -1;
            Entry[1] = -1;
            Tree = tree;
        }

        public void CreateTable()            // 当进入一个局部化单位时建立一张新表
        {
            newTable = new List<SymbTable>();
            Scope.Add(newTable);          //压入scope栈
            Offset.Add(7);
            level++;
        }

        public void DestroyTable()      //撤销一个表
        {
            PrintSymbTable();
            if (level >= 0)
            {
                Scope.Remove(Scope[level]);
                Offset.Remove(Offset[level]);
                level--;
            }
        }

        public bool Enter(SymbTable symb)    //将一个表项登记到当前表   SUN
        {
            bool present = FindEntry(symb.idname, 0);
            if (present == true)
            {
                //标识符重复声明
                string error_item = symb.idname.ToString();
                error_item += " 标识符重复声明";
                error.Add(error_item);
                return false;
            }
            else
            {
                SymbTable new_symb = new SymbTable();
                new_symb.idname = symb.idname;
                new_symb.attrIR = symb.attrIR;
                if (level < 0)
                    return false;
                Scope[level].Add(new_symb);
                Entry[0] = level;
                Entry[1] = Scope[level].Count - 1;
                if (symb.attrIR.kind == IdKind.procKind)
                {
                    Offset[level] += 7;
                }
                else if (symb.attrIR.kind == IdKind.typeKind)
                {
                    Offset[level] += 1;
                }
                else
                    if (new_symb.attrIR.typeIR != -1)
                    Offset[level] += TypeTable[new_symb.attrIR.typeIR].size;
                return true;
            }
        }

        public bool FindEntry(string idname, int flag)   //根据flag值查找表里是否出现过idname,0在当前表找，1找所有
        {
            if (flag == 0)
            {
                return SearchoneTable(idname, level);
            }
            else
            {
                for (int i = 0; i <= level; i++)
                    if ((SearchoneTable(idname, i)) == true)
                        return SearchoneTable(idname, i);
            }
            Entry[0] = -1;
            Entry[1] = -1;
            return false;
        }

        public bool SearchoneTable(string idname, int currentLevel)  //在表中找标识符
        {
            if (currentLevel >= 0 && currentLevel < Scope.Count)
            {
                for (int i = 0; i < Scope[currentLevel].Count; i++)
                {
                    if (idname == Scope[currentLevel][i].idname)
                    {
                        Entry[0] = currentLevel;
                        Entry[1] = i;
                        return true;
                    }
                }
                Entry[0] = -1;
                Entry[1] = -1;
                return false;
            }
            Entry[0] = -1;
            Entry[1] = -1;
            return false;
        }

        public int findField(string id, List<Field> fields)   //在域表中查找域名,找到了返回索引值，否则返回-1
        {
            int len = fields.Count;
            for (int i = 0; i < len; i++)
                if (fields[i].idname == id)
                    return i;
            return -1;
        }

        public void PrintSymbTable()
        {
            List<string> newline = new List<string>();
            newline.Add("\r\n");
            newline.Add("************************ " + level.ToString() + " ************************");
            STables.Add(newline);
            if (level < 0)
                return;
            for (int i = 0; i < Scope[level].Count; i++)
            {
                newline = new List<string>();
                newline.Add("标识符名称:");
                newline.Add(Scope[level][i].idname);
                newline.Add("    ");
                newline.Add("内部类型:");
                newline.Add(Scope[level][i].attrIR.typeIR.ToString());
                newline.Add("    ");
                newline.Add("类型:");
                newline.Add(Scope[level][i].attrIR.kind.ToString());
                newline.Add("    ");
                if (Scope[level][i].attrIR.kind == IdKind.varKind)//如果是变量
                {
                    newline.Add("accessKind:");
                    newline.Add(Scope[level][i].attrIR.varAttr.accessKind.ToString());
                    newline.Add("    ");
                    newline.Add("level:");
                    newline.Add(Scope[level][i].attrIR.varAttr.level.ToString());
                    newline.Add("    ");
                    newline.Add("offset:");
                    newline.Add(Scope[level][i].attrIR.varAttr.off.ToString());
                    newline.Add("    ");
                }
                if (Scope[level][i].attrIR.kind == IdKind.procKind)//如果是过程标识符
                {
                    newline.Add("level:");
                    newline.Add(Scope[level][i].attrIR.procAttr.level.ToString());
                    newline.Add("    ");
                    newline.Add("code:");
                    newline.Add(Scope[level][i].attrIR.procAttr.code.ToString());
                    newline.Add("    ");
                    newline.Add("size:");
                    newline.Add(Scope[level][i].attrIR.procAttr.size.ToString());
                    newline.Add("    ");
                    STables.Add(newline);
                    newline = new List<string>();
                    newline.Add("\r\n");
                    newline.Add("    ParamTable");
                    newline.Add("\r\n");
                    foreach (int key in Scope[level][i].attrIR.procAttr.ParamTable.Keys)
                    {
                        newline.Add("            ");
                        newline.Add(Scope[level][i].attrIR.procAttr.ParamTable[key].name.ToString());
                        newline.Add("    内部类型:");
                        newline.Add(Scope[level][i].attrIR.procAttr.ParamTable[key].whichtype.ToString());
                    }
                    STables.Add(newline);//符号表
                    continue;
                }
                STables.Add(newline);//符号表
            }
        }

        public void PrintTypeTable()
        {
            List<string> newline = new List<string>();
            newline.Add("\r\n");
            newline.Add("###################### " + "TypeTable" + " ######################");
            STables.Add(newline);
            for (int i = 0; i < TypeTable.Count; i++)
            {
                newline = new List<string>();
                newline.Add(i.ToString());
                newline.Add("    ");
                newline.Add("size:");
                newline.Add(TypeTable[i].size.ToString());
                newline.Add("    ");
                newline.Add("kind:");
                newline.Add(TypeTable[i].kind.ToString());
                newline.Add("    ");
                if (TypeTable[i].kind == TypeKind.arrayTy)
                {
                    newline.Add("indexTy:");
                    newline.Add(TypeTable[i].arrayAttr.indexTy.ToString());
                    newline.Add("elemTy:");
                    newline.Add(TypeTable[i].arrayAttr.elemTy.ToString());
                }
                if (TypeTable[i].kind == TypeKind.recordTy)
                {
                    for (int j = 0; j < TypeTable[i].FieldList.Count; j++)
                    {
                        newline.Add("name:");
                        newline.Add(TypeTable[i].FieldList[j].idname.ToString());
                        newline.Add("    unitType:");
                        newline.Add(TypeTable[i].FieldList[j].unitType.ToString());
                        newline.Add("    offset:");
                        newline.Add(TypeTable[i].FieldList[j].offset.ToString());
                        newline.Add("            ");

                    }
                }
                STables.Add(newline);
            }
        }
        public void Analyze(Node Treenode)        //主程序
        {
            CreateTable();
            initialize();
            Node DeclarePart = Treenode.son[1];
            Node ProgramBody = Treenode.son[2];
            Node TypeDec_n = DeclarePart.son[0];
            Node VarDec_n = DeclarePart.son[1];
            Node ProcDec_n = DeclarePart.son[2];
            TypeDec(TypeDec_n.son[0]);            //typedeclaration
            VarDecList(VarDec_n.son[0]);          //vardeclaration
            ProcDec(ProcDec_n.son[0]);            //procdeclaration
            Body(ProgramBody.son[1]);
            DestroyTable();
            PrintTypeTable();
        }

        private void initialize()    //初始化
        {
            newtype.kind = TypeKind.intTy;
            newtype.size = 1;
            TypeTable.Add(newtype);
            newtype = new typeIR();
            newtype.kind = TypeKind.charTy;
            newtype.size = 1;
            TypeTable.Add(newtype);
            newtype = new typeIR();
            newtype.kind = TypeKind.boolTy;
            newtype.size = 1;
            TypeTable.Add(newtype);
        }

        private int TypeProcess(Node Treenode)         //处理当前节点的类型,返回类型信息表的索引,TypeName
        {
            if (Treenode.son[0].flag == 1)
                return nameType(Treenode);
            if (Treenode.son[0].flag == 0 && Treenode.son[0].vn == VN.BaseType)
            {
                if (Treenode.son[0].son[0].token.tex == Token.Tex.INTEGER)
                    return 0;
                if (Treenode.son[0].son[0].token.tex == Token.Tex.CHAR1)
                    return 1;
            }
            if (Treenode.son[0].flag == 0 && Treenode.son[0].vn == VN.StructType)
            {
                if (Treenode.son[0].son[0].vn == VN.ArrayType)
                    return arrayType(Treenode.son[0].son[0]);
                if (Treenode.son[0].son[0].vn == VN.RecType)
                    return recordType(Treenode.son[0].son[0]);
            }
            return -1;
        }

        private int TypeProcess_2(Node Treenode, string decKind)         //处理当前节点的类型,返回类型信息表的索引,TypeName
        {

            if (decKind == "BaseType")
            {
                if (Treenode.son[0].flag == 1 && Treenode.son[0].token.tex == Token.Tex.INTEGER)
                    return 0;
                if (Treenode.son[0].flag == 1 && Treenode.son[0].token.tex == Token.Tex.CHAR1)
                    return 1;
            }
            if (decKind == "StructureType")
            {
                if (Treenode.son[0].flag == 0 && Treenode.son[0].vn == VN.ArrayType)
                    return arrayType(Treenode.son[0]);
                if (Treenode.son[0].flag == 0 && Treenode.son[0].vn == VN.RecType)
                    return recordType(Treenode.son[0]);
            }
            return -1;
        }

        private int nameType(Node Treenode)    //查找自定义类型 typename      SUN
        {
            bool present = FindEntry(Treenode.son[0].name, 1);
            if (present == false)
            {
                string error_item = "第";
                error_item += Treenode.son[0].token.row.ToString();
                error_item += "行 ";
                error_item += Treenode.son[0].name.ToString();
                error_item += " 类型标识符未声明";
                error.Add(error_item);
                return -1;
            }
            else
            {
                IdKind node_kind = Scope[Entry[0]][Entry[1]].attrIR.kind;
                if (node_kind != IdKind.typeKind)
                {
                    string error_item = "第";
                    error_item += Treenode.son[0].token.row.ToString();
                    error_item += "行 ";
                    error_item += Treenode.son[0].name.ToString();
                    error_item += " 非类型标识符";
                    error.Add(error_item);
                    return -1;
                }
                else
                {
                    int re = Scope[Entry[0]][Entry[1]].attrIR.typeIR;
                    return re;
                }
            }
        }

        private int arrayType(Node Treenode)     //TypeName=StructureType,StructureType=ArrayType
        {
            int low = Treenode.son[2].son[0].token.content_num;
            int high = Treenode.son[4].son[0].token.content_num;
            if (high < low)
            {
                error.Add("第" + Treenode.son[0].token.row.ToString() + "行，数组下标越界");
                return -1;
            }
            int type_index = 0;
            int type = TypeProcess_2(Treenode.son[7], "BaseType");
            if (type == -1)
                return -1;
            typeIR newtype = new typeIR();
            newtype.kind = TypeKind.arrayTy;
            newtype.size = TypeTable[type].size * (high - low + 1);
            newtype.arrayAttr.indexTy = type_index;
            newtype.arrayAttr.elemTy = type;
            TypeTable.Add(newtype);
            return TypeTable.Count - 1;
        }

        private int recordType(Node Treenode)             //对应节点RecType
        {

            typeIR newtype = new typeIR();
            newtype.kind = TypeKind.recordTy;
            Node FieldDecList = Treenode.son[1];
            Node FieldDecMore = FieldDecList.son[3];
            int size = 0;
            while (FieldDecList.vn != VN.Null)
            {
                int type = 0;
                if (FieldDecList.son[0].vn == VN.BaseType)
                    type = TypeProcess_2(FieldDecList.son[0], "BaseType");
                else
                    type = arrayType(FieldDecList.son[0]);
                Node temp_id = FieldDecList.son[1];               //idlist
                int temp_off = 0;
                while (temp_id.vn != VN.Null)
                {
                    if (temp_id.son[0].name.Length > 10)
                        error.Add("第" + temp_id.son[0].token.row.ToString() + "行,标识符超过长度");
                    Field field = new Field();
                    field.idname = temp_id.son[0].name;
                    field.unitType = type;
                    field.offset = size;
                    if (type == -1)
                        size += 0;
                    else
                        size += TypeTable[type].size;
                    temp_off++;
                    newtype.FieldList.Add(field);
                    Node idmore = temp_id.son[1];
                    if (idmore.son[0].vn == VN.Null)
                        break;
                    else
                    {
                        temp_id = idmore.son[1];
                    }
                }
                FieldDecMore = FieldDecList.son[3];
                FieldDecList = FieldDecMore.son[0];
            }
            newtype.size = size;
            TypeTable.Add(newtype);
            return TypeTable.Count - 1;
        }

        private void TypeDec(Node Treenode)     //类型声明部分分析处理函数,typedeclaration    SUN
        {
            if (Treenode.vn == VN.Null)
            {
                return;
            }
            else
            {
                SymbTable new_item = new SymbTable();
                Node new_Treenode = Treenode.son[1];    //TypeDecList
                if (Treenode.vn == VN.TypeDeclaration)
                    new_Treenode = Treenode.son[1];    //TypeDecList
                else
                    new_Treenode = Treenode;
                new_item.idname = new_Treenode.son[0].son[0].name;
                new_item.attrIR.typeIR = TypeProcess(new_Treenode.son[2]);  //TypeName;
                new_item.attrIR.kind = IdKind.typeKind;
                if (level >= 0)
                    new_item.attrIR.varAttr.off = Offset[level];
                bool present = Enter(new_item);          //
                if (present == true)
                {
                    new_Treenode = new_Treenode.son[4].son[0];
                    TypeDec(new_Treenode);
                }
            }
        }

        private void VarDecList(Node Treenode)        //变量声明部分分析处理  VarDeclaration/空
        {
            if (Treenode.vn == VN.Null)
            {
                ;
            }
            else
            {
                Node pTreenode = Treenode;
                if (pTreenode.vn == VN.VarDeclaration)
                    pTreenode = pTreenode.son[1]; //VarDecList
                Node idTreenode = pTreenode.son[1];//VarIdList
                int ptr = TypeProcess(pTreenode.son[0]);  //TypeName调用类型处理函数
                while (idTreenode.vn != VN.Null)
                {
                    SymbTable new_item = new SymbTable();
                    //如果是直接变
                    new_item.attrIR.varAttr.level = level;      //记录层数
                    new_item.attrIR.typeIR = ptr;
                    new_item.attrIR.varAttr.off = Offset[level];  //偏移量加变量类型的size

                    new_item.idname = idTreenode.son[0].name;//名字
                    new_item.attrIR.kind = IdKind.varKind;//变量类型
                    bool present = Enter(new_item);
                    if (present == false)
                    {
                        //重复定义
                    }
                    if (idTreenode.son[1].son[0].vn == VN.Null)  //如果为空
                        idTreenode = idTreenode.son[1].son[0];
                    else
                        idTreenode = idTreenode.son[1].son[1];
                }
                pTreenode = pTreenode.son[3].son[0];
                VarDecList(pTreenode);
            }
        }

        private void ProcDec(Node Treenode)     //ok,过程声明部分分析处理函数,ProcDeclaration或空   SUN
        {
            if (Treenode.vn == VN.Null)
            {
                ;
            }
            else
            {
                HeadProcess(Treenode);
                TypeDec(Treenode.son[6].son[0].son[0].son[0]);            //typedec
                VarDecList(Treenode.son[6].son[0].son[1].son[0]);            //vardec
                ProcDec(Treenode.son[6].son[0].son[2].son[0]);               //procdec
                Body(Treenode.son[7].son[0].son[1]);                     //stmlist
                DestroyTable();
                Node Treenode_2 = Treenode.son[8].son[0];
                ProcDec(Treenode_2);
            }
        }

        private void HeadProcess(Node Treenode)   //过程声明头，ProcDeclaration或空   SUN
        {
            if (Treenode.vn != VN.Null)
            {
                SymbTable new_item = new SymbTable();
                new_item.idname = Treenode.son[1].son[0].name;
                new_item.attrIR.kind = IdKind.procKind;
                new_item.attrIR.typeIR = -1;   //无返回类型
                new_item.attrIR.procAttr.level = level;
                if (level >= 0)
                    new_item.attrIR.varAttr.off = Offset[level];
                Enter(new_item);
                ParamDecList(Treenode.son[3].son[0]);
            }
        }

        private void ParamDecList(Node Treenode)    //ParamDecList或空   SUN
        {
            CreateTable();
            while (true)
            {
                if (Treenode.vn == VN.Null)
                {
                    break;
                }
                else
                {
                    Node temp = Treenode;
                    if (Treenode.son[0].son[0].token.tex == Token.Tex.VAR)   //参数变量
                    {
                        temp = temp.son[0].son[2];           //FormList
                        while (true)
                        {
                            SymbTable new_item = new SymbTable();
                            new_item.idname = temp.son[0].name;
                            new_item.attrIR.kind = IdKind.varKind;
                            new_item.attrIR.typeIR = TypeProcess(Treenode.son[0].son[1]);          //TypeName
                            new_item.attrIR.varAttr.accessKind = AccessKind.indir;
                            new_item.attrIR.varAttr.level = level;
                            if (level >= 0)
                            {
                                new_item.attrIR.varAttr.off = Offset[level];
                                Offset[level] += TypeTable[new_item.attrIR.typeIR].size;
                            }
                            int pos = 0;
                            if (level > 0)
                                pos = Scope[level - 1].Count - 1;
                            aParam param = new aParam();
                            param.name = new_item.idname;
                            param.whichtype = new_item.attrIR.typeIR;
                            if (pos >= 0)
                            {
                                Scope[level - 1][pos].attrIR.procAttr.ParamTable.Add(Scope[level - 1][pos].attrIR.procAttr.key_reg, param);
                                Scope[level - 1][pos].attrIR.procAttr.key_reg++;
                            }
                            Enter(new_item);
                            if (temp.son[1].son[0].vn == VN.Null)
                            {
                                break;
                            }
                            else
                            {
                                temp = temp.son[1].son[1];
                            }
                        }
                    }
                    else   //值变量
                    {
                        temp = temp.son[0].son[1];
                        while (true)
                        {
                            SymbTable new_item = new SymbTable();
                            new_item.idname = temp.son[0].name;
                            new_item.attrIR.kind = IdKind.varKind;
                            new_item.attrIR.typeIR = TypeProcess(Treenode.son[0].son[0]);
                            new_item.attrIR.varAttr.accessKind = AccessKind.dir;
                            new_item.attrIR.varAttr.level = level;
                            int pos = 0;
                            if (level > 0)
                                pos = Scope[level - 1].Count - 1;
                            aParam param = new aParam();
                            param.name = new_item.idname;
                            param.whichtype = new_item.attrIR.typeIR;
                            Scope[level - 1][pos].attrIR.procAttr.ParamTable.Add(Scope[level - 1][pos].attrIR.procAttr.key_reg, param);
                            Scope[level - 1][pos].attrIR.procAttr.key_reg++;
                            if (Scope[level].Count == 0)
                            {
                                new_item.attrIR.varAttr.off = Offset[level];
                            }
                            else
                            {
                                SymbTable tem = Scope[level][Scope[level].Count - 1];
                                new_item.attrIR.varAttr.off = tem.attrIR.varAttr.off + TypeTable[tem.attrIR.typeIR].size;
                            }
                            Enter(new_item);
                            if (temp.son[1].son[0].vn == VN.Null)
                            {
                                break;
                            }
                            else
                            {
                                temp = temp.son[1].son[1];
                            }
                        }
                    }
                    if (Treenode.son[1].son[0].vn == VN.Null)
                    {
                        break;
                    }
                    else
                    {
                        Treenode = Treenode.son[1].son[1];
                    }
                }
            }
        }

        private void Body(Node Treenode)     //执行体部分分析处理函数 stmlist
        {
            Node tempnode = Treenode;
            while (tempnode.vn != VN.Null)
            {
                Statement(tempnode.son[0]);
                tempnode = tempnode.son[1];   //stmmore
                if (tempnode.son[0].vn == VN.Null)
                    break;
                tempnode = tempnode.son[1];
            }
        }

        private void Statement(Node Treenode)     //语句序列声明部分分析处理函数 STM
        {
            if (Treenode.son[0].flag == 0)
            {
                switch (Treenode.son[0].vn)
                {
                    case VN.ConditionalStm:
                        ifstatement(Treenode.son[0]);
                        break;
                    case VN.LoopStm:
                        whilestatement(Treenode.son[0]);
                        break;
                    case VN.InputStm:
                        readstatement(Treenode.son[0]);
                        break;
                    case VN.OutputStm:
                        writestatement(Treenode.son[0]);
                        break;
                    case VN.ReturnStm:
                        returnstatement(Treenode.son[0]);
                        break;
                    default: break;
                }
            }
            else
            {
                if (Treenode.son[1].son[0].vn == VN.CallStmRest)
                    callstatement(Treenode);
                else
                    assignstatement(Treenode);
            }
        }

        private int Term(Node Treenode)        //term
        {
            Node Factor = Treenode.son[0];
            Node OtherFactor = Treenode.son[1];
            if (OtherFactor.son[0].flag == 0 && OtherFactor.son[0].vn == VN.Null)
            {
                if (Factor.son[0].flag == 1 && Factor.son[0].token.tex == Token.Tex.INTC)
                {
                    Ekind = AccessKind.dir;
                    return 0;
                }
                else if (Factor.son[0].flag == 1 && Factor.son[0].token.tex == Token.Tex.LPAREN)
                    return Expr(Factor.son[1]);
                else
                {
                    Ekind = AccessKind.indir;
                    Node vari = Factor.son[0];
                    Node varimore = vari.son[1];
                    if (varimore.son[0].vn == VN.Null)         //是单个普通变量
                    {
                        string idd = vari.son[0].token.content;
                        if (FindEntry(idd, 1) == false)          //没找到
                        {
                            error.Add("第" + vari.son[0].token.row.ToString() + "行" + vari.son[0].token.content + "未定义");
                            return -1;
                        }
                        else
                        {
                            if (Scope[Entry[0]][Entry[1]].attrIR.kind != IdKind.varKind)
                            {
                                error.Add("第" + vari.son[0].token.row.ToString() + "行" + vari.son[0].token.content + "不是变量类型");
                                return -1;
                            }
                            return Scope[Entry[0]][Entry[1]].attrIR.typeIR;
                        }

                    }
                    else                 //是数组或记录
                    {
                        if (varimore.son[0].flag == 1 && varimore.son[0].token.tex == Token.Tex.LMIDPAREN)  //数组的情况
                        {
                            return arrayVar(vari);
                        }
                        else
                        {
                            return recordVar(vari);
                        }
                    }
                }
            }
            else                                         //otherfactor!=null
            {
                int factortype;
                if (Factor.son[0].flag == 1 && Factor.son[0].token.tex == Token.Tex.INTC)
                {
                    Ekind = AccessKind.dir;
                    factortype = 0;
                }
                else if (Factor.son[0].flag == 1 && Factor.son[0].token.tex == Token.Tex.LPAREN)
                    factortype = Expr(Factor.son[1]);
                else
                {
                    Ekind = AccessKind.indir;
                    Node vari = Factor.son[0];
                    Node varimore = vari.son[1];
                    if (varimore.son[0].vn == VN.Null)         //是单个普通变量
                    {
                        string idd = vari.son[0].token.content;
                        if (FindEntry(idd, 1) == false)          //没找到
                        {
                            error.Add("第" + vari.son[0].token.row.ToString() + "行" + vari.son[0].token.content + "未定义");
                            return -1;
                        }
                        else
                        {
                            if (Scope[Entry[0]][Entry[1]].attrIR.kind != IdKind.varKind)
                            {
                                error.Add("第" + vari.son[0].token.row.ToString() + "行" + vari.son[0].token.content + "不是变量类型");
                                return -1;
                            }
                            else
                                factortype = Scope[Entry[0]][Entry[1]].attrIR.typeIR;
                        }

                    }
                    else                 //是数组或记录
                    {
                        if (varimore.son[0].flag == 1 && varimore.son[0].token.tex == Token.Tex.LMIDPAREN)  //数组的情况
                        {
                            factortype = arrayVar(vari);
                        }
                        else
                        {
                            factortype = recordVar(vari);
                        }
                    }
                }
                if (factortype != 0)
                {
                    error.Add("表达式操作数类型不匹配");
                    return -1;
                }
                if (factortype != Term(OtherFactor.son[1]))
                {
                    error.Add("表达式操作数类型不匹配");
                    return -1;
                }
                else { Ekind = AccessKind.dir; return 0; }
            }
        }

        private int Expr(Node Treenode)     //返回类型信息表的索引  //EXP,return出错
        {
            Node term = Treenode.son[0];
            Node Otherterm = Treenode.son[1];
            if (Otherterm.son[0].flag == 0 && Otherterm.son[0].vn == VN.Null)    //只有term
                return Term(term);
            else
            {
                int term_type = Term(term);
                if (term_type != 0)
                {
                    return -1;
                }
                if (term_type != Expr(Otherterm.son[1]))
                {
                    error.Add("表达式中操作数类型不匹配");
                    return -1;
                }
                else
                { Ekind = AccessKind.dir; }
                return 0;
            }
        }

        private int arrayVar(Node Treenode)     //返回类型信息表的索引  Treenode=Variable
        {

            if (FindEntry(Treenode.son[0].name, 1))//符号表中查找标识符 ID
            {
                if (Scope[Entry[0]][Entry[1]].attrIR.kind == IdKind.varKind)//判断是变量
                {
                    int type = Scope[Entry[0]][Entry[1]].attrIR.typeIR;
                    TypeKind typeKind = TypeTable[type].kind;
                    if (typeKind == TypeKind.arrayTy)//判断是否为数组变量
                    {
                        int exp_ty = Expr(Treenode.son[1].son[1]);
                        if (exp_ty == -1)
                        {
                            return -1;
                        }
                        if (TypeTable[exp_ty].kind == TypeKind.intTy) //下标类型相符exp int型
                        {
                            return TypeTable[type].arrayAttr.elemTy;
                        }
                        else
                        {
                            error.Add("第" + Treenode.son[1].son[1].token.row + "行" + Treenode.son[1].son[1].name + "与下标类型不相符");
                        }
                    }
                    else
                    {
                        error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].name + "不是数组变量");
                    }
                }
                else
                {
                    error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].name + "不是变量");
                }
            }
            else
            {
                error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].name + "在符号表中未找到此标识符");
            }
            return -1;
        }

        private int recordVar(Node Treenode)     //返回类型信息表的索引Treenode=Variable
        {
            if (FindEntry(Treenode.son[0].name, 1))
            {
                if (Scope[Entry[0]][Entry[1]].attrIR.kind == IdKind.varKind)//判断是变量
                {
                    int type = Scope[Entry[0]][Entry[1]].attrIR.typeIR;
                    if (type == -1)//在标识符类型内部表示表的下标
                        return -1;
                    TypeKind typeKind = TypeTable[type].kind;     //类型
                    if (typeKind == TypeKind.recordTy)//判断是否为记录变量
                    {
                        int index = findField(Treenode.son[1].son[1].son[0].name, TypeTable[type].FieldList);  //
                        if (index != -1)//是否是合法域名
                        {
                            if (Treenode.son[1].son[1].son[1].vn == VN.Null)    //仅为.ID
                                return TypeTable[type].FieldList[index].unitType;//
                            else                                                                              //为.ID[]
                                return TypeTable[TypeTable[type].FieldList[index].unitType].arrayAttr.elemTy;
                        }
                        else
                        {
                            error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[1].son[1].son[0].name + "不是合法域名");
                        }
                    }
                    else
                    {
                        error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].name + "不是记录变量");
                    }
                }
                else
                {
                    error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].name + "不是变量");
                }
            }
            else
            {
                error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].name + "在符号表中未找到此标识符");
            }
            return -1;//有错误

        }

        private void assignstatement(Node Treenode)     //赋值语句部分分析处理函数,stm   SUN
        {
            bool re = FindEntry(Treenode.son[0].name, 1);
            Node temp = Treenode.son[1].son[0];
            int LEptr = -1;
            int REptr = -1;
            if (re)
            {
                SymbTable left = Scope[Entry[0]][Entry[1]];
                if (temp.son[0].son[0].vn == VN.Null)
                {
                    if (left.attrIR.kind == IdKind.varKind)   //ID是变量类型
                    {
                        LEptr = left.attrIR.typeIR;
                    }
                    else
                    {
                        string error_item = "第";
                        error_item += Treenode.son[0].token.row.ToString();
                        error_item += "行";
                        error_item += Treenode.son[0].name;
                        error_item += "不允许该类型的标识符出现在赋值号左端";
                        error.Add(error_item);
                        return;
                    }
                }
                else    //数组或记录
                {
                    if (left.attrIR.typeIR == -1)
                    {
                        error.Add("第" + Treenode.son[0].token.row.ToString() + "行，表达式左端数组非法引用");
                        return;
                    }
                    if (TypeTable[left.attrIR.typeIR].kind == TypeKind.arrayTy)
                    {
                        if(left.attrIR.typeIR==-1)
                        {
                            error.Add("第"+ Treenode.son[0].token.row.ToString()+"行，表达式左端数组非法引用");
                            return;
                        }
                        LEptr = TypeTable[left.attrIR.typeIR].arrayAttr.elemTy;
                    }
                    else
                    {
                        if (TypeTable[left.attrIR.typeIR].kind == TypeKind.recordTy)
                        {
                            if (left.attrIR.typeIR == -1)
                            {
                                error.Add("第" + Treenode.son[0].token.row.ToString() + "行，表达式左端域非法引用");
                                return;
                            }
                            int field_index = findField(temp.son[0].son[1].son[0].name, TypeTable[left.attrIR.typeIR].FieldList);
                            if (field_index == -1)
                            {
                                error.Add("第" + Treenode.son[0].token.row.ToString() + "行，表达式左端域非法引用");
                                return; }
                            LEptr = TypeTable[left.attrIR.typeIR].FieldList[field_index].unitType;
                        }
                        else
                        {
                            string error_item = "第";
                            error_item += Treenode.son[0].token.row.ToString();
                            error_item += "行 ";
                            error_item += Treenode.son[0].name;
                            error_item += "该类型不被允许";
                            error.Add(error_item);
                            return;
                        }
                    }
                }
            }
            else    //没找到
            {
                string error_item = "第";
                error_item += Treenode.son[0].token.row.ToString();
                error_item += "行 ";
                error_item += Treenode.son[0].name;
                error_item += "标识符未声明";
                error.Add(error_item);
                return;
            }
            REptr = Expr(temp.son[2]);
            if (REptr != LEptr)
            {
                string error_item = "第";
                error_item += Treenode.son[0].token.row.ToString();
                error_item += "行 ";
                error_item += "赋值号两端类型不匹配";
                error.Add(error_item);
                return;
            }
        }

        private void callstatement(Node Treenode)     //过程调用部分分析处理函数
        {
            if (FindEntry(Treenode.son[0].token.content, 1) == false)
            {
                error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].token.content + "未定义");
                return;
            }
            if (Scope[Entry[0]][Entry[1]].attrIR.kind != IdKind.procKind)
            {
                error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].token.content + "不是过程名");
                return;
            }
            Node CallstmRest = Treenode.son[1].son[0];
            Node ActParamList = CallstmRest.son[1];
            Node ActParamMore = ActParamList.son[0];
            Dictionary<int, aParam> paralist = Scope[Entry[0]][Entry[1]].attrIR.procAttr.ParamTable;
            if (ActParamList.son[0].vn != VN.Null)
                ;
            else                          //不传参
            {
                if (paralist.Count == 0)
                    return;
                else
                    error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].token.content + "缺少参数");
            }
            int reg = 0;
            while (ActParamList.son[0].vn != VN.Null)
            {
                ActParamMore = ActParamList.son[1];
                
                if (reg >= paralist.Count)
                {
                    error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].token.content + "调用参数过多");
                    return;
                }
                if (Expr(ActParamList.son[0]) != paralist[reg].whichtype)
                {
                    error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].token.content + "参数类型不匹配");
                }
                reg++;
                if (ActParamMore.son[0].vn != VN.Null)
                    ActParamList = ActParamMore.son[1];
                else
                {
                    if (paralist.Count > reg)
                    {
                        error.Add("第" + Treenode.son[0].token.row + "行" + Treenode.son[0].token.content + "调用参数过少");
                        return;
                    }
                    return;
                }
            }
        }

        private void ifstatement(Node Treenode)     //条件分析处理函数 conditionalstm
        {
            Node RelExp = Treenode.son[1];
            Node ThenStm = Treenode.son[3];
            Node ElseStm = Treenode.son[5];
            if (Expr(RelExp.son[0]) != 0)
            {
                error.Add("第" + Treenode.son[0].token.row + "行if表达式的条件必须是整型的关系运算");
            }
            Node OtherRel = RelExp.son[1];
            if (Expr(OtherRel.son[1]) != 0)
            {
                error.Add("第" + Treenode.son[0].token.row + "行if表达式的条件必须是整型的关系运算");
            }
            Body(ThenStm);
            Body(ElseStm);
        }

        private void whilestatement(Node Treenode)     //循环分析处理函数
        {
            Node RelExp = Treenode.son[1];
            Node DoStm = Treenode.son[3];
            if (Expr(RelExp.son[0]) != 0)
            {
                error.Add("第" + Treenode.son[0].token.row + "行if表达式的条件必须是整型的关系运算");
            }
            Node OtherRel = RelExp.son[1];
            if (Expr(OtherRel.son[1]) != 0)
            {
                error.Add("第" + Treenode.son[0].token.row + "行if表达式的条件必须是整型的关系运算");
            }
            Body(DoStm);
        }

        private void readstatement(Node Treenode)     //读语句分析处理函数InPut
        {
            if (FindEntry(Treenode.son[2].son[0].name, 1))
            {
                if (Scope[Entry[0]][Entry[1]].attrIR.kind == IdKind.varKind)//Id是变量标识符
                {
                    return;
                }
                else
                {
                    error.Add("第" + Treenode.son[2].son[0].token.row + "行" + Treenode.son[2].son[0].token.content + "不是变量标识符");
                }
            }
            else
            {
                error.Add("第" + Treenode.son[2].son[0].token.row + "行" + Treenode.son[2].son[0].token.content + "在符号表中未找到标识符");
            }
        }

        private void writestatement(Node Treenode)     //写语句分析处理函数OutPut
        {
            int ptr = Expr(Treenode.son[2]);
            if (ptr == -1)
                return;
            if (TypeTable[ptr].kind == TypeKind.boolTy)//如果为bool类型 错误
            {
                error.Add("第" + Treenode.son[2].token.row + "行写条件表达式为bool类型");
            }
            else
            {
                return;
            }
        }

        private void returnstatement(Node Treenode)   //返回
        {
            return;
        }
    }
}