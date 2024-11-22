namespace T2_T2CalculadoraMasaCorporal.Vistas;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void OnCalcularClicked(object sender, EventArgs e)
    {
		float imc = 0f;
        float peso, altura;

        try
        {
            peso = float.Parse(txtPeso.Text);
            altura = float.Parse(txtAltura.Text);

            imc = peso / (altura * altura); //La fórmula es peso entre altura^2, por lo que multiplicamos altura por sí misma para obtener su cuadrado

        }catch (Exception ex)
        {
            lblResultado.Text = "Se ha producido un error procesando los datos";
        }

		
		if(imc < 18.5f)
		{
			lblResultado.Text = "IMC = " + imc + ". Peso inferior al normal";
            lblResultado.TextColor = Colors.Blue;
        }
        else if(imc >= 18.5f && imc < 24.9f)
		{
            lblResultado.Text = "IMC = " + imc + ". Peso normal";
            lblResultado.TextColor = Colors.Green;
        }
        else if (imc >= 25.0f && imc < 29.9f){
            lblResultado.Text = "IMC = " + imc + ". Peso superior al normal";
			lblResultado.TextColor = Colors.Orange;
		}
		else
		{
            lblResultado.Text = "IMC = " + imc + ". Obesidad";
            lblResultado.TextColor = Colors.Red;
        }
    }

    private void OnAlturaTextChanged(object sender, TextChangedEventArgs e)
    {
        txtAltura.Text = e.NewTextValue.Replace('.', ',');
    }

    private void OnPesoTextChanged(object sender, TextChangedEventArgs e)
    {
        txtPeso.Text = e.NewTextValue.Replace('.', ',');
    }
}