# Strings
## Programma C# per lo studio delle stringhe

#### Programma C# per lo studio delle stringhe, trasformandole in char array e senza l'utilizzo di strumenti per la gestione delle stringhe forniti da Microsoft, come ToUpper/ToLower/.Length/IsLetter e simili 
L'esercizio svolge una serie di operazioni su una stringa fornita dall'utente, ricreando e utilizzando le funzioni fornite da Microsoft negate come da consegna. Le operazioni svolte sono :
- Trasformare la stringa tutta in maiuscolo
```
 public string Maiuscola(string phrase)
  {
      char[] maiuscola = phrase.ToCharArray();
      for (int i = 0; i < Lungo(maiuscola); i++)
      {
          maiuscola[i] = CharMin(maiuscola[i]);
      }
      return new String(maiuscola);
  }
```
- Trasformare la stringa tutta in minuscolo
- Rendere la stringa capitalizzata (es. buon giorno = Buon Giorno)
```
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
```
- Controllare se la stringa è palindroma
- Invertire la stringa (es. ciao = oaic)
- Contare quante parole sono presenti nella stringa inserita
- Contare quante lettere sono presenti nella stringa inserita
```
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
```
- Controllare se la stringa è composta solo da caratteri alfanumerici
- Controllare se la stringa è composta solo da caratteri alfabetici
