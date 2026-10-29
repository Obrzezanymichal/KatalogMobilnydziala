namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
    private int licznik = 0;

    public NewProductPage()
    {
        InitializeComponent();
    }

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        licznik++;
        EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
    }

    // Ta metoda obsługuje wpisywanie tekstu w polu nazwa
    private void Nazwa_TextChanged(object sender, TextChangedEventArgs e)
    {
        int dlugosc = e.NewTextValue?.Length ?? 0;
        EtykietaWyniku.Text = $"Nazwa ma {dlugosc} znaków";
    }
}