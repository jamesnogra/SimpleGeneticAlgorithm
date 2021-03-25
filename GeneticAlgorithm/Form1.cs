using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        String goal = "THISISAVERYLONGSTRINGIHOPEGACANSOLVEIT";
        static int populationSize = 500;
        int generation = 1;
        Random r = new Random();
        List<Gene> allGenes = new List<Gene>();
        float mutationProbability = 0.05F;

        public Form1()
        {
            InitializeComponent();
            goalText.Text = this.goal;
            this.generateInitialPopulation();
        }

        /**
         * This will generate the initial genes (string) of Gen 1
         */
        public void generateInitialPopulation()
        {
            for (int x=0; x<populationSize; x++)
            {
                Gene tempGene = new Gene();
                tempGene.code = "";
                for (int y=0; y<this.goal.Length; y++)
                {
                    tempGene.code += this.generateRandomCharacter();
                }
                tempGene.fitness = this.calculateFitness(tempGene.code);
                allGenes.Add(tempGene);
            }

            // Sort the initial genes by fitness
            // Highest fitness will be at index 0
            allGenes = allGenes.OrderByDescending(x => x.fitness).ToList();

            // Display the initial gene population
            this.displayTopGenes(10);
        }

        /**
         * Calculates the fitness of a specific gene
         */
        public int calculateFitness(String str)
        {
            int tempScore = 0;
            for (int x = 0; x < this.goal.Length; x++)
            {
                if (str[x] == this.goal[x])
                {
                    tempScore++;
                }
            }

            return tempScore;
        }

        /**
         * Mate the allGenes and create new children to form a new allGenes
         */
        public void reproduce()
        {
            // Current population of genes will become parents
            List<Gene> parents = this.allGenes;

            for (int x=0; x<populationSize; x++)
            {
                // Create a new population from two random "best" parents
                int indexParent1 = r.Next(0, populationSize / 10);
                int indexParent2 = r.Next(0, populationSize / 5);
                // Generate a new Gene based from the two best random parents
                allGenes[x].code = this.generateNewGene(
                    this.allGenes[indexParent1].code,
                    this.allGenes[indexParent2].code
                );
                allGenes[x].fitness = this.calculateFitness(allGenes[x].code);
            }

            // Sort the new genes by fitness
            // Highest fitness will be at index 0
            allGenes = allGenes.OrderByDescending(x => x.fitness).ToList();

            // Display the top genes
            this.displayTopGenes(10);

            // Update generation count
            this.generation++;
        }

        /**
         * Generate a new gene based from two genes
         */
        public String generateNewGene(String parent1, String parent2)
        {
            String tempGene = "";

            // Combine the genes of the two parents randomly to
            // create a new one
            for (int x=0; x<this.goal.Length; x++)
            {
                if (r.Next(0,2) == 0) // value of this random can either be 0 or 1
                {
                    tempGene += parent1[x];
                }
                else
                {
                    tempGene += parent2[x];
                }
            }

            // Do we mutate this gene?
            if (r.Next(0,100) <= (this.mutationProbability * 100))
            {
                // Pick an index to mutate
                int indexToMutate = r.Next(0, this.goal.Length);
                // Convert String to char array first (C# restriction)
                char[] tempArray = tempGene.ToCharArray();
                // Replace with a random character
                tempArray[indexToMutate] = this.generateRandomCharacter();
                // Convert char array to string
                tempGene = new string(tempArray);
            }

            return tempGene;
        }

        /**
         * Display top 10 genes
         */
        public void displayTopGenes(int topNumber)
        {
            String tempStr = "";
            for (int x=0; x< topNumber; x++)
            {
                tempStr += this.allGenes[x].code + " ["+allGenes[x].fitness+"]\n";
            }
            allGenesText.Text = tempStr;
            generationText.Text = "Generation: " + this.generation.ToString();
        }

        /**
         * This will generate a random character
         */
        public char generateRandomCharacter()
        {
            return Convert.ToChar(r.Next(65,91));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            while (this.allGenes[0].code != this.goal)
            {
                this.reproduce();
                Application.DoEvents();
            }
        }
    }
}
