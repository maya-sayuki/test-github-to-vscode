using System;


    public static List<int> GeneratePrime(int max)
    {
        int prime;
        double sqrtMax = Math.Sqrt(max);
        var primeList = new List<int>(); 

        var searchList = Enumerable.Range(2, max -1).ToList(); 

        do
        {
            prime = searchList.First();
            primeList.Add(prime);
            searchList.RemoveAll(n => % prime == 0);
            
        } while (prime < sqrtMax);

        primeList.AddRange(searchList);

        return primeList;
    }
