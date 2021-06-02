using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    class BalanceCollection
    {
        Balance[] balances;

        public BalanceCollection()
        {
            balances = new Balance[0];
        }

        public int Count => balances.Length;
        public void Clear() => balances = new Balance[0];
        public void Add(int account, double amount)
        {
            Array.Resize(ref balances,  Count + 1);
            balances[^1] = new Balance { Account = account, Amount = amount };
        }
        public IEnumerator<Balance> GetEnumerator()
        {
            for (int i = 0; i < balances.Length; i++)
                yield return balances[i];
        }
    }
}
