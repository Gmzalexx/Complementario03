namespace Complementario03;

public partial class Notas : ContentPage
{
	public Notas()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Creamos el codigo en el evento y ponemos las calificaciones ingresadas para luego calcular el promedio 
        //Esto se hace con el double parse con nota configurada en xaml de la app
        if (double.TryParse(nota1.Text, out double N1) &&
            double.TryParse(nota2.Text, out double N2) &&
            double.TryParse(nota3.Text, out double N3) &&
            double.TryParse(nota4.Text, out double N4) &&
            double.TryParse(nota5.Text, out double N5))
        {
            //Ponemos las notas ingresadas haciendo suma de ellas para luego dividirlas en 5 luego de eso
            //Agregamos un label text con el promedio de las notas es, y aparece las nota asignada
            double promedio = (N1 + N2 + N3 + N3 + N4) / 5;
            resultadoLabel.Text = $"El promedio de las notas es: {promedio:F2}";
        }
        else
        {
            resultadoLabel.Text = "Por favor, ingrese calificaciones válidas.";
        }
    }
}