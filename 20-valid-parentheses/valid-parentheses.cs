public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char> ();
       Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach(char currentchar in s)
        {
            if(bracketPairs.ContainsKey(currentchar)){
                stack.Push(currentchar);
            }
            else
            {
                if(stack.Count == 0) return false;

                char lastopeningbracket = stack.Pop();
                

                if(bracketPairs[lastopeningbracket]!= currentchar )
                {
                    return false;
                }
            }
        }
        return stack.Count ==0;
    }
}