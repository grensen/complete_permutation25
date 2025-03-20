
class Program
{
    static void Main()
    {

        Console.WriteLine("Permutation generator demo\n");
        // Configuration
        bool useFirstElement = true;
        int permutationSize = 4;

        // Initialize elements array
        int[] elements = new int[permutationSize];
        for (int i = 0; i < elements.Length; i++)
            elements[i] = i;

        // Create permutation generator
        var permutationGenerator = new PermutationGenerator(elements);

        // Display all permutations
        Console.WriteLine("Show all element permutations:");
        permutationGenerator.GenerateAndPrintPermutations(!useFirstElement);

        // Display permutations with fixed first element
        Console.WriteLine("\nShow first element permutations:");
        permutationGenerator.GenerateAndPrintPermutations(useFirstElement);
    }
}

class PermutationGenerator
{
    private readonly int[] _elements;

    public PermutationGenerator(int[] e) => _elements = (int[])e.Clone(); // Create a copy to prevent modification of the original array

    public void GenerateAndPrintPermutations(bool useFirstElement)
    {
        long count = 0;
        int[] permutation = (int[])_elements.Clone();
        int startDepth = useFirstElement ? 1 : 0; // Start permuting from index 1 if first element is fixed

        Permute(permutation, startDepth, ref count);
    }

    private void Permute(int[] permutation, int depth, ref long count)
    {
        if (depth == permutation.Length)
        {
            // Reached a complete permutation
            Console.WriteLine($"{count,-3}: {string.Join(" ", permutation)}");
            count++;
            return;
        }

        for (int i = depth; i < permutation.Length; i++)
        {
            // Swap elements and recursively generate permutations
            Swap(ref permutation[i], ref permutation[depth]);
            Permute(permutation, depth + 1, ref count);
            Swap(ref permutation[i], ref permutation[depth]); // Backtrack
        }
    }

    private void Swap(ref int a, ref int b) => (b, a) = (a, b);

}