# Intuition
We can think of this problem as finding the largest rectangle in a histogram.
We maintain a dynamic programming matrix to store the heights of rectangles formed by consecutive 1's.
Then, for each position (i, j) in the matrix, we calculate the width of the rectangle by iterating backwards and finding the minimum height among the consecutive rows.
Finally, we compute the area of the rectangle and update the maxArea variable accordingly.

# Approach
1. Initialize the dynamic programming matrix 'dp' with the heights of rectangles for the first row.
2. For each subsequent row, update the 'dp' matrix with the heights of rectangles formed by consecutive 1's in that row.
3. Iterate through each position (i, j) in the matrix, and for each position, iterate backwards to find the minimum height among the consecutive rows.
4. Calculate the width of the rectangle and update the maxArea variable with the maximum area found.
5. Return the maxArea as the result.

# Complexity
Time complexity: O(rows * cols)

Space complexity: O(rows * cols)
__________________________________________________________________________________________
# Create a new console project
dotnet new console -n LongestCommonPrefix

# Run the project
dotnet run
