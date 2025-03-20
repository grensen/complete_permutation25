
# A Complete Permutation Block Using C#: The Monster is Real

How to find all combinations? For example, how can we arrange ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-green-green), or ![](https://img.shields.io/badge/-blue-blue) in all possible ways?
 
- ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-blue-blue)  
- ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-green-green)  
- ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-red-red)  
- ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-blue-blue)  
- ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-green-green)  
- ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-red-red)

These are permutations, and we can compute the numbers of combinations with the factorial function.

Factorial(3) = 6

Or a bit more formal:
The factorial of 3 (denoted as **3!**) is calculated as:  
**3! = 3 × 2 × 1 = 6**  

But think about it, you don't see every combination, for example if the combination of 2 ![](https://img.shields.io/badge/-colors-purple) would be better for some reason, this combination would not be respected in the permutations.

- ![](https://img.shields.io/badge/-red-red)
- ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-green-green)
- ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-blue-blue)
- ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-blue-blue)
- ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-green-green)
- ![](https://img.shields.io/badge/-green-green)
- ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-blue-blue)
- ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-red-red)
- ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-blue-blue)
- ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-red-red)
- ![](https://img.shields.io/badge/-blue-blue)
- ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-red-red)
- ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-green-green)
- ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-red-red), ![](https://img.shields.io/badge/-green-green)
- ![](https://img.shields.io/badge/-blue-blue), ![](https://img.shields.io/badge/-green-green), ![](https://img.shields.io/badge/-red-red)

Using all permutations, including subsets, does not have an official name as far as I know. With the help of my LLM, I think the name **Complete Permutations** sounds fitting. However, I am not a mathematician, my focus is engineering-based. So, let's look at a practical example.

#

<p align="center">
  <img src="https://github.com/grensen/complete_permutation25/blob/main/figures/permutation_demo.png?raw=true" alt="Permutation Demo"/>
</p>

[Basic Permutation Code](https://github.com/grensen/complete_permutation25/blob/main/permutation_demo.cs)

Here is a small example of permutations of size 4, which yields 24 unique combinations. The second approach fixes the first element, reducing the number of permutations to 6 unique combinations. Since permutations depend on order, I will use the term "permutations" from now on. That was the basic demo. Let’s dive deeper. 

#

<p align="center">
  <img src="https://github.com/grensen/complete_permutation25/blob/main/figures/permutation_block.png?raw=true" alt="Permutation Demo"/>
</p>

[Complete Permutation Block Code](https://github.com/grensen/complete_permutation25/blob/main/permutation_block.cs)

Because the reduction is so impactful, my approach is to use the complete permutations as a block where a fixed first element is preselected. The first three steps show the construction process. Next, the filter names can be applied. The last block shows the unique IDs for each filter. 

## Verbose Definition 

A **Complete Permutation Block** is a structured collection of all possible permutations of every subset size (from 1 to N) of a given set. Each permutation subset is arranged in **lexicographical order** (dictionary order) to ensure systematic exploration. Every permutation is associated with its corresponding IDs for traceability.  

### Key Approach  
The presented method **uses a fixed first element** to significantly reduce computational complexity while maintaining exhaustiveness. This optimization ensures:  
- **Efficiency**: Avoids redundant permutations by anchoring the starting element.  
- **Order**: Maintains lexicographical consistency across all subsets.  

### Why Lexicographical Order?  
- Guarantees a logical sequence for permutations (e.g., numerical or alphabetical).  
- Enables systematic testing or analysis without missing configurations.  

### Subset Size Coverage  
- Includes **all subset sizes** from 1 (single elements) to N (full set).  
- Example: For a set of 5 elements, permutations of sizes 1, 2, 3, 4, and 5 are included.
- The symbol -1 marks elements excluded from the current arrangement, allowing sequences of any length (including empty).

This approach balances **exhaustiveness** and **efficiency**, making it ideal for applications like algorithm testing, combinatorial optimization, or brute-force solutions.   

It may still seem a bit abstract. Let’s see why this approach works for me. 

#

<p align="center">
  <img src="https://github.com/grensen/complete_permutation25/blob/main/figures/roulette_wheel_selection_demo.png?raw=true" alt="Permutation Demo"/>
</p>

[Roulette Wheel Selection Code](https://github.com/grensen/complete_permutation25/blob/main/roulette_wheel_selection_demo.cs)

The roulette wheel selection technique, also known as proportional selection, helps select the best machines in this demo. You can learn how RWS works here [Implementing a Proportional Selection Function Using Roulette Wheel Selection](https://jamesmccaffrey.wordpress.com/2020/04/23/implementing-a-proportional-selection-function-using-roulette-wheel-selection/). However, if you think about it, this technique can also be applied to the complete permutation block in the same way. Instead of selecting machines, we can select permutation ids using the same method. Perhaps we need to run each permutation id multiple times, and the RWS technique would then be an effective way to identify the most useful permutations over time.  

#

<p align="center">
  <img src="https://github.com/grensen/complete_permutation25/blob/main/figures/CIFAR-10_augmentation_demo.png?raw=true" alt="Permutation Demo"/>
</p>

My repository should provide a solid foundation for using all permutations of the set and its subsets. This picture of CIFAR-10 images under the effects of different filters demonstrates a practical example where these concepts come together. Let me start with [this Link](https://github.com/grensen/ML_demos/tree/main#easy-solutions-for-cifar-10-overfitting), where the demo shows a convolutional neural network trained on the images from the CIFAR-10 dataset. As it turns out, using only the sharp filter for testing and training as the first element in the permutation doubles the test accuracy. However, with 15 filters, we cannot apply every permutation to every image, as this would increase computational costs excessively. But by combining all these ideas, it becomes far more likely to "defeat the monster." 

Additionally, we can swap the first element approach with other elements to test all possible permutations if needed. And there is much more to explore, and I am not entirely sure about the correctness of this work. However, you can take a look to the references at the bottom, which include practical examples of how to use combinations and permutations in different ways. Thus, I conclude with the headline: **The Monster is Real**  

# Permutations & Derangements

- [Lightweight Mathematical Permutations Using C# in Visual Studio Magazine](https://jamesmccaffrey.wordpress.com/2022/07/19/lightweight-mathematical-permutations-using-csharp-in-visual-studio-magazine/)  
  *An article discussing the implementation of mathematical permutations in C# as featured in Visual Studio Magazine.*

- [Lightweight Derangements Using C#](https://jamesmccaffrey.wordpress.com/2022/06/23/lightweight-derangements-using-c/)  
  *A post on generating derangements (permutations with no fixed points) using C#.*

- [Combining Two Mathematical Permutations](https://jamesmccaffrey.wordpress.com/2022/11/14/combining-two-mathematical-permutations/)  
  *A discussion on how to combine two permutation sets in a mathematical context.*

- [The Kendall Tau Distance For Permutations Example C# Code](https://jamesmccaffrey.wordpress.com/2022/01/11/kendall_tau_permutations_csharp/)  
  *C# code illustrating the Kendall Tau distance calculation for permutations.*

- [The Kendall Tau Distance For Permutations Example Python Code](https://jamesmccaffrey.wordpress.com/2021/11/22/the-kendall-tau-distance-for-permutations-example-python-code/)  
  *Python code that demonstrates the Kendall Tau distance for comparing permutations.*

- [Constant Time Generation of Derangements](https://jamesmccaffrey.wordpress.com/2022/07/21/constant-time-generation-of-derangements/)  
  *An approach to generate derangements in constant time using C#.*

- [Generating the kth Lexicographical Element of a Permutation Using the Factoradic](https://jamesmccaffrey.wordpress.com/2022/06/27/generating-the-kth-lexicographical-element-of-a-permutation-using-the-factoradic/)  
  *A method for generating the kth lexicographical permutation with the factoradic representation.*

- [The Factoradic of a Number](https://jamesmccaffrey.wordpress.com/2012/09/07/the-factoradic-of-a-number/)  
  *An explanation of the factoradic number system and its application in permutation generation.*

# Combinations

- [Lightweight Combinations with C#](https://jamesmccaffrey.wordpress.com/2022/06/15/lightweight-combinations-with-csharp/)  
  *A guide to generating combinations in a lightweight manner using C#.*

- [Lightweight Mathematical Combinations Using C# in Visual Studio Magazine](https://jamesmccaffrey.wordpress.com/2022/07/28/lightweight-mathematical-combinations-using-csharp-in-visual-studio-magazine/)  
  *An article from Visual Studio Magazine that delves into mathematical combinations using C#.*

- [Generating the mth Lexicographical Element of a Combination Using the Combinadic](https://jamesmccaffrey.wordpress.com/2022/06/28/generating-the-mth-lexicographical-element-of-a-combination-using-the-combinadic/)  
  *A step-by-step guide on generating the mth lexicographical combination using the combinadic approach.*

# Combinatorial Optimization (Traveling Salesman Problem)

- [The Traveling Salesman Problem Using Quantum Inspired Annealing In C#](https://jamesmccaffrey.wordpress.com/2021/12/20/quantum-tsp-using-csharp/)  
  *An exploration of solving the Traveling Salesman Problem with quantum-inspired annealing techniques in C#.*

- [Traveling Salesman Problem Combinatorial Optimization Using an Evolutionary Algorithm with C#](https://jamesmccaffrey.wordpress.com/2022/11/17/traveling-salesman-problem-combinatorial-optimization-using-an-evolutionary-algorithm-with-csharp/)  
  *A look at tackling the Traveling Salesman Problem through evolutionary algorithms in C#.*

