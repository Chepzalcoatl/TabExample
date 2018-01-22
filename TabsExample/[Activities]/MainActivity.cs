using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.View;
using Android.Views;
using Toolbar = global::Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;
using System;

namespace TabsExample
{
    /// <summary>
    /// Main activity.
    /// </summary>
    [Activity(Label = "TabsExample", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/PrincipalTheme", WindowSoftInputMode = global::Android.Views.SoftInput.AdjustPan)]
    public class MainActivity : AppCompatActivity, ViewPager.IOnPageChangeListener
    {
        #region Variables

        /// <summary>
        /// Representa el control ViewPager del ContenidoFragments.
        /// </summary>
        private ViewPager ContenidoFragmentsViewPager;

        #endregion

        #region Metodos Protegidos

        /// <summary>
        /// Ons the create.
        /// </summary>
        /// <param name="savedInstanceState">Saved instance state.</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);
            this.RequestedOrientation = global::Android.Content.PM.ScreenOrientation.SensorPortrait;

            // CONFIGURAR TOOLBAR DE APPCOMPAT
            var toolbar = FindViewById<Toolbar>(Resource.Id.ToolbarInicio);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Tabs";

            //Asignar Controles
            this.ContenidoFragmentsViewPager = FindViewById<ViewPager>(Resource.Id.Contenido);

            //ConfigurarTabs
            this.ConfigurarTabLayout();
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Método que configura los tabs de la sección de perfil en el TabLayout general.
        /// </summary>
        private void ConfigurarTabLayout()
        {
            try
            {
                // ASIGNAR EL VIEWPAGER CON LOS FRAGMENTS
                AdapterContenidoFragments adapter = new AdapterContenidoFragments(this.SupportFragmentManager);
                adapter.AgregarFragment(new FragmentPrueba("1"), "Uno");
                adapter.AgregarFragment(new FragmentPrueba("2"), "Dos");
                adapter.AgregarFragment(new FragmentPrueba("3"), "Tres");
                adapter.AgregarFragment(new FragmentPrueba("4"), "Cuatro");
                adapter.AgregarFragment(new FragmentPrueba("5"), "Cinco");
                adapter.AgregarFragment(new FragmentPrueba("6"), "Seis");
                adapter.AgregarFragment(new FragmentPrueba("7"), "Siete");
                this.ContenidoFragmentsViewPager.Adapter = adapter;
                this.ContenidoFragmentsViewPager.AddOnPageChangeListener(this);
                // MOSTRAR LA BARRA DE TABS SUPERIOR
                TabLayout tabsHome = FindViewById<TabLayout>(Resource.Id.tabs);
                tabsHome.Visibility = ViewStates.Visible;
                tabsHome.SetupWithViewPager(this.ContenidoFragmentsViewPager);
                tabsHome.TabMode = TabLayout.ModeScrollable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Implementacion Interface ViewPager.IOnPageChangeListener

        /// <summary>
        /// Ons the page scrolled.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <param name="positionOffset">Position offset.</param>
        /// <param name="positionOffsetPixels">Position offset pixels.</param>
        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            
        }

        /// <summary>
        /// Ons the page scroll state changed.
        /// </summary>
        /// <param name="state">State.</param>
        public void OnPageScrollStateChanged(int state)
        {
            
        }

        /// <summary>
        /// Ons the page selected.
        /// </summary>
        /// <param name="position">Position.</param>
        public void OnPageSelected(int position)
        {
            
        }

        #endregion
    }
}

