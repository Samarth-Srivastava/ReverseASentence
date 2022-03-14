using System.Text;
namespace ReverseASentence{
    public partial class Solution{
        public string solve2(string A){
            int N = A.Length;
            //string revStrtTemp = reverse(A, 0, N-1);
            string[] words = A.Split(' ');
            StringBuilder sb = new StringBuilder();
            for(int i = words.Length -1; i >= 0; i--){
                sb.Append(words[i] + " ");
            }

            return sb.ToString().Trim();
        }
    }
}