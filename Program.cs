using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class GeneticAlgorithm
{
    static Random random = new Random();
    const int PopulationSize = 9;
    const int ChromosomeBits = 3;
    const int Iterations = 20;
    const int TournamentSize = 2;
    const double MinValue = 0.0;
    const double MaxValue = 100.0;

    static void Main(string[] args)
    {
<<<<<<< HEAD
        List<int[]> population = InitializePopulation();

        for (int iteration = 0; iteration <= Iterations; iteration++)
        {
            var fitnessValues = population.Select(DecodeAndEvaluate).ToList();
            double bestFitness = fitnessValues.Max();
            double averageFitness = fitnessValues.Average();
            Console.WriteLine($"Iteracja {iteration}: Najlepsza: {bestFitness:F4}, Średnia: {averageFitness:F4}");
=======
        
        
      
>>>>>>> dac8696930e02caf5f5c1bae4678ded3d4deddc9

            if (iteration == Iterations) break;

            List<int[]> newPopulation = new List<int[]>();

            while (newPopulation.Count < PopulationSize - 1)
            {
                int[] parent = TournamentSelection(population, fitnessValues);
                int[] mutatedChild = Mutate(parent);
                newPopulation.Add(mutatedChild);
            }

<<<<<<< HEAD
            int bestIndex = fitnessValues.IndexOf(bestFitness);
            newPopulation.Add(population[bestIndex]);
=======
       

        static void Main(string[] args)
        
        
        {
            List<int[]> population = InitializePopulation();

            for (int iteration = 0; iteration <= Iterations; iteration++)

            {
                var fitnessValues = population.Select(DecodeAndEvaluate).ToList();

                double bestFitness = fitnessValues.Max();
                double averageFitness = fitnessValues.Average();

                Console.WriteLine($"Iteracja {iteration}: Najlepsza = {bestFitness}, Srednia = {averageFitness}");

                if (iteration == Iterations) break;


                List<int[]> newPopulation = new List<int[]>();



            }



            static List<int> InitializePopulation()
            {
                List<int> population = new List<int>();
                for (int i = 0; i < PopulationSize; i++)
                {
                    int[] chromosome = new int[ChromosomeBits * 2];
                    for (int j = 0; j < chromosome.Length; j++)
                        chromosome[j] = Random.Next(2);
                    population.Add(chromosome);
                }
                return population;
            }   
           
            




            static double Decode(int[] bits)
            {
                int vaule = 0; 
                for (int i = 0; i < bits.Length; i++)
                {
                    vaule += bits[i] * (1 << (bits.Length - i - 1));

                    double range = MaxValue - MinValue; 
                    return MinValue + vaule * range / (Math.Pow(2, ChromosomeBits) - 1);
                }
            }




            static double FitnessFunction(double x1, double x2)
            {
                return Math.Sin(0.05 * x1) + Math.Sin(0.05 * x2) + 0.4 * Math.Sin(0.15 * x1) * Math.Sin(0.15 * x2);

            }


            static double DecodeAndEvaluate(int[] chromosome)
            {
                double x1 = Decode(chromosome.Take(ChromosomeBits).ToArray());
                double x2 = Decode(chromosome.Skip(ChromosomeBits).Take(ChromosomeBits).ToArray()); 

                return FitnessFunction(x1, x2);
            }




          





        }



            
>>>>>>> dac8696930e02caf5f5c1bae4678ded3d4deddc9

            population = newPopulation;
        }
    }

<<<<<<< HEAD
    static List<int[]> InitializePopulation()
    {
        List<int[]> population = new List<int[]>();
        for (int i = 0; i < PopulationSize; i++)
        {
            int[] chromosome = new int[ChromosomeBits * 2];
            for (int j = 0; j < chromosome.Length; j++)
                chromosome[j] = random.Next(2);
            population.Add(chromosome);
        }
        return population;
    }

    static double DecodeAndEvaluate(int[] chromosome)
    {
        double x1 = Decode(chromosome.Take(ChromosomeBits).ToArray());
        double x2 = Decode(chromosome.Skip(ChromosomeBits).Take(ChromosomeBits).ToArray());
        return FitnessFunction(x1, x2);
    }

    static double Decode(int[] bits)
    {
        int value = 0;
        for (int i = 0; i < bits.Length; i++)
            value += bits[i] * (1 << (bits.Length - i - 1));
        double range = MaxValue - MinValue;
        return MinValue + value * range / (Math.Pow(2, ChromosomeBits) - 1);
    }

    static double FitnessFunction(double x1, double x2)
    {
        return Math.Sin(0.05 * x1) + Math.Sin(0.05 * x2) + 0.4 * Math.Sin(0.15 * x1) * Math.Sin(0.15 * x2);
    }

    static int[] TournamentSelection(List<int[]> population, List<double> fitnessValues)
    {
        List<int> tournamentIndices = new List<int>();
        while (tournamentIndices.Count < TournamentSize)
        {
            int randomIndex = random.Next(PopulationSize);
            if (!tournamentIndices.Contains(randomIndex))
                tournamentIndices.Add(randomIndex);
        }
        int bestIndex = tournamentIndices.OrderByDescending(i => fitnessValues[i]).First();
        return population[bestIndex];
    }

    static int[] Mutate(int[] chromosome)
    {
        int[] mutatedChromosome = (int[])chromosome.Clone();
        int mutationPoint = random.Next(chromosome.Length);
        mutatedChromosome[mutationPoint] ^= 1;
        return mutatedChromosome;
    }
}
=======



>>>>>>> dac8696930e02caf5f5c1bae4678ded3d4deddc9
