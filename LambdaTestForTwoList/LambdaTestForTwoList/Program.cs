namespace LambdaTestForTwoList
{
    public class Program
    {
        /// <summary>
        /// 兩個List中找出日期且id相等的項目
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] nameList = { "測試1", "測試2", "測試3" };
            List<ModelA> dataListA = CreateDataA(nameList);
            List<ModelB> dataListB = CreateDataB(nameList);
            var same = dataListA.Where(x => dataListB.Any(y => x.id == y.id && x.date == y.date));
        }
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<ModelA> CreateDataA(string[] input)
        {
            List<ModelA> result = new List<ModelA>();
            for (int i = 1; i <= 20; i++)
            {
                ModelA a = new ModelA() { id = i.ToString() };
                Random random = new Random();
                a.name = input[random.Next(input.Length)];
                if (i <= 10)
                    a.date = DateTime.Now.ToString("yyyyMMdd");
                else 
                    a.date = DateTime.Now.AddDays(1).ToString("yyyyMMdd");
                result.Add(a);
            }
            return result;
        }
        /// <summary>
        /// 新增類別B資料
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<ModelB> CreateDataB(string[] input)
        {
            List<ModelB> result = new List<ModelB>();
            for (int i = 1; i <= 15; i++)
            {
                ModelB b = new ModelB() { id = i.ToString(), date = DateTime.Now.ToString("yyyyMMdd")};
                Random random = new Random();
                b.name = input[random.Next(input.Length)];
                result.Add(b);  
            }
            return result;
        }
    }
    /// <summary>
    /// 類別A
    /// </summary>
    public class ModelA
    { 
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

    }
    /// <summary>
    /// 類別B
    /// </summary>
    public class ModelB
    { 
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
    }
}