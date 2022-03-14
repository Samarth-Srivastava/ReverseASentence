using System.Text;

namespace ReverseASentence{
    public partial class Solution{
        public string solve(string A){
            int N = A.Length;
            string revStrtTemp = reverse(A, 0, N-1);
            StringBuilder sb = new StringBuilder();

            int wordStart = 0;
            int wordEnd = 0;
            for(int i = 0; i < N; i++){
                // if(i == 0 || revStrtTemp[i - 1] == ' '){
                //     wordStart = i;
                // }
                if(revStrtTemp[i] == ' '){
                    wordEnd = i;
                    string w = reverse(revStrtTemp, wordStart, wordEnd - 1);
                    sb.Append(w + " ");
                    wordStart = wordEnd + 1;
                }
                if(i == N-1){
                    wordEnd = i;
                    string w = reverse(revStrtTemp, wordStart, wordEnd);
                    sb.Append(w + " ");
                }
            }

            return sb.ToString().Trim();
        }

        public string reverse(string arr, int s, int e){
            int start = s;
            int end = e;
            StringBuilder sb = new StringBuilder(arr);
            while(s < e){
                char temp;

                temp = arr[s];
                sb[s] = arr[e];
                sb[e] = temp;

                s++;
                e--;
            }
            string ans = sb.ToString();
            return subStr(ans, start, end); 
        }

        public string subStr(string A, int start, int end=-1){
            int N = A.Length;
            if(end < start){
                return string.Empty;
            }
            if(end == -1){
                end = N-1;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                sb.Append(A[i]);
            }
            return sb.ToString();
        }
    }
}
