using System.Text;

namespace ReverseASentence{
    public class Solution{
        public string solve(string A){
            int N = A.Length;
            string revStrtTemp = reverse(A, 0, N-1);
            string[] words = revStrtTemp.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach(string item in words){
                string w = reverse(item, 0, item.Length -1);
                sb.Append(w + " ");
            }

            return sb.ToString().Trim();
        }

        public string reverse(string arr, int s, int e){
            StringBuilder sb = new StringBuilder(arr);
            while(s < e){
                char temp;

                temp = arr[s];
                sb[s] = arr[e];
                sb[e] = temp;

                s++;
                e--;
            }
        return sb.ToString();
        }
    }
}