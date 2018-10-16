using System.Linq;

namespace ExcelImageInsert
{
    public class NameUnit
    {
        private char[] Units = new char[] 
        {
            '个',
            '斤',
            '两',
            '套',
            '打',
            '副',
            '幅',
            '张',
            '台',
            '根',
            '只',
            '袋',
            '扎',
            '件',
            '瓶',
            '米',
            '箱',
            '双',
            '盒'
        };
        private char[] CnNumber = new char[] 
        {
            '一','二','三','四','五','六','七','八','九','十'
        };
        public int GetNumber(string name)
        {
            for(int i = 0; i < name.Length; i++)
            {
                if(CnNumber.Contains(name[i]) && i < name.Length - 1)
                {
                    if(Units.Contains(name[i+1]))
                    {
                        return CnNumber.ToList().IndexOf(name[i]) + 1;
                    }
                }
            }

            //单位在最后
            if (Units.Contains(name[name.Length - 1]))
            {
                int j = name.Length - 2;
                while (char.IsDigit(name[j]))
                {
                    j--;
                }
                
                int value = int.Parse(name.Substring(j+1,name.Length - 1 - j - 1));
                return value;
            }

            return 0;
        }
    }
}
