using System;
using System.Collections;

namespace Task1._3
{
    class CitizenCollection : IEnumerable
    {
        Citizen[] citizens;

        public CitizenCollection()
        {
            citizens = new Citizen[0];
        }

        public int Count => citizens.Length;
        public void Clear() => citizens = new Citizen[0];
        public (Citizen, int) ReturnLast => ( citizens[Count], Count - 1);

        public int Add(Citizen citizen) 
        {
            if (Contains(citizen).Item1)
                return -1;
            
            Array.Resize(ref citizens, Count + 1);
            if (citizen as Pensioner == null)
            {
                citizens[Count-1] = citizen;
            }
            else
            {
                for(var i = 0; i < Count; i++)
                    if(citizens[i] as Pensioner == null)
                    {
                        Array.ConstrainedCopy(citizens, i, citizens, i + 1, Count - 1 - i);
                        citizens[i] = citizen;
                        return i;
                    }
            }
            return -1;
        }
        public (bool, int) Contains(Citizen citizen)
        {
            for (var i = 0; i < Count; i++)
            {
                if (citizens[i] == citizen) return (true, i);
            }
                
            
            return (false, -1);
        }
        public void Remove()
        {
            if(Count > 0)
            {
                Array.ConstrainedCopy(citizens, 1, citizens, 0, Count - 1);
                Array.Resize(ref citizens, Count - 1);
            }
        }
        public void Remove(Citizen citizen)
        {
            var index = Contains(citizen).Item2;
            if (Count > 0 && Contains(citizen).Item2 >= 0)
                Array.ConstrainedCopy(citizens, index + 1, citizens, index, Count - 1 - index);
            Array.Resize(ref citizens, Count - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return citizens.GetEnumerator();
        }
    }
}
