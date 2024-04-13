using System;

public class Solution {
  public int MaximalRectangle(char[][] matrix) {
       if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return 0;
        
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        
        int[,] dp = new int[rows, cols];
        int maxArea = 0;
        
        // Initialize the first row of dp
        for (int j = 0; j < cols; j++) {
            dp[0, j] = matrix[0][j] == '1' ? 1 : 0;
        }
        
        // Calculate dp values for remaining rows
        for (int i = 1; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                dp[i, j] = matrix[i][j] == '1' ? dp[i - 1, j] + 1 : 0;
            }
        }
        
        // Calculate the maximum rectangle area for each position
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                int minWidth = dp[i, j];
                for (int k = j; k >= 0 && dp[i, k] > 0; k--) {
                    minWidth = Math.Min(minWidth, dp[i, k]);
                    maxArea = Math.Max(maxArea, minWidth * (j - k + 1));
                }
            }
        }
        
        return maxArea;
    }
}