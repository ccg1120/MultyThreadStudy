using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/// <summary>
/// Deadlock 오류 및 해결 방안 Monitor 생성자 잠그기
/// </summary>
namespace MultyThreadStudy
{
    class Day1
    {

        



        public static void LockTooMuch(object lock1, object lock2)
        {
            lock(lock1)
            {
                Thread.Sleep(1000);
                lock (lock2)
                {

                }

            }
        }
    }

   
}
