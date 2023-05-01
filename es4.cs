 static void es4
        { 
            int n = 0;
            string s = "";
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            double risultato = 0;
            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = posizione % alfabeto.Length;

                    risultato =risultato * posizione;
                }
                else
                {

                    risultato += c;

                }
            }
            risultato = risultato / n;
                               
    }