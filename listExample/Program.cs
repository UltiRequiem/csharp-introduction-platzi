var (rnd, randomNumbers, randomNumbersToAdd) = (new Random(), new List<int>(), 10);

for (int j = 0; j < randomNumbersToAdd; j++) randomNumbers.Add(rnd.Next());

randomNumbers.ForEach(Console.WriteLine);
