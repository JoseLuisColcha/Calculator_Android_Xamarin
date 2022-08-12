using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.OS;

namespace Calculator_Android_Xamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        double primerNumero = 0.0;
        double segundoNumero = 0.0;
        string operacion = "";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Obtenemos la referencia a los Items de la vista para poder manejar los <br>// Establecemos nuestra vista para poder trabajar sobre ella o de estos items
            TextView resutlado = FindViewById<TextView>(Resource.Id.resultado);

            Button number1 = FindViewById<Button>(Resource.Id.btnNumber1);
            Button number2 = FindViewById<Button>(Resource.Id.btnNumber2);
            Button number3 = FindViewById<Button>(Resource.Id.btnNumber3);
            Button number4 = FindViewById<Button>(Resource.Id.btnNumber4);
            Button number5 = FindViewById<Button>(Resource.Id.btnNumber5);
            Button number6 = FindViewById<Button>(Resource.Id.btnNumber6);
            Button number7 = FindViewById<Button>(Resource.Id.btnNumber7);
            Button number8 = FindViewById<Button>(Resource.Id.btnNumber8);
            Button number9 = FindViewById<Button>(Resource.Id.btnNumber9);
            Button number0 = FindViewById<Button>(Resource.Id.btnNumber0);

            Button dividir = FindViewById<Button>(Resource.Id.btnDividir);
            Button multiplicar = FindViewById<Button>(Resource.Id.btnMultiplicar);
            Button suma = FindViewById<Button>(Resource.Id.btnSumar);
            Button restar = FindViewById<Button>(Resource.Id.btnRestar);

            Button coma = FindViewById<Button>(Resource.Id.btnComa);
            Button borrar = FindViewById<Button>(Resource.Id.btnBorrar);
            Button calcular = FindViewById<Button>(Resource.Id.btnDCalcular);


            // Una vez obtenida la referencia, definimos el comportamiento de cada // uno de los eventos
            number1.Click += delegate
            {
                resutlado.Text = resutlado.Text + "1";
            };
            number2.Click += delegate
            {
                resutlado.Text = resutlado.Text + "2";
            };
            number3.Click += delegate
            {
                resutlado.Text = resutlado.Text + "3";
            };
            number4.Click += delegate
            {
                resutlado.Text = resutlado.Text + "4";
            };
            number5.Click += delegate
            {
                resutlado.Text = resutlado.Text + "5";
            };
            number6.Click += delegate
            {
                resutlado.Text = resutlado.Text + "6";
            };
            number7.Click += delegate
            {
                resutlado.Text = resutlado.Text + "7";
            };
            number8.Click += delegate
            {
                resutlado.Text = resutlado.Text + "8";
            };
            number9.Click += delegate
            {
                resutlado.Text = resutlado.Text + "9";
            };
            number0.Click += delegate
            {
                resutlado.Text = resutlado.Text + "0";
            };
            coma.Click += delegate
            {
                resutlado.Text = resutlado.Text + ".";
            };
            borrar.Click += delegate
            {
                resutlado.Text = "";
            };


            dividir.Click += delegate
            {
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resutlado.Text);
                    operacion = "dividir";
                    resutlado.Text = "";
                }
            };
            multiplicar.Click += delegate
            {
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resutlado.Text);
                    operacion = "multiplicar";
                    resutlado.Text = "";
                }
            };
            suma.Click += delegate
            {
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resutlado.Text);
                    operacion = "suma";
                    resutlado.Text = "";
                }
            };
            restar.Click += delegate
            {
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resutlado.Text);
                    operacion = "resta";
                    resutlado.Text = "";
                }
            };

            calcular.Click += delegate
            {

                segundoNumero = Convert.ToDouble(resutlado.Text);

                switch (operacion)
                {
                    case "dividir":
                        resutlado.Text = Convert.ToString(primerNumero / segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    case "multiplicar":
                        resutlado.Text = Convert.ToString(primerNumero * segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    case "suma":
                        resutlado.Text = Convert.ToString(primerNumero + segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    case "resta":
                        resutlado.Text = Convert.ToString(primerNumero - segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            };
        }
    }

}
