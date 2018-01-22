using System;
using Android.OS;
using Android.Views;
using Android.Support.V4.App;
using Android.Widget;

namespace TabsExample
{
    /// <summary>
    /// Fragment prueba.
    /// </summary>
    public class FragmentPrueba : Fragment
    {
        #region

        /// <summary>
        /// The texto.
        /// </summary>
        private string texto;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TabsExample.FragmentPrueba"/> class.
        /// </summary>
        /// <param name="a">The alpha component.</param>
        public FragmentPrueba(String aux)
        {
            texto = aux;
        }

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Ons the create view.
        /// </summary>
        /// <returns>The create view.</returns>
        /// <param name="inflater">Inflater.</param>
        /// <param name="container">Container.</param>
        /// <param name="savedInstanceState">Saved instance state.</param>
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.LayoutFragmentPrueba, container, false);
        }

        /// <summary>
        /// Ons the resume.
        /// </summary>
        public override void OnResume()
        {
            base.OnResume();
            this.View.FindViewById<TextView>(Resource.Id.texto_fragmento).Text = "Contenido : " + texto;
        }

        #endregion
    }
}
