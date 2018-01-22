namespace TabsExample
{
    using System.Collections.Generic;
    using System.Linq;
    using Android.Support.V4.App;
    using Java.Lang;

    /// <summary>
    /// Adapter contenido fragments.
    /// </summary>
    public class AdapterContenidoFragments : FragmentPagerAdapter
    {

        #region Constructores

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TabsExample.AdapterContenidoFragments"/> class.
        /// </summary>
        /// <param name="fm">Fm.</param>
        public AdapterContenidoFragments(FragmentManager fm) : base(fm)
        {
        }

        #endregion

        #region Variables
        /// <summary>
        /// The fragments perfil.
        /// </summary>
        private List<Fragment> Fragmentos = new List<Fragment>();

        /// <summary>
        /// The titulos perfil.
        /// </summary>
        private List<string> Titulos = new List<string>();

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public override int Count
        {
            get
            {
                return this.Fragmentos.Count();
            }
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <returns>The item.</returns>
        /// <param name="position">Position.</param>
        public override Fragment GetItem(int position)
        {
            return this.Fragmentos.ElementAt<Fragment>(position);
        }

        /// <summary>
        /// Gets the page title formatted.
        /// </summary>
        /// <returns>The page title formatted.</returns>
        /// <param name="position">Position.</param>
        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(this.Titulos.ElementAt(position));
        }

        //public override int GetItemPosition(Java.Lang.Object objectValue)
        //{
        //    return PositionNone;
        //}

        /// <summary>
        /// Agregars the fragment.
        /// </summary>
        /// <param name="fragment">Fragment.</param>
        /// <param name="titulo">Titulo.</param>
        public void AgregarFragment(Fragment fragment, string titulo)
        {

            this.Fragmentos.Add(fragment);
            this.Titulos.Add(titulo);
            //this.NotifyDataSetChanged();
        }

        #endregion

    }
}