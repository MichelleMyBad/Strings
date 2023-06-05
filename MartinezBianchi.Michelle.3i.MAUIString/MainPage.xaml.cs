namespace MartinezBianchi.Michelle._3i.MAUIString { 

    public partial class MainPage : ContentPage
    {
         MiaStringLib MiaLib= new MiaStringLib();
	    public MainPage()
	    {
		    InitializeComponent();
	    }

        //azioni al click del pulsante 
        private void OnCounterClicked(object sender, EventArgs e)
	    {
		    if (edtTesto.Text == "")
		    {
			    txtMaiuscola.Text = "---";
                txtMinuscola.Text = "---";
                txtCapitalizzata.Text = "---";
                txtPalindroma.Text = "---";
                txtReverse.Text = "---";
                txtParole.Text = $"Le parole in {edtTesto.Text} sono {MiaLib.Parole(edtTesto.Text)}";
                txtLettere.Text = $"Le lettere in {edtTesto.Text} sono {MiaLib.Lettere(edtTesto.Text)}";
                txtCheckalnum.Text = "---";
                txtCheckal.Text = "---";
            }
		    else
		    {
			    txtMaiuscola.Text = MiaLib.Maiuscola(edtTesto.Text);
			    txtMinuscola.Text = MiaLib.Minuscola(edtTesto.Text);
			    txtCapitalizzata.Text = MiaLib.Capitalize(edtTesto.Text);
			    if (MiaLib.Palindroma(edtTesto.Text) == true)
			    {
				    txtPalindroma.Text = $"{edtTesto.Text} è palindroma!";

			    }
			    else
			    {
                    txtPalindroma.Text = $"{edtTesto.Text} non è palindroma!";
                }
			    txtReverse.Text = $"{edtTesto.Text} al contrario è: {MiaLib.Reverse(edtTesto.Text)}";
			    txtParole.Text= $"Le parole in {edtTesto.Text} sono {MiaLib.Parole(edtTesto.Text)}";
                txtLettere.Text = $"Le lettere in {edtTesto.Text} sono {MiaLib.Lettere(edtTesto.Text)}";
                if (MiaLib.CheckAlNum(edtTesto.Text) == true)
			    {
				    txtCheckalnum.Text= $"{edtTesto.Text} contiene solo valori alfanumerici";
			    }
			    else
			    {
                    txtCheckalnum.Text = $"{edtTesto.Text} contiene valori non alfanumerici";
                }
                if (MiaLib.CheckAl(edtTesto.Text) == true)
                {
                    txtCheckal.Text = $"{edtTesto.Text} contiene solo valori alfabetici";
                }
                else
                {
                    txtCheckal.Text = $"{edtTesto.Text} contiene valori non alfabetici";
                }
            }

        }
    }
}

