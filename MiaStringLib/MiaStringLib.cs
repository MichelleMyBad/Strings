namespace MartinezBianchi.Michelle._3i.MAUIString
{
    // All the code in this file is included in all platforms.
    public class MiaStringLib
    {

        //ToLower()
        public char CharMin(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                int a = (int)c | 0x20;
                return (char)a;
            }
            else
            {
                return c;
            }
        }

        //ToUpper()
        public char CharMaius(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                int a = (int)c & 0x5f;
                return (char)a;
            }
            else
            {
                return c;
            }
        }

        //Length()
        public int Lungo(char[] caratteri)
        {
            int retVal = 0;
            foreach (char c in caratteri)
            {
                retVal++;
            }
            return retVal;
        }

        //IsLetter()
        public bool Lettera(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //IsLetterOrDigit()
        public bool LetteraNumero(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //funzioni Maiuscola
        public string Maiuscola(string phrase)
        {
            char[] maiuscola = phrase.ToCharArray();
            for (int i = 0; i < Lungo(maiuscola); i++)
            {
                maiuscola[i] = CharMin(maiuscola[i]);
            }
            return new String(maiuscola);
        }

        //funzioni Minuscola
        public string Minuscola(string phrase)
        {
            char[] minuscola = phrase.ToCharArray();
            for (int i = 0; i < Lungo(minuscola); i++)
            {
                minuscola[i] = CharMin(minuscola[i]);
            }
            return new String(minuscola);
        }

        //funzioni Capitalizzare
        public string Capitalize(string phrase)
        {

            char[] frase = phrase.ToCharArray();
            int lunghezza = Lungo(frase);
            char[] finalPhrase = new char[lunghezza];

            for (int i = 0; i < lunghezza; i++)
            {
                if (i == 0)
                {
                    finalPhrase[0] = CharMaius(frase[i]);
                }
                else if (LetteraNumero(frase[i - 1]) == false && LetteraNumero(frase[i]))
                {
                    finalPhrase[i] = CharMaius(frase[i]);
                }
                else
                {
                    finalPhrase[i] = CharMin(frase[i]);
                }
            }
            return new String(finalPhrase);

        }

        //funzioni Palindroma
        public bool Palindroma(string phrase)
        {
            char[] frase = phrase.ToCharArray();
            char[] avanti = new char[Lungo(frase)];
            char[] indietro = new char[Lungo(frase)];
            int j = 0;
            int k = 0;
            bool flag = true;

            for (int i = 0; i < Lungo(frase); i++)
            {
                if (Lettera(frase[i]))
                {
                    avanti[k] = CharMin(frase[i]);
                    k++;
                }
                if (Lettera(frase[i]) == false && frase[i] != ' ')
                {
                    flag = false;
                    break;
                }
            }
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                if (Lettera(frase[i]))
                {
                    indietro[j] = CharMin(frase[i]);
                    j++;
                }
            }

            for (int i = 0; i < Lungo(frase); i++)
            {
                if (avanti[i] != indietro[i])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //funzioni Reverse 
        public string Reverse(string phrase)
        {
            char[] frase = phrase.ToCharArray();
            int lunghezza = Lungo(frase);
            int lunghezzautile;
            char tmp;
            int j = 0;
            if (lunghezza % 2 == 0)
            {
                lunghezzautile=lunghezza / 2;
            }
            else
            {
                lunghezzautile = lunghezza / 2 + 1;
            }

            for (int i = lunghezza-1; i >= lunghezzautile; i--)
            {
                tmp = frase[j];
                frase[j] = frase[i];
                frase[i] = tmp;
                j++;
            }
            return new String(frase);
        }

        //funzioni Parole
        public int Parole(string phrase)
        {
            int counter = 0;
            char[] frase = phrase.ToCharArray();
            for (int i = 0; i < Lungo(frase); i++)
            {
                if (i == 0)
                {
                    if (Lettera(frase[i]))
                    {
                        counter++;
                    }
                }
                else if (Lettera(frase[i - 1]) == false && Lettera(frase[i]))
                {
                    counter++;
                }
            }
            return counter;
        }

        //funzioni Lettere
        public int Lettere(string phrase)
        {
            int counter = 0;
            char[] frase = phrase.ToCharArray();
            for (int i = 0; i < Lungo(frase); i++)
            {
                if (Lettera(frase[i]))
                {
                    counter++;
                }
            }
            return counter;
        }

        //funzioni Check
        public bool CheckAlNum(string phrase)
        {
            bool messaggio = true;
            char[] frase = phrase.ToCharArray();
            foreach (var c in frase)
            {
                if (LetteraNumero(c) == false)
                {
                    messaggio = false;
                }
            }
            return messaggio;
        }

        //funzioni Check
        public bool CheckAl(string phrase)
        {
            bool messaggio = true;
            char[] frase = phrase.ToCharArray();
            foreach (var c in frase)
            {
                if (Lettera(c) == false)
                {
                    messaggio = false;
                }
            }
            return messaggio;
        }
    }
}