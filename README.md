# Strings

## Descrizione
#### Programma C# per lo studio delle stringhe. Le stringhe vengono trasformate in char array e, senza l'utilizzo di strumenti per la gestione delle stringhe forniti da Microsoft come ToUpper/ToLower/.Length/IsLetter e simili, il programma svolge una serie di operazioni sulla stringa fornita dall'utente, ricreando e utilizzando le funzioni nominate in precedenza (in quanto proibite).

## Sostituti alle funzioni Microsoft
<details>
<summary></summary>
</details>
<details>
<summary></summary>
</details>
<details>
<summary></summary>
</details>
<details>
<summary></summary>
</details>
<details>
<summary></summary>
</details>
<details>
<summary></summary>
</details>

<details>
<summary>Trasformare la stringa tutta in maiuscolo</summary>

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
</details>

<details>
<summary>Trasformare la stringa tutta in minuscolo</summary>
</details>

<details>
<summary>Rendere la stringa capitalizzata (es. buon giorno = Buon Giorno)</summary>

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
</details>

<details>
<summary>Controllare se la stringa è palindroma</summary>
</details>

<details>
<summary>Invertire la stringa (es. ciao = oaic)</summary>
</details>

<details>
<summary>Contare quante parole sono presenti nella stringa inserita</summary>
</details>

<details>
<summary>Contare quante lettere sono presenti nella stringa inserita</summary>

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
</details>

<details>
<summary>Controllare se la stringa è composta solo da caratteri alfanumerici</summary>
</details>

<details>
<summary>Controllare se la stringa è composta solo da caratteri alfabetici</summary>
</details>
