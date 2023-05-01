int n = 0;
            string s = "";
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int risultato = 0;
             foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = posizione % alfabeto.Length;
                    es5();
                    Console.Write(s);              
                }
                else
                {
                    risultato += c;
                }
            }