using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// 멀티스레드를 공부하기위한 프로젝트
/// 시작일 : 2018년 06월 05일
/// 종료일 : 
/// </summary>
namespace MultyThreadStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            object lock1 = new object();
            object lock2 = new object();

            new Thread(() => Day1.LockTooMuch(lock1, lock2)).Start();

            lock(lock2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Monitor.try enter allow not to get ");
                if(Monitor.TryEnter(lock1,TimeSpan.FromSeconds(5)))
                {
                    Console.WriteLine("resoucr succesfully !!");
                }
                else
                {
                    Console.WriteLine("time out resource");
                }
            }

            new Thread(()=> Day1.LockTooMuch(lock1,lock2)).Start();

            Console.WriteLine("_________________________________");

            lock (lock2)
            {
                Console.WriteLine("Monitor.try enter allow not to get ");
                Thread.Sleep(1000);
                lock (lock1)
                {
                    Console.WriteLine("next resource!!");
                }

            }

        }
    }
}
