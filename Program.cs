using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace AlgGene
{
    class Program
    {
        
        
      

           Random random = new Random();

            const int PopulationSize = 9;
            const int ChromosomeBits = 3;
            const int Iterations = 20;
            const int Tournaments = 2;
            const double MinValue = 0.0;
            const double MaxValue = 100.0;    


       

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



            

        }
    }




