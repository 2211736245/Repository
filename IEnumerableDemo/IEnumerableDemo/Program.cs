using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();//实例化一个对象
            // 通过foreach来调用Person yield return出来的值
            foreach (string item in person) // 这边可以根据return的值类型来写接收类型。本次return出来的是string
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        public class Person : IEnumerable
        {

            private string[] m = new string[] { "123", "456", "789", "abc" };//定义一个string类型的一维数组
            // 得到一个“枚举器”
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < m.Length; i++)
                {
                    // 使用yield return语句可一次返回一个元素
                    // 通过 foreach 语句来使用迭代器方法。 foreach 循环的每次迭代都会调用迭代器方法。
                    //迭代器方法运行到 yield return 语句时，会返回一个 expression，并保留当前在代码中的位置。 
                    //下次调用迭代器函数时，将从该位置重新开始执行。
                    yield return m[i];
                }
            }
        }
    }
}
