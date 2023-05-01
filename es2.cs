            int n = 0;
            string s = "";
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";
            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione - n) % alfabeto.Length;

                    risultato += alfabeto[posizione];
                }
                else
                {

                    risultato += c;

                }
            }